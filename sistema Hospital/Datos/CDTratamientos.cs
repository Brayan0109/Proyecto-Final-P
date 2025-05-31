using sistema_Hospital.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHospital.Datos
{
    public  class CDtratamientos
    {

     CDConexion cd_conexion = new CDConexion();

        // Metodo que consulta el listado de Citas en la base de datos para luego llevarlos al combobox de citas
        public List<dynamic> MtdListaCitas()
        {
            List<dynamic> ListaCitas = new List<dynamic>();
            string QueryListaCitas = "Select ci.CodigoCitas CodigoCitas, pa.Nombres NombrePaciente from tbl_Citas ci inner join tbl_Pacientes pa on ci.CodigoPaciente=pa.CodigoPaciente ";
            SqlCommand cmd = new SqlCommand(QueryListaCitas, cd_conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListaCitas.Add(new
                {
                    Value = reader["CodigoCitas"],
                    Text = $"{reader["CodigoCitas"]} - {reader["NombrePaciente"]}"
                });
            }

            cd_conexion.MtdCerrarConexion();
            return ListaCitas;
        }


        // Metodo que consulta el listado de Medicamentos en la base de datos para luego llevarlos al combobox de Medicamentos  
        public List<dynamic> MtdListaMedicamentos()
        {
            List<dynamic> ListaMedicamentos = new List<dynamic>();
            string QueryListaMedicamentos = "Select CodigoMedicamento, Nombre from tbl_Medicamentos";
            SqlCommand cmd = new SqlCommand(QueryListaMedicamentos, cd_conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListaMedicamentos.Add(new
                {
                    Value = reader["CodigoMedicamento"],
                    Text = $"{reader["CodigoMedicamento"]} - {reader["Nombre"]}"
                });
            }

            cd_conexion.MtdCerrarConexion();
            return ListaMedicamentos;
        }

        // Metodo que consulta en la base de datos la Citas seleccionada en el DataGridView para luego llevarlos al combobox de citas
        public List<dynamic> MtdListaCitaDgv(int CodigoCita)
        {
            List<dynamic> ListaCitaDgv = new List<dynamic>();
            string QueryListaCitaDgv = "Select ci.CodigoCitas CodigoCitas, pa.Nombres Nombres from tbl_Citas ci inner join tbl_Pacientes pa on ci.CodigoPaciente=pa.CodigoPaciente where CodigoCitas=@CodigoCitas";
            SqlCommand cmd = new SqlCommand(QueryListaCitaDgv, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoCitas", CodigoCita);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListaCitaDgv.Add(new
                {
                    Value = reader["CodigoCitas"],
                    Text = $"{reader["CodigoCitas"]} - {reader["Nombres"]}"
                });
            }

            cd_conexion.MtdCerrarConexion();
            return ListaCitaDgv;
        }

       
        public List<dynamic> MtdListaMedicamentoDgv(int CodigoMedicamento)
        {
            List<dynamic> ListaMedicamentoDgv = new List<dynamic>();
            string QueryListaMedicamentoDgv = "Select CodigoMedicamento, Nombre from tbl_Medicamentos where CodigoMedicamento=@CodigoMedicamento ";
            SqlCommand cmd = new SqlCommand(QueryListaMedicamentoDgv, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoMedicamento", CodigoMedicamento);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListaMedicamentoDgv.Add(new
                {
                    Value = reader["CodigoMedicamento"],
                    Text = $"{reader["CodigoMedicamento"]} - {reader["Nombre"]}"
                });
            }

            cd_conexion.MtdCerrarConexion();
            return ListaMedicamentoDgv;
        }


        
        public DataTable MtdConsultarTratamientos()
        {
            string QueryConsultarTratamientos = "Select * from tbl_Tratamientos";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarTratamientos, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }

       
        public void MtdAgregarTratamientos(int CodigoCita, int CodigoMedicamento, double Costo, DateTime FechaTratamiento, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string QueryAgregarTratamientos = "Insert into tbl_Tratamientos (CodigoCita, CodigoMedicamento, Costo, FechaTratamiento, Estado, UsuarioAuditoria, FechaAuditoria) values (@CodigoCita, @CodigoMedicamento, @Costo, @FechaTratamiento, @Estado, @UsuarioAuditoria, @FechaAuditoria)";
            SqlCommand cmd = new SqlCommand(QueryAgregarTratamientos, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoCita", CodigoCita);
            cmd.Parameters.AddWithValue("@CodigoMedicamento", CodigoMedicamento);
            cmd.Parameters.AddWithValue("@Costo", Costo);
            cmd.Parameters.AddWithValue("@FechaTratamiento", FechaTratamiento);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdActualizarTratamientos(int CodigoCita, int CodigoMedicamento, double Costo, DateTime FechaTratamiento, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string QueryActualizarpacientes = "Update tbl_Tratamientos set CodigoCita=@CodigoCita , CodigoMedicamento=@CodigoMedicamento, Costo=@Costo, FechaTratamiento=@FechaTratamiento,  Estado=@Estado, UsuarioAuditoria=@UsuarioAuditoria, FechaAuditoria=@FechaAuditoria";
            SqlCommand cmd = new SqlCommand(QueryActualizarpacientes, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoCita", CodigoCita);
            cmd.Parameters.AddWithValue("@CodigoMedicamento", CodigoMedicamento);
            cmd.Parameters.AddWithValue("@Costo", Costo);
            cmd.Parameters.AddWithValue("@FechaTratamiento", FechaTratamiento);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion(); ;
        }


    }
}
