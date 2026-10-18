using System;
using System.Windows.Forms;

namespace CRUD_APP
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string email = txtEmail.Text.Trim();
            string mk = txtPassword.Text;
            string xacNhan = txtPasswordConfirm.Text;

            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(mk))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên, Số điện thoại và Mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (mk != xacNhan)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                btnDangKy.Enabled = false;
                btnDangKy.Text = "Đang xử lý...";

                if (XuLyNguoiDung.DangKy(ten, sdt, email, mk))
                {
                    MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnDangKy.Enabled = true;
                btnDangKy.Text = "Đăng Ký";
            }
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
