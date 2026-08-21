using AshkanSocial.Application.Abstractions;
using AshkanSocial.Application.Common.Session;
using AshkanSocial.Application.Features.Auth.Login;
using AshkanSocial.Services;

namespace AshkanSocial.Forms.Auth;

public partial class LoginForm : Form
{
    private readonly IUserService _userService;
    private readonly CurrentUserSession _currentUserSession;
    private readonly FormNavigationService _navigationService;

    public LoginForm(
        IUserService userService,
        CurrentUserSession currentUserSession,
        FormNavigationService navigationService)
    {
        InitializeComponent();

        _userService = userService;
        _currentUserSession = currentUserSession;
        _navigationService = navigationService;

        cmbLanguage.SelectedIndex = 0;
    }

    private void btnGoToRegister_Click(object sender, EventArgs e)
    {
        _navigationService.ShowRegister(this);
    }

    private async void btnLogin_Click(object sender, EventArgs e)
    {
        SetLoadingState(true);

        try
        {
            var request = new LoginRequest
            {
                UsernameOrEmail = txtUsernameOrEmail.Text,
                Password = txtPassword.Text
            };

            var result = await _userService.LoginAsync(request);

            if (!result.IsSuccess)
            {
                lblStatus.ForeColor = Color.FromArgb(220, 38, 38);
                lblStatus.Text = result.Message;
                return;
            }

            if (result.UserId is null ||
                string.IsNullOrWhiteSpace(result.Username) ||
                string.IsNullOrWhiteSpace(result.DisplayName))
            {
                lblStatus.ForeColor = Color.FromArgb(220, 38, 38);
                lblStatus.Text = "Unable to start the user session.";
                return;
            }

            _currentUserSession.Start(
                result.UserId.Value,
                result.Username,
                result.DisplayName);

            lblStatus.ForeColor = Color.FromArgb(22, 163, 74);
            lblStatus.Text = "Login successful.";

            _navigationService.ShowMain(this);


            // در گام بعدی MainForm را اینجا باز می‌کنیم.
        }
        catch
        {
            lblStatus.ForeColor = Color.FromArgb(220, 38, 38);
            lblStatus.Text = "An unexpected error occurred. Please try again.";
        }
        finally
        {
            SetLoadingState(false);
        }
    }

    private void SetLoadingState(bool isLoading)
    {
        btnLogin.Enabled = !isLoading;
        txtUsernameOrEmail.Enabled = !isLoading;
        txtPassword.Enabled = !isLoading;
        cmbLanguage.Enabled = !isLoading;
        btnGoToRegister.Enabled = !isLoading;

        btnLogin.Text = isLoading
            ? "Signing in..."
            : "Sign In";
    }

    private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
    {
        bool isPersian = cmbLanguage.SelectedIndex == 1;

        RightToLeft = isPersian
            ? RightToLeft.Yes
            : RightToLeft.No;

        RightToLeftLayout = isPersian;

        // Username/email و password بهتر است لاتین و LTR باقی بمانند.
        txtUsernameOrEmail.RightToLeft = RightToLeft.No;
        txtUsernameOrEmail.TextAlign = HorizontalAlignment.Left;

        txtPassword.RightToLeft = RightToLeft.No;
        txtPassword.TextAlign = HorizontalAlignment.Left;

        if (isPersian)
        {
            Text = "ورود - اشکان سوشال";
            lblLanguage.Text = "زبان:";
            lblTitle.Text = "به اشکان سوشال خوش آمدید";
            lblSubtitle.Text = "برای ادامه وارد حساب کاربری خود شوید.";
            lblUsernameOrEmail.Text = "نام کاربری یا ایمیل";
            lblPassword.Text = "رمز عبور";
            btnLogin.Text = "ورود";
            btnGoToRegister.Text = "حساب کاربری ندارید؟ ثبت‌نام کنید";
        }
        else
        {
            Text = "Sign In - Ashkan Social";
            lblLanguage.Text = "Language:";
            lblTitle.Text = "Welcome back";
            lblSubtitle.Text = "Sign in to continue to Ashkan Social.";
            lblUsernameOrEmail.Text = "Username or Email";
            lblPassword.Text = "Password";
            btnLogin.Text = "Sign In";
            btnGoToRegister.Text = "Don't have an account? Create one";
        }

        lblStatus.Text = string.Empty;
    }
}
