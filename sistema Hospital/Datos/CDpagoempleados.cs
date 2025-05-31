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
    internal class CDpagoempleados
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
        public DataTable MtdConsultarPagoempleados()
        {
            string QueryConsultarPagoempleados = "Select * from tbl_PagoEmpleados";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarPagoempleados, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }
        public void MtdAgregarPagoempleados(int Codigoempleado, DateTime Fechapago, double Sueldo,double Bono, int MontoHorasE,  double TotalMonto, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string QueryAgregarUsuario = "Insert into tbl_PagoEmpleados(CodigoEmpleado, Fechapago, Sueldo, Bono,MontoHorasE, TotalMonto,  Estado, FechaAuditoria, UsuarioAuditoria) values (@CodigoEmpleado, @Fechapago, @Sueldo,@Bono,@MontoHorasE,  @TotalMonto, @Estado, @FechaAuditoria, @UsuarioAuditoria)";
            SqlCommand cmd = new SqlCommand(QueryAgregarUsuario, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoEmpleado", Codigoempleado);
            cmd.Parameters.AddWithValue("@Fechapago", Fechapago);
            cmd.Parameters.AddWithValue("@Sueldo", Sueldo);
            cmd.Parameters.AddWithValue("@Bono", Bono);
            cmd.Parameters.AddWithValue("@MontoHorasE", MontoHorasE);
            cmd.Parameters.AddWithValue("@TotalMonto", TotalMonto);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
        public void MtdActualizarPagoempleados(int Codigopago, int Codigoempleado, DateTime Fechapago, double Sueldo,double Bono,int MontoHorasE,  double TotalMonto, string Estado, DateTime FechaAuditoria, string UsuarioAuditoria)
        {
            string QueryActualizarUsuario = "Update tbl_PagoEmpleados set CodigoEmpleado=@CodigoEmpleado ,FechaPago=@FechaPago,  Sueldo=@Sueldo,Bono=@Bono,MontoHorasE=@MontoHorasE ,TotalMonto=@TotalMonto, Estado=@Estado, FechaAuditoria=@FechaAuditoria, UsuarioAuditoria=@UsuarioAuditoria where Codigopago=@Codigopago";
            SqlCommand cmd = new SqlCommand(QueryActualizarUsuario, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Codigopago", Codigopago);
            cmd.Parameters.AddWithValue("@CodigoEmpleado", Codigoempleado);
            cmd.Parameters.AddWithValue("@FechaPago", Fechapago);
            cmd.Parameters.AddWithValue("@Sueldo", Sueldo);
            cmd.Parameters.AddWithValue("@Bono", Bono);
            cmd.Parameters.AddWithValue("@MontoHorasE", MontoHorasE);
            cmd.Parameters.AddWithValue("@TotalMonto", TotalMonto);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
        public void MtdEliminarPagoEmpleados(int Codigopago)
        {
            string QueryEliminarPagoempleados = "Delete tbl_PagoEmpleados where Codigopago=@Codigopago";
            SqlCommand cmd = new SqlCommand(QueryEliminarPagoempleados, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Codigopago", Codigopago);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

    }
}
