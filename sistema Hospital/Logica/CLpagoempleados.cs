using sistema_Hospital.Datos;
using Sistema_Proyecto;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Proyecto
{
    internal class CLpagoempleados
    {
        CDConexion cd_conexion = new CDConexion();
        public double Mtdsueldoempleados(int CodigoEmpleado)
        {
            double sueldoempleado = 0;
           

            string QueryConsultarSueldoempleado = "Select Sueldo  from tbl_Empleados where CodigoEmleado=@CodigoEmleado";
            SqlCommand CommandSueldoempleado = new SqlCommand(QueryConsultarSueldoempleado, cd_conexion.MtdAbrirConexion());
            CommandSueldoempleado.Parameters.AddWithValue("@CodigoEmleado", CodigoEmpleado);
            

            SqlDataReader reader = CommandSueldoempleado.ExecuteReader();

            if (reader.Read())
            {
               sueldoempleado= double.Parse(reader["Sueldo"].ToString());

              
            }
            else
            {
                sueldoempleado = 0;               

            }
            cd_conexion.MtdCerrarConexion();
            return sueldoempleado;
        
             
        }
        public double MtdSueldoBono(double Sueldo)
        {
            return Sueldo * 0.12;
        }
        public double MtdTotalmonto(double Sueldo, double Bono, double MontoHorasE)
        {
         


            return Sueldo + Bono + (MontoHorasE * 20);
        }

        public DateTime MtdFechaHoy()
        {
            return DateTime.Now;
        }
    }
}
