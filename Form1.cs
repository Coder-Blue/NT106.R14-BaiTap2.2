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

        // Nút Đăng nhập
        private async void btnDangNhap_Click(object sender, EventArgs e)
        {
            lblLoi.Text = "";

            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text;

            if (string.IsNullOrEmpty(tenDangNhap))
            {
                lblLoi.Text = "Vui lòng nhập tên đăng nhập.";
                txtTenDangNhap.Focus();
                return;
            }

            if (string.IsNullOrEmpty(matKhau))
            {
                lblLoi.Text = "Vui lòng nhập mật khẩu.";
                txtMatKhau.Focus();
                return;
            }

            btnDangNhap.Enabled = false;
            btnDangNhap.Text = "Đang xử lý...";
            try
            {
                NguoiDung? nguoiDung = await XuLyNguoiDung.DangNhap(tenDangNhap, matKhau);

                if (nguoiDung == null)
                {
                    // Sai tên hoặc sai mật khẩu đều trả về cùng một thông báo.
                    lblLoi.Text = "Tên đăng nhập hoặc mật khẩu không đúng.";
                    txtMatKhau.Clear();
                    txtMatKhau.Focus();
                }
                else
                {
                    this.Hide();
                    using (FormChinh formChinh = new FormChinh(nguoiDung))
                    {
                        formChinh.ShowDialog();
                    }
                    this.Show();
                    txtMatKhau.Clear();
                }
            }
            catch (Exception ex)
            {
                lblLoi.Text = ex.Message;
            }
            finally
            {
                btnDangNhap.Enabled = true;
                btnDangNhap.Text = "Đăng nhập";
            }
        }

        // Nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Liên kết chuyển sang form Đăng ký
        private void llbDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (DangKy formDangKy = new DangKy())
            {
                formDangKy.ShowDialog();
            }
        }
    }
}
