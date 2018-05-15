using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebRankingProvider.Models;

namespace WebRankingProviderRepository
{
    public class PlayerRepository : IRepository<Player>
    {

        private WebRankingProviderContext _context;

        public PlayerRepository(WebRankingProviderContext context)
        {
            this._context = context;
        }

        public bool Create(Player item)
        {
            try
            {
                this._context.Players.Add(item);
                this._context.SaveChanges();
                return true;
            } 
            catch
            {
                return false;
            }


        }

        public bool Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Player Get(long id)
        {
            return this._context.Players.First();
        }

        public IQueryable<Player> List()
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}