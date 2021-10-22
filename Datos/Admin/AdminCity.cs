using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Datos.Server;
using System.Data;

namespace Datos.Admin
{
    public static class AdminCity
    {
        // Query 
        public static DataTable ListarSoloCiudades()
        {
            // Query 
            string consultaSQL = "SELECT DISTINCT city FROM dbo.authors";

            //declarar y crear un SQLDataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter(consultaSQL, AdminDB.ConectarBase());

            //Declarar y crear un DataSet
            DataSet ds = new DataSet();

            //invocar al método Fill-->conecta a la DB, Ejecuta el Select, Crear DataTable y se desconecta
            adapter.Fill(ds, "City");

            return ds.Tables["City"];
        }

    }
}
