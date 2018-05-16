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

        // TODO: implement a log
        public bool Create(GameResult item)
        {
            Console.WriteLine("Trying to save a game result.");
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

        public IEnumerable<GameResult> List()
        {
            return this._context.GameResults.ToList<GameResult>();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}