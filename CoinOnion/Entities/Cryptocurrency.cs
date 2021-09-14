using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoinOnion.Entities
{
    public class Cryptocurrency
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int InfoId { get; set; }
        public virtual Info  Info { get; set; }
        public virtual List<Comment> Comments { get; set; }

    }
}
