namespace CRUD_APP
{
    partial class QuenMatKhau
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            llbDangNhap = new LinkLabel();
            btnResetPassword = new Button();
            btnOTP = new Button();
            txtOTP = new TextBox();
            txtNewPasswordConfirm = new TextBox();
            txtNewPassword = new TextBox();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            txtTen = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // llbDangNhap
            // 
            llbDangNhap.AutoSize = true;
            llbDangNhap.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llbDangNhap.Location = new Point(410, 379);
            llbDangNhap.Margin = new Padding(2, 0, 2, 0);
            llbDangNhap.Name = "llbDangNhap";
            llbDangNhap.Size = new Size(118, 30);
            llbDangNhap.TabIndex = 33;
            llbDangNhap.TabStop = true;
            llbDangNhap.Text = "Đăng nhập";
            llbDangNhap.LinkClicked += llbDangNhap_LinkClicked;
            // 
            // btnResetPassword
            // 
            btnResetPassword.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResetPassword.Location = new Point(358, 318);
            btnResetPassword.Margin = new Padding(2);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(232, 50);
            btnResetPassword.TabIndex = 32;
            btnResetPassword.Text = "Đặt lại mật khẩu";
            btnResetPassword.UseVisualStyleBackColor = true;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // btnOTP
            // 
            btnOTP.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOTP.Location = new Point(528, 250);
            btnOTP.Margin = new Padding(2);
            btnOTP.Name = "btnOTP";
            btnOTP.Size = new Size(241, 28);
            btnOTP.TabIndex = 31;
            btnOTP.Text = "Nhấn để gửi OTP về SĐT và Email";
            btnOTP.UseVisualStyleBackColor = true;
            btnOTP.Click += btnOTP_Click;
            // 
            // txtOTP
            // 
            txtOTP.Font = new Font("Segoe UI", 15F);
            txtOTP.Location = new Point(299, 250);
            txtOTP.Margin = new Padding(2);
            txtOTP.Name = "txtOTP";
            txtOTP.Size = new Size(227, 34);
            txtOTP.TabIndex = 30;
            // 
            // txtNewPasswordConfirm
            // 
            txtNewPasswordConfirm.Font = new Font("Segoe UI", 15F);
            txtNewPasswordConfirm.Location = new Point(299, 218);
            txtNewPasswordConfirm.Margin = new Padding(2);
            txtNewPasswordConfirm.Name = "txtNewPasswordConfirm";
            txtNewPasswordConfirm.PasswordChar = '?';
            txtNewPasswordConfirm.Size = new Size(472, 34);
            txtNewPasswordConfirm.TabIndex = 29;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 15F);
            txtNewPassword.Location = new Point(299, 187);
            txtNewPassword.Margin = new Padding(2);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '?';
            txtNewPassword.Size = new Size(472, 34);
            txtNewPassword.TabIndex = 28;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 15F);
            txtEmail.Location = new Point(299, 155);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(472, 34);
            txtEmail.TabIndex = 27;
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Segoe UI", 15F);
            txtSDT.Location = new Point(299, 123);
            txtSDT.Margin = new Padding(2);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(472, 34);
            txtSDT.TabIndex = 26;
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI", 15F);
            txtTen.Location = new Point(299, 91);
            txtTen.Margin = new Padding(2);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(472, 34);
            txtTen.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(299, 280);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(340, 41);
            label8.TabIndex = 24;
            label8.Text = "----------- *** -----------";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(101, 252);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(51, 28);
            label7.TabIndex = 23;
            label7.Text = "OTP:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(101, 220);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(181, 28);
            label6.TabIndex = 22;
            label6.Text = "Xác nhận mật khẩu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(101, 188);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(137, 28);
            label5.TabIndex = 21;
            label5.Text = "Mật khẩu mới:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(101, 157);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 28);
            label4.TabIndex = 20;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(101, 125);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(132, 28);
            label3.TabIndex = 19;
            label3.Text = "Số điện thoại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(101, 93);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 18;
            label2.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(338, 35);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(245, 37);
            label1.TabIndex = 17;
            label1.Text = "QUÊN MẬT KHẨU";
            // 
            // QuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 439);
            Controls.Add(llbDangNhap);
            Controls.Add(btnResetPassword);
            Controls.Add(btnOTP);
            Controls.Add(txtOTP);
            Controls.Add(txtNewPasswordConfirm);
            Controls.Add(txtNewPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtSDT);
            Controls.Add(txtTen);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "QuenMatKhau";
            Text = "Cấp Lại Mật Khẩu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel llbDangNhap;
        private Button btnResetPassword;
        private Button btnOTP;
        private TextBox txtOTP;
        private TextBox txtNewPasswordConfirm;
        private TextBox txtNewPassword;
        private TextBox txtEmail;
        private TextBox txtSDT;
        private TextBox txtTen;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}