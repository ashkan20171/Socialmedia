using AshkanSocial.Application.Common.Session;
using AshkanSocial.Localization;

namespace AshkanSocial.Forms.Pages;

public partial class HomePageControl : UserControl
{
    private readonly CurrentUserSession _currentUserSession;

    public HomePageControl(CurrentUserSession currentUserSession)
    {
        InitializeComponent();

        _currentUserSession = currentUserSession;

        Dock = DockStyle.Fill;

        ApplyLanguage();
    }

    public void ApplyLanguage()
    {
        bool isPersian =
            LanguageService.CurrentLanguage == AppLanguage.Persian;

        RightToLeft = isPersian
            ? RightToLeft.Yes
            : RightToLeft.No;

        lblPageTitle.Text = isPersian ? "خانه" : "Home";

        lblWelcome.Text = isPersian
            ? $"خوش آمدی، {_currentUserSession.DisplayName}!"
            : $"Welcome back, {_currentUserSession.DisplayName}!";

        lblDescription.Text = isPersian
            ? "از منوی کناری یک بخش را انتخاب کنید."
            : "Choose an option from the sidebar to get started.";

        lblComingSoon.Text = isPersian
            ? "پست‌ها، اعلان‌ها و پیشنهادهای شما به‌زودی اینجا نمایش داده می‌شوند."
            : "Your posts, notifications, and recommendations will appear here soon.";
    }
}
