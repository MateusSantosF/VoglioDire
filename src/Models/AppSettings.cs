using System;

namespace VoglioDire.Api.src.Models
{
    public class AppSettings
    {
        public string SenderEmailAddress { get; set; }

        public string SenderEmailPassword { get; set; }

        public string SmtpHost { get; set; }

        public int SmtpPort { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
