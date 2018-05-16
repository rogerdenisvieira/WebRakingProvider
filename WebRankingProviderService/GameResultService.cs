using System;
using System.Collections.Generic;
using System.Text;
using WebRankingProvider.Models;
using WebRankingProviderRepository;

namespace WebRankingProviderService
{
    public class GameResultService : IService<GameResult>
    {
        private GameResultRepository _repository;

        // DI in constructor
        public GameResultService(GameResultRepository repository)
        {
            this._repository = repository;
        }

        /// <summary>
        /// Method designed to store new game's results into database
        /// </summary>
        /// <param name="item"> It is an object that represent a game's result</param>
        /// <returns> Return if method had success on persist operation</returns>
        public bool InsertGameResult(GameResult item)
        {
            try
            {
                if (CheckIfExists(item))
                {
                    this._repository.SaveChanges(item);
                    return true;
                }
                else
                {
                    this._repository.Create(item);
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }


        }

        /// <summary>
        /// Method to check if a provided GameResult exists in DB
        /// </summary>
        /// <param name="item"> Item to lookup</param>
        /// <returns> Return a boolean indicating GametResult existence in DB</returns>
        public bool CheckIfExists(GameResult item)
        {
            GameResult result = this._repository.Get(item.PlayerId, item.GameId);

            if(result != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
