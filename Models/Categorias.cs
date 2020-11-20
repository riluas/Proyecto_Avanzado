using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RatePI.Models
{
    public class Categorias
    {
        public Categorias(int id, string nombre_categoria)
        {
            Id = id;
            Nombre_categoria = nombre_categoria;
        }

        public int Id { get; set; }
        public string Nombre_categoria { get; set; }

    }
}