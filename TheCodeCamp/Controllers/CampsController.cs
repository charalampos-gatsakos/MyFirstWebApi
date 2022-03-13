using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace TheCodeCamp.Controllers
{
    public class CampsController : ApiController
    {
        // GET: Camps
        public IHttpActionResult Get()
        {
            return BadRequest("It's only a game");
            return Ok(new { Name = "Babis", Occupation = "Developer" });
        }
    }
}