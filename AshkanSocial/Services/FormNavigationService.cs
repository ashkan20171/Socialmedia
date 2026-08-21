using Microsoft.Extensions.DependencyInjection;

namespace AshkanSocial.Services;

public sealed class FormNavigationService
{
    private readonly IServiceProvider _serviceProvider;

    public FormNavigationService(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public void ShowLogin(Form currentForm)
    {
        var loginForm = ActivatorUtilities.CreateInstance<
            AshkanSocial.Forms.Auth.LoginForm>(_serviceProvider);

        ShowForm(currentForm, loginForm);
    }

    public void ShowRegister(Form currentForm)
    {
        var registerForm = ActivatorUtilities.CreateInstance<
            AshkanSocial.Forms.Auth.RegisterForm>(_serviceProvider);

        ShowForm(currentForm, registerForm);
    }
    public void ShowMain(Form currentForm)
    {
        var mainForm = ActivatorUtilities.CreateInstance<
            AshkanSocial.MainForm>(_serviceProvider);

        currentForm.Hide();

        mainForm.FormClosed += (_, _) =>
        {
            if (!currentForm.IsDisposed)
            {
                currentForm.Close();
            }
        };

        mainForm.Show();
    }

    private static void ShowForm(Form currentForm, Form nextForm)
    {
        currentForm.Hide();

        nextForm.FormClosed += (_, _) =>
        {
            if (!currentForm.IsDisposed)
            {
                currentForm.Show();
            }
        };

        nextForm.Show();
    }
}
