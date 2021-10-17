using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoinOnion.Models
{
    public class CreateCryptocurrencyDto
    {
        
        public int Id { get; set; }
        public double Price { get; set; }
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string ContractAddress { get; set; }
        public string WebSite { get; set; }
    }
}
