using VoglioDire.Api.src.Models.Enums;

namespace VoglioDire.Api.src.Models
{
    public class Mail
    {
        public MailType Type { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
    }
}
