using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoinOnion.Models
{
    public class CryptocurrencyDto
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string ContractAddress { get; set; }
        public string WebSite { get; set; }
        public List<CommentDto> Comments { get; set; }
    }
}
