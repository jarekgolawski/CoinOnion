using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoinOnion.Entities
{
    public class CryptocurrencyDbContext : DbContext
    {
        private string _connectionString =
            "Server=DESKTOP-CSD5VNR\\SQLEXPRESS;Database=CoinOnionDb;Trusted_Connection=true;";
        public DbSet<Cryptocurrency> Cryptocurrencies { get; set; }
        public DbSet<Info> Infos { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cryptocurrency>()
                .Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(25);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
