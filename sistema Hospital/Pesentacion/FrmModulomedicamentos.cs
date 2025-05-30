using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Proyecto
{
    public partial class FrmModulomedicamentos : Form
    {
        CLmedicamentos cl_medicamentos=new CLmedicamentos();
        CDmedicamentos cd_medicamentos = new CDmedicamentos();
        public FrmModulomedicamentos()
        {
            InitializeComponent();
        }
        private void MtdConsultarMedicamentos()
        {
            DataTable Dt = cd_medicamentos.MtdConsultarMedicamentos();
            dvgMedicamentos.DataSource = Dt;
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtN.Text) || string.IsNullOrEmpty(cboxTM.Text) || string.IsNullOrEmpty(txtCos.Text) || string.IsNullOrEmpty(txtstock.Text) ||
                 string.IsNullOrEmpty(dtpfechaven.Text) || string.IsNullOrEmpty(cboxEstado.Text) )
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string Nombre = txtN.Text;
                    string Tipomedicamento = cboxTM.Text;
                    double Costo = cl_medicamentos.Mtdmedicamento(Tipomedicamento);
                    double Stock = double.Parse(txtstock.Text);
                    DateTime FechaVencimiento = dtpfechaven.Value;
                    string Estado = cboxEstado.Text;
                    DateTime FechaAuditoria = cl_medicamentos.MtdFechaHoy();
                    string UsuarioAuditoria = "DESKTOP-M60V2AT";

                    cd_medicamentos.MtdAgregarMedicamento(Nombre, Tipomedicamento, Costo, Stock, FechaVencimiento, Estado, UsuarioAuditoria, FechaAuditoria);
                    MessageBox.Show("Medicamento agregado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarMedicamentos();
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
            if (string.IsNullOrEmpty(txtN.Text) || string.IsNullOrEmpty(cboxTM.Text) || string.IsNullOrEmpty(txtCos.Text) || string.IsNullOrEmpty(txtstock.Text) ||
                string.IsNullOrEmpty(dtpfechaven.Text) || string.IsNullOrEmpty(cboxEstado.Text))
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int CodigoMedicamento = (int.Parse(txtCodigoM.Text));
                    string Nombre = txtN.Text;
                    string Tipomedicamento = cboxTM.Text;
                    double Costo = cl_medicamentos.Mtdmedicamento(Tipomedicamento);
                    double Stock = double.Parse(txtstock.Text);
                    DateTime FechaVencimiento = dtpfechaven.Value;
                    string Estado = cboxEstado.Text;
                    DateTime FechaAuditoria = cl_medicamentos.MtdFechaHoy();
                    string UsuarioAuditoria = "DESKTOP-M60V2AT";

                    cd_medicamentos.MtdActualizarMedicamento(CodigoMedicamento, Nombre, Tipomedicamento, Costo, Stock, FechaVencimiento, Estado, UsuarioAuditoria, FechaAuditoria);
                    MessageBox.Show("Medicamento agregado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarMedicamentos();
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
            if (string.IsNullOrEmpty(txtCodigoM.Text))
            {
                MessageBox.Show("Favor seleccionar medicamento a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int CodigoMedicamento = (int.Parse(txtCodigoM.Text));

                    cd_medicamentos.MtdEliminarMedicamentos(CodigoMedicamento);
                    MessageBox.Show("Medicamento eliminado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarMedicamentos();
                    MtdLimpiarCampos();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dvgMedicamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var FilaSeleccionada = dvgMedicamentos.SelectedRows[0];

            if (FilaSeleccionada.Index == dvgMedicamentos.RowCount - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtCodigoM.Text = dvgMedicamentos.SelectedCells[0].Value.ToString();
                txtN.Text = dvgMedicamentos.SelectedCells[1].Value.ToString();
                cboxTM.Text = dvgMedicamentos.SelectedCells[2].Value.ToString();
                txtCos.Text =  dvgMedicamentos.SelectedCells[3].Value.ToString();
                txtstock.Text = dvgMedicamentos.SelectedCells[4].Value.ToString();
                dtpfechaven.Text = dvgMedicamentos.SelectedCells[5].Value.ToString();

              
             

                cboxEstado.Text = dvgMedicamentos.SelectedCells[6].Value.ToString();

            }


        }

        private void txtCos_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Modulomedicamentos_Load(object sender, EventArgs e)
        {
            lblfecha.Text = cl_medicamentos.MtdFechaHoy().ToString("dd/MM/yyyy");
        }

        private void cboxTM_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCos.Text = cl_medicamentos.Mtdmedicamento(cboxTM.Text).ToString();
        }
        private void MtdLimpiarCampos()
        {
            txtCodigoM.Text = "";
            txtN.Text = "";
            cboxTM.Text = "";
            txtCos.Text = "";
            txtstock.Text = "";
            dtpfechaven.Text = "";
            cboxEstado.Text = "";
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            MtdLimpiarCampos();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigoM_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
/*Seagregaron y editaron datos en este procedimiento luego se cancelaran se hara tambien la logica para poder seleccionar filas
    Lugo de eso  se hara la logica de donde se llamaan los datos de los metodos */
