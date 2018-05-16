using System;

namespace WebRankingProvider.Models
{
    public class GameResult
    {
        public long GameResultId { get; set; }
        public long GameId { get; set; }
        public long PlayerId { get; set; }
        public long Win { get; set; }
        public DateTime Timestamp { get; set; }
    }
}