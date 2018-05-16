using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebRankingProvider.Models;
using WebRankingProviderService;

namespace WebRankingProviderWebAPI.Controllers
{
    //[Produces("application/json")]
    [Route("api/gameresult")]
    public class GameResultController : Controller
    {

        private GameResultService _service;

        // DI via constructor
        public GameResultController(GameResultService service)
        {
            this._service = service;
        }

        // POST: api/gameresult
        // {
        //  GameId: 12,
        //  PlayerId:66,
        //  Win:15587
        // }
        [HttpPost]
        public IActionResult Post([FromBody]GameResult value)
        {
            if(value != null)
            {
                this._service.InsertNewGameResult(value);
                return Ok();
            }
            else
            {
                return BadRequest();
            }         
        }
    }
}
