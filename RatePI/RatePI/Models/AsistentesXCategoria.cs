using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RatePI.Models
{
    public class AsistentesXCategoria
    {
        public AsistentesXCategoria(int id, int id_asistente, int id_proyecto, int id_categoria, int voto)
        {
            Id = id;
            Id_asistente = id_asistente;
            Id_proyecto = id_proyecto;
            Id_categoria = id_categoria;
            Voto = voto;
        }

        public int Id { get; set; }
        public int Id_asistente { get; set; }
        public int Id_proyecto{ get; set; }
        public int Id_categoria { get; set; }
        public int Voto { get; set; }
    }
}