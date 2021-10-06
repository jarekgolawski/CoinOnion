using CoinOnion.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoinOnion.Controllers
{
    [ApiController]
    [Route("api/cryptocurrency")]
    public class CryptocurrencyController : ControllerBase
    {
        private readonly CryptocurrencyDbContext _dbContext;
        public CryptocurrencyController(CryptocurrencyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public ActionResult<IEnumerable<Cryptocurrency>> GetAll()
        {
            var cryptocurrencies = _dbContext
                .Cryptocurrencies
                .ToList();

            return Ok(cryptocurrencies);
        }

        [HttpGet("{id}")]
        public ActionResult<Cryptocurrency> Get([FromRoute] int )
        {

        }
    }
}
