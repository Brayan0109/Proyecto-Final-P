namespace CapaPresentacion.Presentacion
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.lblMensajeBienvenida = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnTratamientos = new FontAwesome.Sharp.IconButton();
            this.btnMedicamentos = new FontAwesome.Sharp.IconButton();
            this.btnPagoEmpleados = new FontAwesome.Sharp.IconButton();
            this.btnPagoCitas = new FontAwesome.Sharp.IconButton();
            this.btnCitas = new FontAwesome.Sharp.IconButton();
            this.btnGestion = new FontAwesome.Sharp.IconButton();
            this.btnPacientes = new FontAwesome.Sharp.IconButton();
            this.btmHabitaciones = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.PictureBox();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.PanelLogin = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEmpleados = new FontAwesome.Sharp.IconButton();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.PanelContenedor.SuspendLayout();
            this.panelFormularios.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesion)).BeginInit();
            this.PanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelContenedor.Controls.Add(this.panelFormularios);
            this.PanelContenedor.Controls.Add(this.panelMenu);
            this.PanelContenedor.Controls.Add(this.panelBarraTitulo);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(0, 0);
            this.PanelContenedor.Margin = new System.Windows.Forms.Padding(4);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1467, 615);
            this.PanelContenedor.TabIndex = 0;
            // 
            // panelFormularios
            // 
            this.panelFormularios.BackColor = System.Drawing.SystemColors.Control;
            this.panelFormularios.Controls.Add(this.lblMensajeBienvenida);
            this.panelFormularios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularios.Location = new System.Drawing.Point(264, 49);
            this.panelFormularios.Margin = new System.Windows.Forms.Padding(4);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(1203, 566);
            this.panelFormularios.TabIndex = 2;
            this.panelFormularios.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFormularios_Paint);
            // 
            // lblMensajeBienvenida
            // 
            this.lblMensajeBienvenida.AutoSize = true;
            this.lblMensajeBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeBienvenida.Location = new System.Drawing.Point(379, 201);
            this.lblMensajeBienvenida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensajeBienvenida.Name = "lblMensajeBienvenida";
            this.lblMensajeBienvenida.Size = new System.Drawing.Size(231, 29);
            this.lblMensajeBienvenida.TabIndex = 0;
            this.lblMensajeBienvenida.Text = "PAGINA PRINCIPAL";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.panelMenu.Controls.Add(this.btnTratamientos);
            this.panelMenu.Controls.Add(this.btnMedicamentos);
            this.panelMenu.Controls.Add(this.btnPagoEmpleados);
            this.panelMenu.Controls.Add(this.btnPagoCitas);
            this.panelMenu.Controls.Add(this.btnCitas);
            this.panelMenu.Controls.Add(this.btnGestion);
            this.panelMenu.Controls.Add(this.btnPacientes);
            this.panelMenu.Controls.Add(this.btmHabitaciones);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.btnUsuarios);
            this.panelMenu.Controls.Add(this.PanelLogin);
            this.panelMenu.Controls.Add(this.btnEmpleados);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 49);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(264, 566);
            this.panelMenu.TabIndex = 1;
            // 
            // btnTratamientos
            // 
            this.btnTratamientos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTratamientos.FlatAppearance.BorderSize = 0;
            this.btnTratamientos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTratamientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTratamientos.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnTratamientos.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.btnTratamientos.IconColor = System.Drawing.Color.White;
            this.btnTratamientos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTratamientos.IconSize = 25;
            this.btnTratamientos.Location = new System.Drawing.Point(7, 425);
            this.btnTratamientos.Margin = new System.Windows.Forms.Padding(4);
            this.btnTratamientos.Name = "btnTratamientos";
            this.btnTratamientos.Size = new System.Drawing.Size(247, 27);
            this.btnTratamientos.TabIndex = 11;
            this.btnTratamientos.Text = "Tratamientos";
            this.btnTratamientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTratamientos.UseVisualStyleBackColor = true;
            this.btnTratamientos.Click += new System.EventHandler(this.btnTratamientos_Click);
            // 
            // btnMedicamentos
            // 
            this.btnMedicamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedicamentos.FlatAppearance.BorderSize = 0;
            this.btnMedicamentos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMedicamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicamentos.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnMedicamentos.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.btnMedicamentos.IconColor = System.Drawing.Color.White;
            this.btnMedicamentos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMedicamentos.IconSize = 25;
            this.btnMedicamentos.Location = new System.Drawing.Point(7, 390);
            this.btnMedicamentos.Margin = new System.Windows.Forms.Padding(4);
            this.btnMedicamentos.Name = "btnMedicamentos";
            this.btnMedicamentos.Size = new System.Drawing.Size(247, 27);
            this.btnMedicamentos.TabIndex = 10;
            this.btnMedicamentos.Text = "Medicamentos";
            this.btnMedicamentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMedicamentos.UseVisualStyleBackColor = true;
            this.btnMedicamentos.Click += new System.EventHandler(this.btnMedicamentos_Click);
            // 
            // btnPagoEmpleados
            // 
            this.btnPagoEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagoEmpleados.FlatAppearance.BorderSize = 0;
            this.btnPagoEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPagoEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagoEmpleados.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPagoEmpleados.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.btnPagoEmpleados.IconColor = System.Drawing.Color.White;
            this.btnPagoEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPagoEmpleados.IconSize = 25;
            this.btnPagoEmpleados.Location = new System.Drawing.Point(7, 355);
            this.btnPagoEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.btnPagoEmpleados.Name = "btnPagoEmpleados";
            this.btnPagoEmpleados.Size = new System.Drawing.Size(247, 27);
            this.btnPagoEmpleados.TabIndex = 9;
            this.btnPagoEmpleados.Text = "Pago Empleados";
            this.btnPagoEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPagoEmpleados.UseVisualStyleBackColor = true;
            this.btnPagoEmpleados.Click += new System.EventHandler(this.btnPagoEmpleados_Click);
            // 
            // btnPagoCitas
            // 
            this.btnPagoCitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagoCitas.FlatAppearance.BorderSize = 0;
            this.btnPagoCitas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPagoCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagoCitas.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPagoCitas.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.btnPagoCitas.IconColor = System.Drawing.Color.White;
            this.btnPagoCitas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPagoCitas.IconSize = 25;
            this.btnPagoCitas.Location = new System.Drawing.Point(6, 320);
            this.btnPagoCitas.Margin = new System.Windows.Forms.Padding(4);
            this.btnPagoCitas.Name = "btnPagoCitas";
            this.btnPagoCitas.Size = new System.Drawing.Size(247, 27);
            this.btnPagoCitas.TabIndex = 8;
            this.btnPagoCitas.Text = "Pago Citas";
            this.btnPagoCitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPagoCitas.UseVisualStyleBackColor = true;
            this.btnPagoCitas.Click += new System.EventHandler(this.btnPagoCitas_Click);
            // 
            // btnCitas
            // 
            this.btnCitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCitas.FlatAppearance.BorderSize = 0;
            this.btnCitas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitas.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCitas.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.btnCitas.IconColor = System.Drawing.Color.White;
            this.btnCitas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCitas.IconSize = 25;
            this.btnCitas.Location = new System.Drawing.Point(4, 285);
            this.btnCitas.Margin = new System.Windows.Forms.Padding(4);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(247, 27);
            this.btnCitas.TabIndex = 7;
            this.btnCitas.Text = "Citas";
            this.btnCitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCitas.UseVisualStyleBackColor = true;
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click);
            // 
            // btnGestion
            // 
            this.btnGestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestion.FlatAppearance.BorderSize = 0;
            this.btnGestion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestion.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnGestion.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.btnGestion.IconColor = System.Drawing.Color.White;
            this.btnGestion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGestion.IconSize = 25;
            this.btnGestion.Location = new System.Drawing.Point(4, 250);
            this.btnGestion.Margin = new System.Windows.Forms.Padding(4);
            this.btnGestion.Name = "btnGestion";
            this.btnGestion.Size = new System.Drawing.Size(247, 27);
            this.btnGestion.TabIndex = 6;
            this.btnGestion.Text = "Gestion Habitacion ";
            this.btnGestion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGestion.UseVisualStyleBackColor = true;
            this.btnGestion.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // btnPacientes
            // 
            this.btnPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPacientes.FlatAppearance.BorderSize = 0;
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientes.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPacientes.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.btnPacientes.IconColor = System.Drawing.Color.White;
            this.btnPacientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPacientes.IconSize = 25;
            this.btnPacientes.Location = new System.Drawing.Point(4, 216);
            this.btnPacientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(247, 26);
            this.btnPacientes.TabIndex = 5;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPacientes.UseVisualStyleBackColor = true;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // btmHabitaciones
            // 
            this.btmHabitaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmHabitaciones.FlatAppearance.BorderSize = 0;
            this.btmHabitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btmHabitaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmHabitaciones.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btmHabitaciones.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.btmHabitaciones.IconColor = System.Drawing.Color.White;
            this.btmHabitaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btmHabitaciones.IconSize = 25;
            this.btmHabitaciones.Location = new System.Drawing.Point(4, 179);
            this.btmHabitaciones.Margin = new System.Windows.Forms.Padding(4);
            this.btmHabitaciones.Name = "btmHabitaciones";
            this.btmHabitaciones.Size = new System.Drawing.Size(247, 29);
            this.btmHabitaciones.TabIndex = 4;
            this.btmHabitaciones.Text = "Habitaciones";
            this.btmHabitaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btmHabitaciones.UseVisualStyleBackColor = true;
            this.btmHabitaciones.Click += new System.EventHandler(this.btmHabitaciones_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 478);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 88);
            this.panel1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(81, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cerrar sesion:";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.Location = new System.Drawing.Point(24, 16);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(51, 51);
            this.btnCerrarSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarSesion.TabIndex = 0;
            this.btnCerrarSesion.TabStop = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnUsuarios.IconColor = System.Drawing.Color.White;
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.IconSize = 25;
            this.btnUsuarios.Location = new System.Drawing.Point(4, 142);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(247, 29);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // PanelLogin
            // 
            this.PanelLogin.Controls.Add(this.panel2);
            this.PanelLogin.Controls.Add(this.lblEstado);
            this.PanelLogin.Controls.Add(this.lblRol);
            this.PanelLogin.Controls.Add(this.lblUsuario);
            this.PanelLogin.Controls.Add(this.label3);
            this.PanelLogin.Controls.Add(this.label2);
            this.PanelLogin.Controls.Add(this.label1);
            this.PanelLogin.Controls.Add(this.pictureBox1);
            this.PanelLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogin.Location = new System.Drawing.Point(0, 0);
            this.PanelLogin.Margin = new System.Windows.Forms.Padding(4);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(264, 95);
            this.PanelLogin.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(6, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 1);
            this.panel2.TabIndex = 8;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Teal;
            this.lblEstado.Location = new System.Drawing.Point(163, 64);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(11, 16);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = ".";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.Color.Teal;
            this.lblRol.Location = new System.Drawing.Point(163, 42);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(11, 16);
            this.lblRol.TabIndex = 5;
            this.lblRol.Text = ".";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Teal;
            this.lblUsuario.Location = new System.Drawing.Point(163, 23);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(11, 16);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(78, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(78, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rol:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(78, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEmpleados.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.btnEmpleados.IconColor = System.Drawing.Color.White;
            this.btnEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmpleados.IconSize = 25;
            this.btnEmpleados.Location = new System.Drawing.Point(4, 107);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(247, 27);
            this.btnEmpleados.TabIndex = 0;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.panelBarraTitulo.Controls.Add(this.btnMinimizar);
            this.panelBarraTitulo.Controls.Add(this.btnRestaurar);
            this.panelBarraTitulo.Controls.Add(this.btnMaximizar);
            this.panelBarraTitulo.Controls.Add(this.btnCerrar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1467, 49);
            this.panelBarraTitulo.TabIndex = 0;
            this.panelBarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBarraTitulo_Paint);
            this.panelBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseMove);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1352, 15);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(27, 25);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1389, 15);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(27, 25);
            this.btnRestaurar.TabIndex = 2;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1389, 15);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(27, 25);
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1424, 15);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(27, 25);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 615);
            this.Controls.Add(this.PanelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(867, 492);
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.PanelContenedor.ResumeLayout(false);
            this.panelFormularios.ResumeLayout(false);
            this.panelFormularios.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesion)).EndInit();
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.Panel panelFormularios;
        private System.Windows.Forms.Label lblMensajeBienvenida;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox btnCerrarSesion;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private System.Windows.Forms.Panel PanelLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnEmpleados;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnGestion;
        private FontAwesome.Sharp.IconButton btnPacientes;
        private FontAwesome.Sharp.IconButton btmHabitaciones;
        private FontAwesome.Sharp.IconButton btnTratamientos;
        private FontAwesome.Sharp.IconButton btnMedicamentos;
        private FontAwesome.Sharp.IconButton btnPagoEmpleados;
        private FontAwesome.Sharp.IconButton btnPagoCitas;
        private FontAwesome.Sharp.IconButton btnCitas;
    }
}