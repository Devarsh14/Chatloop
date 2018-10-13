// using SendGrid's C# Library
// https://github.com/sendgrid/sendgrid-csharp
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Threading.Tasks;

namespace Chatloop.Services
{


    public interface ISendGrid
    {
        Task Execute();
    }

    public class SmsSendGrid:ISendGrid
    {        


        public async Task Execute()
        {
            var apiKey = "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";
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("Devarsh14@gmail.com", "Devarsh");
            var subject = "Sending with SendGrid is Fun";
            var to = new EmailAddress("devarsh.shukla@icloud.com", "Arya Shukla");
            var plainTextContent = "and easy to do anywhere, even with C#";
            var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
    }
}