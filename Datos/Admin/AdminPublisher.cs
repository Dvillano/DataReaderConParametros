using Datos.Models;
using Datos.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Admin
{
    public static class AdminPublisher
    {
        public static List<Publisher> Listar()
        {
            string querySQL = "SELECT pub_id,pub_name,city,state,country FROM dbo.publishers";

            SqlCommand comando = new SqlCommand(querySQL, AdminDB.ConectarBase());
            SqlDataReader reader;
            reader = comando.ExecuteReader();

            List<Publisher> publishers = new List<Publisher>();

            while (reader.Read())
            {
                publishers.Add
                    (
                    new Publisher
                    {
                        Pub_id = reader["Pub_id"].ToString(),
                        Pub_name = reader["Pub_name"].ToString(),
                        City = reader["City"].ToString(),
                        State = reader["State"].ToString(),
                        Country = reader["Country"].ToString(),
                    }
                    );
            }

            AdminDB.ConectarBase().Close();
            reader.Close();

            return publishers;
        }

        public static List<Publisher> Listar(string ciudad)
        {
            string querySQL = "SELECT pub_id,pub_name,city,state,country FROM dbo.publishers WHERE city = @city";

            SqlCommand comando = new SqlCommand(querySQL, AdminDB.ConectarBase());

            comando.Parameters.Add("@city", SqlDbType.VarChar, 20).Value = ciudad;

            SqlDataReader reader;
            reader = comando.ExecuteReader();

            List<Publisher> publishers = new List<Publisher>();

            while (reader.Read())
            {
                publishers.Add
                    (
                    new Publisher
                    {
                        Pub_id = reader["Pub_id"].ToString(),
                        Pub_name = reader["Pub_name"].ToString(),
                        City = reader["City"].ToString(),
                        State = reader["State"].ToString(),
                        Country = reader["Country"].ToString(),
                    }
                    );
            }

            AdminDB.ConectarBase().Close();
            reader.Close();

            return publishers;
        }

        public static List<Publisher> Listar(string ciudad, string estado)
        {
            string querySQL = "SELECT pub_id,pub_name,city,state,country FROM dbo.publishers WHERE city = @city AND state is NULL OR state = @state";

            SqlCommand comando = new SqlCommand(querySQL, AdminDB.ConectarBase());

            comando.Parameters.Add("@city", SqlDbType.VarChar, 20).Value = ciudad;
            comando.Parameters.Add("@state", SqlDbType.Char, 2).Value = estado;

            SqlDataReader reader;
            reader = comando.ExecuteReader();

            List<Publisher> publishers = new List<Publisher>();

            while (reader.Read())
            {
                publishers.Add
                    (
                    new Publisher
                    {
                        Pub_id = reader["Pub_id"].ToString(),
                        Pub_name = reader["Pub_name"].ToString(),
                        City = reader["City"].ToString(),
                        State = reader["State"].ToString(),
                        Country = reader["Country"].ToString(),
                    }
                    );
            }

            AdminDB.ConectarBase().Close();
            reader.Close();

            return publishers;
        }

        public static List<Publisher> Listar(string ciudad, string estado, string pais)
        {
            string querySQL = "SELECT pub_id,pub_name,city,state,country FROM dbo.publishers WHERE city = @city AND state is NULL OR state = @state AND country = @country";

            SqlCommand comando = new SqlCommand(querySQL, AdminDB.ConectarBase());

            comando.Parameters.Add("@city", SqlDbType.VarChar, 20).Value = ciudad;
            comando.Parameters.Add("@state", SqlDbType.Char, 2).Value = estado;
            comando.Parameters.Add("@country", SqlDbType.VarChar, 30).Value = pais;

            SqlDataReader reader;
            reader = comando.ExecuteReader();

            List<Publisher> publishers = new List<Publisher>();

            while (reader.Read())
            {
                publishers.Add
                    (
                    new Publisher
                    {
                        Pub_id = reader["Pub_id"].ToString(),
                        Pub_name = reader["Pub_name"].ToString(),
                        City = reader["City"].ToString(),
                        State = reader["State"].ToString(),
                        Country = reader["Country"].ToString(),
                    }
                    );
            }

            AdminDB.ConectarBase().Close();
            reader.Close();

            return publishers;
        }
    }
}
