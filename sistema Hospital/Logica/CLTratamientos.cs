using sistema_Hospital.Datos;
using SistemaHospital.Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHospital.Logica
{
    public  class CLtratamientos
    {
        CDConexion cd_conexion = new CDConexion();

       
        public DateTime MtdFechaActual()
        {
            return DateTime.Now;
        }

      
        public double MtdConsultaCostoMedicamento(int CodigoMedicamento)
        {
            double CostoMedica = 0;

            string QueryConsultarCostoMedicamento = "Select Costo from tbl_Medicamentos where CodigoMedicamento=@CodigoMedicamento";
            SqlCommand CommandCostoMedicamento = new SqlCommand(QueryConsultarCostoMedicamento, cd_conexion.MtdAbrirConexion());
            CommandCostoMedicamento.Parameters.AddWithValue("@CodigoMedicamento", CodigoMedicamento);
            SqlDataReader reader = CommandCostoMedicamento.ExecuteReader();

            if (reader.Read())
            {
                CostoMedica = double.Parse(reader["Costo"].ToString());
            }
            else
            {
                CostoMedica = 0;
            }

            cd_conexion.MtdCerrarConexion();
            return CostoMedica;
        }

    }
}
