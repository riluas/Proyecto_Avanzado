using RatePI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace RatePI.Controllers
{
    public class CategoriasController : ApiController
    {
        // GET: api/Categorias
        public IEnumerable<Categorias> Get()
        {
            var repo = new CategoriasRepository();
            List<Categorias> categorias = repo.RetrieveLista();
            return categorias;
        }

        // GET: api/Categorias/5
        public Categorias Get(int id)
        {
            var repo = new CategoriasRepository();
            Categorias categorias = repo.RetrieveCategorias(id);
            return categorias;
        }

        // POST: api/Categorias
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Categorias/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Categorias/5
        public void Delete(int id)
        {
        }
    }
}
