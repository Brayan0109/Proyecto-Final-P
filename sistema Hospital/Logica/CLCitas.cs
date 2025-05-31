using sistema_Hospital.Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_Hospital.Logica
{
    public class CLCitas
    {
        CDConexion cd_conexion = new CDConexion();
        public DateTime MtdFechaHoy()
        {
            return DateTime.Now;
        }
        public double MtdConsultaCostoTratamiento(int CodigoCita)
        {
            double Costo = 0;

            string QueryConsultarCostoTratamiento = "Select Costo from tbl_Tratamientos where CodigoCita=@CodigoCita";
            SqlCommand CommandCostoMedicamento = new SqlCommand(QueryConsultarCostoTratamiento, cd_conexion.MtdAbrirConexion());
            CommandCostoMedicamento.Parameters.AddWithValue("@CodigoCita", CodigoCita);
            SqlDataReader reader = CommandCostoMedicamento.ExecuteReader();

            if (reader.Read())
            {
                Costo = double.Parse(reader["Costo"].ToString());
            }
            else
            {
                Costo = 0;
            }

            cd_conexion.MtdCerrarConexion();
            return Costo;
        }

    }

   
}
