using RatePI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RatePI.Controllers
{
    public class ProyectosController : ApiController
    {
        // GET: api/Proyectos
        public IEnumerable<Proyectos> Get()
        {
            var repo = new ProyectosRepository();
            List<Proyectos> proyectos = repo.RetrieveLista();
            return proyectos;
        }

        // GET: api/Proyectos/?Categoria=id_cat
        public IEnumerable<Proyectos> GetProyectos(int id_cat)
        {
            var repo = new ProyectosRepository();
            List<Proyectos> proyectos = repo.RetrieveProyec_Categoria(id_cat);
            return proyectos;
        }

        // GET: api/Proyectos/5
        public Proyectos Get(int id)
        {
            var repo = new ProyectosRepository();
            Proyectos proyectos = repo.RetrieveProyectos(id);
            return proyectos;
        }

        // POST: api/Proyectos
        public void Post([FromBody]Proyectos proyecto)
        {
            var repo = new ProyectosRepository();
            repo.CrearPi(proyecto);
        }

        // PUT: api/Proyectos/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Proyectos/5
        public void Delete(int id)
        {
        }
    }
}
