using Habitaciones.Datos;
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

namespace Habitaciones
{
    public partial class FrmHabitaciones : Form
    {
        CLHabitaciones calcu = new CLHabitaciones();
        CDHabitacion cd_Habitaciones = new CDHabitacion();
        public FrmHabitaciones()
        {
            InitializeComponent();
        }
        private void MtdConsultarCodigoHabitacion()
        {
            DataTable Dt = cd_Habitaciones.MtdConsultarCodigoHabitacion();
            dgvHabitacion.DataSource = Dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNumero.Text) || string.IsNullOrEmpty(txtUbicacion.Text) || string.IsNullOrEmpty(cbxTipoHabitacion.Text) ||
                string.IsNullOrEmpty(cbxEstado.Text) || string.IsNullOrEmpty(lblTotalCosto.Text))
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    string Numero = txtNumero.Text;
                    string TipoHabitacion = cbxTipoHabitacion.Text;
                    double TotalCosto = calcu.MtdCostoHabitacion(TipoHabitacion);
                    string Estado = cbxEstado.Text;
                    string Ubicacion = txtUbicacion.Text;
                    string UsuarioAuditoria = "LAPTOP-AMYS\\SQLEXPRESS01";
                    DateTime FechaAuditoria = calcu.MtdFechaHoy();

                    //Logica para guardar en la base de datos
                    cd_Habitaciones.MtdAgregarHabitaciones(Numero, Ubicacion, TipoHabitacion, TotalCosto, Estado, UsuarioAuditoria, FechaAuditoria);
                    MessageBox.Show("Habitacion agregada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarCodigoHabitacion();
                    MtdLimpiar();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtCodigoHabitacion.Text) || string.IsNullOrEmpty(txtNumero.Text) || string.IsNullOrEmpty(txtUbicacion.Text) || string.IsNullOrEmpty(txtCodigoHabitacion.Text) ||
                string.IsNullOrEmpty(cbxEstado.Text))
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {

                    int FilaSeleccionada = dgvHabitacion.Rows.Add();

                    int CodigoPaciente = int.Parse(txtCodigoHabitacion.Text);
                    int Numero = int.Parse(txtNumero.Text);
                    string Ubicacion = txtUbicacion.Text;
                    string TotlCosto = lblTotalCosto.Text;
                    string TipoHabitacion = txtCodigoHabitacion.Text;
                    
                    string Estado = cbxEstado.Text;
                   // string UsuarioAuditoria = "Admin";
                    DateTime FechaAuditoria = calcu.MtdFechaHoy();
                    MtdLimpiar();
                }

                catch (Exception ex)
                {

                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MtdLimpiar();

        }
        private void MtdLimpiar()
        {
            txtCodigoHabitacion.Text = "";
            txtNumero.Text = "";
            txtUbicacion.Text = "";
            txtCodigoHabitacion.Text = "";
            lblTotalCosto.Text = "";
            cbxEstado.Text = "";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigoHabitacion.Text == "")
                {
                    MessageBox.Show("No hay fila seleccionada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    int FilaSeleccionada = dgvHabitacion.CurrentRow.Index;
                    dgvHabitacion.Rows.RemoveAt(FilaSeleccionada);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dgvHabitacion_CellClick(object sender, DataGridViewCellEventArgs e)
        { 

            var FilaSeleccionada = dgvHabitacion.SelectedRows[0];

            if (FilaSeleccionada.Index == dgvHabitacion.RowCount - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtCodigoHabitacion.Text = dgvHabitacion.SelectedCells[0].Value.ToString();
                txtNumero.Text = dgvHabitacion.SelectedCells[1].Value.ToString();
                txtUbicacion.Text = dgvHabitacion.SelectedCells[2].Value.ToString();
                cbxTipoHabitacion.Text = dgvHabitacion.SelectedCells[3].Value.ToString();
                lblTotalCosto.Text = dgvHabitacion.SelectedCells[4].Value.ToString();
               
                cbxEstado.Text = dgvHabitacion.SelectedCells[5].Value.ToString();
            }
        }

              private void FrmHabitaciones_Load(object sender, EventArgs e)
        {
            lblfecha.Text = calcu.MtdFechaHoy().ToString();
        }

        private void cbxTipoHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTotalCosto.Text = calcu.MtdCostoHabitacion(cbxTipoHabitacion.Text).ToString();

        }

        private void FrmHabitaciones_Load_1(object sender, EventArgs e)
        { //Comentario prueba
            lblfecha.Text = calcu.MtdFechaHoy().ToString();
            MtdConsultarCodigoHabitacion();
        }
    }
    
 }

      

      
