using EmailsenderDemo.Models;

namespace EmailsenderDemo
{
    public interface IEmailSendService
    {
        Task EmailSendServiec(MailRequest mail);
    }
}
