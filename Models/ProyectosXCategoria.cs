using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RatePI.Models
{
    public class ProyectosXCategoria
    {
        public ProyectosXCategoria(int id, string id_proyectos, string id_categoria)
        {
            Id = id;
            Id_proyectos = id_proyectos;
            Id_categoria = id_categoria;
        }

        public int Id { get; set; }
        public string Id_proyectos { get; set; }
        public string Id_categoria { get; set; }
    }
}