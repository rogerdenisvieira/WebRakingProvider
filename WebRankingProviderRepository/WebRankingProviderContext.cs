
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
            : base(options)
        {
            var optionsBuilder = new DbContextOptionsBuilder<WebRankingProviderContext>();
            optionsBuilder.                
        }
    }
}