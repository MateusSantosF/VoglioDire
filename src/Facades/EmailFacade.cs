using Microsoft.Extensions.Options;
using MimeKit;
using MimeKit.Text;
using System.Threading.Tasks;
using VoglioDire.Api.src.Facades.Interfaces;
using VoglioDire.Api.src.Factory.Interfaces;
using VoglioDire.Api.src.Models;
using VoglioDire.Api.src.Models.Enums;
using VoglioDire.Api.src.Services.Interfaces;

namespace VoglioDire.Api.src.Facades
{
    public class EmailFacade : IEmailFacade
    {

        private readonly IEmailService _emailService;
        private readonly IMailFactory _mailFactory;
        private readonly AppSettings _settings;

        public EmailFacade(IEmailService emailService, IMailFactory mailFactory, IOptions<AppSettings> appSettings)
        {
            _settings = appSettings.Value;
            _emailService = emailService;
            _mailFactory = mailFactory;
        }

        public async Task<string> SendMail(string recipient, MailType type)
        {

            Mail mailModel = await _mailFactory.GetEmail(type);

            var mimeMessage = new MimeMessage();

            mimeMessage.From.Add(MailboxAddress.Parse(_settings.SenderEmailAddress));
            mimeMessage.To.Add(MailboxAddress.Parse(recipient));
            mimeMessage.Subject = mailModel.Subject;
            mimeMessage.Body = new TextPart(TextFormat.Html)
            {
                Text = mailModel.Content
            };

            return await _emailService.SendMail(mimeMessage);
        }
    }
}
