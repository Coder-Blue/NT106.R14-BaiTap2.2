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
            string ten = txtTen.Text.Trim();
            string mkMoi = txtNewPassword.Text;
            string xacNhan = txtNewPasswordConfirm.Text;
            string otp = txtOTP.Text.Trim();

            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(mkMoi) || string.IsNullOrEmpty(otp))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên đăng nhập, Mật khẩu mới và OTP!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (mkMoi != xacNhan)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (!XuLyNguoiDung.KiemTraMaOTP(ten, otp))
                {
                    MessageBox.Show("Mã OTP không đúng hoặc đã hết hạn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (XuLyNguoiDung.DatLaiMatKhau(ten, mkMoi))
                {
                    MessageBox.Show("Đặt lại mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llbDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnOTP_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập Tên đăng nhập, Số điện thoại và Email!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (!XuLyNguoiDung.KiemTraNguoiDung(ten, sdt, email))
                {
                    MessageBox.Show("Thông tin tài khoản không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maOTP = XuLyNguoiDung.TaoMaOTP();
                XuLyNguoiDung.LuuMaOTP(ten, maOTP);
                MessageBox.Show("Mã OTP của bạn là: " + maOTP + "\n(Mã có hiệu lực trong 5 phút)", "Thông báo OTP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
