using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistema_Hospital.Logica;
using sistema_Hospital.Datos;

namespace Habitaciones.Datos
{
    internal class CDHabitacion
    {
        CDConexion cd_conexion = new CDConexion();
        public DataTable MtdConsultarCodigoHabitacion()
        {
            string QueryConsultarMedicamentos = "Select * from  tbl_Habitaciones";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarMedicamentos, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }
        //aqui es para agregar 
        public void MtdAgregarHabitaciones(string Numero, string Ubicacion, string TipoHabitacion, double Costo, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string QueryAgregarHabitaciones = "Insert into tbl_Habitaciones(Numero, Ubicacion, TipoHabitacion, Costo, Estado, UsuarioAuditoria, FechaAuditoria) values (@Numero, @Ubicacion, @TipoHabitacion, @Costo, @Estado, @UsuarioAuditoria, @FechaAuditoria)";
            SqlCommand cmd = new SqlCommand(QueryAgregarHabitaciones, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Numero", Numero);
            cmd.Parameters.AddWithValue("@Ubicacion", Ubicacion);
            cmd.Parameters.AddWithValue("@TipoHabitacion", TipoHabitacion);
            cmd.Parameters.AddWithValue("@Costo", Costo);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);

            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
        //Aqui es para editar
        public void MtdActualizarHabitaciones(int CodigoHabitacion, int Numero, string TipoHubicacion, double Costo, string Estado, double Ubicacion, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string QueryActualizarUsuario = "Update tbl_Usuarios set CodigoHabitacion=@CodigoHabitacion , Numero=@Numero, Costo=@Costo, Estado=@Estado,@Ubicacion, FechaAuditoria=@FechaAuditoria, UsuarioAuditoria=@UsuarioAuditoria where CodigoHabitacion=@CodigoHabitacion";
            SqlCommand cmd = new SqlCommand(QueryActualizarUsuario, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoHabitacion", CodigoHabitacion);
            cmd.Parameters.AddWithValue("@Numero", Numero);
            cmd.Parameters.AddWithValue("@TipoHubicacion", TipoHubicacion);
            cmd.Parameters.AddWithValue("@Costo", Costo);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@Ubicacion", Ubicacion);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
           
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
        public void MtdEliminarHabitaciones(int Codigohabitaciones)
        {
            string QueryEliminarHabitaciones = "Delete tbl_Habitaciones where CodigoHabitacion=@CodigoHabitacion";
            SqlCommand cmd = new SqlCommand(QueryEliminarHabitaciones, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoHabitacion", Codigohabitaciones);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
    }
}

    
