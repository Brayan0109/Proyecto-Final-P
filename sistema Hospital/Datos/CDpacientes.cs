using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistema_Hospital.Logica;
using sistema_Hospital.Datos;


namespace Pacientesamy
{
    internal class CDpacientes
    {
        CDConexion cd_conexion = new CDConexion();
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
        public DataTable MtdConsultarPacientes()
        {
            string QueryConsultarpacientes = "Select * from tbl_Pacientes";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarpacientes, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }
        public void MtdAgregarPacientes( int Codigohabitacion, string Nombres, int Nit, DateTime FechaNacimiento,string TipoPaciente, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string QueryAgregarpacientes = "Insert into tbl_Pacientes( CodigoHabitacion, Nombres, Nit, FechaNacimiento,TipoPaciente, Estado, FechaAuditoria, UsuarioAuditoria) values ( @CodigoHabitacion, @Nombres, @Nit, @FechaNacimiento, @TipoPaciente, @Estado, @FechaAuditoria, @UsuarioAuditoria)";
            SqlCommand cmd = new SqlCommand(QueryAgregarpacientes, cd_conexion.MtdAbrirConexion());
            
            cmd.Parameters.AddWithValue("@CodigoHabitacion", Codigohabitacion);
            cmd.Parameters.AddWithValue("@Nombres", Nombres);
            cmd.Parameters.AddWithValue("@Nit", Nit);
            cmd.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
            cmd.Parameters.AddWithValue("@TipoPaciente", TipoPaciente);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
        public void MtdActualizarPacientes(int CodigoPacientes,int Codigohabitacion, string Nombres, int Nit, DateTime FechaNacimiento, string TipoPaciente, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string QueryActualizarpacientes = "Update tbl_Pacientes set CodigoHabitacion=@CodigoHabitacion , Nombres=@Nombres, Nit=@Nit, FechaNacimiento=@FechaNacimiento, TipoPaciente=@TipoPaciente Estado=@Estado, FechaAuditoria=@FechaAuditoria, UsuarioAuditoria=@UsuarioAuditoria where CodigoPacientes=@CodigoPacientes";
            SqlCommand cmd = new SqlCommand(QueryActualizarpacientes, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoPacientes", CodigoPacientes);
            cmd.Parameters.AddWithValue("@CodigoHabitacion", Codigohabitacion);
            cmd.Parameters.AddWithValue("@Nombre", Nombres);
            cmd.Parameters.AddWithValue("@Nit", Nit);
            cmd.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
            cmd.Parameters.AddWithValue("@TipoPaciente", TipoPaciente);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
        public void MtdEliminarPacientess(int CodigoPacientes)
        {
            string QueryEliminarPacientes = "Delete  tbl_Pacientes where CodigoPacientes=@CodigoPacientes";
            SqlCommand cmd = new SqlCommand(QueryEliminarPacientes, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Codigogestionhabitaciones", CodigoPacientes);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
    }
}
