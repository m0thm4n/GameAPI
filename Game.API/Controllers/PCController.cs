using Game.Contracts;
using Game.Data;
using Game.Models.PC;
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
    [RoutePrefix("api/PCGames")]
    public class PCController : ApiController
    {
        private IPCService _pcService;

        // Create PC Game
        [HttpPost]
        [Route("Create")]
        public IHttpActionResult Create([FromBody] PCCreateModel pcGameToCreate)
        {
            _pcService = new PCGameService();
            _pcService.CreatePCGame(pcGameToCreate);

            return Ok();
        }

        // Get All PC Games
        [HttpGet]
        [Route("GetAll")]
        public IHttpActionResult GetAll()
        {
            _pcService = new PCGameService();
            return Ok(_pcService.GetPCGames());
        }

        // Get Single PC game
        [HttpGet]
        [Route("Get")]
        public IHttpActionResult Get(int id)
        {
            _pcService = new PCGameService();
            _pcService.GetPCGame(id);

            return Ok();
        }

        // Update PC Game
        [HttpPut]
        [Route("Update")]
        public IHttpActionResult Update(int id, [FromBody] PCUpdateModel game)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _pcService = new PCGameService();
            _pcService.UpdatePCGame(id, game);

            return Ok();
        }

        // Delete PC Game
        [HttpDelete]
        [Route("Delete")]
        public IHttpActionResult Delete(int id)
        {
            _pcService = new PCGameService();
            _pcService.DeleteGame(id);

            return Ok();
        }
    }
}
