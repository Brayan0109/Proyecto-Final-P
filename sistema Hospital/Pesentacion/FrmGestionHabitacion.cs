using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TablaAmy
{
    public partial class FrmGestionHabitacion : Form
    {
        CLgestionhabitaciones cl_gestionhabitaciones = new CLgestionhabitaciones();
        CDgestionhabitaciones cd_gestionhabitaciones = new CDgestionhabitaciones();
        public FrmGestionHabitacion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblfecha.Text=cl_gestionhabitaciones.MtdFechaHoy().ToString();
            MtdMostrarListaempleados();
            MtdMostrarListahabitaciones();
        }
        private void MtdMostrarListaempleados()
        {
            var ListaEmpleados = cd_gestionhabitaciones.MtdListaEmpleados();

            foreach (var Empleados in ListaEmpleados)
            {
                cboxcodigoempleado.Items.Add(Empleados);
            }

            cboxcodigoempleado.DisplayMember = "Text";
            cboxcodigoempleado.ValueMember = "Value";
        }
        private void MtdMostrarListahabitaciones()
        {
            var ListaHabitaciones = cd_gestionhabitaciones.MtdListaHabitaciones();

            foreach (var Habitacion in ListaHabitaciones)
            {
                cboxcodigohabitacion.Items.Add(Habitacion);
            }

            cboxcodigohabitacion.DisplayMember = "Text";
            cboxcodigohabitacion.ValueMember = "Value";
        }
        private void MtdConsultargestionhabitaciones()
        {
            DataTable Dt = cd_gestionhabitaciones.MtdConsultarGestionhabitaciones();
            dgvGestionhabitaciones.DataSource = Dt;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboxcodigoempleado.Text) || string.IsNullOrEmpty(cboxcodigohabitacion.Text) || string.IsNullOrEmpty(cboxtipogestion.Text) || string.IsNullOrEmpty(dtpFechagestion.Text) ||
                 string.IsNullOrEmpty(cboxestado.Text))
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    
                    int Codigoempleado = (int)((dynamic)cboxcodigoempleado.SelectedItem).Value;
                    int Codigohabitacion = (int)((dynamic)cboxcodigohabitacion.SelectedItem).Value;
                    string Tipogestion = cboxtipogestion.Text;
                    DateTime Fechagestion = dtpFechagestion.Value;
                    string Estado = cboxestado.Text;
                    DateTime FechaAuditoria = cl_gestionhabitaciones.MtdFechaHoy();
                    string UsuarioAuditoria = "LAPTOP-AMYS\\SQLEXPRESS01";
                   
                    cd_gestionhabitaciones.MtdAgregargestioonhabitaciones(Codigoempleado, Codigohabitacion, Tipogestion, Fechagestion, Estado, UsuarioAuditoria, FechaAuditoria);
                    MessageBox.Show("gestion habitacion agregado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultargestionhabitaciones();
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
            if (string.IsNullOrEmpty(cboxcodigoempleado.Text) || string.IsNullOrEmpty(cboxcodigohabitacion.Text) || string.IsNullOrEmpty(cboxtipogestion.Text) || string.IsNullOrEmpty(dtpFechagestion.Text) ||
                 string.IsNullOrEmpty(cboxestado.Text))
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    //Ente la llave primaria se coloca esto
                    int Codigogestinhabitaciones = (int.Parse(txtcodigogestion.Text));
                    int Codigoempleado = (int)((dynamic)cboxcodigoempleado.SelectedItem).Value;
                    int Codigohabitacion = (int)((dynamic)cboxcodigohabitacion.SelectedItem).Value;
                    string Tipogestion = cboxtipogestion.Text;
                    DateTime Fechagestion = dtpFechagestion.Value;
                    string Estado = cboxestado.Text;
                    DateTime FechaAuditoria = cl_gestionhabitaciones.MtdFechaHoy();
                    string UsuarioAuditoria = "LAPTOP-AMYS\\SQLEXPRESS01";

                    cd_gestionhabitaciones.MtdActualizarGestionhabitaciones(Codigogestinhabitaciones,Codigoempleado, Codigohabitacion, Tipogestion, Fechagestion, Estado, UsuarioAuditoria, FechaAuditoria);
                    MessageBox.Show("gestion habitacion Actualizado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultargestionhabitaciones();
                    MtdLimpiarCampos();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtcodigogestion.Text))
            {
                MessageBox.Show("Favor seleccionar gestion habitacion a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int Codigogestionhabitacion = (int.Parse(txtcodigogestion.Text));

                    cd_gestionhabitaciones.MtdEliminargestionhabitaciones(Codigogestionhabitacion);
                    MessageBox.Show("gestion habitacion eliminado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultargestionhabitaciones();
                    MtdLimpiarCampos();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvGestionhabitaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSeleccionada = dgvGestionhabitaciones.SelectedRows[0];

            if (FilaSeleccionada.Index == dgvGestionhabitaciones.RowCount - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                {
                    txtcodigogestion.Text = dgvGestionhabitaciones.SelectedCells[0].Value.ToString();
                    cboxtipogestion.Text = dgvGestionhabitaciones.SelectedCells[3].Value.ToString();
                    dtpFechagestion.Text = dgvGestionhabitaciones.SelectedCells[4].Value.ToString();
                    cboxestado.Text = dgvGestionhabitaciones.SelectedCells[5].Value.ToString();


                    int Codigoempleado = (int)dgvGestionhabitaciones.SelectedCells[1].Value;
                    foreach (var codigoem in cboxcodigoempleado.Items)
                    {
                        if (((dynamic)codigoem).Value == Codigoempleado)
                        {
                            cboxcodigoempleado.SelectedItem = codigoem;

                        }
                    }
                    int Codigohabitacion = (int)dgvGestionhabitaciones.SelectedCells[2].Value;
                    foreach (var codigohabitaciones in cboxcodigohabitacion.Items)
                    {
                        if (((dynamic)codigohabitaciones).Value == Codigohabitacion)
                        {
                            cboxcodigohabitacion.SelectedItem = codigohabitaciones;

                        }
                    }


                 






                }
            }
        }
        private void MtdLimpiarCampos()
        {
            txtcodigogestion.Text = "";
            cboxcodigoempleado.SelectedIndex = -1;
            cboxcodigohabitacion.Text = "";
            cboxtipogestion.Text = "";
            dtpFechagestion.Text = "";
            cboxestado.Text = "";
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            MtdLimpiarCampos();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

