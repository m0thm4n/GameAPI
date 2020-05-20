using Game.Contracts;
using Game.Models.Developer;
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
    [RoutePrefix("api/Developers")]
    public class DeveloperController : ApiController
    {
        // GET: Playstation
        private IDeveloperService _developerService;

        [HttpPost]
        [Route("Create")]
        public IHttpActionResult Create([FromBody] DeveloperCreateModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _developerService = new DeveloperService();

            _developerService.CreateDeveloper(model);

            return Ok();
        }

        [HttpGet]
        [Route("GetAll")]
        public IHttpActionResult List()
        {
            _developerService = new DeveloperService();
            return Ok(_developerService.GetDevelopers());
        }

        [HttpGet]
        [Route("Get")]
        public IHttpActionResult Get([FromUri] int id)
        {
            _developerService = new DeveloperService();
            _developerService.GetDeveloper(id);
            return Ok();
        }

        [HttpPut]
        [Route("Update")]
        public IHttpActionResult Update([FromUri] int id, [FromBody] DeveloperUpdateModel game)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _developerService = new DeveloperService();

            _developerService.UpdateDeveloper(id, game);

            return Ok();
        }

        [HttpDelete]
        [Route("Delete")]
        public IHttpActionResult Delete([FromUri] int id)
        {
            _developerService = new DeveloperService();
            _developerService.DeleteDeveloper(id);
            return Ok();
        }
    }
}