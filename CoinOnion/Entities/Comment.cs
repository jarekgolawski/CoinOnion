using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoinOnion.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Time { get; set; }
        public int CryptocurrencyId { get; set; }
        public virtual Cryptocurrency Cryptocurrency { get; set; }
    }
}
