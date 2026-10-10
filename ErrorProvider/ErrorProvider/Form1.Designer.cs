namespace ErrorProvider
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
            components = new System.ComponentModel.Container();
            lblUsername = new Label();
            lblPassword = new Label();
            lblConfirm = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtConfirm = new TextBox();
            groupBoxPersonal = new GroupBox();
            groupBoxAdditional = new GroupBox();
            lblBirth = new Label();
            dtpBirth = new DateTimePicker();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            cbTerms = new CheckBox();
            btnRegister = new Button();
            btnReset = new Button();
            epCheck = new System.Windows.Forms.ErrorProvider(components);
            groupBoxPersonal.SuspendLayout();
            groupBoxAdditional.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epCheck).BeginInit();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(16, 28);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(107, 20);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Tên đăng nhập";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(48, 62);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Mật khẩu";
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Location = new Point(0, 96);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(134, 20);
            lblConfirm.TabIndex = 2;
            lblConfirm.Text = "Xác nhận mật khẩu";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(140, 25);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 27);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(140, 59);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(140, 93);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(200, 27);
            txtConfirm.TabIndex = 5;
            txtConfirm.UseSystemPasswordChar = true;
            // 
            // groupBoxPersonal
            // 
            groupBoxPersonal.Controls.Add(lblUsername);
            groupBoxPersonal.Controls.Add(lblPassword);
            groupBoxPersonal.Controls.Add(lblConfirm);
            groupBoxPersonal.Controls.Add(txtUsername);
            groupBoxPersonal.Controls.Add(txtPassword);
            groupBoxPersonal.Controls.Add(txtConfirm);
            groupBoxPersonal.Location = new Point(12, 12);
            groupBoxPersonal.Name = "groupBoxPersonal";
            groupBoxPersonal.Size = new Size(360, 130);
            groupBoxPersonal.TabIndex = 6;
            groupBoxPersonal.TabStop = false;
            groupBoxPersonal.Text = "Thông tin cá nhân";
            // 
            // groupBoxAdditional
            // 
            groupBoxAdditional.Controls.Add(lblBirth);
            groupBoxAdditional.Controls.Add(dtpBirth);
            groupBoxAdditional.Controls.Add(rbMale);
            groupBoxAdditional.Controls.Add(rbFemale);
            groupBoxAdditional.Controls.Add(cbTerms);
            groupBoxAdditional.Location = new Point(12, 150);
            groupBoxAdditional.Name = "groupBoxAdditional";
            groupBoxAdditional.Size = new Size(360, 160);
            groupBoxAdditional.TabIndex = 7;
            groupBoxAdditional.TabStop = false;
            groupBoxAdditional.Text = "Thông tin bổ sung";
            // 
            // lblBirth
            // 
            lblBirth.AutoSize = true;
            lblBirth.Location = new Point(16, 28);
            lblBirth.Name = "lblBirth";
            lblBirth.Size = new Size(74, 20);
            lblBirth.TabIndex = 0;
            lblBirth.Text = "Ngày sinh";
            // 
            // dtpBirth
            // 
            dtpBirth.Format = DateTimePickerFormat.Short;
            dtpBirth.Location = new Point(140, 22);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(200, 27);
            dtpBirth.TabIndex = 1;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(140, 58);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(62, 24);
            rbMale.TabIndex = 2;
            rbMale.TabStop = true;
            rbMale.Text = "Nam";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(210, 58);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(50, 24);
            rbFemale.TabIndex = 3;
            rbFemale.TabStop = true;
            rbFemale.Text = "Nữ";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // cbTerms
            // 
            cbTerms.AutoSize = true;
            cbTerms.Location = new Point(16, 96);
            cbTerms.Name = "cbTerms";
            cbTerms.Size = new Size(255, 24);
            cbTerms.TabIndex = 4;
            cbTerms.Text = "Tôi đồng ý với Điều khoản dịch vụ";
            cbTerms.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(60, 330);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(100, 30);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Đăng Ký";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(220, 330);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(100, 30);
            btnReset.TabIndex = 9;
            btnReset.Text = "Làm Mới";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // epCheck
            // 
            epCheck.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 372);
            Controls.Add(groupBoxPersonal);
            Controls.Add(groupBoxAdditional);
            Controls.Add(btnRegister);
            Controls.Add(btnReset);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Đăng ký tài khoản";
            groupBoxPersonal.ResumeLayout(false);
            groupBoxPersonal.PerformLayout();
            groupBoxAdditional.ResumeLayout(false);
            groupBoxAdditional.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epCheck).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.GroupBox groupBoxPersonal;
        private System.Windows.Forms.GroupBox groupBoxAdditional;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.CheckBox cbTerms;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ErrorProvider epCheck;

        #endregion
    }
}
