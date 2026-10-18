namespace CRUD_APP
{
    partial class Form1
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
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTieuDe.Location = new Point(120, 20);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(180, 32);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "ĐĂNG NHẬP";
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Segoe UI", 12F);
            lblTenDangNhap.Location = new Point(30, 85);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(110, 21);
            lblTenDangNhap.TabIndex = 1;
            lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI", 12F);
            txtTenDangNhap.Location = new Point(150, 82);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(220, 29);
            txtTenDangNhap.TabIndex = 0;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 12F);
            lblMatKhau.Location = new Point(30, 125);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(75, 21);
            lblMatKhau.TabIndex = 2;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 12F);
            txtMatKhau.Location = new Point(150, 122);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '●';
            txtMatKhau.Size = new Size(220, 29);
            txtMatKhau.TabIndex = 1;
            // 
            // lblLoi
            // 
            lblLoi.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblLoi.ForeColor = Color.Red;
            lblLoi.Location = new Point(30, 160);
            lblLoi.Name = "lblLoi";
            lblLoi.Size = new Size(340, 42);
            lblLoi.TabIndex = 3;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDangNhap.Location = new Point(60, 210);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(130, 40);
            btnDangNhap.TabIndex = 2;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 12F);
            btnThoat.Location = new Point(215, 210);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(130, 40);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // llbDangKy
            // 
            llbDangKy.AutoSize = true;
            llbDangKy.Font = new Font("Segoe UI", 10F);
            llbDangKy.Location = new Point(110, 272);
            llbDangKy.Name = "llbDangKy";
            llbDangKy.Size = new Size(180, 19);
            llbDangKy.TabIndex = 4;
            llbDangKy.TabStop = true;
            llbDangKy.Text = "Chưa có tài khoản? Đăng ký";
            llbDangKy.LinkClicked += llbDangKy_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 320);
            Controls.Add(lblTieuDe);
            Controls.Add(lblTenDangNhap);
            Controls.Add(txtTenDangNhap);
            Controls.Add(lblMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(lblLoi);
            Controls.Add(btnDangNhap);
            Controls.Add(btnThoat);
            Controls.Add(llbDangKy);
            AcceptButton = btnDangNhap;
            CancelButton = btnThoat;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
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
