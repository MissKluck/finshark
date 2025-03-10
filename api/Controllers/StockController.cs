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
    public class StockController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public StockController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        /*public async Task<IActionResult> Get()
        {
            var article = await _context.ArticleModel.ToListAsync();
            return Ok(article);
        }*/
        public async Task<IActionResult> GetAll()
        {
            var stocks = _context.Stocks.ToListAsync();
            
            return Ok(stocks);
        }

       /* [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var stock = context.Stocks.Find(id);

            if (stock == null)
            {
                return NotFound();
            }
            
            return Ok(stock);
        }*/
    }
}