using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RatePI.Models
{
    public class AsistentesXCategoria
    {
        public AsistentesXCategoria(int id, int id_asistentes, int id_categorias, int voto)
        {
            Id = id;
            Id_asistentes = id_asistentes;
            Id_categorias = id_categorias;
            Voto = voto;
        }

        public int Id { get; set; }
        public int Id_asistentes { get; set; }
        public int Id_categorias { get; set; }
        public int Voto { get; set; }
    }
}