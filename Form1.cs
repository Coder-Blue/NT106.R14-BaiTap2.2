using System;
using System.Windows.Forms;

namespace CRUD_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 1. Xử lý nút Đăng Nhập
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text.Trim();
            string mk = txtPassword.Text;

            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(mk))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu!");
                return;
            }

            try
            {

                bool thanhCong = XuLyNguoiDung.DangNhap(ten, mk);

                if (thanhCong)
                {
                    MessageBox.Show("Đăng nhập thành công! Chào " + ten);

                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. Xử lý link "Đăng ký tài khoản" (Đây là hàm bạn đang bị thiếu)
        private void llbDangKyTaiKhoan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy formDangKy = new DangKy();
            formDangKy.ShowDialog(); // Mở form Đăng ký
        }

        // 3. Xử lý link "Quên mật khẩu" 
        private void llbQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau formQuenMK = new QuenMatKhau();
            formQuenMK.ShowDialog(); // Mở form Quên mật khẩu
        }

        private void llbDangKyTaiKhoan_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy formDangKy = new DangKy();
            formDangKy.ShowDialog(); // Mở form Đăng ký lên
        }
    }
}