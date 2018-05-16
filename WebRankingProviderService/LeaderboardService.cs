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

            var result = (List<GameResult>)_repository.List();
            var resultFiltered = result
                .GroupBy(r => r.PlayerId)
                .SelectMany( cl => cl.Select( clLine => new Leaderboard{
                    PlayerId = clLine.PlayerId,
                    Balance = cl.Sum( s => s.Win),
                    LastUpdateDate = DateTime.UtcNow
                })).OrderByDescending(o => o.Balance);

            return resultFiltered;

        }
    }
}
