using Game.Contracts;
using Game.Models.Xbox;
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
    [RoutePrefix("api/XboxGames")]
    public class XboxController : ApiController
    {
        private IXboxService _xboxService;

        [HttpPost]
        [Route("Create")]
        public IHttpActionResult Create(XboxCreateModel xboxToCreate)
        {
            _xboxService = new XboxService();

            _xboxService.CreateXboxGame(xboxToCreate);

            return Ok();
        }

        [HttpPut]
        [Route("Update")]
        public IHttpActionResult Update(XboxUpdatesModel xboxToUpdate)
        {
            if (ModelState.IsValid)
            {
                _xboxService = new XboxService();

                _xboxService.UpdateXboxGame(xboxToUpdate);

                return Ok();
            }
            return BadRequest("Cannot find game to update, please try again.");
        }

        [HttpGet]
        [Route("GetSingleGame")]
        public IHttpActionResult Get(int id)
        {
            _xboxService = new XboxService();

            return Ok(_xboxService.GetXboxGame(id));
        }

        [HttpGet]
        [Route("GetAllGames")]
        public IHttpActionResult Get()
        {
            _xboxService = new XboxService();
            _xboxService.GetAllXboxGames();
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                _xboxService = new XboxService();
                _xboxService.DeleteXboxGame(id);

                return Ok();
            }
            return BadRequest("Wrong ID# entered, please try again.");

        }
    }
}
