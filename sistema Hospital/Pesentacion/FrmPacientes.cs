using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Pacientesamy
{
    public partial class FrmPacientes : Form
    {
        CLpacientes cl_pacientes = new CLpacientes();
        CDpacientes cd_pacientes = new CDpacientes();
        public FrmPacientes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblfecha.Text=cl_pacientes.MtdFechaHoy().ToString();
            MtdMostrarListahabitaciones();
            MtdConsultargestionPacientes();
        }
        private void MtdMostrarListahabitaciones()
        {
            var ListaHabitaciones = cd_pacientes.MtdListaHabitaciones();

            foreach (var Habitacion in ListaHabitaciones)
            {
                cboxcodigohabitaciones.Items.Add(Habitacion);
            }

            cboxcodigohabitaciones.DisplayMember = "Text";
            cboxcodigohabitaciones.ValueMember = "Value";
        }
        private void MtdConsultargestionPacientes()
        {
            DataTable Dt = cd_pacientes.MtdConsultarPacientes();
            dgvpacientes.DataSource = Dt;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            MtdLimpiarCampos();
        }
        private void MtdLimpiarCampos()
        {
            txtcodigopaciente.Text = "";
            cboxcodigohabitaciones.SelectedIndex = -1;
            txtNombre.Text = "";
            txtNit.Text = "";
            dtpFechaNacimiento.Text = "";
            cboxtipopaciente.Text = "";
            cboxcodigoestado.Text = "";
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcodigopaciente.Text))
            {
                MessageBox.Show("Favor seleccionar paciente a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int Codigopaciente = (int.Parse(txtcodigopaciente.Text));

                    cd_pacientes.MtdEliminarPacientess(Codigopaciente);
                    MessageBox.Show("Paciente  eliminado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultargestionPacientes();
                    MtdLimpiarCampos();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboxcodigohabitaciones.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtNit.Text) || string.IsNullOrEmpty(dtpFechaNacimiento.Text) ||
                string.IsNullOrEmpty(cboxtipopaciente.Text) || string.IsNullOrEmpty(cboxcodigoestado.Text))
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    
                    int Codigohabitacion = (int)((dynamic)cboxcodigohabitaciones.SelectedItem).Value;
                    string Nombres = txtNombre.Text;
                    int Nit =int.Parse( txtNit.Text);
                    DateTime FechaNacimiento = dtpFechaNacimiento.Value;
                    string Tipopaciente = cboxtipopaciente.Text;
                    string Estado = cboxcodigoestado.Text;
                    DateTime FechaAuditoria = cl_pacientes.MtdFechaHoy();
                    string UsuarioAuditoria = "DESKTOP-M60V2AT";

                    cd_pacientes.MtdAgregarPacientes(Codigohabitacion,Nombres,Nit, FechaNacimiento,Tipopaciente, Estado, UsuarioAuditoria, FechaAuditoria);
                    MessageBox.Show("Paciente agregado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultargestionPacientes();
                    MtdLimpiarCampos();




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboxcodigohabitaciones.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtNit.Text) || string.IsNullOrEmpty(dtpFechaNacimiento.Text) ||
                string.IsNullOrEmpty(cboxtipopaciente.Text) || string.IsNullOrEmpty(cboxcodigoestado.Text))
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    //Ente la llave primaria se coloca esto
                    int CodigoPacientes = (int.Parse(txtcodigopaciente.Text));
                    int Codigohabitacion = (int)((dynamic)cboxcodigohabitaciones.SelectedItem).Value;
                    string Nombres = txtNombre.Text;
                    int Nit =int.Parse(txtNit.Text);
                    DateTime FechaNacimiento = dtpFechaNacimiento.Value;
                    string Tipopaciente = cboxtipopaciente.Text;
                    string Estado = cboxcodigoestado.Text;
                    DateTime FechaAuditoria = cl_pacientes.MtdFechaHoy();
                    string UsuarioAuditoria = "DESKTOP-M60V2AT";

                    cd_pacientes.MtdActualizarPacientes(CodigoPacientes,Codigohabitacion, Nombres, Nit, FechaNacimiento, Tipopaciente, Estado, UsuarioAuditoria, FechaAuditoria);
                    MessageBox.Show("gestion habitacion Actualizado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultargestionPacientes();
                    MtdLimpiarCampos();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvpacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSeleccionada = dgvpacientes.SelectedRows[0];

            if (FilaSeleccionada.Index == dgvpacientes.RowCount - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtcodigopaciente.Text = dgvpacientes.SelectedCells[0].Value.ToString();
                txtNombre.Text = dgvpacientes.SelectedCells[2].Value.ToString();
                txtNit.Text = dgvpacientes.SelectedCells[3].Value.ToString();
                dtpFechaNacimiento.Text = dgvpacientes.SelectedCells[4].Value.ToString();
                cboxtipopaciente.Text = dgvpacientes.SelectedCells[5].Value.ToString();





                int Codigohabitacion = (int)dgvpacientes.SelectedCells[1].Value;
                foreach (var codigohabitaciones in cboxcodigohabitaciones.Items)
                {
                    if (((dynamic)codigohabitaciones).Value == Codigohabitacion)
                    {
                        cboxcodigohabitaciones.SelectedItem = codigohabitaciones;
                        //break;
                    }
                }


                cboxcodigoestado.Text = dgvpacientes.SelectedCells[6].Value.ToString();





            }
        }

        private void cboxcodigohabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
