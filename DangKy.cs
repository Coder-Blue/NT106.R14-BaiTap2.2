using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CRUD_APP
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các TextBox (BẠN CẦN ĐỔI TÊN txtTen, txtSdt... CHO KHỚP VỚI TÊN THỰC TẾ TRÊN FORM)
            string ten = txtTen.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string email = txtEmail.Text.Trim();
            string mk = txtPassword.Text;
            string xacNhan = txtPasswordConfirm.Text;

            // 1. Kiểm tra dữ liệu rỗng
            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(mk))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên, Số điện thoại và Mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Kiểm tra khớp mật khẩu
            if (mk != xacNhan)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Gọi xuống Database
            try
            {
                // Khóa nút bấm để tránh người dùng bấm nhiều lần (Theo yêu cầu đề bài)
                btnDangKy.Enabled = false;
                btnDangKy.Text = "Đang xử lý...";

                if (XuLyNguoiDung.DangKy(ten, sdt, email, mk))
                {
                    MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đóng form đăng ký
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi tiếng Việt (từ lớp XuLyNguoiDung)
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Mở khóa nút bấm dù thành công hay thất bại
                btnDangKy.Enabled = true;
                btnDangKy.Text = "Đăng Ký";
            }
        }

        private void llbDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close(); // Đóng form Đăng ký, tự động quay về Form Đăng nhập
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void btnOTP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mã OTP của bạn là: 123456\n(Vui lòng nhập mã này vào ô OTP bên dưới)", "Thông báo OTP", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
