using System;
using System.Windows.Forms;

namespace CRUD_APP
{
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng cấp lại mật khẩu đang được bảo trì. Vui lòng liên hệ Admin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void llbDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnOTP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mã OTP của bạn là: 123456\n(Vui lòng nhập mã này vào ô OTP bên dưới)", "Thông báo OTP", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
