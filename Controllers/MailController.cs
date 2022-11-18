using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using VoglioDire.Api.src.Facades.Interfaces;
using VoglioDire.Api.src.Models.Enums;

namespace VoglioDire.Api2.Controllers
{
    [ApiController]
    [Route("api")]
    public class MailController : ControllerBase
    {

        private readonly IEmailFacade _mailFacade;
        /// <summary>
        /// MailController constructor
        /// </summary>
        public MailController(IEmailFacade emailFacade)
        {
            _mailFacade = emailFacade;
        }

        /// <summary>
        /// Send an email to the entered email address based on your type
        /// </summary>
        /// <param name="recipient">Destination e-mail address</param>
        /// <param name="type">Type of mail</param>
        [HttpGet("send-mail")]
        public async Task<ActionResult> SendMail(string recipient, MailType type)
        {
            return Ok(await _mailFacade.SendMail(recipient, type));
        }
    }
}
