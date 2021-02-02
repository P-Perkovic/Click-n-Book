using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Click_and_Book.Email
{
    public class SendGidEmailSender : IEmailSender
    {
        private readonly IConfiguration _configuration;

        public SendGidEmailSender(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<SendEmailResponse> SendEmailAsync(SendEmailDetails details)
        {
            var apiKey = _configuration["SendGridKey"];

            var client = new SendGridClient(apiKey);

            var from = new EmailAddress(details.FromEmail, details.FromName);

            var to = new EmailAddress(details.ToEmail, details.ToName);

            var subject = details.Subject;

            var content = details.Content;
            
            var msg = MailHelper.CreateSingleEmail(
                from, 
                to, 
                subject, 
                details.IsHTML ? null : content, 
                details.IsHTML ? content : null);
            
            var response = await client.SendEmailAsync(msg);

            return new SendEmailResponse();
        }
    }
}
