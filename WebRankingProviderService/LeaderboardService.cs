using System;
using System.Collections.Generic;
using System.Text;
using WebRankingProvider.Models;
using WebRankingProviderModel.Models;
using WebRankingProviderRepository;

namespace WebRankingProviderService
{
    public class LeaderboardService : IService<Leaderboard>
    {
        private IRepository<GameResult> _repository;

        public LeaderboardService(IRepository<GameResult> repository)
        {
            this._repository = repository;
        }

        /// <summary>
        /// Method dsigned to retrieve a list with top N players
        /// </summary>
        /// <param name="limit">Size of collection with top players</param>
        /// <returns></returns>
        // TODO: fix it 
        public IEnumerable<Leaderboard> RetrieveLeaderBoards(int limit)
        {
            List<Leaderboard> l = new List<Leaderboard>();

            l.Add(new Leaderboard
            {
                PlayerId = 300,
                Balance = 18385,
                LastUpdateDate = DateTime.Now

            });

            return l;

        }
    }
}
