using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using System;
using System.Threading.Tasks;
using VoglioDire.Api.src.Models;
using VoglioDire.Api.src.Services.Interfaces;

namespace VoglioDire.Api.src.Services
{
    public class EmailService : IEmailService
    {

        private readonly AppSettings _settings;
        public EmailService(IOptions<AppSettings> appSettings)
        {
            _settings = appSettings.Value;
        }

        public async Task<string> SendMail(MimeMessage mimeMessage)
        {
            try
            {
                using var smtp = new SmtpClient();
                smtp.Connect(_settings.SmtpHost, _settings.SmtpPort, SecureSocketOptions.StartTls);
                smtp.Authenticate(_settings.SenderEmailAddress, _settings.SenderEmailPassword);

                var result = await smtp.SendAsync(mimeMessage);
                smtp.Disconnect(true);

                return result;
            }
            catch( Exception ex)
            {
                return ex.ToString();
            }
      
        }
    }
}
