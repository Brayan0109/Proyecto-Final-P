using CapaPresentacion.Presentacion;
using CapaPresentacion.Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        // Se importa la siguiente libreria para agregar logica de redimencionar el forms login
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage (IntPtr hWnd, int wMsg, int wParam, int lParam);




        private void txtUser_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtUser_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_Enter(object sender, EventArgs e)// cursor del mause este dentro de la caja de texto
        {

            if (txtUser.Text== "USUARIO")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;
            }

        }

        private void txtUser_Leave(object sender, EventArgs e) // cursor del mause este afuera de la caja de texto
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {

            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = true;
            }

        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "Username" && txtUser.TextLength > 2)
            {
                if (txtPass.Text != "Password")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtUser.Text, txtPass.Text);
                    if (validLogin == true)
                    {
                        FrmMenuPrincipal mainMenu = new FrmMenuPrincipal();
                        MessageBox.Show("Bienvenido " + UserCache.NombreUsuario + ", " + UserCache.Rol);
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        msgError("Usuario o Contraseña incorrecta.");
                        txtPass.Text = "Password";
                        txtPass.UseSystemPasswordChar = false;
                        txtUser.Focus();
                    }
                }
                else msgError("Please enter password.");
            }
            else msgError("Please enter username.");
        }

        private void msgError(string msg)
        {
            lblErrorMessage.Text = "    " + msg;
            lblErrorMessage.Visible = true;
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtPass.Text = "Password";
            txtPass.UseSystemPasswordChar = false;
            txtUser.Text = "Username";
            lblErrorMessage.Visible = false;
            this.Show();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
