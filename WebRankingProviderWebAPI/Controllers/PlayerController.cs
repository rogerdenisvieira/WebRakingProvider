using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebRankingProvider.Models;
using WebRankingProviderService;

namespace WebRankingProviderWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class PlayerController : Controller
    {
        private PlayerService _service;

        public PlayerController(PlayerService service)
        {
            this._service = service;
        }


        [HttpGet]
        public IEnumerable<Player> Get()
        {
            return this._service.AllPlayers();
        }
    }
}