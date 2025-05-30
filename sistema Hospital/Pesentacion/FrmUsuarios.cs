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
    public partial class FrmUsuarios : Form
    {
        //Poner las conexciones de logica y base de datos
        CLusuario cl_usu = new CLusuario();
        CDusuario cd_usuario = new CDusuario();
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Aca esta llamando a la llave secundaria de tabla empleado
        private void MtdMostrarListaempleados()
        {
            var ListaEmpleados = cd_usuario.MtdListaEmpleados();

            foreach (var Empleados in ListaEmpleados)
            {
                cboxCodigoEmpleado.Items.Add(Empleados);
            }

            cboxCodigoEmpleado.DisplayMember = "Text";
            cboxCodigoEmpleado.ValueMember = "Value";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //Aca esta llamando la consulta que se hixo en la lamada de la bse de datos
        private void MtdConsultarUsuario()
        {
            DataTable Dt = cd_usuario.MtdConsultarUsuario();
            dvgUsuario.DataSource = Dt;
        }
        //Aca se esta configurando el boton de agregar 
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboxCodigoEmpleado.Text) || string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtClave.Text) || string.IsNullOrEmpty(cboxTipoUsuario.Text) ||
                  string.IsNullOrEmpty(cboxEstado.Text)) 
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    //Este codigo que esta en codigo empleado siempre debe de ir en las llaves primarias
                    int Codigoempleado = (int)((dynamic)cboxCodigoEmpleado.SelectedItem).Value;
                    string Usuario = txtUsuario.Text;
                    int Clave = int.Parse(txtClave.Text);
                    string TipoUsuario = cboxTipoUsuario.Text;
                    string Estado = cboxEstado.Text;
                    DateTime FechaAuditoria = cl_usu.MtdFechaHoy();
                    string UsuarioAuditoria = "DESKTOP-M60V2AT";
                    
                    cd_usuario.MtdAgregarUsuario(Codigoempleado, Usuario, Clave, TipoUsuario, Estado, UsuarioAuditoria, FechaAuditoria);
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

        private void label5_Click(object sender, EventArgs e)
        {

        }
        //Aca se estan agregando el llamado de la llave y el llamado de la logica de la fecha
        private void Form1_Load(object sender, EventArgs e)
        {
            lblfecha.Text = cl_usu.MtdFechaHoy().ToString();
            MtdMostrarListaempleados();
            MtdConsultarUsuario();

        }
        //Aca se esta cnfigurando el boton editar
        private void btneditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboxCodigoEmpleado.Text) || string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtClave.Text) || string.IsNullOrEmpty(cboxTipoUsuario.Text) ||
                string.IsNullOrEmpty(cboxEstado.Text))
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    //Ente la llave primaria se coloca esto
                    int CodigoUsuario = (int.Parse(txtCodigoUsuario.Text));
                    int Codigoempleado = (int)((dynamic)cboxCodigoEmpleado.SelectedItem).Value;
                    string Usuario = txtUsuario.Text;
                    int Clave = int.Parse(txtClave.Text);
                    string TipoUsuario = cboxTipoUsuario.Text;
                    string Estado = cboxEstado.Text;
                    DateTime FechaAuditoria = cl_usu.MtdFechaHoy();
                    string UsuarioAuditoria = "DESKTOP-M60V2AT";
                    //Aca manda a actualizar las tablas a la base de datos
                    cd_usuario.MtdActualizarUsuario(CodigoUsuario, Codigoempleado, Usuario, Clave, TipoUsuario, Estado,FechaAuditoria, UsuarioAuditoria);
                    MessageBox.Show("Usuario actualizado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarUsuario();
                    MtdLimpiarCampos();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Aca se configura el cell click 
        private void dvgUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSeleccionada = dvgUsuario.SelectedRows[0];

            if (FilaSeleccionada.Index == dvgUsuario.RowCount - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtCodigoUsuario.Text = dvgUsuario.SelectedCells[0].Value.ToString();
                txtUsuario.Text = dvgUsuario.SelectedCells[2].Value.ToString();
                txtClave.Text = dvgUsuario.SelectedCells[3].Value.ToString();
                cboxTipoUsuario.Text = dvgUsuario.SelectedCells[4].Value.ToString();


                //Este sirve para que cuando se seleccione selecciones la llave secundaria
                //cboxCodigoEmpleado.Text = dgvUsuario.SelectedCells[6].Value.ToString();
                int Codigoempleado = (int)dvgUsuario.SelectedCells[1].Value;
                foreach (var codigoem in cboxCodigoEmpleado.Items)
                {
                    if (((dynamic)codigoem).Value == Codigoempleado)
                    {
                        cboxCodigoEmpleado.SelectedItem = codigoem;
                        //break;
                    }
                }


                cboxEstado.Text = dvgUsuario.SelectedCells[6].Value.ToString();





            }

        }
        //Aca se esta configurando el boton eliminar
        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoUsuario.Text))
            {
                MessageBox.Show("Favor seleccionar Usuario a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int CodigoUsuario = (int.Parse(txtCodigoUsuario.Text));

                    cd_usuario.MtdEliminarUsuario(CodigoUsuario);
                    MessageBox.Show("Usuario eliminado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarUsuario();
                    MtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lblfecha_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MtdLimpiarCampos();
        }
             private void MtdLimpiarCampos()
        {
            txtCodigoUsuario.Text = "";
            cboxCodigoEmpleado.SelectedIndex = -1;
            txtUsuario.Text = "";
            txtClave.Text = "";
            cboxTipoUsuario.Text = "";
            cboxEstado.Text = "";
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigoUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
  }
