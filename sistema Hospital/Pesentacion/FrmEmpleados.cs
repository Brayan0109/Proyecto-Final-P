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

namespace sistema_Hospital
{
    public partial class FrmEmpleados : Form
    {
        CDConexion cd_conexion = new CDConexion();
        CDEmpleados cd_Empleados = new CDEmpleados();
        CLEmpleados cl_empleados = new CLEmpleados();
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            lblFechaActual.Text = cl_empleados.MtdFechaHoy().ToString();
            MtdConsultarCitas();
        }
        private void MtdConsultarCitas()
        {
            DataTable Dt = cd_Empleados.MtdConsultarEmpleados();
            dgvEmpleados.DataSource = Dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(cboxTipoTrabajo.Text) || string.IsNullOrEmpty(txtEspecialidad.Text) || string.IsNullOrEmpty(cboxEstado.Text) ||
                 string.IsNullOrEmpty(cboxEstado.Text))
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string Nombre =txtNombre.Text;
                    string Tipo =cboxTipoTrabajo.Text;
                    string Especialidad = txtEspecialidad.Text;
                    double Sueldo = cl_empleados.MtdSalario(Tipo);
                    DateTime FechaFecha = DtpFechaVencimiento.Value;

                    string Estado = cboxEstado.Text;
                    DateTime FechaAuditoria = dtpFechaAuditoria.Value;
                    string UsuarioAuditoria = cboxUsuarioAuditoria.Text;

                    cd_Empleados.MtdAgregarEmpleados(Nombre, Tipo, Especialidad, Sueldo, FechaFecha, Estado,  UsuarioAuditoria, FechaAuditoria);
                    MessageBox.Show("Usuario agregado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarCitas();
                    MtdLimpiar();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
        }

        private void cboxTipoTrabajo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboxTipoTrabajo.Text))
            {
                MessageBox.Show("Seleccione una descripcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblSueldo.Text = cl_empleados.MtdSalario(cboxTipoTrabajo.Text).ToString("c");
            }
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
              var FilaSeleccionada = dgvEmpleados.SelectedRows[0];

            if (FilaSeleccionada.Index == dgvEmpleados.RowCount - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtCodigoEmpleado.Text = dgvEmpleados.SelectedCells[0].Value.ToString();
                txtNombre.Text = dgvEmpleados.SelectedCells[1].Value.ToString();
                cboxTipoTrabajo.Text = dgvEmpleados.SelectedCells[2].Value.ToString();
                txtEspecialidad.Text = dgvEmpleados.SelectedCells[3].Value.ToString();
                lblSueldo.Text = dgvEmpleados.SelectedCells[4].Value.ToString();
                DtpFechaVencimiento.Text = dgvEmpleados.SelectedCells[5].Value.ToString();
                cboxEstado.Text = dgvEmpleados.SelectedCells[6].Value.ToString();
                dtpFechaAuditoria.Text = dgvEmpleados.SelectedCells[8].Value.ToString();
                cboxUsuarioAuditoria.Text = dgvEmpleados.SelectedCells[7].Value.ToString();


            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(cboxTipoTrabajo.Text) || string.IsNullOrEmpty(txtEspecialidad.Text) || string.IsNullOrEmpty(cboxEstado.Text) ||
                 string.IsNullOrEmpty(cboxEstado.Text))
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string Nombre = txtNombre.Text;
                    string Tipo = cboxTipoTrabajo.Text;
                    string Especialidad = txtEspecialidad.Text;
                    double Sueldo = cl_empleados.MtdSalario(Tipo);
                    DateTime FechaFecha = DtpFechaVencimiento.Value;

                    string Estado = cboxEstado.Text;
                    DateTime FechaAuditoria = dtpFechaAuditoria.Value;
                    string UsuarioAuditoria = cboxUsuarioAuditoria.Text;

                    cd_Empleados.MtdActualizarEmpleados(Nombre, Tipo, Especialidad, Sueldo, FechaFecha, Estado, UsuarioAuditoria, FechaAuditoria);
                    MessageBox.Show("Usuario agregado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarCitas();
                    MtdLimpiar();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigoEmpleado.Text == "")
                {
                    MessageBox.Show("No hay fila seleccionada ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    int FilaSeleccionada = dgvEmpleados.CurrentRow.Index;
                    dgvEmpleados.Rows.RemoveAt(FilaSeleccionada);
                    MessageBox.Show("Fila eliminada", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MtdLimpiar();

        }
        public void MtdLimpiar()
        {
            txtCodigoEmpleado.Text = "";
            txtNombre.Text = "";
            cboxTipoTrabajo.Text = "";
            txtEspecialidad.Text = "";
            lblSueldo.Text = "";
            DtpFechaVencimiento.Text = "";
            cboxEstado.Text = "";
            dtpFechaAuditoria.Text = "";
            cboxUsuarioAuditoria.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}