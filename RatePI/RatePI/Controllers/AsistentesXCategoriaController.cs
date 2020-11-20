using RatePI.Models;
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
        public IEnumerable<AsistentesXCategoria> Get()
        {
            var repo = new AsistentesXCategoriaRepository();
            List<AsistentesXCategoria> asistXCate = repo.RetrieveLista();
            return asistXCate;
        }

        // GET: api/AsistentesXCategoria/5
        public AsistentesXCategoria Get(int id)
        {
            var repo = new AsistentesXCategoriaRepository();
            AsistentesXCategoria asistXCate = repo.RetrieveAsistXCategor(id);
            return asistXCate;
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
