using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebRankingProviderModel.Models;
using WebRankingProviderService;

namespace WebRankingProviderWebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/leaderboard")]
    public class LeaderboardController : Controller
    {
        private LeaderboardService _service;

        // DI via constructor
        public LeaderboardController(LeaderboardService service)
        {
            this._service = service;
        }


        // GET: api/leaderboards
        [HttpGet]
        public IEnumerable<Leaderboard> Get()
        {
            return this._service.RetrieveLeaderBoards(100);
        }
    }
}
