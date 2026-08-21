using AshkanSocial.Application.Common.Session;
using AshkanSocial.Localization;

namespace AshkanSocial;

public partial class MainForm : Form
{
    private readonly CurrentUserSession _currentUserSession;
    private bool _isLoadingLanguage;

    public MainForm(CurrentUserSession currentUserSession)
    {
        InitializeComponent();

        _currentUserSession = currentUserSession;

        if (!_currentUserSession.IsAuthenticated)
        {
            MessageBox.Show(
                "Please sign in first.",
                "Authentication Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            Close();
            return;
        }

        LoadLanguage();
        ApplyLanguage();
    }

    private void LoadLanguage()
    {
        _isLoadingLanguage = true;

        cmbLanguage.SelectedIndex =
            LanguageService.CurrentLanguage == AppLanguage.Persian
                ? 1
                : 0;

        _isLoadingLanguage = false;
    }

    private void cmbLanguage_SelectedIndexChanged(
        object? sender,
        EventArgs e)
    {
        if (_isLoadingLanguage)
        {
            return;
        }

        AppLanguage selectedLanguage = cmbLanguage.SelectedIndex == 1
            ? AppLanguage.Persian
            : AppLanguage.English;

        LanguageService.SetLanguage(selectedLanguage);

        ApplyLanguage();
    }

    private void ApplyLanguage()
    {
        bool isPersian =
            LanguageService.CurrentLanguage == AppLanguage.Persian;

        RightToLeft = isPersian
            ? RightToLeft.Yes
            : RightToLeft.No;

        RightToLeftLayout = isPersian;

        Text = isPersian
            ? "اشکان سوشال"
            : "Ashkan Social";

        lblAppName.Text = "Ashkan Social";

        lblWelcome.Text = isPersian
            ? $"خوش آمدی، {_currentUserSession.DisplayName}!"
            : $"Welcome back, {_currentUserSession.DisplayName}!";

        lblWelcomeDescription.Text = isPersian
            ? "برای شروع، یک بخش را از منوی کناری انتخاب کنید."
            : "Choose an option from the sidebar to get started.";

        btnHome.Text = isPersian ? "خانه" : "Home";
        btnChats.Text = isPersian ? "گفت‌وگوها" : "Chats";
        btnContacts.Text = isPersian ? "مخاطبین" : "Contacts";
        btnProfile.Text = isPersian ? "پروفایل" : "Profile";
        btnSettings.Text = isPersian ? "تنظیمات" : "Settings";
        btnLogout.Text = isPersian ? "خروج از حساب" : "Log Out";

        lblSectionTitle.Text = isPersian ? "خانه" : "Home";

        lblComingSoon.Text = isPersian
            ? "قابلیت‌های شبکهٔ اجتماعی به‌زودی در این بخش قرار می‌گیرند."
            : "Social features will appear here soon.";
    }

    private void btnLogout_Click(object sender, EventArgs e)
    {
        bool isPersian =
            LanguageService.CurrentLanguage == AppLanguage.Persian;

        DialogResult confirmation = MessageBox.Show(
            isPersian
                ? "آیا مطمئن هستید که می‌خواهید خارج شوید؟"
                : "Are you sure you want to log out?",
            isPersian
                ? "خروج از حساب"
                : "Log Out",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (confirmation != DialogResult.Yes)
        {
            return;
        }

        _currentUserSession.Clear();

        Close();
    }
}
