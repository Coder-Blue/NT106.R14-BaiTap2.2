using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace CRUD_APP
{
    public static class XuLyNguoiDung
    {
        // Chuỗi kết nối SQL Server (đổi lại tên Server cho đúng với máy của bạn nếu cần).
        private const string ChuoiKetNoi = @"Server=.;Database=QuanLyNguoiDung;Trusted_Connection=True;TrustServerCertificate=True;";

        // 1. Hàm xử lý Đăng Ký
        public static bool DangKy(string ten, string sdt, string email, string matKhau)
        {
            // Gọi lớp MatKhau để lấy Salt và chuỗi băm
            var (salt, bam) = MatKhau.Tao(matKhau);

            using var conn = new SqlConnection(ChuoiKetNoi);
            // Câu lệnh SQL dùng tham số (chống SQL Injection)
            const string sql = @"INSERT INTO Users (TenDangNhap, SoDienThoai, Email, MatKhauBam, Salt) 
                                 VALUES (@ten, @sdt, @email, @bam, @salt)";
            using var cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = ten;
            cmd.Parameters.Add("@sdt", SqlDbType.VarChar, 10).Value = sdt;
            // Nếu email rỗng thì lưu NULL vào DB
            cmd.Parameters.Add("@email", SqlDbType.NVarChar, 100).Value = string.IsNullOrEmpty(email) ? DBNull.Value : email;
            cmd.Parameters.Add("@bam", SqlDbType.NVarChar, 64).Value = bam;
            cmd.Parameters.Add("@salt", SqlDbType.NVarChar, 32).Value = salt;

            try
            {
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0; // Thêm thành công trả về true
            }
            catch (SqlException ex) when (ex.Number == 2627) // Mã lỗi vi phạm ràng buộc UNIQUE
            {
                throw new Exception("Tên đăng nhập này đã có người sử dụng. Vui lòng chọn tên khác!");
            }
            catch (Exception ex)
            {
                // Bắt mọi lỗi kết nối (ví dụ: tắt SQL Server) để không văng màn hình ngoại lệ
                throw new Exception("Lỗi kết nối (Đăng ký): " + ex.Message, ex);
            }
        }

        // 2. Hàm xử lý Đăng Nhập
        public static bool DangNhap(string ten, string matKhau)
        {
            using var conn = new SqlConnection(ChuoiKetNoi);
            const string sql = "SELECT MatKhauBam, Salt FROM Users WHERE TenDangNhap = @ten";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = ten;

            try
            {
                conn.Open();
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string bamLuu = reader.GetString(0);
                    string saltLuu = reader.GetString(1);

                    // Kiểm tra mật khẩu bằng lớp MatKhau
                    if (MatKhau.KiemTra(matKhau, saltLuu, bamLuu))
                    {
                        return true; // Đăng nhập thành công
                    }
                }
                return false; // Sai tên hoặc sai mật khẩu
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi kết nối (Đăng nhập): " + ex.Message, ex);
            }
        }

        // 3. Sinh mã OTP gồm 6 chữ số
        public static string TaoMaOTP()
        {
            return Random.Shared.Next(100000, 1000000).ToString();
        }

        // 4. Kiểm tra tài khoản có khớp Tên đăng nhập, SĐT và Email không (dùng khi quên mật khẩu)
        public static bool KiemTraNguoiDung(string ten, string sdt, string email)
        {
            using var conn = new SqlConnection(ChuoiKetNoi);
            const string sql = @"SELECT COUNT(*) FROM Users
                                 WHERE TenDangNhap = @ten AND SoDienThoai = @sdt AND Email = @email";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = ten;
            cmd.Parameters.Add("@sdt", SqlDbType.VarChar, 10).Value = sdt;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar, 100).Value = email;

            try
            {
                conn.Open();
                return (int)cmd.ExecuteScalar() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi kết nối (Kiểm tra người dùng): " + ex.Message, ex);
            }
        }

        // 5. Lưu mã OTP vào CSDL, có hiệu lực trong 5 phút
        public static void LuuMaOTP(string ten, string maOTP)
        {
            using var conn = new SqlConnection(ChuoiKetNoi);
            const string sql = @"UPDATE Users
                                 SET MaOTP = @otp, ThoiGianHetHanOTP = DATEADD(MINUTE, 5, SYSDATETIME())
                                 WHERE TenDangNhap = @ten";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@otp", SqlDbType.VarChar, 6).Value = maOTP;
            cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = ten;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi kết nối (Gửi OTP): " + ex.Message, ex);
            }
        }

        // 6. Kiểm tra mã OTP nhập vào có đúng và còn hiệu lực không
        public static bool KiemTraMaOTP(string ten, string maOTP)
        {
            using var conn = new SqlConnection(ChuoiKetNoi);
            const string sql = @"SELECT COUNT(*) FROM Users
                                 WHERE TenDangNhap = @ten AND MaOTP = @otp
                                       AND ThoiGianHetHanOTP > SYSDATETIME()";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = ten;
            cmd.Parameters.Add("@otp", SqlDbType.VarChar, 6).Value = maOTP;

            try
            {
                conn.Open();
                return (int)cmd.ExecuteScalar() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi kết nối (Kiểm tra OTP): " + ex.Message, ex);
            }
        }

        // 7. Đặt lại mật khẩu mới và xóa OTP đã dùng
        public static bool DatLaiMatKhau(string ten, string matKhauMoi)
        {
            var (salt, bam) = MatKhau.Tao(matKhauMoi);

            using var conn = new SqlConnection(ChuoiKetNoi);
            const string sql = @"UPDATE Users
                                 SET MatKhauBam = @bam, Salt = @salt,
                                     MaOTP = NULL, ThoiGianHetHanOTP = NULL
                                 WHERE TenDangNhap = @ten";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@bam", SqlDbType.NVarChar, 64).Value = bam;
            cmd.Parameters.Add("@salt", SqlDbType.NVarChar, 32).Value = salt;
            cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = ten;

            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi kết nối (Đặt lại mật khẩu): " + ex.Message, ex);
            }
        }
    }
}