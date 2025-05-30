using sistema_Hospital.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Proyecto
{
    internal class CLpagocita
    {
        CDConexion cd_conexion = new CDConexion();
        public double Mtdmontocita(int CodigoPagoCita)
        {
            double CostoPagocita = 0;

            string QueryConsultarCostoPagocita = "Select CostoTratamiento, CostoHabitacion from tbl_Citas where CodigoPagoCita=@CodigoPagoCita";
            SqlCommand CommandCostoPagocita = new SqlCommand(QueryConsultarCostoPagocita, cd_conexion.MtdAbrirConexion());
            CommandCostoPagocita.Parameters.AddWithValue("@CodigoPagoCita", CodigoPagoCita);
            SqlDataReader reader = CommandCostoPagocita.ExecuteReader();

            if (reader.Read())
            {
                double CostoTratamiento = double.Parse(reader["CostoTratamiento"].ToString());
                double CostoHabitacion = double.Parse(reader["CostoHabitacion"].ToString());
                CostoPagocita = CostoTratamiento + CostoHabitacion;
            }
            else
            {
                CostoPagocita= 0;
            }

            cd_conexion.MtdCerrarConexion();
            return CostoPagocita;
        }

        public DateTime MtdFechaHoy()
        {
            return DateTime.Now;
        }



        public double Mtdimpuesto(double Montocita)
        {
            return Montocita * 0.12;

        }
        public double MtdDescuentopago(double Montocita, double Montopago)
        {
            if(Montocita > 0 || Montocita <= 500) { return Montopago*0.03; }
            else if (Montocita > 500 || Montocita <= 5000) { return Montopago * 0.05; }
            else if (Montocita > 5000) { return Montopago * 0.07; }
            return 0;
        }
        public double Mtdtotalpago(double Montocita, double impuesto, double descuento)
        {
            return Montocita + impuesto - descuento;
        }
    }
}
