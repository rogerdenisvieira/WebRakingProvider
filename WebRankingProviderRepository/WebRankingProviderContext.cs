using System;
using Microsoft.EntityFrameworkCore;
using WebRankingProvider.Models;

namespace WebRankingProviderRepository
{
    public class WebRankingProviderContext : DbContext
    {
        // collection that represents GameResult entities
        public DbSet<GameResult> GameResults { get; set; }


        public WebRankingProviderContext(DbContextOptions<WebRankingProviderContext> options) 
            : base (options)
            {
                
            }

        //setting up SQLite DB
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=WebRankingProvider.db");
        }
    }
}