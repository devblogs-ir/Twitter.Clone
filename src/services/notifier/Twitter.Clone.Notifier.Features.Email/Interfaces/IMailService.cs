using Twitter.Clone.Notifier.Features.Email.Data;

namespace Twitter.Clone.Notifier.Features.Email.Interfaces
{
    public interface IMailService
    {
        bool SendEmail(MailData mailData);
    }
}
