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
    public class AsistentesXCategoriaRepository
    {
        private MySqlConnection Connect()
        {
            string connString = "Server =127.0.0.1;Port=3306;Database=ratepi;Uid=root;password=;SslMode=none";
            MySqlConnection con = new MySqlConnection(connString);
            return con;
        }

        internal List<AsistentesXCategoria> RetrieveLista()
        {
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM asistentesxcategoria";
            try
            {
                con.Open();
                MySqlDataReader res = command.ExecuteReader();

                AsistentesXCategoria a = null;
                List<AsistentesXCategoria> asistXCate = new List<AsistentesXCategoria>();
                while (res.Read())
                {
                    Debug.WriteLine("Recuperado: " + res.GetInt32(0) + " " + res.GetInt32(1) + " " + res.GetInt32(2) + " " + res.GetInt32(3) + " " + res.GetInt32(4));
                    a = new AsistentesXCategoria(res.GetInt32(0), res.GetInt32(1), res.GetInt32(2), res.GetInt32(3), res.GetInt32(4));
                    asistXCate.Add(a);
                }
                con.Close();
                return asistXCate;
            }
            catch (MySqlException a)
            {

                Debug.WriteLine("Se ha producido un error de conexión");
                return null;

            }
        }
        internal AsistentesXCategoria RetrieveAsistXCategor(int id)
        {

            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM asistentesxcategoria WHERE id=@id";
            command.Parameters.AddWithValue("@id", id);

            con.Open();
            MySqlDataReader res = command.ExecuteReader();

            AsistentesXCategoria a = null;
            if (res.Read())
            {
                a = new AsistentesXCategoria(res.GetInt32(0), res.GetInt32(1), res.GetInt32(2), res.GetInt32(3), res.GetInt32(4));
            }

            return a;

        }
    }
}