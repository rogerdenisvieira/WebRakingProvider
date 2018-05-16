using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebRankingProvider.Models;
using WebRankingProviderModel.Models;
using WebRankingProviderRepository;

namespace WebRankingProviderService
{
    public class LeaderboardService : IService<Leaderboard>
    {
        private GameResultRepository _repository;

        public LeaderboardService(GameResultRepository repository)
        {
            this._repository = repository;
        }

        /// <summary>
        /// Method dsigned to retrieve a list with top N players
        /// </summary>
        /// <param name="limit">Size of collection with top players</param>
        /// <returns> Returns top N players ordering by sum of their individual scores.</returns>
        // TODO: fix it 
        public IEnumerable<Leaderboard> RetrieveLeaderBoards(int limit)
        {
            var result = (List<GameResult>)_repository.List();
            var resultFiltered = result
                .GroupBy( group => group.PlayerId)
                .Select( select => new Leaderboard{
                    PlayerId = select.First().PlayerId,
                    Balance = select.Sum( s => s.Win),
                    LastUpdateDate = DateTime.Now
                })
                .OrderByDescending( order => order.Balance)
                .Take(limit);

            return resultFiltered;
        }
    }
}
