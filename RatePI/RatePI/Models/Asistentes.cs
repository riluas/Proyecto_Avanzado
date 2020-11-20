using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RatePI.Models
{
    public class Asistentes
    {
        public Asistentes(int id, string nombre, string apellidos)
        {
            Id = id;
            Nombre = nombre;
            Apellidos = apellidos;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
    }
}