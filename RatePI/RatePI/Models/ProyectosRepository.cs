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
    public class ProyectosRepository
    {
        private MySqlConnection Connect()
        {
            string connString = "Server =127.0.0.1;Port=3306;Database=ratepi;Uid=root;password=;SslMode=none";
            MySqlConnection con = new MySqlConnection(connString);
            return con;
        }

        internal List<Proyectos> RetrieveLista()
        {
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM proyectos";
            try
            {
                con.Open();
                MySqlDataReader res = command.ExecuteReader();

                Proyectos a = null;
                List<Proyectos> proyectos = new List<Proyectos>();
                while (res.Read())
                {
                    Debug.WriteLine("Recuperado: " + res.GetInt32(0) + " " + res.GetInt32(1) + " " + res.GetString(2) + " " + res.GetString(3) + " " + res.GetString(4));
                    a = new Proyectos(res.GetInt32(0), res.GetInt32(1), res.GetString(2), res.GetString(3), res.GetString(4));
                    proyectos.Add(a);
                }

                con.Close();
                return proyectos;
            }
            catch (MySqlException a)
            {

                Debug.WriteLine("Se ha producido un error de conexión");
                return null;

            }
        }

        internal List<Proyectos> RetrieveProyec_Categoria(int id_cat)
        {
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM proyectos WHERE id_categoria=@id_cat";
            command.Parameters.AddWithValue("@id_cat", id_cat);
            try
            {
                con.Open();
                MySqlDataReader res = command.ExecuteReader();

                Proyectos a = null;
                List<Proyectos> proyectos = new List<Proyectos>();
                while (res.Read())
                {
                    Debug.WriteLine("Recuperado: " + res.GetInt32(0) + " " + res.GetInt32(1) + " " + res.GetString(2) + " " + res.GetString(3) + " " + res.GetString(4));
                    a = new Proyectos(res.GetInt32(0), res.GetInt32(1), res.GetString(2), res.GetString(3), res.GetString(4));
                    proyectos.Add(a);
                    
                }

                con.Close();
                return proyectos;
            }
            catch (MySqlException a)
            {

                Debug.WriteLine("Se ha producido un error de conexión");
                return null;

            }
        }

        internal Proyectos RetrieveProyectos(int id)
        {

            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM proyectos WHERE id=@id";
            command.Parameters.AddWithValue("@id", id);

            con.Open();
            MySqlDataReader res = command.ExecuteReader();

            Proyectos a = null;
            if (res.Read())
            {
                a = new Proyectos(res.GetInt32(0), res.GetInt32(1), res.GetString(2), res.GetString(3), res.GetString(4));
            }

            return a;

        }


        internal void CrearPi(Proyectos proyecto)
        {
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "INSERT INTO proyectos(id_categoria, ciclo_formativo, titulo, descripcion) VALUES('" + proyecto.Id_categoria + "','" + proyecto.Ciclo_formativo + "','" + proyecto.Titulo + "','" + proyecto.Descripcion + "');";


            Debug.WriteLine("comando " + command.CommandText);
            try
             {
                 con.Open();
                 command.ExecuteNonQuery();
                 con.Close();
             }
             catch (MySqlException a)
             {

              Debug.WriteLine("Se ha producido un error de conexión");

            }

        }
    }
}