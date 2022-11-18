using System.Threading.Tasks;
using VoglioDire.Api.src.Models;
using VoglioDire.Api.src.Models.Enums;

namespace VoglioDire.Api.src.Factory.Interfaces
{
    public interface IMailFactory
    {
        public  Task<Mail> GetEmail(MailType type);
    }
}
