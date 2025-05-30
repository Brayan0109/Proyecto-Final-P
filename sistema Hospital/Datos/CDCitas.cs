using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_Hospital.Datos
{
    public class CDCitas
    {
        CDConexion cd_conexion = new CDConexion();
        public List<dynamic> MtdListaProveedores()
        {
            List<dynamic> ListaProveedores = new List<dynamic>();
            string QueryListaProveedores = "Select CodigoPaciente , Nombre from tbl_citas";
            SqlCommand cmd = new SqlCommand(QueryListaProveedores, cd_conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListaProveedores.Add(new
                {
                    Value = reader["CodigoProveedor"],
                    Text = $"{reader["CodigoProveedor"]} - {reader["Nombre"]}"
                });
            }

            cd_conexion.MtdCerrarConexion();
            return ListaProveedores;
        }

        public List<dynamic> MtdListaEmpleados()
        {
            List<dynamic> ListaEmpleados = new List<dynamic>();
            string QueryListaEmpleados = "Select CodigoEmleado , Nombres from tbl_Empleados";
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


        public List<dynamic> MtdCostoCitas()
        {
            List<dynamic> ListaProveedores = new List<dynamic>();
            string QueryListaProveedores = "Select CodigoEmleado , Nombres from tbl_Empleados";
            SqlCommand cmd = new SqlCommand(QueryListaProveedores, cd_conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListaProveedores.Add(new
                {
                    Value = reader["CodigoEmleado"],
                    Text = $"{reader["CodigoEmleado"]} - {reader["Nombre"]}"
                });
            }

            cd_conexion.MtdCerrarConexion();
            return ListaProveedores;
        }

        public DataTable MtdConsultaCitas()
        {
            string QueryConsultarCitas = "Select * from tbl_Citas";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarCitas, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }
        public void MtdAgregarCitas( int  CodigoPaciente, double CodigoEmpleado, DateTime FechaIngreso, DateTime FechaEgreso, string CostoTratamiento, string CostoHabitacion, string UsuarioAuditoria, string Estado, DateTime FechaAuditoria)
        {
            string QueryAgregarMedicamentos = "Insert into tbl_medicamentos(CodigoCitas,CodigoPaciente,CodigoEmpleado, FechaIngreso, FechaEgreso, CostoTratamiento, CostoHabitacion, UsuarioAuditoria, FechaAuditoria) values (@CodigoCitas,@CodigoPaciente,@CodigoEmpleado, @FechaIngreso, @FechaEgreso, @CostoTratamiento, @CostoHabitacion, @UsuarioAuditoria,@FechaAuditoria)";
            SqlCommand cmd = new SqlCommand(QueryAgregarMedicamentos, cd_conexion.MtdAbrirConexion());
            
            cmd.Parameters.AddWithValue("@CodigoPaciente", CodigoPaciente);
            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            cmd.Parameters.AddWithValue("@FechaIngreso", FechaIngreso);
            cmd.Parameters.AddWithValue("@FechaEgreso", FechaEgreso);
            cmd.Parameters.AddWithValue("@CostoTratamiento", CostoTratamiento);
            cmd.Parameters.AddWithValue("@CostoHabitacion", CostoHabitacion);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdActualizarCitas(string CodigoCitas, string CodigoPaciente, double CodigoEmpleado, DateTime FechaIngreso, DateTime FechaEgreso, int CostoTratamiento, int CostoHabitacion, string UsuarioAuditoria, string Estado, DateTime FechaAuditoria)
        {

            string QueryActualizarMedicamentos = "Update tbl_Citas set CodigoCitas=@CodigoCitas, CodigoPaciente=@CodigoPaciente, CodigoEmpleado=@CodigoEmpleado, FechaIngreso=@FechaIngreso, FechaEgreso=@FechaEgreso, CostoTratamiento=@CostoTratamiento, CostoHabitacion=@CostoHabitacion, UsuarioAuditoria=@UsuarioAuditoria, FechaAuditoria=@FechaAuditoria where CodigoMedicamento=@CodigoMedicamento";
            SqlCommand cmd = new SqlCommand(QueryActualizarMedicamentos, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoCitas", CodigoCitas);
            cmd.Parameters.AddWithValue("@CodigoPaciente", CodigoPaciente);
            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            cmd.Parameters.AddWithValue("@FechaIngreso", FechaIngreso);
            cmd.Parameters.AddWithValue("@FechaEgreso", FechaEgreso);
            cmd.Parameters.AddWithValue("@CostoTratamiento", CostoTratamiento);
            cmd.Parameters.AddWithValue("@CostoHabitacion", CostoHabitacion);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdEliminarMedicamentos(int CodigoMedicamento)
        {
            string QueryEliminarMedicamentos = "Delete tbl_medicamentos where CodigoMedicamento=@CodigoMedicamento";
            SqlCommand cmd = new SqlCommand(QueryEliminarMedicamentos, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoMedicamento", CodigoMedicamento);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

    }
}
