using RatePI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RatePI.Controllers
{
    public class AsistentesController : ApiController
    {
        // GET: api/Asistentes
        public IEnumerable<Asistentes> Get()
        {
            var repo = new AsistentesRepository();
            List<Asistentes> asistentes = repo.RetrieveLista();
            return asistentes;
        }

        // GET: api/Asistentes/5
        public Asistentes Get(int id)
        {
            var repo = new AsistentesRepository();
            Asistentes alumXProyect = repo.RetrieveAsistentes(id);
            return alumXProyect;
        }

        // POST: api/Asistentes
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Asistentes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Asistentes/5
        public void Delete(int id)
        {
        }
    }
}
