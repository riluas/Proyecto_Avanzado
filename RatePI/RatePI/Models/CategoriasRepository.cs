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
    public class CategoriasRepository
    {
        private MySqlConnection Connect()
        {
            string connString = "Server =127.0.0.1;Port=3306;Database=ratepi;Uid=root;password=;SslMode=none";
            MySqlConnection con = new MySqlConnection(connString);
            return con;
        }
        internal List<Categorias> RetrieveLista()
        {
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM categorias";
            try
            {
                con.Open();
                MySqlDataReader res = command.ExecuteReader();

                Categorias a = null;
                List<Categorias> categorias = new List<Categorias>();
                while (res.Read())
                {
                    Debug.WriteLine("Recuperado: " + res.GetInt32(0) + " " + res.GetString(1));
                    a = new Categorias(res.GetInt32(0), res.GetString(1));
                    categorias.Add(a);
                }
                con.Close();
                return categorias;
            }
            catch (MySqlException a)
            {

                Debug.WriteLine("Se ha producido un error de conexión");
                return null;

            }
        }
        internal Categorias RetrieveCategorias(int id)
        {

            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM categorias WHERE id=@id";
            command.Parameters.AddWithValue("@id", id);

            con.Open();
            MySqlDataReader res = command.ExecuteReader();

            Categorias a = null;
            if (res.Read())
            {
                a = new Categorias(res.GetInt32(0), res.GetString(1));
            }

            return a;

        }
    }
}