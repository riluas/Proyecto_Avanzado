using RatePI.Models;
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
        public IEnumerable<Alumnos> Get()
        {
            var repo = new AlumnosRepository();
            List<Alumnos> alumnos = repo.RetrieveLista();
            return alumnos;
        }

        // GET: api/Alumnos/5
        public Alumnos Get(int id)
        {
            var repo = new AlumnosRepository();
            Alumnos alumnos = repo.RetrieveAlumno(id);
            return alumnos;
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
