using AshkanSocial.Application.Abstractions;
using AshkanSocial.Application.DTOs;
using AshkanSocial.Localization;
using AshkanSocial.Services;

namespace AshkanSocial.Forms.Auth;

public partial class RegisterForm : Form
{
    private readonly IUserService _userService;
    private readonly FormNavigationService _navigationService;
    private bool _isLoadingLanguage;

    public RegisterForm(
        IUserService userService,
        FormNavigationService navigationService)
    {
        InitializeComponent();

        _userService = userService;
        _navigationService = navigationService;

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
            ? "ایجاد حساب - اشکان سوشال"
            : "Create Account - Ashkan Social";

        lblLanguage.Text = isPersian
            ? "زبان:"
            : "Language:";

        lblTitle.Text = isPersian
            ? "به اشکان سوشال خوش آمدید"
            : "Welcome to Ashkan Social";

        lblSubtitle.Text = isPersian
            ? "حساب کاربری خود را بسازید و ارتباط را شروع کنید."
            : "Create your account and start connecting.";

        lblUsername.Text = isPersian
            ? "نام کاربری"
            : "Username";

        lblDisplayName.Text = isPersian
            ? "نام نمایشی"
            : "Display Name";

        lblEmail.Text = isPersian
            ? "ایمیل (اختیاری)"
            : "Email (Optional)";

        lblPhoneNumber.Text = isPersian
            ? "شماره تلفن (اختیاری)"
            : "Phone Number (Optional)";

        lblPassword.Text = isPersian
            ? "رمز عبور"
            : "Password";

        lblConfirmPassword.Text = isPersian
            ? "تکرار رمز عبور"
            : "Confirm Password";

        btnRegister.Text = isPersian
            ? "ایجاد حساب کاربری"
            : "Create Account";

        btnGoToLogin.Text = isPersian
            ? "حساب دارید؟ وارد شوید"
            : "Already have an account? Sign in";

        // Username، email، phone و password معمولاً شناسه/دادهٔ لاتین هستند.
        txtUsername.RightToLeft = RightToLeft.No;
        txtUsername.TextAlign = HorizontalAlignment.Left;

        txtEmail.RightToLeft = RightToLeft.No;
        txtEmail.TextAlign = HorizontalAlignment.Left;

        txtPhoneNumber.RightToLeft = RightToLeft.No;
        txtPhoneNumber.TextAlign = HorizontalAlignment.Left;

        txtPassword.RightToLeft = RightToLeft.No;
        txtPassword.TextAlign = HorizontalAlignment.Left;

        txtConfirmPassword.RightToLeft = RightToLeft.No;
        txtConfirmPassword.TextAlign = HorizontalAlignment.Left;

        // Display name می‌تواند فارسی باشد.
        txtDisplayName.RightToLeft = isPersian
            ? RightToLeft.Yes
            : RightToLeft.No;

        txtDisplayName.TextAlign = isPersian
            ? HorizontalAlignment.Right
            : HorizontalAlignment.Left;
    }

    private async void btnRegister_Click(object sender, EventArgs e)
    {
        await RegisterUserAsync();
    }

    private void btnGoToLogin_Click(object sender, EventArgs e)
    {
        _navigationService.ShowLogin(this);
    }

    private async Task RegisterUserAsync()
    {
        ToggleControls(isEnabled: false);
        ShowStatus(string.Empty, isError: false);

        try
        {
            RegisterUserRequest request = new()
            {
                Username = txtUsername.Text.Trim(),
                DisplayName = txtDisplayName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                PhoneNumber = txtPhoneNumber.Text.Trim(),
                Password = txtPassword.Text,
                ConfirmPassword = txtConfirmPassword.Text
            };

            var result = await _userService.RegisterAsync(request);

            if (!result.IsSuccess)
            {
                ShowStatus(result.Message, isError: true);
                return;
            }

            bool isPersian =
                LanguageService.CurrentLanguage == AppLanguage.Persian;

            string successMessage = isPersian
                ? "حساب کاربری شما با موفقیت ساخته شد."
                : "Your account has been created successfully.";

            string successTitle = isPersian
                ? "ثبت‌نام موفق"
                : "Registration Successful";

            ShowStatus(successMessage, isError: false);

            MessageBox.Show(
                successMessage,
                successTitle,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ClearInputs();
        }
        catch
        {
            bool isPersian =
                LanguageService.CurrentLanguage == AppLanguage.Persian;

            ShowStatus(
                isPersian
                    ? "خطایی غیرمنتظره رخ داد. لطفاً دوباره تلاش کنید."
                    : "An unexpected error occurred. Please try again.",
                isError: true);
        }
        finally
        {
            ToggleControls(isEnabled: true);
        }
    }

    private void ToggleControls(bool isEnabled)
    {
        btnRegister.Enabled = isEnabled;
        btnGoToLogin.Enabled = isEnabled;
        cmbLanguage.Enabled = isEnabled;

        txtUsername.Enabled = isEnabled;
        txtDisplayName.Enabled = isEnabled;
        txtEmail.Enabled = isEnabled;
        txtPhoneNumber.Enabled = isEnabled;
        txtPassword.Enabled = isEnabled;
        txtConfirmPassword.Enabled = isEnabled;
    }

    private void ShowStatus(string message, bool isError)
    {
        lblStatus.Text = message;

        lblStatus.ForeColor = isError
            ? Color.FromArgb(220, 38, 38)
            : Color.FromArgb(22, 163, 74);
    }

    private void ClearInputs()
    {
        txtUsername.Clear();
        txtDisplayName.Clear();
        txtEmail.Clear();
        txtPhoneNumber.Clear();
        txtPassword.Clear();
        txtConfirmPassword.Clear();

        txtUsername.Focus();
    }
}
