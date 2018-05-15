using System;
using Microsoft.EntityFrameworkCore;
using WebRankingProvider.Models;

namespace WebRankingProviderRepository
{
    public class WebRankingProviderContext : DbContext
    {

        public DbSet<Player> Players { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Score> Scores { get; set; }


        public WebRankingProviderContext(DbContextOptions<WebRankingProviderContext> options) 
            : base (options)
            {
                
            }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=WebRankingProvider.db");
        }
    }
}