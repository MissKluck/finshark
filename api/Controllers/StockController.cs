using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using Microsoft.EntityFrameworkCore;
using api.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/stock")]
    [ApiController]
    public class StockController(ApplicationDbContext context) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var stocks = context.Stocks.ToList();
            return Ok(stocks);
        }
    }
}