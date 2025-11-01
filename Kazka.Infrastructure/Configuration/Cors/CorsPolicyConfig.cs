namespace Infrastructure.Configuration.Cors
{
    public class CorsPolicyConfig
    {
        public string Name { get; set; } = string.Empty;
        public string[] Origins { get; set; } = [];
        public string[] Methods { get; set; } = [];
        public string[] Headers { get; set; } = [];
        public bool AllowCredentials { get; set; } = false;
    }

}
