using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RatePI.Controllers
{
    public class ProyectosXCategoriaController : ApiController
    {
        // GET: api/ProyectosXCategoria
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ProyectosXCategoria/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ProyectosXCategoria
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ProyectosXCategoria/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ProyectosXCategoria/5
        public void Delete(int id)
        {
        }
    }
}
