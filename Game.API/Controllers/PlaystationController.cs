using Game.Contracts;
using Game.Models.Playstation;
using Game.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Game.API.Controllers
{
    [Authorize]
    [RoutePrefix("api/PlaystationGames")]
    public class PlaystationController : ApiController
    {
        // GET: Playstation
        private IPlaystationService _playstationService;

        [HttpPost]
        [Route("Create")]
        public IHttpActionResult Create([FromBody] PlaystationGameCreateModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _playstationService = new PlaystationService();

            _playstationService.CreatePlaystationGame(model);

            return Ok();
        }

        [HttpGet]
        [Route("GetAll")]
        public IHttpActionResult List()
        {
            _playstationService = new PlaystationService();
            return Ok(_playstationService.GetPlaystationGames());
        }

        [HttpGet]
        [Route("Get")]
        public IHttpActionResult Get(int id)
        {
            _playstationService = new PlaystationService();
            _playstationService.GetPlaystationGame(id);
            return Ok();
        }

        [HttpPut]
        [Route("Update")]
        public IHttpActionResult Update(int id, [FromBody] PlaystationUpdateModel game)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _playstationService = new PlaystationService();

            _playstationService.UpdatePlaystationGame(id, game);

            return Ok();
        }

        [HttpDelete]
        [Route("Delete")]
        public IHttpActionResult Delete(int id)
        {
            _playstationService = new PlaystationService();
            _playstationService.DeletePlaystationGame(id);
            return Ok();
        }
    }
}