using Game.Contracts;
using Game.Models.Switch;
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
    [RoutePrefix("api/SwitchGames")]
    public class SwitchController : ApiController
    {
        private ISwitchService _switchService;

        [HttpPost]
        [Route("Create")]
        public IHttpActionResult Create([FromBody] SwitchCreateModel switchToCreate)
        {
            _switchService = new SwitchService();

            _switchService.CreateSwitchGame(switchToCreate);

            return Ok();
        }

        [HttpPut]
        [Route("Update")]
        public IHttpActionResult Update([FromBody] SwitchUpdateModel switchToUpdate)
        {
            if (ModelState.IsValid)
            {
                _switchService = new SwitchService();

                _switchService.UpdateSwitchGame(switchToUpdate);

                return Ok();
            }
            return BadRequest("Cannot find game to update, please try again.");
        }

        [HttpGet]
        [Route("{SwitchId:int}")]
        public IHttpActionResult Get([FromUri]int switchId)
        {
            _switchService = new SwitchService();

            return Ok(_switchService.GetSwitchGame(switchId));
        }

        [HttpGet]
        [Route("GetAll")]
        public IHttpActionResult List()
        {
            _switchService = new SwitchService();
            _switchService.GetAllSwitchGames();
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete([FromUri] int switchId)
        {
            if (ModelState.IsValid)
            {
                _switchService = new SwitchService();
                _switchService.DeleteSwitchGame(switchId);

                return Ok();
            }
            return BadRequest("Wrong ID# entered, please try again.");
        }
    }
}
