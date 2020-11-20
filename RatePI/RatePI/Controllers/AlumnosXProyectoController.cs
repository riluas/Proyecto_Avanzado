using RatePI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RatePI.Controllers
{
    public class AlumnosXProyectoController : ApiController
    {
        // GET: api/AlumnosXProyecto
        public IEnumerable<AlumnosXProyectos> Get()
        {
            var repo = new AlumnosXProyectosRepository();
            List<AlumnosXProyectos> alumXProyect = repo.RetrieveLista();
            return alumXProyect;
        }

        // GET: api/AlumnosXProyecto/5
        public AlumnosXProyectos Get(int id)
        {
            var repo = new AlumnosXProyectosRepository();
            AlumnosXProyectos alumXProyect = repo.RetrieveAlumXProyect(id);
            return alumXProyect;
        }

        // POST: api/AlumnosXProyecto
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/AlumnosXProyecto/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/AlumnosXProyecto/5
        public void Delete(int id)
        {
        }
    }
}
