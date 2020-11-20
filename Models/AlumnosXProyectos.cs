using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RatePI.Models
{
    public class AlumnosXProyectos
    {
        public AlumnosXProyectos(int id, int id_alumnos, int id_proyectos)
        {
            Id = id;
            Id_alumnos = id_alumnos;
            Id_proyectos = id_proyectos;
        }

        public int Id { get; set; }
        public int Id_alumnos { get; set; }
        public int Id_proyectos{ get; set; }
    }
}