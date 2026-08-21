namespace AshkanSocial.Forms.Auth
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null!;

        private Label lblLanguage;
        private ComboBox cmbLanguage;

        private Label lblTitle;
        private Label lblSubtitle;

        private Label lblUsernameOrEmail;
        private TextBox txtUsernameOrEmail;

        private Label lblPassword;
        private TextBox txtPassword;

        private Button btnLogin;
        private Button btnGoToRegister;
        private Label lblStatus;

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
            lblLanguage = new Label();
            cmbLanguage = new ComboBox();
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblUsernameOrEmail = new Label();
            txtUsernameOrEmail = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnGoToRegister = new Button();
            lblStatus = new Label();

            SuspendLayout();

            // lblLanguage
            lblLanguage.AutoSize = true;
            lblLanguage.Font = new Font("Segoe UI", 8.5F);
            lblLanguage.ForeColor = Color.FromArgb(100, 116, 139);
            lblLanguage.Location = new Point(315, 17);
            lblLanguage.Name = "lblLanguage";
            lblLanguage.Size = new Size(68, 20);
            lblLanguage.TabIndex = 0;
            lblLanguage.Text = "Language:";

            // cmbLanguage
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

            // lblTitle
            lblTitle.AutoSize = false;
            lblTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitle.Location = new Point(50, 95);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(420, 42);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Welcome back";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // lblSubtitle
            lblSubtitle.AutoSize = false;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubtitle.Location = new Point(55, 141);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(410, 34);
            lblSubtitle.TabIndex = 3;
            lblSubtitle.Text = "Sign in to continue to Ashkan Social.";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;

            // lblUsernameOrEmail
            lblUsernameOrEmail.AutoSize = true;
            lblUsernameOrEmail.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblUsernameOrEmail.ForeColor = Color.FromArgb(30, 41, 59);
            lblUsernameOrEmail.Location = new Point(65, 215);
            lblUsernameOrEmail.Name = "lblUsernameOrEmail";
            lblUsernameOrEmail.Size = new Size(142, 21);
            lblUsernameOrEmail.TabIndex = 4;
            lblUsernameOrEmail.Text = "Username or Email";

            // txtUsernameOrEmail
            txtUsernameOrEmail.BackColor = Color.White;
            txtUsernameOrEmail.BorderStyle = BorderStyle.FixedSingle;
            txtUsernameOrEmail.Font = new Font("Segoe UI", 10F);
            txtUsernameOrEmail.ForeColor = Color.FromArgb(15, 23, 42);
            txtUsernameOrEmail.Location = new Point(65, 240);
            txtUsernameOrEmail.MaxLength = 150;
            txtUsernameOrEmail.Name = "txtUsernameOrEmail";
            txtUsernameOrEmail.RightToLeft = RightToLeft.No;
            txtUsernameOrEmail.Size = new Size(390, 30);
            txtUsernameOrEmail.TabIndex = 5;
            txtUsernameOrEmail.TextAlign = HorizontalAlignment.Left;

            // lblPassword
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(30, 41, 59);
            lblPassword.Location = new Point(65, 295);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(82, 21);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password";

            // txtPassword
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.ForeColor = Color.FromArgb(15, 23, 42);
            txtPassword.Location = new Point(65, 320);
            txtPassword.MaxLength = 100;
            txtPassword.Name = "txtPassword";
            txtPassword.RightToLeft = RightToLeft.No;
            txtPassword.Size = new Size(390, 30);
            txtPassword.TabIndex = 7;
            txtPassword.TextAlign = HorizontalAlignment.Left;
            txtPassword.UseSystemPasswordChar = true;

            // btnLogin
            btnLogin.BackColor = Color.FromArgb(37, 99, 235);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(65, 390);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(390, 44);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Sign In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;

            // btnGoToRegister
            btnGoToRegister.BackColor = Color.FromArgb(248, 250, 252);
            btnGoToRegister.Cursor = Cursors.Hand;
            btnGoToRegister.FlatAppearance.BorderSize = 0;
            btnGoToRegister.FlatStyle = FlatStyle.Flat;
            btnGoToRegister.Font = new Font("Segoe UI", 9F);
            btnGoToRegister.ForeColor = Color.FromArgb(37, 99, 235);
            btnGoToRegister.Location = new Point(105, 445);
            btnGoToRegister.Name = "btnGoToRegister";
            btnGoToRegister.Size = new Size(310, 30);
            btnGoToRegister.TabIndex = 9;
            btnGoToRegister.Text = "Don't have an account? Create one";
            btnGoToRegister.UseVisualStyleBackColor = false;
            btnGoToRegister.Click += btnGoToRegister_Click;


            // lblStatus
            lblStatus.Font = new Font("Segoe UI", 9F);
            lblStatus.ForeColor = Color.FromArgb(220, 38, 38);
            lblStatus.Location = new Point(65, 485);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(390, 35);
            lblStatus.TabIndex = 10;
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;

            // LoginForm
            AcceptButton = btnLogin;
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(520, 560);

            Controls.Add(lblStatus);
            Controls.Add(btnGoToRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsernameOrEmail);
            Controls.Add(lblUsernameOrEmail);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Controls.Add(cmbLanguage);
            Controls.Add(lblLanguage);

            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimumSize = new Size(520, 560);
            Name = "LoginForm";
            RightToLeft = RightToLeft.No;
            RightToLeftLayout = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign In - Ashkan Social";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
