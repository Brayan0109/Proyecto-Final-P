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
    internal class CDpagocita
    {
        CDConexion cd_conexion = new CDConexion();

        public List<dynamic> MtdListaCitas()
        {
            List<dynamic> ListaCitas = new List<dynamic>();
            string QueryListaCitas = "Select CodigoCitas from tbl_Empleados";
            SqlCommand cmd = new SqlCommand(QueryListaCitas, cd_conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListaCitas.Add(new
                {
                    Value = reader["CodigoCitas"],
                    Text = $"{reader["CodigoCitas"]}"
                });
            }

            cd_conexion.MtdCerrarConexion();
            return ListaCitas;
        }
        public DataTable MtdConsultarPagocitas()
        {
            string QueryConsultarPagocitas = "Select * from tbl_PagoCitas";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarPagocitas, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }
        public void MtdAgregarPagoCita(int Codigocita, int Montocita, double Impuestos, double Descuentos, double Totalpago, DateTime Fechapago, string Tipopago, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string QueryAgregarPagocitas = "Insert into tbl_PagoCitas(Codigocita,Montocita,Impuestos, Descuentos,  Totalpago,Fechapago,Tipopago, FechaAuditoria, UsuarioAuditoria) values (@Codigocita, @Montocita, @Impuestos, @Descuentos, @Totalpago,Fechapago,Tipopago, @FechaAuditoria, @UsuarioAuditoria)";
            SqlCommand cmd = new SqlCommand(QueryAgregarPagocitas, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Codigocita", Codigocita);
            cmd.Parameters.AddWithValue("@Montocita", Montocita);
            cmd.Parameters.AddWithValue("@Impuestos", Impuestos);
            cmd.Parameters.AddWithValue("@Descuentos", Descuentos);
            cmd.Parameters.AddWithValue("@Totalpago", Totalpago);
            cmd.Parameters.AddWithValue("@Fechapago", Fechapago);
            cmd.Parameters.AddWithValue("@Tipopago", Tipopago);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
        public void MtdActualizarPagocitas(int CodigoPagocitas, int Codigocita, int Montocita, double Impuestos, double Descuentos,double Totalpago,DateTime Fechapago, string Tipopago, DateTime FechaAuditoria, string UsuarioAuditoria)
        {
            string QueryActualizarPagocitas = "Update tbl_PagoCitas set Codigocita=@Codigocita , Montocita=@Montocita, Impuestos=@Impuestos, Descuentos=@Descuentos, Totalpago=@Totalpago, Fechapago=@Fechapago, Tipopago=@Tipopago FechaAuditoria=@FechaAuditoria, UsuarioAuditoria=@UsuarioAuditoria where CodigoPagocitas=@CodigoPagocitas";
            SqlCommand cmd = new SqlCommand(QueryActualizarPagocitas, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoUsuario", CodigoPagocitas);
            cmd.Parameters.AddWithValue("@Codigocita", Codigocita);
            cmd.Parameters.AddWithValue("@Montocita", Montocita);
            cmd.Parameters.AddWithValue("@Impuestos", Impuestos);
            cmd.Parameters.AddWithValue("@Descuentos", Descuentos);
            cmd.Parameters.AddWithValue("@Totalpago", Totalpago);
            cmd.Parameters.AddWithValue("@Fechapago", Fechapago);
            cmd.Parameters.AddWithValue("@Tipopago", Tipopago);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
        public void MtdEliminarPagoCitas(int CodigoPagoCita)
        {
            string QueryEliminarPagocitas = "Delete tbl_PagoCitas where CodigoPagoCita=@CodigoPagoCita";
            SqlCommand cmd = new SqlCommand(QueryEliminarPagocitas, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoPagoCita", CodigoPagoCita);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
    }
}
