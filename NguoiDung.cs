using System;

namespace CRUD_APP
{
    // Thông tin người dùng lấy từ bảng Users, dùng để hiển thị trên form chính.
    public class NguoiDung
    {
        public string TenDangNhap { get; set; } = "";
        public string HoTen { get; set; } = "";
        public string Email { get; set; } = "";
        public DateTime NgayTao { get; set; }
        public DateTime? LanDangNhapCuoi { get; set; }
    }
}
