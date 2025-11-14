using BPMPlaylist.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BPMPlaylist.Presentation.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthenticatorController : ControllerBase
    {
        private readonly IAuthenticatorService _authService;

        public AuthenticatorController(IAuthenticatorService authService)
        {
            _authService = authService;
        }

        [HttpGet]
        [Route("auth")]
        public IActionResult Auth()
        {
            var url = _authService.Authenticate();

            return Ok(url);
        }

        [HttpGet]
        [Route("callback")]
        public void Callback()
        {
            _authService.Callback(null);
        }
    }
}
