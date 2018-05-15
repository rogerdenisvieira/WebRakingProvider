using System;

namespace WebRankingProvider.Models
{
    public class Score
    {
        public long ScoreId { get; set; }
        public Game GameId { get; set; }
        public Player PlayerId { get; set; }
    }
}