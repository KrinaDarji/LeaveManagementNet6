using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace LeaveManagement.Web.Services
{
    public class EmailSender : IEmailSender
    {
        private string smtpserver;
        private int smtpport;
        private string fromemailaddress;

        public EmailSender(string smtpserver, int smtpport, string fromemailaddress)
        {
            this.smtpserver = smtpserver;
            this.smtpport = smtpport;
            this.fromemailaddress = fromemailaddress;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var message = new MailMessage
            {
                From = new MailAddress(fromemailaddress),
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true
            };
            message.To.Add(new MailAddress(email));
            using (var client = new SmtpClient(smtpserver, smtpport))
            {
                client.Send(message);
            }
            return Task.CompletedTask;
        }
    }
}
