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
    public static class AdminAuthor
    {
        public static List<Author> Listar()
        {
            string querySQL = "SELECT au_id,au_lname,au_fname,phone,address,city,state,zip,contract FROM dbo.authors";

            SqlCommand comando = new SqlCommand(querySQL, AdminDB.ConectarBase());
            SqlDataReader reader;
            reader = comando.ExecuteReader();

            List<Author> authors = new List<Author>();

            while (reader.Read())
            {
                authors.Add
                    (
                    new Author
                    {
                        Au_id = reader["Au_id"].ToString(),
                        Au_lname = reader["Au_lname"].ToString(),
                        Au_fname = reader["Au_fname"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        Address = reader["Address"].ToString(),
                        City = reader["City"].ToString(),
                        State = reader["State"].ToString(),
                        Zip = reader["Zip"].ToString(),
                        Contract = (bool) reader["Contract"]
                    }
                    );
            }

            AdminDB.ConectarBase().Close();
            reader.Close();

            return authors;
        }

        public static List<Author> Listar(string ciudad)
        {
            string querySQL = "SELECT au_id,au_lname,au_fname,phone,address,city,state,zip,contract FROM dbo.authors WHERE city = @city";

            SqlCommand comando = new SqlCommand(querySQL, AdminDB.ConectarBase());

            comando.Parameters.Add("@city", SqlDbType.VarChar, 20).Value = ciudad;

            SqlDataReader reader;
            reader = comando.ExecuteReader();

            List<Author> authors = new List<Author>();

            while (reader.Read())
            {
                authors.Add
                    (
                    new Author
                    {
                        Au_id = reader["Au_id"].ToString(),
                        Au_lname = reader["Au_lname"].ToString(),
                        Au_fname = reader["Au_fname"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        Address = reader["Address"].ToString(),
                        City = reader["City"].ToString(),
                        State = reader["State"].ToString(),
                        Zip = reader["Zip"].ToString(),
                        Contract = (bool)reader["Contract"]
                    }
                    );
            }

            AdminDB.ConectarBase().Close();
            reader.Close();

            return authors;
        }

        public static List<Author> Listar(string ciudad, string estado)
        {
            string querySQL = "SELECT au_id,au_lname,au_fname,phone,address,city,state,zip,contract FROM dbo.authors WHERE city = @city AND state = @state";

            SqlCommand comando = new SqlCommand(querySQL, AdminDB.ConectarBase());

            comando.Parameters.Add("@city", SqlDbType.VarChar, 20).Value = ciudad;
            comando.Parameters.Add("@state", SqlDbType.Char, 2).Value = estado;

            SqlDataReader reader;
            reader = comando.ExecuteReader();

            List<Author> authors = new List<Author>();

            while (reader.Read())
            {
                authors.Add
                    (
                    new Author
                    {
                        Au_id = reader["Au_id"].ToString(),
                        Au_lname = reader["Au_lname"].ToString(),
                        Au_fname = reader["Au_fname"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        Address = reader["Address"].ToString(),
                        City = reader["City"].ToString(),
                        State = reader["State"].ToString(),
                        Zip = reader["Zip"].ToString(),
                        Contract = (bool)reader["Contract"]
                    }
                    );
            }

            AdminDB.ConectarBase().Close();
            reader.Close();

            return authors;
        }
    }
}
