using CoinOnion.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoinOnion
{
    public class CoinOnionSeeder
    {
        private readonly CryptocurrencyDbContext _dbContext;

        public CoinOnionSeeder(CryptocurrencyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Seed()
        {
            if (_dbContext.Database.CanConnect())
            {
                if (!_dbContext.Cryptocurrencies.Any())
                {
                    var cryptocurrencies = GetCryptocurrencies();
                    _dbContext.Cryptocurrencies.AddRange(cryptocurrencies);
                    _dbContext.SaveChanges();
                }
            }
        }

        private IEnumerable<Cryptocurrency> GetCryptocurrencies()
        {
            var restaurants = new List<Cryptocurrency>()
            {
                new Cryptocurrency()
                {
                    Price = 10,
                    Name = "Luna",
                    Category = "1st layer project",
                    Description =
                    "Creating a new stablecoins project. Got a lot of partners. UST could me stablecoin on Cosmos ecosystem.",
                    Comments = new List<Comment>()
                    {
                        new Comment()
                        {
                            Title = "Very Bad",
                            Content = "This is a shitcoin!",
                        },

                        new Comment()
                        {
                            Title = "To da moon!",
                            Content = "Perfect project! Best team and advisors!",
                        },
                    },
                    Info = new Info()
                    {
                        ContractAddress = "8765sgemrjd763hdns62j3n",
                        WebSite = "www.terra.money",
                        Wallet = "Terra Station"
                    }
                },

                new Cryptocurrency()
                {
                    Price = 10,
                    Name = "Osmosis",
                    Category = "Inter blockchain communication",
                    Description =
                    "Working for cooperate with a rare of blockchains",
                    Comments = new List<Comment>()
                    {
                        new Comment()
                        {
                            Title = "Why there was no public sale??",
                            Content = "This is no fair!",
                        },

                        new Comment()
                        {
                            Title = "Fairdrop",
                            Content = "It was great to make fairdrop dor cosmos stakers!",
                        },
                    },
                    Info = new Info()
                    {
                        ContractAddress = "8765sgemrjd763hdns62j3n",
                        WebSite = "osmosis.zone",
                        Wallet = "Keplr Wallet"
                    }
                }
            };
            return restaurants;
        }
    }
}
