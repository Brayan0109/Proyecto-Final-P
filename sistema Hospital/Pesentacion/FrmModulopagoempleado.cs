using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using static System.Net.WebRequestMethods;

namespace Sistema_Proyecto
{
    public partial class FrmModulopagoempleado : Form
    {
        CLpagoempleados cl_pagoempleados = new CLpagoempleados();
        CDpagoempleados cd_pagoempleados = new CDpagoempleados();
        public FrmModulopagoempleado()
        {
            InitializeComponent();
        }
        private void MtdMostrarListaEmpleados()
        {
            var ListaEmpleados = cd_pagoempleados.MtdListaEmpleados();

            foreach (var Empleados in ListaEmpleados)
            {
                cboxcodigoempleado.Items.Add(Empleados);
            }

            cboxcodigoempleado.DisplayMember = "Text";
            cboxcodigoempleado.ValueMember = "Value";
        }

        private void Modulopagoempleado_Load(object sender, EventArgs e)
        {
            lblfecha.Text = cl_pagoempleados.MtdFechaHoy().ToString("dd/MM/yyyy");
            MtdMostrarListaEmpleados();
            MtdConsultarPagoempleados();
        }
        private void MtdConsultarPagoempleados()
        {
            DataTable Dt = cd_pagoempleados.MtdConsultarPagoempleados();
            dvgEmpleados.DataSource = Dt;
        }
        private void cboxcodigoempleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedpagoempleado = (dynamic)cboxcodigoempleado.SelectedItem;
            if (selectedpagoempleado != null)
            {
                int Sueldo = (int)selectedpagoempleado.Value;
                txtSueldo.Text = cl_pagoempleados.Mtdsueldoempleados(Sueldo).ToString();

                double Bono = double.Parse(txtSueldo.Text);
                txtbono.Text = cl_pagoempleados.MtdSueldoBono(Bono).ToString();




            }
            else
            {
                txtSueldo.Text = string.Empty;
            }








        }

        private void txtSueldo_TextChanged(object sender, EventArgs e)
        {



        }

        private void txtbono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttotalmonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboxcodigoempleado.Text) || string.IsNullOrEmpty(dtpfechapago.Text) || string.IsNullOrEmpty(txtSueldo.Text) || string.IsNullOrEmpty(txtbono.Text) ||
                 string.IsNullOrEmpty(txtMontohorasextras.Text) || string.IsNullOrEmpty(cboxestado.Text) || string.IsNullOrEmpty(txttotalmonto.Text))
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                try
                {
                    var Selectedempleado = (dynamic)cboxcodigoempleado.SelectedItem;
                    int Codigoempleado = (int)((dynamic)cboxcodigoempleado.SelectedItem).Value;
                    DateTime Fechapago = dtpfechapago.Value;
                    double Sueldo = double.Parse(txtSueldo.Text);
                    double Bono = double.Parse(txtbono.Text);
                    int MontoHorasextras = int.Parse(txtMontohorasextras.Text);
                    double Montototal = double.Parse(txttotalmonto.Text);
                    string Estado = cboxestado.Text;
                    DateTime FechaAuditoria = cl_pagoempleados.MtdFechaHoy();
                    string UsuarioAuditoria = "Admin";

                    cd_pagoempleados.MtdAgregarPagoempleados(Codigoempleado, Fechapago, Sueldo, Bono, MontoHorasextras, Montototal, Estado, UsuarioAuditoria, FechaAuditoria);
                    MessageBox.Show("Pago empleado agregado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarPagoempleados();
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
            if (string.IsNullOrEmpty(cboxcodigoempleado.Text) || string.IsNullOrEmpty(dtpfechapago.Text) || string.IsNullOrEmpty(txtSueldo.Text) || string.IsNullOrEmpty(txtbono.Text) ||
                 string.IsNullOrEmpty(txtMontohorasextras.Text) || string.IsNullOrEmpty(txttotalmonto.Text) || string.IsNullOrEmpty(cboxestado.Text))
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                


                try
                {
                    int Codigopagoempleado = (int.Parse(txtPagoempleados.Text));
                    int Codigoempleados = (int)((dynamic)cboxcodigoempleado.SelectedItem).Value;
                    DateTime Fechapago = dtpfechapago.Value;
                    double Sueldos = double.Parse(txtSueldo.Text);
                    double Bono = double.Parse(txtbono.Text);
                    int Montohorasextras = int.Parse(txtMontohorasextras.Text);
                    double Totalmonto = double.Parse(txttotalmonto.Text);
                    string Estado = cboxestado.Text;
                    DateTime FechaAuditoria = cl_pagoempleados.MtdFechaHoy();
                    string UsuarioAuditoria = "Admin";
                    //Aca esta llamando la base de datos para agregar a las tablas
                    cd_pagoempleados.MtdActualizarPagoempleados(Codigopagoempleado, Codigoempleados, Fechapago, Sueldos, Bono, Montohorasextras, Totalmonto, Estado, FechaAuditoria, UsuarioAuditoria);
                    MessageBox.Show("Usuario agregado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarPagoempleados();
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
            if (string.IsNullOrEmpty(txtPagoempleados.Text))
            {
                MessageBox.Show("Favor seleccionar Pago empleado eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int Codigopago = (int.Parse(txtPagoempleados.Text));

                    cd_pagoempleados.MtdEliminarPagoEmpleados(Codigopago);
                    MessageBox.Show("Pago empleado eliminado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarPagoempleados();
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
            txtPagoempleados.Text = "";
            cboxcodigoempleado.SelectedIndex = -1;
            dtpfechapago.Text = "";
            txtSueldo.Text = "";
            txtbono.Text = "";
            txtMontohorasextras.Text = "";
            txttotalmonto.Text = "";
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

        private void dvgEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSeleccionada = dvgEmpleados.SelectedRows[0];

            if (FilaSeleccionada.Index == dvgEmpleados.RowCount - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtPagoempleados.Text =   dvgEmpleados.SelectedCells[0].Value.ToString();
                dtpfechapago.Text = dvgEmpleados.SelectedCells[2].Value.ToString();
                txtSueldo.Text = dvgEmpleados.SelectedCells[3].Value.ToString();
                txtbono.Text = dvgEmpleados.SelectedCells[4].Value.ToString();
                txtMontohorasextras.Text = dvgEmpleados.SelectedCells[5].Value.ToString();
                txttotalmonto.Text = dvgEmpleados.SelectedCells[6].Value.ToString();


                //Este sirve para que cuando se seleccione selecciones la llave secundaria
                //cboxCodigoEmpleado.Text = dgvUsuario.SelectedCells[6].Value.ToString();
                int Codigoempleados = (int)dvgEmpleados.SelectedCells[1].Value;
                foreach (var codigoempleados in cboxcodigoempleado.Items)
                {
                    if (((dynamic)codigoempleados).Value == Codigoempleados)
                    {
                        cboxcodigoempleado.SelectedItem = codigoempleados;
                        //break;
                    }
                }


                cboxestado.Text = dvgEmpleados.SelectedCells[7].Value.ToString();
            }
            }

        private void txtMontohorasextras_TextChanged(object sender, EventArgs e)
        {
            if (txtMontohorasextras.Text != "")
            {


                if (!string.IsNullOrWhiteSpace(txtSueldo.Text))
                {


                    double sueldo = double.Parse(txtSueldo.Text);
                    
                    double montohorase = double.Parse(txtMontohorasextras.Text);
                    double bono = double.Parse(txtbono.Text);
                    txttotalmonto.Text = cl_pagoempleados.MtdTotalmonto(sueldo, bono, montohorase).ToString();



                }
            }
        }
    }
}
