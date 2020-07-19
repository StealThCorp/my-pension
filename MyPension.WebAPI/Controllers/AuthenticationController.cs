using Microsoft.AspNetCore.Mvc;
using MyPension.WebAPI.Models;
using System;
using System.Threading.Tasks;

namespace MyPension.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        [HttpPost]
        public Task<IActionResult> PostIdentifier([FromBody] CustomerIdentifier identifier)
        {
            throw new NotImplementedException();
        }

        [HttpPost("otp")]
        public Task<IActionResult> PostOneTimePassword([FromBody] OtpModel otp)
        {
            throw new NotImplementedException();
        }
    }
}
