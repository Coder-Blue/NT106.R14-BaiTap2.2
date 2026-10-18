using System;
using System.Windows.Forms;

namespace CRUD_APP
{
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
        }

        // Nhận thông tin người dùng đang đăng nhập để hiển thị
        public FormChinh(NguoiDung nguoiDung) : this()
        {
            lblChaoMung.Text = "Xin chào, " + nguoiDung.HoTen;
            lblTenDangNhap.Text = nguoiDung.TenDangNhap;
            lblHoTen.Text = nguoiDung.HoTen;
            lblEmail.Text = string.IsNullOrEmpty(nguoiDung.Email) ? "(không có)" : nguoiDung.Email;
            lblNgayTao.Text = nguoiDung.NgayTao.ToString("dd/MM/yyyy HH:mm");
            lblLanDangNhapCuoi.Text = nguoiDung.LanDangNhapCuoi.HasValue
                ? nguoiDung.LanDangNhapCuoi.Value.ToString("dd/MM/yyyy HH:mm")
                : "Đăng nhập lần đầu";
        }

        // Nút Đăng xuất quay lại form Đăng nhập
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
