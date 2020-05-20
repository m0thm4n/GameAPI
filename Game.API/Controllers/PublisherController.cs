using Game.Contracts;
using Game.Models.Publisher;
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
    [RoutePrefix("api/Publishers")]
    public class PublisherController : ApiController
    {
        private IPublisherContract _publisherService;

        [HttpPost]
        [Route("Create")]
        public IHttpActionResult Create([FromBody] PublisherCreateModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _publisherService = new PublisherServices();

            _publisherService.CreatePublisher(model);

            return Ok();
        }

        [HttpGet]
        [Route("GetAll")]
        public IHttpActionResult List()
        {
            _publisherService = new PublisherServices();
            return Ok(_publisherService.GetPublisher());
        }

        [HttpGet]
        [Route("Get")]
        public IHttpActionResult Get([FromUri] int id)
        {
            _publisherService = new PublisherServices();
            _publisherService.GetPublisher(id);
            return Ok();
        }

        [HttpPut]
        [Route("Update")]
        public IHttpActionResult Update([FromUri] int id, [FromBody] PublisherUpdateModel game)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _publisherService = new PublisherServices();

            _publisherService.UpdatePublisher(id, game);

            return Ok();
        }

        [HttpDelete]
        [Route("Delete")]
        public IHttpActionResult Delete([FromUri] int id)
        {
            _publisherService = new PublisherServices();
            _publisherService.DeletePublisher(id);
            return Ok();
        }
    }
}
