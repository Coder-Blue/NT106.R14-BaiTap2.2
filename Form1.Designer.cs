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
            llbDangKyTaiKhoan = new LinkLabel();
            llbQuenMatKhau = new LinkLabel();
            btnDangNhap = new Button();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            txtTen = new TextBox();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // llbDangKyTaiKhoan
            // 
            llbDangKyTaiKhoan.AutoSize = true;
            llbDangKyTaiKhoan.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llbDangKyTaiKhoan.Location = new Point(503, 626);
            llbDangKyTaiKhoan.Name = "llbDangKyTaiKhoan";
            llbDangKyTaiKhoan.Size = new Size(275, 45);
            llbDangKyTaiKhoan.TabIndex = 47;
            llbDangKyTaiKhoan.TabStop = true;
            llbDangKyTaiKhoan.Text = "Đăng ký tài khoản";
            // 
            // llbQuenMatKhau
            // 
            llbQuenMatKhau.AutoSize = true;
            llbQuenMatKhau.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llbQuenMatKhau.Location = new Point(519, 581);
            llbQuenMatKhau.Name = "llbQuenMatKhau";
            llbQuenMatKhau.Size = new Size(238, 45);
            llbQuenMatKhau.TabIndex = 46;
            llbQuenMatKhau.TabStop = true;
            llbQuenMatKhau.Text = "Quên mật khẩu";
            // 
            // btnDangNhap
            // 
            btnDangNhap.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.Location = new Point(473, 475);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(332, 84);
            btnDangNhap.TabIndex = 45;
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 15F);
            txtPassword.Location = new Point(436, 318);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '?';
            txtPassword.Size = new Size(672, 47);
            txtPassword.TabIndex = 44;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 15F);
            txtEmail.Location = new Point(436, 265);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(672, 47);
            txtEmail.TabIndex = 43;
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Segoe UI", 15F);
            txtSDT.Location = new Point(436, 212);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(672, 47);
            txtSDT.TabIndex = 42;
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI", 15F);
            txtTen.Location = new Point(436, 159);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(672, 47);
            txtTen.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(389, 412);
            label8.Name = "label8";
            label8.Size = new Size(505, 60);
            label8.TabIndex = 40;
            label8.Text = "----------- *** -----------";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(153, 321);
            label5.Name = "label5";
            label5.Size = new Size(149, 41);
            label5.TabIndex = 39;
            label5.Text = "Mật khẩu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(153, 268);
            label4.Name = "label4";
            label4.Size = new Size(95, 41);
            label4.TabIndex = 38;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(153, 215);
            label3.Name = "label3";
            label3.Size = new Size(200, 41);
            label3.TabIndex = 37;
            label3.Text = "Số điện thoại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(153, 162);
            label2.Name = "label2";
            label2.Size = new Size(159, 41);
            label2.TabIndex = 36;
            label2.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(494, 48);
            label1.Name = "label1";
            label1.Size = new Size(293, 60);
            label1.TabIndex = 35;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 732);
            Controls.Add(llbDangKyTaiKhoan);
            Controls.Add(llbQuenMatKhau);
            Controls.Add(btnDangNhap);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtSDT);
            Controls.Add(txtTen);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Đăng Nhập Tài Khoản";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel llbDangKyTaiKhoan;
        private LinkLabel llbQuenMatKhau;
        private Button btnDangNhap;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtSDT;
        private TextBox txtTen;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
