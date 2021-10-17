using AutoMapper;
using CoinOnion.Entities;
using CoinOnion.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private readonly IMapper mapper;

        public CryptocurrencyController(CryptocurrencyDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            this.mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CryptocurrencyDto>> GetAll()
        {
            var cryptocurrencies = _dbContext
                .Cryptocurrencies
                .Include(c => c.Comments)
                .Include(c => c.Info)
                .ToList();

            var cryptocurrenciesDtos = mapper.Map<List<CryptocurrencyDto>>(cryptocurrencies);
            return Ok(cryptocurrenciesDtos);
        }

        [HttpGet("{id}")]
        public ActionResult<CryptocurrencyDto> Get([FromRoute] int id)
        {
            var cryptocurrency = _dbContext
                .Cryptocurrencies
                .Include(c => c.Comments)
                .Include(c => c.Info)
                .FirstOrDefault(c => c.Id == id);

            if (cryptocurrency is null)
            {
                return NotFound();
            }
            var cryptocurrencyDto = mapper.Map<CryptocurrencyDto>(cryptocurrency);

            return Ok(cryptocurrencyDto);
        }

        [HttpPost]
        public ActionResult CreateCryptocurrency([FromBody] CreateCryptocurrencyDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cryptocurrency = mapper.Map<Cryptocurrency>(dto);
            _dbContext.Cryptocurrencies.Add(cryptocurrency);
            _dbContext.SaveChanges();

            return Created($"api/cryptocurrency/{cryptocurrency.Id}", null);
        }
    }
}
