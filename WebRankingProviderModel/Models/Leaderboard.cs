using System;
using System.Collections.Generic;
using System.Text;
using WebRankingProvider.Models;

namespace WebRankingProviderModel.Models
{
    /// <summary>
    /// A class that represents sum of player's score in a game
    /// </summary>
    public class Leaderboard
    {
        public long PlayerId { get; set; }
        public long Balance { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
