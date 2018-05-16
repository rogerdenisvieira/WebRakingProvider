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
    [Produces("application/json")]
    [Route("api/gameresult")]
    public class GameResultController : Controller
    {

        private GameResultService _service;

        // DI via constructor
        public GameResultController(GameResultService service)
        {
            this._service = service;
        }

        // TODO: fix this method
        // POST: api/gameresult
        [HttpPost]
        public IActionResult Post([FromBody] GameResult value)
        {

            if(value == null)
            {
                return BadRequest();
            }
            else
            {
                this._service.InsertNewGameResult(value);
                return Ok();
            }
        }
        
 
    }
}
