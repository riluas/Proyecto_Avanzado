using RatePI.Models;
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
        public IEnumerable<ProyectosXCategoria> Get()
        {
            var repo = new ProyectosXCategoriaRepository();
            List<ProyectosXCategoria> proyectosXCategorias = repo.RetrieveLista();
            return proyectosXCategorias;
        }


        // GET: api/ProyectosXCategoria/5
        public ProyectosXCategoria Get(int id)
        {
            var repo = new ProyectosXCategoriaRepository();
            ProyectosXCategoria proyectosXCategoria = repo.proyectosXCategoria(id);
            return proyectosXCategoria;
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
