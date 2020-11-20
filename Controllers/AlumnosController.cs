using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RatePI.Controllers
{
    public class AlumnosController : ApiController
    {
        // GET: api/Alumnos
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Alumnos/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Alumnos
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Alumnos/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Alumnos/5
        public void Delete(int id)
        {
        }
    }
}
