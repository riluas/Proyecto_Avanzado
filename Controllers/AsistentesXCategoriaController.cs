using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RatePI.Controllers
{
    public class AsistentesXCategoriaController : ApiController
    {
        // GET: api/AsistentesXCategoria
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/AsistentesXCategoria/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/AsistentesXCategoria
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/AsistentesXCategoria/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/AsistentesXCategoria/5
        public void Delete(int id)
        {
        }
    }
}
