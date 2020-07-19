using Microsoft.AspNetCore.Mvc;
using MyPension.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyPension.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PortfolioController : ControllerBase
    {
        [HttpGet]
        public Task<IActionResult> GetNpsPortfolio()
        {
            throw new NotImplementedException();
        }

        [HttpPost("{porfolioId}/holdings")]
        public Task<IActionResult> DeclareHoldings([FromRoute] string portfolioId, [FromBody] IList<HoldingModel> holdings)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{porfolioId}/simulation")]
        public Task<IActionResult> GetSimulation([FromRoute] string portfolioId)
        {
            throw new NotImplementedException();
        }
    }
}
