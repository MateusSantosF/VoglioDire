using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using VoglioDire.Api.src.Factory.Interfaces;
using VoglioDire.Api.src.Models;
using VoglioDire.Api.src.Models.Enums;

namespace VoglioDire.Api.src.Factory
{
    public class MailFactory : IMailFactory
    {
        private readonly string TEMPLATES_PATH;
        private readonly string MESSAGE_PATH;
        private readonly int NUMBER_ONE = 1;
        private readonly int NUMBER_FIVE = 5;
        private readonly AppSettings _settings;

        public MailFactory(IOptions<AppSettings> settings)
        {
            _settings = settings.Value;
            MESSAGE_PATH = Path.Combine(AppContext.BaseDirectory, Constants.MESSAGES_PATH);
            TEMPLATES_PATH = Path.Combine(AppContext.BaseDirectory, Constants.TEMPLATES_PATH);
        }

        public async Task<Mail> GetEmail(MailType type)
        {
            switch (type)
            {
                case MailType.THOUGHTS:
                    return CreateMail(await GetMailContent(type), GetMailSubject(type), type);
                default:
                    return null;
            }
        }


        private async Task<string> GetMailContent(MailType type)
        {
            var template = await GetMailTemplate(type);
            template = template.Replace(Constants.CONTENT_TOKEN, GetTodayMessage());
            template = template.Replace(Constants.DAY_TOKEN, GetMessageKey());
            template = template.Replace(Constants.COLOR_TOKEN, GetRandomColor());

            return template;
        }


        private async Task<string> GetMailTemplate(MailType type)
        {
            return await File.ReadAllTextAsync(
                Path.Combine(TEMPLATES_PATH, type.ToString().ToLower() + Constants.HTML_EXTENSION));
        }


        private string GetRandomColor()
        {
            int index = new Random().Next(NUMBER_ONE, NUMBER_FIVE);
            Dictionary<int, string> colors = new Dictionary<int, string>(){
                {1, "#8FBBAF"},
                {2, "#ACDEAA"},
                {3, "#F67280"},
                {4, "#96B3C2"},
                {5, "#FFCCB6"},
            };
            return colors[index];
        }
        private string GetTodayMessage()
        {
            string key = GetMessageKey();
            using (StreamReader reader = new StreamReader(MESSAGE_PATH))
            {
                var messagesJson = reader.ReadToEnd();
                var messages = JsonConvert.DeserializeObject<Dictionary<string, string>>(messagesJson);

                if (messages.ContainsKey(key))
                {
                    return messages[key];
                }

                return Constants.ERROR_MESSAGE;
            }
        }
        private string GetMessageKey()
        {
            return ((_settings.StartDate.Subtract(DateTime.Now).Days * -NUMBER_ONE) + NUMBER_ONE).ToString();
        }

        private Mail CreateMail(string content, string subject, MailType type)
        {
            return new Mail() { Content = content, Subject = subject, Type = type};
        }

        private string GetMailSubject(MailType type)
        {
            switch (type)
            {
                case MailType.THOUGHTS:
                    return Constants.MAIL_THOUGHTS_SUBJECT;
                default:
                    return Constants.MAIL_THOUGHTS_SUBJECT;
            }
        }
    }
}
