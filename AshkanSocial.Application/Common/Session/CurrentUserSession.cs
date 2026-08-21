namespace AshkanSocial.Application.Common.Session;

public sealed class CurrentUserSession
{
    public Guid? UserId { get; private set; }

    public string? Username { get; private set; }

    public string? DisplayName { get; private set; }

    public bool IsAuthenticated => UserId.HasValue;

    public void Start(Guid userId, string username, string displayName)
    {
        UserId = userId;
        Username = username;
        DisplayName = displayName;
    }

    public void Clear()
    {
        UserId = null;
        Username = null;
        DisplayName = null;
    }
}
