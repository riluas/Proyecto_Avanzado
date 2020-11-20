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
    public class ProyectosXCategoriaRepository
    {
        private MySqlConnection Connect()
        {
            string connString = "Server =127.0.0.1;Port=3306;Database=ratepi;Uid=root;password=;SslMode=none";
            MySqlConnection con = new MySqlConnection(connString);
            return con;
        }

        internal List<ProyectosXCategoria> RetrieveLista()
        {
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM proyectosxcategoria";
            try
            {
                con.Open();
                MySqlDataReader res = command.ExecuteReader();

                ProyectosXCategoria a = null;
                List<ProyectosXCategoria> proyectosXCategorias = new List<ProyectosXCategoria>();
                while (res.Read())
                {
                    Debug.WriteLine("Recuperado: " + res.GetInt32(0) + " " + res.GetInt32(1) + " " + res.GetInt32(2));
                    a = new ProyectosXCategoria(res.GetInt32(0), res.GetInt32(1), res.GetInt32(2));
                    proyectosXCategorias.Add(a);
                }
                con.Close();
                return proyectosXCategorias;
            }
            catch (MySqlException a)
            {

                Debug.WriteLine("Se ha producido un error de conexión");
                return null;

            }
        }
        internal ProyectosXCategoria proyectosXCategoria(int id)
        {

            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM proyectosxcategoria WHERE id=@id";
            command.Parameters.AddWithValue("@id", id);

            con.Open();
            MySqlDataReader res = command.ExecuteReader();

            ProyectosXCategoria a = null;
            if (res.Read())
            {
                a = new ProyectosXCategoria(res.GetInt32(0), res.GetInt32(1), res.GetInt32(2));
            }

            return a;

        }
    }
}