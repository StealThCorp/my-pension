﻿using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> GetNpsPortfolio()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<IActionResult> DeclareHoldings(IList<HoldingModel> holdings)
        {
            throw new NotImplementedException();
        }
    }
}
