using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RatePI.Models
{
    public class Proyectos
    {
        public Proyectos(int id, string ciclo_formativo, string titulo, string descripcion)
        {
            Id = id;
            Ciclo_formativo = ciclo_formativo;
            Titulo = titulo;
            Descripcion = descripcion;
        }

        public int Id { get; set; }
        public string Ciclo_formativo { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }


    }
}