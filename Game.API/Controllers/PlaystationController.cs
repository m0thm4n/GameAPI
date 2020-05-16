using Game.Contracts;
using Game.Models.Playstation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Game.API.Controllers
{
    [Route("api/playstation")]
    public class PlaystationController : ApiController
    {
        // GET: Playstation
        private IPlaystationService _playstationService;

        [HttpPost]
        public IHttpActionResult Create([FromBody] PlaystationGameCreateModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _playstationService = new PlaystationService();

            _playstationService.CreateGame(model);

            return Ok();
        }

        [HttpGet]
        public IHttpActionResult List()
        {
            _playstationService = new PlaystationService();
            return Ok(_playstationService.GetPlaystationGameList());
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            _playstationService = new PlaystationService();
            _playstationService.GetPlaystationGames(id);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Update([FromBody] PlaystationUpdateModel game)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _playstationService = new PlaystationService();

            _playstationService.UpdatePlaystationGame();

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            _playstationService = new PlaystationService();
            _playstationService.DeleteGame();
            return Ok();
        }
    }
}