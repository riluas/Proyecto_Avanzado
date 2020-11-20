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
    public class AsistentesRepository
    {
        private MySqlConnection Connect()
        {
            string connString = "Server =127.0.0.1;Port=3306;Database=ratepi;Uid=root;password=;SslMode=none";
            MySqlConnection con = new MySqlConnection(connString);
            return con;
        }

        internal List<Asistentes> RetrieveLista()
        {
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM asistentes";
            try
            {
                con.Open();
                MySqlDataReader res = command.ExecuteReader();

                Asistentes a = null;
                List<Asistentes> asistentes = new List<Asistentes>();
                while (res.Read())
                {
                    Debug.WriteLine("Recuperado: " + res.GetInt32(0) + " " + res.GetString(1) + " " + res.GetString(2));
                    a = new Asistentes(res.GetInt32(0), res.GetString(1), res.GetString(2));
                    asistentes.Add(a);
                }
                con.Close();
                return asistentes;
            }
            catch (MySqlException a)
            {

                Debug.WriteLine("Se ha producido un error de conexión");
                return null;

            }
        }
        internal Asistentes RetrieveAsistentes(int id)
        {

            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM asistentes WHERE id=@id";
            command.Parameters.AddWithValue("@id", id);

            con.Open();
            MySqlDataReader res = command.ExecuteReader();

            Asistentes a = null;
            if (res.Read())
            {
                a = new Asistentes(res.GetInt32(0), res.GetString(1), res.GetString(2));
            }

            return a;

        }
    }
}