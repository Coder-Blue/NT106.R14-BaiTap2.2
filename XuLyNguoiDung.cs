using System;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace CRUD_APP
{
    // Lớp truy cập cơ sở dữ liệu: mọi câu lệnh SQL đều nằm ở đây,
    // không viết trực tiếp trong hàm xử lý sự kiện của form.
    public static class XuLyNguoiDung
    {
        // Chuỗi kết nối SQL Server. Đổi lại tên instance cho đúng với máy của bạn nếu cần.
        private const string ChuoiKetNoi =
            @"Server=localhost\SQLEXPRESS;Database=QuanLyNguoiDung;Trusted_Connection=True;TrustServerCertificate=True;";

        // Kiểm tra tên đăng nhập đã tồn tại trong bảng Users chưa.
        public static async Task<bool> KiemTraTenDangNhapTonTai(string tenDangNhap)
        {
            const string sql = "SELECT COUNT(*) FROM Users WHERE TenDangNhap = @ten";
            using var conn = new SqlConnection(ChuoiKetNoi);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = tenDangNhap;

            try
            {
                await conn.OpenAsync();
                int soLuong = Convert.ToInt32(await cmd.ExecuteScalarAsync());
                return soLuong > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Không thể kết nối đến cơ sở dữ liệu. Vui lòng kiểm tra lại SQL Server.", ex);
            }
        }

        // Thêm một tài khoản mới; mật khẩu được băm kèm salt trước khi lưu.
        public static async Task DangKy(string tenDangNhap, string matKhau, string hoTen, string email)
        {
            var (salt, bam) = MatKhau.Tao(matKhau);

            const string sql = @"INSERT INTO Users (TenDangNhap, MatKhauBam, Salt, HoTen, Email)
                                 VALUES (@ten, @bam, @salt, @hoTen, @email)";
            using var conn = new SqlConnection(ChuoiKetNoi);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = tenDangNhap;
            cmd.Parameters.Add("@bam", SqlDbType.NVarChar, 64).Value = bam;
            cmd.Parameters.Add("@salt", SqlDbType.NVarChar, 32).Value = salt;
            cmd.Parameters.Add("@hoTen", SqlDbType.NVarChar, 50).Value = hoTen;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar, 100).Value =
                string.IsNullOrEmpty(email) ? DBNull.Value : email;

            try
            {
                await conn.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }
            catch (SqlException ex) when (ex.Number == 2627)
            {
                // Ràng buộc UNIQUE trên TenDangNhap là mức ngăn trùng thứ hai.
                throw new Exception("Tên này đã có người dùng.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Không thể kết nối đến cơ sở dữ liệu. Vui lòng kiểm tra lại SQL Server.", ex);
            }
        }

        // Kiểm tra đăng nhập. Trả về thông tin người dùng nếu đúng, ngược lại trả về null.
        public static async Task<NguoiDung?> DangNhap(string tenDangNhap, string matKhau)
        {
            var nguoiDung = new NguoiDung { TenDangNhap = tenDangNhap };

            using var conn = new SqlConnection(ChuoiKetNoi);
            try
            {
                await conn.OpenAsync();

                const string sql = @"SELECT MatKhauBam, Salt, HoTen, Email, NgayTao, LanDangNhapCuoi
                                     FROM Users WHERE TenDangNhap = @ten";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = tenDangNhap;
                    using var reader = await cmd.ExecuteReaderAsync();

                    if (!await reader.ReadAsync())
                    {
                        return null;
                    }

                    string bamLuu = reader.GetString(0);
                    string saltLuu = reader.GetString(1);

                    if (!MatKhau.KiemTra(matKhau, saltLuu, bamLuu))
                    {
                        return null;
                    }

                    nguoiDung.HoTen = reader.GetString(2);
                    nguoiDung.Email = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    nguoiDung.NgayTao = reader.GetDateTime(4);
                    nguoiDung.LanDangNhapCuoi = reader.IsDBNull(5) ? null : reader.GetDateTime(5);
                }

                // Cập nhật thời điểm đăng nhập gần nhất.
                const string sqlCapNhat = "UPDATE Users SET LanDangNhapCuoi = SYSDATETIME() WHERE TenDangNhap = @ten";
                using (var cmd = new SqlCommand(sqlCapNhat, conn))
                {
                    cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = tenDangNhap;
                    await cmd.ExecuteNonQueryAsync();
                }

                return nguoiDung;
            }
            catch (Exception ex)
            {
                throw new Exception("Không thể kết nối đến cơ sở dữ liệu. Vui lòng kiểm tra lại SQL Server.", ex);
            }
        }
    }
}
