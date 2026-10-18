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

            // Gán giá trị vào tham số
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
    }
}