namespace Sistema_Proyecto
{
    partial class FrmUsuarios
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.dvgUsuario = new System.Windows.Forms.DataGridView();
            this.cboxCodigoEmpleado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboxEstado = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCodigoUsuario = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuario)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboxTipoUsuario
            // 
            this.cboxTipoUsuario.FormattingEnabled = true;
            this.cboxTipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Doctor",
            "Asistente",
            "Digitador"});
            this.cboxTipoUsuario.Location = new System.Drawing.Point(128, 142);
            this.cboxTipoUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxTipoUsuario.Name = "cboxTipoUsuario";
            this.cboxTipoUsuario.Size = new System.Drawing.Size(140, 24);
            this.cboxTipoUsuario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo Empleado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Clave";
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(525, 65);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(102, 27);
            this.btnagregar.TabIndex = 6;
            this.btnagregar.Text = "➕AGREGAR";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(525, 112);
            this.btneditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(102, 27);
            this.btneditar.TabIndex = 7;
            this.btneditar.Text = "✏EDITAR";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(482, 321);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(102, 27);
            this.btneliminar.TabIndex = 8;
            this.btneliminar.Text = "✖ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // dvgUsuario
            // 
            this.dvgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgUsuario.Location = new System.Drawing.Point(3, 291);
            this.dvgUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dvgUsuario.Name = "dvgUsuario";
            this.dvgUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgUsuario.Size = new System.Drawing.Size(402, 174);
            this.dvgUsuario.TabIndex = 9;
            this.dvgUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgUsuario_CellClick);
            // 
            // cboxCodigoEmpleado
            // 
            this.cboxCodigoEmpleado.FormattingEnabled = true;
            this.cboxCodigoEmpleado.Location = new System.Drawing.Point(128, 44);
            this.cboxCodigoEmpleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxCodigoEmpleado.Name = "cboxCodigoEmpleado";
            this.cboxCodigoEmpleado.Size = new System.Drawing.Size(140, 24);
            this.cboxCodigoEmpleado.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tipo Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 189);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Estado";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gabriola", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(400, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 39);
            this.label6.TabIndex = 13;
            this.label6.Text = "MODULO USUARIO";
            // 
            // cboxEstado
            // 
            this.cboxEstado.FormattingEnabled = true;
            this.cboxEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboxEstado.Location = new System.Drawing.Point(128, 186);
            this.cboxEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxEstado.Name = "cboxEstado";
            this.cboxEstado.Size = new System.Drawing.Size(140, 24);
            this.cboxEstado.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 19);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Codigo Usuario";
            // 
            // txtCodigoUsuario
            // 
            this.txtCodigoUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodigoUsuario.Location = new System.Drawing.Point(128, 14);
            this.txtCodigoUsuario.Name = "txtCodigoUsuario";
            this.txtCodigoUsuario.ReadOnly = true;
            this.txtCodigoUsuario.Size = new System.Drawing.Size(121, 21);
            this.txtCodigoUsuario.TabIndex = 11;
            this.txtCodigoUsuario.TextChanged += new System.EventHandler(this.txtCodigoUsuario_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(128, 84);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 21);
            this.txtUsuario.TabIndex = 19;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(128, 115);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(100, 21);
            this.txtClave.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtClave);
            this.groupBox1.Controls.Add(this.btncancelar);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.txtCodigoUsuario);
            this.groupBox1.Controls.Add(this.cboxEstado);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboxCodigoEmpleado);
            this.groupBox1.Controls.Add(this.btneditar);
            this.groupBox1.Controls.Add(this.btnagregar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboxTipoUsuario);
            this.groupBox1.Location = new System.Drawing.Point(47, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 217);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(525, 163);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(102, 27);
            this.btncancelar.TabIndex = 21;
            this.btncancelar.Text = "✖Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(595, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Fecha actual:";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(692, 22);
            this.lblfecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(78, 16);
            this.lblfecha.TabIndex = 24;
            this.lblfecha.Text = "Imprimir fecha";
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(601, 321);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(102, 27);
            this.btnsalir.TabIndex = 25;
            this.btnsalir.Text = "✖Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 479);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dvgUsuario);
            this.Controls.Add(this.btneliminar);
            this.Font = new System.Drawing.Font("Bodoni MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmUsuarios";
            this.Text = "SISTEMA HOSPITAL";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxTipoUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.DataGridView dvgUsuario;
        private System.Windows.Forms.ComboBox cboxCodigoEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboxEstado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCodigoUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnsalir;
    }
}

