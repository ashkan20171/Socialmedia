using System.Globalization;
using System.Text.Json;

namespace AshkanSocial.Localization;

public static class LanguageService
{
    private const string SettingsFileName = "language-settings.json";

    public static AppLanguage CurrentLanguage { get; private set; }
        = AppLanguage.English;

    public static void Initialize()
    {
        AppLanguage savedLanguage = LoadLanguage();

        SetLanguage(savedLanguage, saveLanguage: false);
    }

    public static void SetLanguage(
        AppLanguage language,
        bool saveLanguage = true)
    {
        CurrentLanguage = language;

        string cultureName = language == AppLanguage.Persian
            ? "fa-IR"
            : "en-US";

        CultureInfo culture = new(cultureName);

        CultureInfo.DefaultThreadCurrentCulture = culture;
        CultureInfo.DefaultThreadCurrentUICulture = culture;

        Thread.CurrentThread.CurrentCulture = culture;
        Thread.CurrentThread.CurrentUICulture = culture;

        if (saveLanguage)
        {
            SaveLanguage(language);
        }
    }

    private static AppLanguage LoadLanguage()
    {
        try
        {
            string settingsPath = GetSettingsPath();

            if (!File.Exists(settingsPath))
            {
                return AppLanguage.English;
            }

            string json = File.ReadAllText(settingsPath);

            LanguageSettings? settings =
                JsonSerializer.Deserialize<LanguageSettings>(json);

            return settings?.Language ?? AppLanguage.English;
        }
        catch
        {
            // اگر فایل تنظیمات خراب یا غیرقابل‌خواندن باشد،
            // برنامه با زبان انگلیسی اجرا می‌شود.
            return AppLanguage.English;
        }
    }

    private static void SaveLanguage(AppLanguage language)
    {
        try
        {
            string settingsPath = GetSettingsPath();

            LanguageSettings settings = new()
            {
                Language = language
            };

            string json = JsonSerializer.Serialize(
                settings,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            File.WriteAllText(settingsPath, json);
        }
        catch
        {
            // ذخیره‌نشدن زبان نباید باعث توقف برنامه شود.
        }
    }

    private static string GetSettingsPath()
    {
        string folderPath = Path.Combine(
            Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData),
            "AshkanSocial");

        Directory.CreateDirectory(folderPath);

        return Path.Combine(folderPath, SettingsFileName);
    }

    private sealed class LanguageSettings
    {
        public AppLanguage Language { get; set; }
    }
}
