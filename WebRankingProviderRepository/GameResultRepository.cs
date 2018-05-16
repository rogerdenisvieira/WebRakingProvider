using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebRankingProvider.Models;

namespace WebRankingProviderRepository
{
    /// <summary>
    /// Provides DAO layer to GameResult entities
    /// </summary>
    public class GameResultRepository : IRepository<GameResult>
    {

        private WebRankingProviderContext _context;

        // DI via constructor
        public GameResultRepository(WebRankingProviderContext context)
        {
            this._context = context;
        }

        /// <summary>
        /// Create a new GameResult into DB
        /// </summary>
        /// <param name="item"> GameResult object to persist into DB</param>
        /// <returns>Return a boolean indicating whether operations was successfully</returns>
        public bool Create(GameResult item)
        {
            try
            {
                this._context.GameResults.Add(item);
                this._context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {        
                System.Console.WriteLine(ex.Message);    
                return false;                
            }
        }

        public bool Delete(long id)
        {
            throw new NotImplementedException();
        }

        public GameResult Get(long id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get a GameResult given playerId and gameId
        /// </summary>
        /// <param name="playerId">Id of the player</param>
        /// <param name="gameId">Id of the game</param>
        /// <returns> Return a GameResult</returns>
        public GameResult Get(long playerId, long gameId)
        {
            GameResult result = this._context.GameResults
                     .Where(gameResult => gameResult.GameId.Equals(gameId) 
                        && gameResult.PlayerId.Equals(playerId))
                     .FirstOrDefault();

            return result;
        }

        /// <summary>
        /// List a ser of GameResults
        /// </summary>
        /// <returns> Return a list that contains a set of GameResults</returns>
        public IEnumerable<GameResult> List()
        {
            return this._context.GameResults.ToList<GameResult>();
        }

        /// <summary>
        /// Updates a GameResult whether it exists
        /// </summary>
        /// <param name="item"> A GameResult to update</param>
        /// <returns> Return a boolean indicating whether operations was successfully</returns>
        public bool SaveChanges(GameResult item)
        {
            try
            {
                var itemToUpdate = this.Get(item.PlayerId, item.GameId);
                if (itemToUpdate != null)
                {
                    itemToUpdate.Win = itemToUpdate.Win + item.Win;
                    this._context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}