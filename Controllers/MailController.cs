using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using VoglioDire.Api.src.Facades.Interfaces;
using VoglioDire.Api.src.Models.Enums;

namespace VoglioDire.Api2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MailController : ControllerBase
    {

        private readonly IEmailFacade _mailFacade;
        public MailController(IEmailFacade emailFacade)
        {
            _mailFacade = emailFacade;
        }

        [HttpGet("send-mail")]
        public async Task<ActionResult> SendMail(string recipient, MailType type)
        {
            return Ok(await _mailFacade.SendMail(recipient, type));
        }
    }
}
