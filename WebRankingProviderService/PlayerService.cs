using System;
using System.Linq;
using WebRankingProvider.Models;
using WebRankingProviderRepository;

namespace WebRankingProviderService
{
    public class PlayerService
    {
        private PlayerRepository _repository;

        public PlayerService(PlayerRepository repository)
        {
            this._repository = repository;
        }

        public IQueryable<Player> AllPlayers()
        {
            return this._repository.List();
        }
    }
}