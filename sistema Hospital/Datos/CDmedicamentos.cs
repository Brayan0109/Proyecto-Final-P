using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistema_Hospital.Datos;

namespace Sistema_Proyecto
{
    internal class CDmedicamentos
    {
        CDConexion cd_conexion = new CDConexion();


        public DataTable MtdConsultarMedicamentos()
        {
            string QueryConsultarMedicamento = "Select * from tbl_Medicamentos";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarMedicamento, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }
        public void MtdAgregarMedicamento(string Nombre, string Tipomedicamento, double Costo, double Stock, DateTime Fechavencimiento, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string QueryAgregarMedicamento = "Insert into tbl_Medicamentos(Nombre,Tipomedicamento,Costo, Stock, Fechavencimiento,  Estado, FechaAuditoria, UsuarioAuditoria) values (@Nombre, @Tipomedicamento, @Costo, @Stock, @Fechavencimiento, @Estado, @FechaAuditoria, @UsuarioAuditoria)";
            SqlCommand cmd = new SqlCommand(QueryAgregarMedicamento, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Tipomedicamento", Tipomedicamento);
            cmd.Parameters.AddWithValue("@Costo", Costo);
            cmd.Parameters.AddWithValue("@Stock", Stock);
            cmd.Parameters.AddWithValue("@Fechavencimiento", Fechavencimiento);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
        public void MtdActualizarMedicamento(int Codigomedicamento, string Nombre, string Tipomedicamento, double Costo, double Stock, DateTime Fechavencimiento, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string QueryActualizarMedicamento = "Update tbl_Medicamentos set Nombre=@Nombre , Tipomedicamento=@Tipomedicamento, Costo=@Costo, Stock=@Stock, Fechavencimiento=@Fechavencimiento, Estado=@Estado, FechaAuditoria=@FechaAuditoria, UsuarioAuditoria=@UsuarioAuditoria where Codigomedicamento=@Codigomedicamento";
            SqlCommand cmd = new SqlCommand(QueryActualizarMedicamento, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Codigomedicamento", Codigomedicamento);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Tipomedicamento", Tipomedicamento);
            cmd.Parameters.AddWithValue("@Costo", Costo);
            cmd.Parameters.AddWithValue("@Stock", Stock);
            cmd.Parameters.AddWithValue("@Fechavencimiento", Fechavencimiento);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
        public void MtdEliminarMedicamentos(int Codigomedicamento)
        {
            string QueryEliminarMedicamentos = "Delete tbl_Medicamentos where Codigomedicamento=@Codigomedicamento";
            SqlCommand cmd = new SqlCommand(QueryEliminarMedicamentos, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoUsuario", Codigomedicamento);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
    }
}
