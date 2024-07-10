using Microsoft.AspNetCore.Identity.UI.Services;

namespace WebUygulamaProje1.Utility
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            //email gönderme işlemlerinizi yapabiliriz.
            return Task.CompletedTask;
        }
    }
}
