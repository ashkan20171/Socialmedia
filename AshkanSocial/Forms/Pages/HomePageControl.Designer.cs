namespace AshkanSocial.Forms.Pages
{
    partial class HomePageControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Label lblPageTitle;
        private Label lblWelcome;
        private Label lblDescription;
        private Panel pnlComingSoon;
        private Label lblComingSoon;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">
        /// true to release managed resources; otherwise, false.
        /// </param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            lblPageTitle = new Label();
            lblWelcome = new Label();
            lblDescription = new Label();
            pnlComingSoon = new Panel();
            lblComingSoon = new Label();

            pnlComingSoon.SuspendLayout();
            SuspendLayout();

            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font(
                "Segoe UI Semibold",
                18F,
                FontStyle.Bold,
                GraphicsUnit.Point);

            lblPageTitle.ForeColor = Color.FromArgb(23, 32, 51);
            lblPageTitle.Location = new Point(0, 0);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(74, 32);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Home";

            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font(
                "Segoe UI Semibold",
                24F,
                FontStyle.Bold,
                GraphicsUnit.Point);

            lblWelcome.ForeColor = Color.FromArgb(23, 32, 51);
            lblWelcome.Location = new Point(0, 52);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(214, 45);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome back!";

            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font(
                "Segoe UI",
                11F,
                FontStyle.Regular,
                GraphicsUnit.Point);

            lblDescription.ForeColor = Color.FromArgb(102, 112, 133);
            lblDescription.Location = new Point(0, 108);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(328, 20);
            lblDescription.TabIndex = 2;
            lblDescription.Text =
                "Choose an option from the sidebar to get started.";

            // 
            // pnlComingSoon
            // 
            pnlComingSoon.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            pnlComingSoon.BackColor = Color.White;
            pnlComingSoon.BorderStyle = BorderStyle.FixedSingle;
            pnlComingSoon.Controls.Add(lblComingSoon);
            pnlComingSoon.Location = new Point(0, 156);
            pnlComingSoon.Name = "pnlComingSoon";
            pnlComingSoon.Size = new Size(760, 150);
            pnlComingSoon.TabIndex = 3;

            // 
            // lblComingSoon
            // 
            lblComingSoon.Dock = DockStyle.Fill;
            lblComingSoon.Font = new Font(
                "Segoe UI",
                11F,
                FontStyle.Regular,
                GraphicsUnit.Point);

            lblComingSoon.ForeColor = Color.FromArgb(102, 112, 133);
            lblComingSoon.Location = new Point(0, 0);
            lblComingSoon.Name = "lblComingSoon";
            lblComingSoon.Size = new Size(758, 148);
            lblComingSoon.TabIndex = 0;
            lblComingSoon.Text =
                "Your posts, notifications, and recommendations will appear here soon.";

            lblComingSoon.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // HomePageControl
            // 
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(248, 249, 251);
            Controls.Add(pnlComingSoon);
            Controls.Add(lblDescription);
            Controls.Add(lblWelcome);
            Controls.Add(lblPageTitle);
            Name = "HomePageControl";
            Padding = new Padding(64, 48, 64, 48);
            Size = new Size(900, 600);

            pnlComingSoon.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
