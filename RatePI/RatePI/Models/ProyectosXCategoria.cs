using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RatePI.Models
{
    public class ProyectosXCategoria
    {
        public ProyectosXCategoria(int id, int id_proyectos, int id_categoria)
        {
            Id = id;
            Id_proyectos = id_proyectos;
            Id_categoria = id_categoria;
        }

        public int Id { get; set; }
        public int Id_proyectos { get; set; }
        public int Id_categoria { get; set; }
    }
}