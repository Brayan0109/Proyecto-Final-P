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
    internal class CDusuario
    {
        CDConexion cd_conexion = new CDConexion();
    //Aca se esta llamando a la tabla de empleados para que de el codigo
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
        //Aca se esta consultando con la taba usuario
        public DataTable MtdConsultarUsuario()
        {
            string QueryConsultarUsuario = "Select * from tbl_Usuarios";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarUsuario, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }
        //Aca se esta agregand las tablas a la tabla usuario
        public void MtdAgregarUsuario(int Codigoempleado, string Usuario, double Clave, string TipoUsuario, string Estado, string UsuarioAuditoria,   DateTime FechaAuditoria)
        {
            string QueryAgregarUsuario = "Insert into tbl_Usuarios(Codigoempleado,Usuario,Clave, TipoUsuario,  Estado, FechaAuditoria, UsuarioAuditoria) values (@Codigoempleado, @Usuario, @Clave, @TipoUsuario, @Estado, @FechaAuditoria, @UsuarioAuditoria)";
            SqlCommand cmd = new SqlCommand(QueryAgregarUsuario, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Codigoempleado", Codigoempleado);
            cmd.Parameters.AddWithValue("@Usuario", Usuario);
            cmd.Parameters.AddWithValue("@Clave", Clave);
            cmd.Parameters.AddWithValue("@TipoUsuario", TipoUsuario);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
        //Aca se esta acyualizando la tabla usuario cada vez que se le de editar
        public void MtdActualizarUsuario(int CodigoUsuario, int Codigoempleado, string Usuario, double Clave, string TipoUsuario, string Estado, DateTime FechaAuditoria, string UsuarioAuditoria)
        {
            string QueryActualizarUsuario = "Update tbl_Usuarios set Codigoempleado=@Codigoempleado , Usuario=@Usuario, Clave=@Clave, TipoUsuario=@TipoUsuario, Estado=@Estado, FechaAuditoria=@FechaAuditoria, UsuarioAuditoria=@UsuarioAuditoria where CodigoUsuario=@CodigoUsuario";
            SqlCommand cmd = new SqlCommand(QueryActualizarUsuario, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoUsuario", CodigoUsuario);
            cmd.Parameters.AddWithValue("@Codigoempleado", Codigoempleado);
            cmd.Parameters.AddWithValue("@Usuario", Usuario);
            cmd.Parameters.AddWithValue("@Clave", Clave);
            cmd.Parameters.AddWithValue("@TipoUsuario", TipoUsuario);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
        //Aca se estan eliminando los campos de la tabla usuario
        public void MtdEliminarUsuario(int CodigoUsuario)
        {
            string QueryEliminarUsuario = "Delete tbl_Usuarios where CodigoUsuario=@CodigoUsuario";
            SqlCommand cmd = new SqlCommand(QueryEliminarUsuario, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoUsuario", CodigoUsuario);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
    }
}
