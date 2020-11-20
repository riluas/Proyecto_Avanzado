using MySql.Data.MySqlClient;
using RatePI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RatePI.Models
{
    public class AlumnosRepository
    {
        private MySqlConnection Connect()
        {
            string connString = "Server =127.0.0.1;Port=3306;Database=ratepi;Uid=root;password=;SslMode=none";
            MySqlConnection con = new MySqlConnection(connString);
            return con;
        }

        internal List<Alumnos> RetrieveLista()
        {
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM alumnos";
            try
            {
                con.Open();
                MySqlDataReader res = command.ExecuteReader();

                Alumnos a = null;
                List<Alumnos> alumnos = new List<Alumnos>();
                while (res.Read())
                {
                    Debug.WriteLine("Recuperado: " + res.GetInt32(0) + " " + res.GetString(1) + " " + res.GetString(2) + " " + res.GetString(3));
                    a = new Alumnos(res.GetInt32(0), res.GetString(1), res.GetString(2), res.GetString(3));
                    alumnos.Add(a);
                }
                con.Close();
                return alumnos;
            }
            catch (MySqlException a)
            {

                Debug.WriteLine("Se ha producido un error de conexión");
                return null;

            }
        }
        internal Alumnos RetrieveAlumno(int id)
        {

            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM alumnos WHERE id=@id";
            command.Parameters.AddWithValue("@id", id);

            con.Open();
            MySqlDataReader res = command.ExecuteReader();

            Alumnos a = null;
            if (res.Read())
            {
                a = new Alumnos(res.GetInt16(0), res.GetString(1), res.GetString(2), res.GetString(3));
            }

            return a;

        }
    }
}