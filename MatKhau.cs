using System;
using System.Security.Cryptography;

namespace CRUD_APP
{
    public static class MatKhau
    {
        // Số vòng lặp theo khuyến nghị của OWASP cho PBKDF2-HMAC-SHA256
        private const int VONG_LAP = 600_000;

        // Hàm gọi khi Đăng ký: Sinh Salt ngẫu nhiên và băm mật khẩu
        public static (string Salt, string Bam) Tao(string matKhau)
        {
            // Sinh 16 bytes salt ngẫu nhiên
            byte[] salt = RandomNumberGenerator.GetBytes(16);

            // Băm mật khẩu
            byte[] bam = Rfc2898DeriveBytes.Pbkdf2(
                matKhau, salt, VONG_LAP, HashAlgorithmName.SHA256, 32);

            // Trả về dạng chuỗi Base64 để lưu vào SQL Server
            return (Convert.ToBase64String(salt), Convert.ToBase64String(bam));
        }

        // Hàm gọi khi Đăng nhập: Băm lại mật khẩu vừa nhập và so sánh với CSDL
        public static bool KiemTra(string matKhau, string saltLuu, string bamLuu)
        {
            try
            {
                byte[] salt = Convert.FromBase64String(saltLuu);
                byte[] bamCu = Convert.FromBase64String(bamLuu);

                // Băm lại với đúng salt đã lưu
                byte[] bamMoi = Rfc2898DeriveBytes.Pbkdf2(
                    matKhau, salt, VONG_LAP, HashAlgorithmName.SHA256, 32);

                // So sánh an toàn (chống tấn công timing attack)
                return CryptographicOperations.FixedTimeEquals(bamCu, bamMoi);
            }
            catch
            {
                return false; // Trả về false nếu có lỗi giải mã chuỗi Base64
            }
        }
    }
}