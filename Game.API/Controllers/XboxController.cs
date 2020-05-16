using Game.Contracts;
using Game.Models.Xbox;
using Game.Services;
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
        [Route("{XboxId:int}")]
        public IHttpActionResult Get([FromUri]int xboxId)
        {
            _xboxService = new XboxService();

            return Ok(_xboxService.GetXboxGame(xboxId));
        }

        [HttpGet]
        [Route("List")]
        public IHttpActionResult Get()
        {
            _xboxService = new XboxService();
            _xboxService.GetAllXboxGames();
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete([FromUri] int xboxId)
        {
            if (ModelState.IsValid)
            {
                _xboxService = new XboxService();
                _xboxService.DeleteXboxGame(xboxId);

                return Ok();
            }
            return BadRequest("Wrong ID# entered, please try again.");

        }
    }
}
