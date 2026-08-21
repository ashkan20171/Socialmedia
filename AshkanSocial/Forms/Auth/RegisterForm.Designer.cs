namespace AshkanSocial.Forms.Auth
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null!;


        private Label lblLanguage;
        private ComboBox cmbLanguage;

        private Label lblTitle;
        private Label lblSubtitle;

        private Label lblUsername;
        private TextBox txtUsername;

        private Label lblDisplayName;
        private TextBox txtDisplayName;

        private Label lblEmail;
        private TextBox txtEmail;

        private Label lblPhoneNumber;
        private TextBox txtPhoneNumber;

        private Label lblPassword;
        private TextBox txtPassword;

        private Label lblConfirmPassword;
        private TextBox txtConfirmPassword;

        private Button btnRegister;
        private Button btnGoToLogin;
        private Label lblStatus;

        /// <summary>
        /// Cleans up any resources used by the form.
        /// </summary>
        /// <param name="disposing">
        /// True to dispose managed resources; otherwise, false.
        /// </param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            lblLanguage = new Label();
            cmbLanguage = new ComboBox();

            lblTitle = new Label();
            lblSubtitle = new Label();

            lblUsername = new Label();
            txtUsername = new TextBox();

            lblDisplayName = new Label();
            txtDisplayName = new TextBox();

            lblEmail = new Label();
            txtEmail = new TextBox();

            lblPhoneNumber = new Label();
            txtPhoneNumber = new TextBox();

            lblPassword = new Label();
            txtPassword = new TextBox();

            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();

            btnRegister = new Button();
            btnGoToLogin = new Button();
            lblStatus = new Label();

            SuspendLayout();

            // ------------------------------------------------------------
            // lblLanguage
            // ------------------------------------------------------------
            lblLanguage.AutoSize = true;
            lblLanguage.Font = new Font("Segoe UI", 8.5F);
            lblLanguage.ForeColor = Color.FromArgb(100, 116, 139);
            lblLanguage.Location = new Point(315, 17);
            lblLanguage.Name = "lblLanguage";
            lblLanguage.Size = new Size(68, 20);
            lblLanguage.TabIndex = 0;
            lblLanguage.Text = "Language:";

            // ------------------------------------------------------------
            // cmbLanguage
            // ------------------------------------------------------------
            cmbLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLanguage.FlatStyle = FlatStyle.Flat;
            cmbLanguage.Font = new Font("Segoe UI", 8.5F);
            cmbLanguage.FormattingEnabled = true;
            cmbLanguage.Items.AddRange(
                new object[]
                {
                    "English",
                    "فارسی"
                });
            cmbLanguage.Location = new Point(387, 13);
            cmbLanguage.Name = "cmbLanguage";
            cmbLanguage.Size = new Size(95, 28);
            cmbLanguage.TabIndex = 1;
            cmbLanguage.SelectedIndexChanged += cmbLanguage_SelectedIndexChanged;

            // ------------------------------------------------------------
            // lblTitle
            // ------------------------------------------------------------
            lblTitle.AutoSize = false;
            lblTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitle.Location = new Point(50, 52);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(420, 42);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Welcome to Ashkan Social";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // ------------------------------------------------------------
            // lblSubtitle
            // ------------------------------------------------------------
            lblSubtitle.AutoSize = false;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubtitle.Location = new Point(55, 98);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(410, 34);
            lblSubtitle.TabIndex = 3;
            lblSubtitle.Text = "Create your account and start connecting.";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;

            // ------------------------------------------------------------
            // lblUsername
            // ------------------------------------------------------------
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(30, 41, 59);
            lblUsername.Location = new Point(65, 145);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(88, 21);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Username";

            // ------------------------------------------------------------
            // txtUsername
            // ------------------------------------------------------------
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.ForeColor = Color.FromArgb(15, 23, 42);
            txtUsername.Location = new Point(65, 170);
            txtUsername.MaxLength = 50;
            txtUsername.Name = "txtUsername";
            txtUsername.RightToLeft = RightToLeft.No;
            txtUsername.Size = new Size(390, 30);
            txtUsername.TabIndex = 5;
            txtUsername.TextAlign = HorizontalAlignment.Left;

            // ------------------------------------------------------------
            // lblDisplayName
            // ------------------------------------------------------------
            lblDisplayName.AutoSize = true;
            lblDisplayName.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblDisplayName.ForeColor = Color.FromArgb(30, 41, 59);
            lblDisplayName.Location = new Point(65, 215);
            lblDisplayName.Name = "lblDisplayName";
            lblDisplayName.Size = new Size(111, 21);
            lblDisplayName.TabIndex = 6;
            lblDisplayName.Text = "Display Name";

            // ------------------------------------------------------------
            // txtDisplayName
            // ------------------------------------------------------------
            txtDisplayName.BackColor = Color.White;
            txtDisplayName.BorderStyle = BorderStyle.FixedSingle;
            txtDisplayName.Font = new Font("Segoe UI", 10F);
            txtDisplayName.ForeColor = Color.FromArgb(15, 23, 42);
            txtDisplayName.Location = new Point(65, 240);
            txtDisplayName.MaxLength = 100;
            txtDisplayName.Name = "txtDisplayName";
            txtDisplayName.RightToLeft = RightToLeft.No;
            txtDisplayName.Size = new Size(390, 30);
            txtDisplayName.TabIndex = 7;
            txtDisplayName.TextAlign = HorizontalAlignment.Left;

            // ------------------------------------------------------------
            // lblEmail
            // ------------------------------------------------------------
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(30, 41, 59);
            lblEmail.Location = new Point(65, 285);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(125, 21);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email (Optional)";

            // ------------------------------------------------------------
            // txtEmail
            // ------------------------------------------------------------
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.ForeColor = Color.FromArgb(15, 23, 42);
            txtEmail.Location = new Point(65, 310);
            txtEmail.MaxLength = 150;
            txtEmail.Name = "txtEmail";
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.Size = new Size(390, 30);
            txtEmail.TabIndex = 9;
            txtEmail.TextAlign = HorizontalAlignment.Left;

            // ------------------------------------------------------------
            // lblPhoneNumber
            // ------------------------------------------------------------
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblPhoneNumber.ForeColor = Color.FromArgb(30, 41, 59);
            lblPhoneNumber.Location = new Point(65, 355);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(194, 21);
            lblPhoneNumber.TabIndex = 10;
            lblPhoneNumber.Text = "Phone Number (Optional)";

            // ------------------------------------------------------------
            // txtPhoneNumber
            // ------------------------------------------------------------
            txtPhoneNumber.BackColor = Color.White;
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Font = new Font("Segoe UI", 10F);
            txtPhoneNumber.ForeColor = Color.FromArgb(15, 23, 42);
            txtPhoneNumber.Location = new Point(65, 380);
            txtPhoneNumber.MaxLength = 20;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.RightToLeft = RightToLeft.No;
            txtPhoneNumber.Size = new Size(390, 30);
            txtPhoneNumber.TabIndex = 11;
            txtPhoneNumber.TextAlign = HorizontalAlignment.Left;

            // ------------------------------------------------------------
            // lblPassword
            // ------------------------------------------------------------
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(30, 41, 59);
            lblPassword.Location = new Point(65, 425);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(82, 21);
            lblPassword.TabIndex = 12;
            lblPassword.Text = "Password";

            // ------------------------------------------------------------
            // txtPassword
            // ------------------------------------------------------------
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.ForeColor = Color.FromArgb(15, 23, 42);
            txtPassword.Location = new Point(65, 450);
            txtPassword.MaxLength = 100;
            txtPassword.Name = "txtPassword";
            txtPassword.RightToLeft = RightToLeft.No;
            txtPassword.Size = new Size(390, 30);
            txtPassword.TabIndex = 13;
            txtPassword.TextAlign = HorizontalAlignment.Left;
            txtPassword.UseSystemPasswordChar = true;

            // ------------------------------------------------------------
            // lblConfirmPassword
            // ------------------------------------------------------------
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblConfirmPassword.ForeColor = Color.FromArgb(30, 41, 59);
            lblConfirmPassword.Location = new Point(65, 495);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(138, 21);
            lblConfirmPassword.TabIndex = 14;
            lblConfirmPassword.Text = "Confirm Password";

            // ------------------------------------------------------------
            // txtConfirmPassword
            // ------------------------------------------------------------
            txtConfirmPassword.BackColor = Color.White;
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Font = new Font("Segoe UI", 10F);
            txtConfirmPassword.ForeColor = Color.FromArgb(15, 23, 42);
            txtConfirmPassword.Location = new Point(65, 520);
            txtConfirmPassword.MaxLength = 100;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.RightToLeft = RightToLeft.No;
            txtConfirmPassword.Size = new Size(390, 30);
            txtConfirmPassword.TabIndex = 15;
            txtConfirmPassword.TextAlign = HorizontalAlignment.Left;
            txtConfirmPassword.UseSystemPasswordChar = true;

            // ------------------------------------------------------------
            // btnRegister
            // ------------------------------------------------------------
            btnRegister.BackColor = Color.FromArgb(37, 99, 235);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(65, 570);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(390, 44);
            btnRegister.TabIndex = 16;
            btnRegister.Text = "Create Account";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;

            // ------------------------------------------------------------
            // btnGoToLogin
            // ------------------------------------------------------------
            btnGoToLogin.BackColor = Color.FromArgb(248, 250, 252);
            btnGoToLogin.Cursor = Cursors.Hand;
            btnGoToLogin.FlatAppearance.BorderSize = 0;
            btnGoToLogin.FlatStyle = FlatStyle.Flat;
            btnGoToLogin.Font = new Font("Segoe UI", 9F);
            btnGoToLogin.ForeColor = Color.FromArgb(37, 99, 235);
            btnGoToLogin.Location = new Point(105, 620);
            btnGoToLogin.Name = "btnGoToLogin";
            btnGoToLogin.Size = new Size(310, 30);
            btnGoToLogin.TabIndex = 17;
            btnGoToLogin.Text = "Already have an account? Sign in";
            btnGoToLogin.UseVisualStyleBackColor = false;
            btnGoToLogin.Click += btnGoToLogin_Click;


            // ------------------------------------------------------------
            // lblStatus
            // ------------------------------------------------------------
            lblStatus.Font = new Font("Segoe UI", 9F);
            lblStatus.ForeColor = Color.FromArgb(220, 38, 38);
            lblStatus.Location = new Point(65, 654);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(390, 30);
            lblStatus.TabIndex = 18;
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;

            // ------------------------------------------------------------
            // RegisterForm
            // ------------------------------------------------------------
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(520, 700);
            Controls.Add(lblStatus);
            Controls.Add(btnGoToLogin);
            Controls.Add(btnRegister);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblPhoneNumber);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtDisplayName);
            Controls.Add(lblDisplayName);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Controls.Add(cmbLanguage);
            Controls.Add(lblLanguage);

            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimumSize = new Size(520, 700);
            Name = "RegisterForm";
            RightToLeft = RightToLeft.No;
            RightToLeftLayout = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Account - Ashkan Social";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
