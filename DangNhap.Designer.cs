namespace CRUD_APP
{
    partial class DangNhap
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            lblPhuDe = new Label();
            lblTenDangNhap = new Label();
            txtTenDangNhap = new TextBox();
            lblMatKhau = new Label();
            txtMatKhau = new TextBox();
            lblLoi = new Label();
            btnDangNhap = new Button();
            btnThoat = new Button();
            llbDangKy = new LinkLabel();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = false;
            lblTieuDe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTieuDe.Location = new Point(0, 26);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(420, 32);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "ĐĂNG NHẬP";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPhuDe
            // 
            lblPhuDe.AutoSize = false;
            lblPhuDe.Font = new Font("Segoe UI", 9F);
            lblPhuDe.ForeColor = Color.FromArgb(110, 110, 110);
            lblPhuDe.Location = new Point(0, 60);
            lblPhuDe.Name = "lblPhuDe";
            lblPhuDe.Size = new Size(420, 20);
            lblPhuDe.TabIndex = 1;
            lblPhuDe.Text = "Hệ thống quản lý người dùng";
            lblPhuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Segoe UI", 10F);
            lblTenDangNhap.Location = new Point(44, 108);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.TabIndex = 2;
            lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI", 11F);
            txtTenDangNhap.Location = new Point(44, 130);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.PlaceholderText = "Nhập tên đăng nhập";
            txtTenDangNhap.Size = new Size(332, 27);
            txtTenDangNhap.TabIndex = 3;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 10F);
            lblMatKhau.Location = new Point(44, 176);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.TabIndex = 4;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 11F);
            txtMatKhau.Location = new Point(44, 198);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '●';
            txtMatKhau.PlaceholderText = "Nhập mật khẩu";
            txtMatKhau.Size = new Size(332, 27);
            txtMatKhau.TabIndex = 5;
            // 
            // lblLoi
            // 
            lblLoi.AutoSize = false;
            lblLoi.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblLoi.ForeColor = Color.FromArgb(192, 40, 40);
            lblLoi.Location = new Point(44, 240);
            lblLoi.Name = "lblLoi";
            lblLoi.Size = new Size(332, 34);
            lblLoi.TabIndex = 6;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(51, 122, 183);
            btnDangNhap.Cursor = Cursors.Hand;
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 96, 145);
            btnDangNhap.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 138, 204);
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(44, 286);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(160, 40);
            btnDangNhap.TabIndex = 7;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.White;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnThoat.FlatAppearance.MouseDownBackColor = Color.FromArgb(225, 225, 225);
            btnThoat.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 245, 245);
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 10.5F);
            btnThoat.ForeColor = Color.FromArgb(64, 64, 64);
            btnThoat.Location = new Point(216, 286);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(160, 40);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // llbDangKy
            // 
            llbDangKy.AutoSize = false;
            llbDangKy.Font = new Font("Segoe UI", 9.75F);
            llbDangKy.Location = new Point(44, 348);
            llbDangKy.Name = "llbDangKy";
            llbDangKy.Size = new Size(332, 20);
            llbDangKy.TabIndex = 9;
            llbDangKy.TabStop = true;
            llbDangKy.Text = "Chưa có tài khoản? Đăng ký ngay";
            llbDangKy.TextAlign = ContentAlignment.MiddleCenter;
            llbDangKy.LinkClicked += llbDangKy_LinkClicked;
            // 
            // DangNhap
            // 
            AcceptButton = btnDangNhap;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnThoat;
            ClientSize = new Size(420, 400);
            Controls.Add(lblTieuDe);
            Controls.Add(lblPhuDe);
            Controls.Add(lblTenDangNhap);
            Controls.Add(txtTenDangNhap);
            Controls.Add(lblMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(lblLoi);
            Controls.Add(btnDangNhap);
            Controls.Add(btnThoat);
            Controls.Add(llbDangKy);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Label lblPhuDe;
        private Label lblTenDangNhap;
        private TextBox txtTenDangNhap;
        private Label lblMatKhau;
        private TextBox txtMatKhau;
        private Label lblLoi;
        private Button btnDangNhap;
        private Button btnThoat;
        private LinkLabel llbDangKy;
    }
}
