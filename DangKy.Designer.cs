namespace CRUD_APP
{
    partial class DangKy
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            lblTenDangNhap = new Label();
            txtTenDangNhap = new TextBox();
            lblLoiTenDangNhap = new Label();
            lblMatKhau = new Label();
            txtMatKhau = new TextBox();
            lblLoiMatKhau = new Label();
            lblXacNhanMatKhau = new Label();
            txtXacNhanMatKhau = new TextBox();
            lblLoiXacNhanMatKhau = new Label();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblLoiHoTen = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblLoiEmail = new Label();
            btnDangKy = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTieuDe.Location = new Point(110, 20);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(240, 32);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Segoe UI", 12F);
            lblTenDangNhap.Location = new Point(30, 80);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(110, 21);
            lblTenDangNhap.TabIndex = 1;
            lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI", 12F);
            txtTenDangNhap.Location = new Point(185, 77);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.PlaceholderText = "3-20 ký tự";
            txtTenDangNhap.Size = new Size(250, 29);
            txtTenDangNhap.TabIndex = 0;
            // 
            // lblLoiTenDangNhap
            // 
            lblLoiTenDangNhap.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblLoiTenDangNhap.ForeColor = Color.Red;
            lblLoiTenDangNhap.Location = new Point(185, 108);
            lblLoiTenDangNhap.Name = "lblLoiTenDangNhap";
            lblLoiTenDangNhap.Size = new Size(250, 18);
            lblLoiTenDangNhap.TabIndex = 2;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 12F);
            lblMatKhau.Location = new Point(30, 135);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(75, 21);
            lblMatKhau.TabIndex = 3;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 12F);
            txtMatKhau.Location = new Point(185, 132);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '●';
            txtMatKhau.PlaceholderText = "tối thiểu 6 ký tự";
            txtMatKhau.Size = new Size(250, 29);
            txtMatKhau.TabIndex = 1;
            // 
            // lblLoiMatKhau
            // 
            lblLoiMatKhau.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblLoiMatKhau.ForeColor = Color.Red;
            lblLoiMatKhau.Location = new Point(185, 163);
            lblLoiMatKhau.Name = "lblLoiMatKhau";
            lblLoiMatKhau.Size = new Size(250, 18);
            lblLoiMatKhau.TabIndex = 4;
            // 
            // lblXacNhanMatKhau
            // 
            lblXacNhanMatKhau.AutoSize = true;
            lblXacNhanMatKhau.Font = new Font("Segoe UI", 12F);
            lblXacNhanMatKhau.Location = new Point(30, 190);
            lblXacNhanMatKhau.Name = "lblXacNhanMatKhau";
            lblXacNhanMatKhau.Size = new Size(150, 21);
            lblXacNhanMatKhau.TabIndex = 5;
            lblXacNhanMatKhau.Text = "Xác nhận mật khẩu";
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Font = new Font("Segoe UI", 12F);
            txtXacNhanMatKhau.Location = new Point(185, 187);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.PasswordChar = '●';
            txtXacNhanMatKhau.PlaceholderText = "nhập lại mật khẩu";
            txtXacNhanMatKhau.Size = new Size(250, 29);
            txtXacNhanMatKhau.TabIndex = 2;
            // 
            // lblLoiXacNhanMatKhau
            // 
            lblLoiXacNhanMatKhau.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblLoiXacNhanMatKhau.ForeColor = Color.Red;
            lblLoiXacNhanMatKhau.Location = new Point(185, 218);
            lblLoiXacNhanMatKhau.Name = "lblLoiXacNhanMatKhau";
            lblLoiXacNhanMatKhau.Size = new Size(250, 18);
            lblLoiXacNhanMatKhau.TabIndex = 6;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 12F);
            lblHoTen.Location = new Point(30, 245);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(55, 21);
            lblHoTen.TabIndex = 7;
            lblHoTen.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 12F);
            txtHoTen.Location = new Point(185, 242);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.PlaceholderText = "tối đa 50 ký tự";
            txtHoTen.Size = new Size(250, 29);
            txtHoTen.TabIndex = 3;
            // 
            // lblLoiHoTen
            // 
            lblLoiHoTen.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblLoiHoTen.ForeColor = Color.Red;
            lblLoiHoTen.Location = new Point(185, 273);
            lblLoiHoTen.Name = "lblLoiHoTen";
            lblLoiHoTen.Size = new Size(250, 18);
            lblLoiHoTen.TabIndex = 8;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F);
            lblEmail.Location = new Point(30, 300);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 21);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(185, 297);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "ten@mien.com";
            txtEmail.Size = new Size(250, 29);
            txtEmail.TabIndex = 4;
            // 
            // lblLoiEmail
            // 
            lblLoiEmail.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblLoiEmail.ForeColor = Color.Red;
            lblLoiEmail.Location = new Point(185, 328);
            lblLoiEmail.Name = "lblLoiEmail";
            lblLoiEmail.Size = new Size(250, 18);
            lblLoiEmail.TabIndex = 10;
            // 
            // btnDangKy
            // 
            btnDangKy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDangKy.Location = new Point(80, 375);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(140, 40);
            btnDangKy.TabIndex = 5;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnHuy
            // 
            btnHuy.Font = new Font("Segoe UI", 12F);
            btnHuy.Location = new Point(250, 375);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(140, 40);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // DangKy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 440);
            Controls.Add(lblTieuDe);
            Controls.Add(lblTenDangNhap);
            Controls.Add(txtTenDangNhap);
            Controls.Add(lblLoiTenDangNhap);
            Controls.Add(lblMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(lblLoiMatKhau);
            Controls.Add(lblXacNhanMatKhau);
            Controls.Add(txtXacNhanMatKhau);
            Controls.Add(lblLoiXacNhanMatKhau);
            Controls.Add(lblHoTen);
            Controls.Add(txtHoTen);
            Controls.Add(lblLoiHoTen);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblLoiEmail);
            Controls.Add(btnDangKy);
            Controls.Add(btnHuy);
            AcceptButton = btnDangKy;
            CancelButton = btnHuy;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DangKy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký tài khoản";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Label lblTenDangNhap;
        private TextBox txtTenDangNhap;
        private Label lblLoiTenDangNhap;
        private Label lblMatKhau;
        private TextBox txtMatKhau;
        private Label lblLoiMatKhau;
        private Label lblXacNhanMatKhau;
        private TextBox txtXacNhanMatKhau;
        private Label lblLoiXacNhanMatKhau;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblLoiHoTen;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblLoiEmail;
        private Button btnDangKy;
        private Button btnHuy;
    }
}
