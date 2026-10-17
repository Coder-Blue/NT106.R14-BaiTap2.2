using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace CRUD_APP
{
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
        }

        // Nút Đặt lại mật khẩu (tạm thời báo lỗi vì chưa có code SQL)
        private void btnDatLaiMatKhau_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng cấp lại mật khẩu đang được bảo trì!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Link Đăng nhập (quay lại form đăng nhập)
        private void linkDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close(); // Đóng form quên mật khẩu
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng cấp lại mật khẩu đang được bảo trì. Vui lòng liên hệ Admin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void llbDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close(); // Đóng form Quên mật khẩu
        }

        private void btnOTP_Click(object sender, EventArgs e)
        {
            // Giả lập gửi OTP bằng cách hiện thông báo
            MessageBox.Show("Mã OTP của bạn là: 123456\n(Vui lòng nhập mã này vào ô OTP bên dưới)", "Thông báo OTP", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}