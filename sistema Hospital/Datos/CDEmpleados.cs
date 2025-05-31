using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_Hospital.Datos
{
    public class CDEmpleados
    {
        CDConexion cd_conexion = new CDConexion();
        public DataTable MtdConsultaEmpleados()
        {
            string QueryConsultarEmpleados = "Select * from tbl_Empleados";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarEmpleados, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }

        public DataTable MtdConsultarEmpleados()
        {
            string QueryConsultarMedicamentos = "Select * from tbl_Empleados";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarMedicamentos, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }
        public void MtdAgregarEmpleados(string Nombres, string TipoTrabajo, string Especialidad, double Sueldo, DateTime FechaAlta,  string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string QueryAgregarMedicamentos = "INSERT INTO tbl_Empleados( Nombres, TipoTrabajo, Especialidad, Sueldo, FechaAlta, Estado, UsuarioAuditoria, FechaAuditoria) VALUES (@Nombres, @TipoTrabajo, @Especialidad, @Sueldo, @FechaAlta, @Estado, @UsuarioAuditoria, @FechaAuditoria)";
            SqlCommand cmd = new SqlCommand(QueryAgregarMedicamentos, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Nombres", Nombres);
            cmd.Parameters.AddWithValue("@TipoTrabajo", TipoTrabajo);
            cmd.Parameters.AddWithValue("@Especialidad", Especialidad);
            cmd.Parameters.AddWithValue("@Sueldo", Sueldo);
            cmd.Parameters.AddWithValue("@FechaAlta", FechaAlta);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
        public void MtdActualizarEmpleados(string Nombres, string TipoTrabajo, string Especialidad, double Sueldo, DateTime FechaAlta, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string QueryActualizarEmpleados = "Update tbl_Empleados set Nombres=@Nombres, TipoTrabajo=@TipoTrabajo, Especialidad=@Especialidad, Sueldo=@Sueldo, FechaAlta=@FechaAlta, Estado=@Estado, UsuarioAuditoria=@UsuarioAuditoria, FechaAuditoria=@FechaAuditoria ";
            SqlCommand cmd = new SqlCommand(QueryActualizarEmpleados, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Nombres", Nombres);
            cmd.Parameters.AddWithValue("@TipoTrabajo", TipoTrabajo);
            cmd.Parameters.AddWithValue("@Especialidad", Especialidad);
            cmd.Parameters.AddWithValue("@Sueldo", Sueldo);
            cmd.Parameters.AddWithValue("@FechaAlta", FechaAlta);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
        public void MtdEliminarMedicamentos(int CodigoEmleado)
        {
            string QueryEliminarMedicamentos = "Delete tbl_Empleados where CodigoEmleado=@CodigoEmleado";
            SqlCommand cmd = new SqlCommand(QueryEliminarMedicamentos, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoEmleado", CodigoEmleado);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

    }
}
