using System.Threading.Tasks;
using VoglioDire.Api.src.Models.Enums;

namespace VoglioDire.Api.src.Facades.Interfaces
{
    public interface IEmailFacade
    {
        Task<string> SendMail(string recipient, MailType type);
    }
}
