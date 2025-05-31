using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_Hospital.Datos
{
    internal class CDConexion
    {
        private SqlConnection db_conexion = new SqlConnection("Data Source=DESKTOP-M60V2AT\\SQLEXPRESS;Initial Catalog=BD_Hospitalsiste;Integrated Security=True;Encrypt=False");

        public SqlConnection MtdAbrirConexion()
        {
            if (db_conexion.State == ConnectionState.Closed)
            {
                db_conexion.Open();
            }
            return db_conexion;
        }

        public SqlConnection MtdCerrarConexion()
        {
            if (db_conexion.State == ConnectionState.Open)
            {
                db_conexion.Close();
            }
            return db_conexion;
        }
    }
}
