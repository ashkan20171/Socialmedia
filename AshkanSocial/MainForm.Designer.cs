namespace AshkanSocial
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null!;

        private Panel pnlSidebar;
        private Panel pnlContent;
        private Panel pnlTopBar;

        private Label lblAppName;
        private Label lblUserName;
        private ComboBox cmbLanguage;

        private Button btnHome;
        private Button btnChats;
        private Button btnContacts;
        private Button btnProfile;
        private Button btnSettings;
        private Button btnLogout;

        private Label lblWelcome;
        private Label lblWelcomeDescription;
        private Label lblSectionTitle;
        private Label lblComingSoon;

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
            pnlSidebar = new Panel();
            btnLogout = new Button();
            btnSettings = new Button();
            btnProfile = new Button();
            btnContacts = new Button();
            btnChats = new Button();
            btnHome = new Button();
            lblUserName = new Label();
            lblAppName = new Label();

            pnlContent = new Panel();
            lblComingSoon = new Label();
            lblSectionTitle = new Label();
            lblWelcomeDescription = new Label();
            lblWelcome = new Label();
            pnlTopBar = new Panel();
            cmbLanguage = new ComboBox();

            pnlSidebar.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlTopBar.SuspendLayout();
            SuspendLayout();

            // ------------------------------------------------------------
            // pnlSidebar
            // ------------------------------------------------------------
            pnlSidebar.BackColor = Color.FromArgb(15, 23, 42);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnSettings);
            pnlSidebar.Controls.Add(btnProfile);
            pnlSidebar.Controls.Add(btnContacts);
            pnlSidebar.Controls.Add(btnChats);
            pnlSidebar.Controls.Add(btnHome);
            pnlSidebar.Controls.Add(lblUserName);
            pnlSidebar.Controls.Add(lblAppName);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(245, 720);
            pnlSidebar.TabIndex = 0;

            // ------------------------------------------------------------
            // lblAppName
            // ------------------------------------------------------------
            lblAppName.AutoSize = false;
            lblAppName.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(20, 28);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(205, 38);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Ashkan Social";
            lblAppName.TextAlign = ContentAlignment.MiddleCenter;

            // ------------------------------------------------------------
            // lblUserName
            // ------------------------------------------------------------
            lblUserName.AutoSize = false;
            lblUserName.Font = new Font("Segoe UI", 9.5F);
            lblUserName.ForeColor = Color.FromArgb(191, 219, 254);
            lblUserName.Location = new Point(20, 76);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(205, 28);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "@username";
            lblUserName.TextAlign = ContentAlignment.MiddleCenter;

            // ------------------------------------------------------------
            // btnHome
            // ------------------------------------------------------------
            ConfigureNavigationButton(
                btnHome,
                "Home",
                135,
                Color.FromArgb(30, 64, 175));

            // ------------------------------------------------------------
            // btnChats
            // ------------------------------------------------------------
            ConfigureNavigationButton(
                btnChats,
                "Chats",
                185,
                Color.Transparent);

            // ------------------------------------------------------------
            // btnContacts
            // ------------------------------------------------------------
            ConfigureNavigationButton(
                btnContacts,
                "Contacts",
                235,
                Color.Transparent);

            // ------------------------------------------------------------
            // btnProfile
            // ------------------------------------------------------------
            ConfigureNavigationButton(
                btnProfile,
                "Profile",
                285,
                Color.Transparent);

            // ------------------------------------------------------------
            // btnSettings
            // ------------------------------------------------------------
            ConfigureNavigationButton(
                btnSettings,
                "Settings",
                335,
                Color.Transparent);

            // ------------------------------------------------------------
            // btnLogout
            // ------------------------------------------------------------
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogout.BackColor = Color.FromArgb(127, 29, 29);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(20, 658);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(205, 42);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;

            // ------------------------------------------------------------
            // pnlContent
            // ------------------------------------------------------------
            pnlContent.BackColor = Color.FromArgb(248, 250, 252);
            pnlContent.Controls.Add(lblComingSoon);
            pnlContent.Controls.Add(lblSectionTitle);
            pnlContent.Controls.Add(lblWelcomeDescription);
            pnlContent.Controls.Add(lblWelcome);
            pnlContent.Controls.Add(pnlTopBar);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Name = "pnlContent";
            pnlContent.TabIndex = 1;

            // ------------------------------------------------------------
            // pnlTopBar
            // ------------------------------------------------------------
            pnlTopBar.BackColor = Color.White;
            pnlTopBar.Controls.Add(cmbLanguage);
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(955, 70);
            pnlTopBar.TabIndex = 0;

            // ------------------------------------------------------------
            // cmbLanguage
            // ------------------------------------------------------------
            cmbLanguage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLanguage.FlatStyle = FlatStyle.Flat;
            cmbLanguage.Font = new Font("Segoe UI", 9F);
            cmbLanguage.FormattingEnabled = true;
            cmbLanguage.Items.AddRange(
                new object[]
                {
                    "English",
                    "فارسی"
                });
            cmbLanguage.Location = new Point(822, 21);
            cmbLanguage.Name = "cmbLanguage";
            cmbLanguage.Size = new Size(110, 28);
            cmbLanguage.TabIndex = 0;
            cmbLanguage.SelectedIndexChanged += cmbLanguage_SelectedIndexChanged;

            // ------------------------------------------------------------
            // lblWelcome
            // ------------------------------------------------------------
            lblWelcome.AutoSize = false;
            lblWelcome.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(15, 23, 42);
            lblWelcome.Location = new Point(55, 118);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(760, 48);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome back!";
            lblWelcome.TextAlign = ContentAlignment.MiddleLeft;

            // ------------------------------------------------------------
            // lblWelcomeDescription
            // ------------------------------------------------------------
            lblWelcomeDescription.AutoSize = false;
            lblWelcomeDescription.Font = new Font("Segoe UI", 10F);
            lblWelcomeDescription.ForeColor = Color.FromArgb(100, 116, 139);
            lblWelcomeDescription.Location = new Point(58, 168);
            lblWelcomeDescription.Name = "lblWelcomeDescription";
            lblWelcomeDescription.Size = new Size(760, 34);
            lblWelcomeDescription.TabIndex = 2;
            lblWelcomeDescription.Text =
                "Choose an option from the sidebar to get started.";
            lblWelcomeDescription.TextAlign = ContentAlignment.MiddleLeft;

            // ------------------------------------------------------------
            // lblSectionTitle
            // ------------------------------------------------------------
            lblSectionTitle.AutoSize = false;
            lblSectionTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblSectionTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblSectionTitle.Location = new Point(58, 250);
            lblSectionTitle.Name = "lblSectionTitle";
            lblSectionTitle.Size = new Size(650, 34);
            lblSectionTitle.TabIndex = 3;
            lblSectionTitle.Text = "Home";
            lblSectionTitle.TextAlign = ContentAlignment.MiddleLeft;

            // ------------------------------------------------------------
            // lblComingSoon
            // ------------------------------------------------------------
            lblComingSoon.AutoSize = false;
            lblComingSoon.BackColor = Color.White;
            lblComingSoon.Font = new Font("Segoe UI", 10F);
            lblComingSoon.ForeColor = Color.FromArgb(100, 116, 139);
            lblComingSoon.Location = new Point(58, 302);
            lblComingSoon.Name = "lblComingSoon";
            lblComingSoon.Padding = new Padding(22);
            lblComingSoon.Size = new Size(760, 120);
            lblComingSoon.TabIndex = 4;
            lblComingSoon.Text =
                "Social features will appear here soon.";
            lblComingSoon.TextAlign = ContentAlignment.MiddleCenter;

            // ------------------------------------------------------------
            // MainForm
            // ------------------------------------------------------------
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1200, 720);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(1000, 650);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ashkan Social";

            pnlSidebar.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            pnlTopBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        private static void ConfigureNavigationButton(
            Button button,
            string text,
            int top,
            Color backColor)
        {
            button.BackColor = backColor;
            button.Cursor = Cursors.Hand;
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button.ForeColor = Color.White;
            button.Location = new Point(20, top);
            button.Name = $"btn{text}";
            button.Size = new Size(205, 42);
            button.TabStop = false;
            button.Text = text;
            button.TextAlign = ContentAlignment.MiddleLeft;
            button.UseVisualStyleBackColor = false;
        }

        #endregion
    }
}
