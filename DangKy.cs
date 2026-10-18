using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CRUD_APP
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        // Nút Đăng ký
        private async void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu())
            {
                return;
            }

            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text;
            string hoTen = txtHoTen.Text.Trim();
            string email = txtEmail.Text.Trim();

            btnDangKy.Enabled = false;
            btnDangKy.Text = "Đang xử lý...";
            try
            {
                // Ngăn trùng tên đăng nhập ở mức chương trình.
                if (await XuLyNguoiDung.KiemTraTenDangNhapTonTai(tenDangNhap))
                {
                    lblLoiTenDangNhap.Text = "Tên này đã có người dùng.";
                    txtTenDangNhap.Focus();
                    return;
                }

                await XuLyNguoiDung.DangKy(tenDangNhap, matKhau, hoTen, email);

                MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnDangKy.Enabled = true;
                btnDangKy.Text = "Đăng ký";
            }
        }

        // Nút Huỷ
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Kiểm tra tính hợp lệ của dữ liệu trước khi truy cập cơ sở dữ liệu.
        private bool KiemTraDuLieu()
        {
            lblLoiTenDangNhap.Text = "";
            lblLoiMatKhau.Text = "";
            lblLoiXacNhanMatKhau.Text = "";
            lblLoiHoTen.Text = "";
            lblLoiEmail.Text = "";

            bool hopLe = true;
            Control? oLoiDauTien = null;

            string tenDangNhap = txtTenDangNhap.Text.Trim();
            if (string.IsNullOrEmpty(tenDangNhap))
            {
                lblLoiTenDangNhap.Text = "Không được để trống.";
                oLoiDauTien ??= txtTenDangNhap;
                hopLe = false;
            }
            else if (tenDangNhap.Length < 3 || tenDangNhap.Length > 20)
            {
                lblLoiTenDangNhap.Text = "Tên đăng nhập phải có từ 3 đến 20 ký tự.";
                oLoiDauTien ??= txtTenDangNhap;
                hopLe = false;
            }

            string matKhau = txtMatKhau.Text;
            if (string.IsNullOrEmpty(matKhau))
            {
                lblLoiMatKhau.Text = "Không được để trống.";
                oLoiDauTien ??= txtMatKhau;
                hopLe = false;
            }
            else if (matKhau.Length < 6)
            {
                lblLoiMatKhau.Text = "Mật khẩu phải có ít nhất 6 ký tự.";
                oLoiDauTien ??= txtMatKhau;
                hopLe = false;
            }

            if (string.IsNullOrEmpty(txtXacNhanMatKhau.Text))
            {
                lblLoiXacNhanMatKhau.Text = "Không được để trống.";
                oLoiDauTien ??= txtXacNhanMatKhau;
                hopLe = false;
            }
            else if (txtXacNhanMatKhau.Text != matKhau)
            {
                lblLoiXacNhanMatKhau.Text = "Mật khẩu xác nhận không khớp.";
                oLoiDauTien ??= txtXacNhanMatKhau;
                hopLe = false;
            }

            string hoTen = txtHoTen.Text.Trim();
            if (string.IsNullOrEmpty(hoTen))
            {
                lblLoiHoTen.Text = "Không được để trống.";
                oLoiDauTien ??= txtHoTen;
                hopLe = false;
            }
            else if (hoTen.Length > 50)
            {
                lblLoiHoTen.Text = "Họ tên tối đa 50 ký tự.";
                oLoiDauTien ??= txtHoTen;
                hopLe = false;
            }

            // Email không bắt buộc, chỉ kiểm tra định dạng khi người dùng có nhập.
            string email = txtEmail.Text.Trim();
            if (!string.IsNullOrEmpty(email) && !KiemTraEmail(email))
            {
                lblLoiEmail.Text = "Địa chỉ thư điện tử không đúng định dạng.";
                oLoiDauTien ??= txtEmail;
                hopLe = false;
            }
            else if (email.Length > 100)
            {
                lblLoiEmail.Text = "Email tối đa 100 ký tự.";
                oLoiDauTien ??= txtEmail;
                hopLe = false;
            }

            if (oLoiDauTien != null)
            {
                oLoiDauTien.Focus();
            }
            return hopLe;
        }

        // Kiểm tra địa chỉ thư điện tử có dạng ten@mien.com
        private static bool KiemTraEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
    }
}
