using System;
using System.Collections.Generic;
using System.Text;
using WebRankingProvider.Models;
using WebRankingProviderRepository;

namespace WebRankingProviderService
{
    public class GameResultService : IService<GameResult>
    {
        private IRepository<GameResult> _repository;

        // DI in constructor
        public GameResultService(IRepository<GameResult> repository)
        {
            this._repository = repository;
        }

        /// <summary>
        /// Method designed to store new game's results into database
        /// </summary>
        /// <param name="item"> It is an object that represent a game's result</param>
        /// <returns></returns>
        public Boolean InsertNewGameResult(GameResult item)
        {
            try
            {
                this._repository.Create(item);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
