using sistema_Hospital.Datos;
using sistema_Hospital.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TablaAmy
{
    internal class CDgestionhabitaciones
    {

        CDConexion cd_conexion = new CDConexion();

        public List<dynamic> MtdListaEmpleados()
        {
            List<dynamic> ListaEmpleados = new List<dynamic>();
            string QueryListaEmpleados = "Select CodigoEmleado, Nombres from tbl_Empleados";
            SqlCommand cmd = new SqlCommand(QueryListaEmpleados, cd_conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListaEmpleados.Add(new
                {
                    Value = reader["CodigoEmleado"],
                    Text = $"{reader["CodigoEmleado"]} - {reader["Nombres"]}"
                });
            }

            cd_conexion.MtdCerrarConexion();
            return ListaEmpleados;
        }
        public List<dynamic> MtdListaHabitaciones()
        {
            List<dynamic> ListaHabitaciones = new List<dynamic>();
            string QueryListaHabitacion = "Select CodigoHabitacion from tbl_Habitaciones";
            SqlCommand cmd = new SqlCommand(QueryListaHabitacion, cd_conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListaHabitaciones.Add(new
                {
                    Value = reader["CodigoHabitacion"],
                    Text = $"{reader["CodigoHabitacion"]}"
                });
            }

            cd_conexion.MtdCerrarConexion();
            return ListaHabitaciones;
        }
        public DataTable MtdConsultarGestionhabitaciones()
        {
            string QueryConsultargestionhabitaciones = "Select * from tbl_GestionHabitacion";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultargestionhabitaciones, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }
        public void MtdAgregargestioonhabitaciones(int Codigoempleado,int Codigohabitacion, string Tipogestion, DateTime Fechagestion, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string QueryAgregargestionhabitaciones = "Insert into tbl_GestionHabitacion(Codigoempleado, Codigohabitacion, Tipogestion, Fechagestion, Estado, FechaAuditoria, UsuarioAuditoria) values (@Codigoempleado, @Codigohabitacion, @Tipogestion, @Fechagestion, @Estado, @FechaAuditoria, @UsuarioAuditoria)";
            SqlCommand cmd = new SqlCommand(QueryAgregargestionhabitaciones, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Codigoempleado", Codigoempleado);
            cmd.Parameters.AddWithValue("@Codigohabitacion", Codigohabitacion);
            cmd.Parameters.AddWithValue("@Tipogestion", Tipogestion);
            cmd.Parameters.AddWithValue("@Fechagestion", Fechagestion);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
        public void MtdActualizarGestionhabitaciones(int Codigogestionhabitaciones, int Codigoempleado, int Codigohabitacion, string Tipogestion, DateTime Fechagestion, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string QueryActualizargestionhabitacion = "Update tbl_GestionHabitacion set Codigoempleado=@Codigoempleado , Codigohabitacion=@Codigohabitacion, Tipogestion=@Tipogestion, Fechagestion=@Fechagestion, Estado=@Estado, FechaAuditoria=@FechaAuditoria, UsuarioAuditoria=@UsuarioAuditoria where Codigogestionhabitaciones=@Codigogestionhabitaciones";
            SqlCommand cmd = new SqlCommand(QueryActualizargestionhabitacion, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Codigogestionhabitaciones", Codigogestionhabitaciones);
            cmd.Parameters.AddWithValue("@Codigoempleado", Codigoempleado);
            cmd.Parameters.AddWithValue("@Codigohabitacion", Codigohabitacion);
            cmd.Parameters.AddWithValue("@Tipogestion", Tipogestion);
            cmd.Parameters.AddWithValue("@Fechagestion", Fechagestion);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
        public void MtdEliminargestionhabitaciones(int Codigogestionhabitaciones)
        {
            string QueryEliminargestionhabitacion = "Delete tbl_GestionHabitacion where Codigogestionhabitaciones=@Codigogestionhabitaciones";
            SqlCommand cmd = new SqlCommand(QueryEliminargestionhabitacion, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Codigogestionhabitaciones", Codigogestionhabitaciones);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
    }
}
