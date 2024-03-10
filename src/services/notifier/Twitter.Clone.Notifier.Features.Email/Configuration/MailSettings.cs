namespace Twitter.Clone.Notifier.Features.Email.Configuration
{
    public class MailSettings
    {
        public string Server { get; set; } = string.Empty;
        public short port { get; set; }
        public string SenderName { get; set; } = string.Empty;
        public string SenderEmail { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
