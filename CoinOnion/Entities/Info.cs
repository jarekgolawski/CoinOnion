using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoinOnion.Entities
{
    public class Info
    {
        public int Id { get; set; }
        public string ContractAddress { get; set; }
        public string WebSite { get; set; }
        public string Wallet { get; set; }

        public virtual Cryptocurrency Cryptocurrency { get; set; }
    }
}
