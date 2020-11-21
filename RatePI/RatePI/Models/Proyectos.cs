using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RatePI.Models
{
    public class Proyectos
    {
        public Proyectos(int id, int id_categoria, string ciclo_formativo, string titulo, string descripcion)
        {
            Id = id;
            Id_categoria = id_categoria;
            Ciclo_formativo = ciclo_formativo;
            Titulo = titulo;
            Descripcion = descripcion;
        }

        public int Id { get; set; }
        public int Id_categoria { get; set; }
        public string Ciclo_formativo { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }


    }
    public class ProyectosVoto
    {
        public ProyectosVoto(int proyectosVotoId, int id_categoria, string ciclo_formativo, string titulo, string descripcion)
        {
            ProyectosVotoId = proyectosVotoId;
            Id_categoria = id_categoria;
            Ciclo_formativo = ciclo_formativo;
            Titulo = titulo;
            Descripcion = descripcion;
        }

        public int ProyectosVotoId { get; set; }
        public int Id_categoria { get; set; }
        public string Ciclo_formativo { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }



    }
}