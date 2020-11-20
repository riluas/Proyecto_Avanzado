using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RatePI.Models
{
    public class Alumnos
    {
        public Alumnos(int id, string nombre, string apellidos, string email)
        {
            Id = id;
            Nombre = nombre;
            Apellidos = apellidos;
            Email = email;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
    }
}