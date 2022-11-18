using MimeKit;
using System.Threading.Tasks;

namespace VoglioDire.Api.src.Services.Interfaces
{
    public interface IEmailService
    {
        Task<string> SendMail(MimeMessage mimeMessage);
    }
}
