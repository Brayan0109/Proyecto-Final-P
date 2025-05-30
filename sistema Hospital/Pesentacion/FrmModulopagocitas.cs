using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Sistema_Proyecto
{
    public partial class modulopagocitas : Form
       {
        CLpagocita cl_pagocitas = new CLpagocita();
        CDpagocita cd_pagocitas = new CDpagocita();
       

        public modulopagocitas()
        {
            InitializeComponent();
        }
        private void MtdMostrarListaCitas()
        {
            var ListaCitas = cd_pagocitas.MtdListaCitas();

            foreach (var Citas in ListaCitas)
            {
                cboxCCI.Items.Add(Citas);
            }

            cboxCCI.DisplayMember = "Text";
            cboxCCI.ValueMember = "Value";
        }
        private void MtdConsultarPagocitas()
        {
            DataTable Dt = cd_pagocitas.MtdConsultarPagocitas();
            dvgpagocitas.DataSource = Dt;
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(cboxCCI.Text) || string.IsNullOrEmpty(txtMC.Text) || string.IsNullOrEmpty(txtI.Text) || string.IsNullOrEmpty(txtD.Text) ||
                  string.IsNullOrEmpty(txtTP.Text) || string.IsNullOrEmpty(dtpFP.Text) || string.IsNullOrEmpty(cboxTP.Text))
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    //Este codigo que esta en codigo empleado siempre debe de ir en las llaves primarias
                    int Codigocita = (int)((dynamic)cboxCCI.SelectedItem).Value;
                    int Montocita = int.Parse(txtMC.Text);
                    double Impuestos = double.Parse( txtI.Text);
                    double Descuentos =double.Parse( txtD.Text);
                    double Totalpago = double.Parse(txtTP.Text);
                    DateTime Fechapago = dtpFP.Value;
                    string Tipopago = cboxTP.Text;
                    DateTime FechaAuditoria = cl_pagocitas.MtdFechaHoy();
                    string UsuarioAuditoria = "DESKTOP-M60V2AT";
                    //Aca esta llamando la base de datos para agregar a las tablas
                    cd_pagocitas.MtdAgregarPagoCita(Codigocita, Montocita, Impuestos, Descuentos, Totalpago,Fechapago,Tipopago,  UsuarioAuditoria, FechaAuditoria);
                    MessageBox.Show("Usuario agregado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarPagocitas();
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

            if (string.IsNullOrEmpty(cboxCCI.Text) || string.IsNullOrEmpty(txtMC.Text) || string.IsNullOrEmpty(txtI.Text) || string.IsNullOrEmpty(txtD.Text) ||
                  string.IsNullOrEmpty(txtTP.Text) || string.IsNullOrEmpty(dtpFP.Text) || string.IsNullOrEmpty(cboxTP.Text))
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    //Ente la llave primaria se coloca esto
                    int CodigoPagoCita = (int.Parse(txtCPC.Text));
                    int Codigocita = (int)((dynamic)cboxCCI.SelectedItem).Value;
                    int Montocita = int.Parse(txtMC.Text);
                    double Impuestos = double.Parse(txtI.Text);
                    double Descuentos = double.Parse(txtD.Text);
                    double Totalpago = double.Parse(txtTP.Text);
                    DateTime Fechapago = dtpFP.Value;
                    string Tipopago = cboxTP.Text;
                    DateTime FechaAuditoria = cl_pagocitas.MtdFechaHoy();
                    string UsuarioAuditoria = "DESKTOP-M60V2AT";
                    //Aca esta llamando la base de datos para agregar a las tablas
                    cd_pagocitas.MtdActualizarPagocitas(CodigoPagoCita,Codigocita, Montocita, Impuestos, Descuentos, Totalpago, Fechapago, Tipopago, FechaAuditoria, UsuarioAuditoria);
                    MessageBox.Show("Usuario agregado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarPagocitas();
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
            if (string.IsNullOrEmpty(txtCPC.Text))
            {
                MessageBox.Show("Favor seleccionar Pago cita a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int CodigoUsuario = (int.Parse(txtCPC.Text));

                    cd_pagocitas.MtdEliminarPagoCitas(CodigoUsuario);
                    MessageBox.Show("Pago citas eliminado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   MtdConsultarPagocitas();
                    MtdLimpiarCampos();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dvgpagocitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSeleccionada = dvgpagocitas.SelectedRows[0];

            if (FilaSeleccionada.Index == dvgpagocitas.RowCount - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtCPC.Text = dvgpagocitas.SelectedCells[0].Value.ToString();
                txtMC.Text = dvgpagocitas.SelectedCells[2].Value.ToString();
                txtI.Text = dvgpagocitas.SelectedCells[3].Value.ToString();
                txtD.Text = dvgpagocitas.SelectedCells[4].Value.ToString();
                txtTP.Text = dvgpagocitas.SelectedCells[5].Value.ToString();
                dtpFP.Text = dvgpagocitas.SelectedCells[6].Value.ToString();


                //Este sirve para que cuando se seleccione selecciones la llave secundaria
                //cboxCodigoEmpleado.Text = dgvUsuario.SelectedCells[6].Value.ToString();
                int Codigocita = (int)dvgpagocitas.SelectedCells[1].Value;
                foreach (var codigocitas in cboxCCI.Items)
                {
                    if (((dynamic)codigocitas).Value == Codigocita)
                    {
                        cboxCCI.SelectedItem = codigocitas;
                        //break;
                    }
                }


                cboxTP.Text = dvgpagocitas.SelectedCells[7].Value.ToString();





            }

        }
        private void MtdLimpiarCampos()
        {
            txtCPC.Text = "";
            cboxCCI.SelectedIndex = -1;
            txtMC.Text = "";
            txtI.Text = "";
            txtD.Text = "";
            txtTP.Text = "";
            dtpFP.Text = "";
            cboxTP.Text = "";
        }

        private void cboxCCI_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dvgpagocitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void modulopagocitas_Load(object sender, EventArgs e)
        {
            lblfecha.Text = cl_pagocitas.MtdFechaHoy().ToString("dd/MM/yyyy");
            MtdMostrarListaCitas();
        }

        private void txtMC_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cboxCCI_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var selectedpagocita = (dynamic)cboxCCI.SelectedItem;
            int codigoPagoCita = (int)selectedpagocita.Value;
            txtMC.Text = cl_pagocitas.Mtdmontocita(codigoPagoCita).ToString();
        }

        private void txtI_TextChanged(object sender, EventArgs e)
        {

            double Montocitas = double.Parse(txtMC.Text);
            txtI.Text = cl_pagocitas.Mtdimpuesto(Montocitas).ToString();
        }

        private void txtD_TextChanged(object sender, EventArgs e)
        {
            double Montocita = double.Parse(txtMC.Text);
            double Montopago = double.Parse(txtMC.Text);
            txtD.Text = cl_pagocitas.MtdDescuentopago(Montocita,Montopago).ToString();

        }

        private void txtTP_TextChanged(object sender, EventArgs e)
        {
            double Montocita = double.Parse(txtMC.Text);
            double Impuestos = double.Parse(txtI.Text);
            double Descuentos = double.Parse(txtD.Text);
            txtTP.Text = cl_pagocitas.Mtdtotalpago(Montocita, Impuestos, Descuentos).ToString();
        }

        private void bntcancelar_Click(object sender, EventArgs e)
        {
            MtdLimpiarCampos();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnagregar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
