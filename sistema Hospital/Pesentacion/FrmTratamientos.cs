using SistemaHospital.Datos;
using SistemaHospital.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHospital.Presentacion
{
    public partial class FrmTratamientos : Form
    {
        CDtratamientos cd_tratamientos = new CDtratamientos();
        CLtratamientos cl_tratamientos = new CLtratamientos();

        public FrmTratamientos()
        {
            InitializeComponent();
        }
        private void FrmTratamientos_Load(object sender, EventArgs e)
        {
            lblFecha.Text = cl_tratamientos.MtdFechaActual().ToString("dd/MM/yyyy");
            MtdMostrarListaCitas();
            MtdMostrarListaMedicamentos();
            MtdConsultarTratamientos();
        }

        private void MtdMostrarListaCitas()
        {
            var ListaCitas = cd_tratamientos.MtdListaCitas();

            foreach (var citas in ListaCitas)
            {
                cboxCodigoCita.Items.Add(citas);
            }

            cboxCodigoCita.DisplayMember = "Text";
            cboxCodigoCita.ValueMember = "Value";
        }

   
        private void MtdMostrarListaMedicamentos()
        {
            var ListaMedicamentos = cd_tratamientos.MtdListaMedicamentos();
            cboxCodigoMedicamento.Items.Clear();

            foreach (var medicamento in ListaMedicamentos)
            {
                cboxCodigoMedicamento.Items.Add(medicamento);
            }
            cboxCodigoMedicamento.DisplayMember = "Text";
            cboxCodigoMedicamento.ValueMember = "Value";
        }

      
        private void cboxCodigoMedicamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedMedicamento = (dynamic)cboxCodigoMedicamento.SelectedItem;
            int codigoMedicamento = (int)selectedMedicamento.Value;
            txtCosto.Text = cl_tratamientos.MtdConsultaCostoMedicamento(codigoMedicamento).ToString();
        }

       
        private void MtdConsultarTratamientos()
        {
            DataTable Dt = cd_tratamientos.MtdConsultarTratamientos();
            dgvTratamientos.DataSource = Dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboxCodigoCita.Text) || string.IsNullOrEmpty(cboxCodigoMedicamento.Text) || string.IsNullOrEmpty(txtCosto.Text) ||
                string.IsNullOrEmpty(DtpFechaTratamiento.Text) || string.IsNullOrEmpty(cboxEstado.Text) )
            {
                MessageBox.Show("Favor completar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    var SelectedCita = (dynamic)cboxCodigoCita.SelectedItem;
                    int CodigoCita= (int)SelectedCita.Value;

                    var SelectedMedicamento = (dynamic)cboxCodigoMedicamento.SelectedItem;
                    int CodigoMedicamento= (int)SelectedMedicamento.Value;

                    double Costo= double.Parse(txtCosto.Text);
                    DateTime FechaTratamiento = DtpFechaTratamiento.Value;
                    string Estado = cboxEstado.Text;
                    string UsuarioAuditoria = "Emorales";
                    DateTime FechaAuditoria= cl_tratamientos.MtdFechaActual();

                    cd_tratamientos.MtdAgregarTratamientos(CodigoCita, CodigoMedicamento, Costo, FechaTratamiento, Estado, UsuarioAuditoria, FechaAuditoria);
                    MessageBox.Show("Tratamiento agregado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarTratamientos();
                    MtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


        private void MtdLimpiarCampos()
        {
            txtCodigoTratamiento.Text = "";
            cboxCodigoCita.Text = "";
            cboxCodigoMedicamento.Text = "";
            txtCosto.Text = "";
            DtpFechaTratamiento.Text = "";
            cboxEstado.Text = "";
        }

        private void dgvTratamientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSeleccionada = dgvTratamientos.SelectedRows[0];

            if (FilaSeleccionada.Index == dgvTratamientos.RowCount - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoCitaSelected = Convert.ToInt32(dgvTratamientos.CurrentRow.Cells[1].Value);
                cboxCodigoCita.Text = cd_tratamientos.MtdListaCitaDgv(CodigoCitaSelected).ToList()[0].Text;

                int CodigoMedicamentoSelected = Convert.ToInt32(dgvTratamientos.CurrentRow.Cells[2].Value);
                cboxCodigoMedicamento.Text = cd_tratamientos.MtdListaMedicamentoDgv(CodigoMedicamentoSelected).ToList()[0].Text;

                txtCodigoTratamiento.Text = dgvTratamientos.CurrentRow.Cells[0].Value.ToString();
                txtCosto.Text = dgvTratamientos.CurrentRow.Cells[3].Value.ToString();
                DtpFechaTratamiento.Text = dgvTratamientos.CurrentRow.Cells[4].Value.ToString();
                cboxEstado.Text = dgvTratamientos.CurrentRow.Cells[5].Value.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboxCodigoCita.Text) || string.IsNullOrEmpty(cboxCodigoMedicamento.Text) || string.IsNullOrEmpty(txtCosto.Text) || string.IsNullOrEmpty(cboxEstado.Text) )
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    var SelectedCita = (dynamic)cboxCodigoCita.SelectedItem;
                    int CodigoCita = (int)SelectedCita.Value;

                    var SelectedMedicamento = (dynamic)cboxCodigoMedicamento.SelectedItem;
                    int CodigoMedicamento = (int)SelectedMedicamento.Value;

                    double Costo = double.Parse(txtCosto.Text);
                    DateTime FechaTratamiento = DtpFechaTratamiento.Value;
                    string Estado = cboxEstado.Text;
                    string UsuarioAuditoria = "Oconer";
                    DateTime FechaAuditoria = cl_tratamientos.MtdFechaActual();


                    cd_tratamientos.MtdActualizarTratamientos(CodigoCita, CodigoMedicamento, Costo, FechaTratamiento, Estado, UsuarioAuditoria, FechaAuditoria);
                    MessageBox.Show("gestion habitacion Actualizado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarTratamientos();
                    MtdLimpiarCampos();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
