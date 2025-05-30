using sistema_Hospital.Datos;
using sistema_Hospital.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_Hospital.Pesentacion
{
    public partial class FrmCitas : Form
    {
        CDCitas cd_Citas =new CDCitas();
        CLCitas Cl_Citas=new CLCitas();
        public FrmCitas()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void MtdMostrarListaempleados()
        {
            var ListaEmpleados = cd_Citas.MtdListaEmpleados();

            foreach (var Empleados in ListaEmpleados)
            {
                cboxCodigoEmpleado.Items.Add(Empleados);
            }

            cboxCodigoEmpleado.DisplayMember = "Text";
            cboxCodigoEmpleado.ValueMember = "Value";
        }

        private void Citas_Load(object sender, EventArgs e)
        {
            lblFechaHoy.Text = Cl_Citas.MtdFechaHoy().ToString();
            MtdMostrarListaempleados();
            MtdConsultarUsuario();
        }
        private void MtdConsultarUsuario()
        {
            DataTable Dt = cd_Citas.MtdConsultaCitas();
            dgvCitas.DataSource = Dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboxCodigoEmpleado.Text) || string.IsNullOrEmpty(txtCodigoCitas.Text) || string.IsNullOrEmpty(cboxCodigoPaciente.Text) || string.IsNullOrEmpty(txtCostoT.Text) ||
                  string.IsNullOrEmpty(cboxEstado.Text))
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int CodigoPaciente = (int)((dynamic)cboxCodigoPaciente.SelectedItem).Value;
                    int Codigoempleado = (int)((dynamic)cboxCodigoEmpleado.SelectedItem).Value;
                    DateTime FechaIngreso = DtpFechaIngreso.Value;
                    DateTime FechaEgreso = dtpFechaEgreso.Value;
                    string costoH =txtCostoH.Text;
                    string CostoT = txtCostoT.Text;
                    string Estado = cboxEstado.Text;
                    DateTime FechaAuditoria = Cl_Citas.MtdFechaHoy();
                    string UsuarioAuditoria = "DESKTOP-M60V2AT";

                    cd_Citas.MtdAgregarCitas(Codigoempleado, CodigoPaciente, FechaIngreso, FechaEgreso, CostoT, costoH, UsuarioAuditoria, Estado, FechaAuditoria);
                    MessageBox.Show("Usuario agregado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarUsuario();
                    MtdLimpiarCampos();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboxCodigoEmpleado.Text) || string.IsNullOrEmpty(txtCodigoCitas.Text) || string.IsNullOrEmpty(cboxCodigoPaciente.Text) || string.IsNullOrEmpty(txtCostoT.Text) ||
                 string.IsNullOrEmpty(cboxEstado.Text))
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int CodigoPaciente = (int)((dynamic)cboxCodigoPaciente.SelectedItem).Value;
                    int Codigoempleado = (int)((dynamic)cboxCodigoEmpleado.SelectedItem).Value;
                    DateTime FechaIngreso = DtpFechaIngreso.Value;
                    DateTime FechaEgreso = dtpFechaEgreso.Value;
                    string costoH = txtCostoH.Text;
                    string CostoT = txtCostoT.Text;
                    string Estado = cboxEstado.Text;
                    DateTime FechaAuditoria = Cl_Citas.MtdFechaHoy();
                    string UsuarioAuditoria = "DESKTOP-M60V2AT";

                    cd_Citas.MtdAgregarCitas(Codigoempleado, CodigoPaciente, FechaIngreso, FechaEgreso, CostoT, costoH, UsuarioAuditoria, Estado, FechaAuditoria);
                    MessageBox.Show("Usuario agregado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarUsuario();
                    MtdLimpiarCampos();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }

        private void dgvCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSeleccionada = dgvCitas.SelectedRows[0];

            if (FilaSeleccionada.Index == dgvCitas.RowCount - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtCodigoCitas.Text = dgvCitas.SelectedCells[0].Value.ToString();
                cboxCodigoPaciente.Text = dgvCitas.SelectedCells[1].Value.ToString();
                cboxCodigoEmpleado.Text = dgvCitas.SelectedCells[2].Value.ToString();
                DtpFechaIngreso.Text = dgvCitas.SelectedCells[3].Value.ToString();
                dtpFechaEgreso.Text = dgvCitas.SelectedCells[4].Value.ToString();
                txtCostoT.Text = dgvCitas.SelectedCells[5].Value.ToString();
                txtCostoH.Text = dgvCitas.SelectedCells[6].Value.ToString();
                cboxEstado.Text = dgvCitas.SelectedCells[8].Value.ToString();
              

                //cboxCodigoCategoria.Text = dgvMedicamentos.SelectedCells[6].Value.ToString();
                int Codigoempleado = (int)dgvCitas.SelectedCells[1].Value;
                foreach (var codigoem in cboxCodigoEmpleado.Items)
                {
                    if (((dynamic)codigoem).Value == Codigoempleado)
                    {
                        cboxCodigoEmpleado.SelectedItem = codigoem;
                        //break;
                    }
                }

            }
        }

        private void dgvCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigoCitas.Text == "")
                {
                    MessageBox.Show("No hay fila seleccionada ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    int FilaSeleccionada = dgvCitas.CurrentRow.Index;
                    dgvCitas.Rows.RemoveAt(FilaSeleccionada);
                    MessageBox.Show("Fila eliminada", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void MtdLimpiarCampos()
        {

            txtCodigoCitas.Text = "";
            cboxCodigoPaciente.Text = "";
            cboxCodigoEmpleado.Text = "";
            DtpFechaIngreso.Text = "";
            dtpFechaEgreso.Text = "";
            txtCostoT.Text = "";
            txtCostoH.Text = "";
            cboxEstado.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }
    }
}