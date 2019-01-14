using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class DefaultController : ApiController
    {
        public IHttpActionResult Get(int id)
        {
            return Json(id);
        }

        public IHttpActionResult Get(int id, string name)
        {
            return Json(id + name);
        }

        [HttpPost]
        [Route("api/post")]
        public IHttpActionResult Post(Test1 data)
        {
            //Test1 g = new Test1();
            //g.Id = data.Id;
            //g.Name = data?.Name;

            return Json(data);
        }

        //[HttpPost]
        //[Route("api/post2")]
        //public IHttpActionResult Post(dynamic data)
        //{
        //    return Json(data);
        //}

        public class Test
        {
            public int Id { get; set; }
        }
        public class Test1
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
