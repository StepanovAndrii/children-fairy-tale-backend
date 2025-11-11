namespace Kazka.Infrastructure.Configuration
{
    public class GoogleOAuthOptions
    {
        public string ClientId { get; set; } = string.Empty;
        public string ClientSecret { get; set; } = string.Empty;
        public string CallbackPath { get; set; } = string.Empty;
    }
}
