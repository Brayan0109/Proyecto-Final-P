namespace TablaAmy
{
    partial class FrmGestionHabitacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.txtcodigogestion = new System.Windows.Forms.TextBox();
            this.cboxcodigoempleado = new System.Windows.Forms.ComboBox();
            this.cboxestado = new System.Windows.Forms.ComboBox();
            this.cboxtipogestion = new System.Windows.Forms.ComboBox();
            this.cboxcodigohabitacion = new System.Windows.Forms.ComboBox();
            this.dtpFechagestion = new System.Windows.Forms.DateTimePicker();
            this.dgvGestionhabitaciones = new System.Windows.Forms.DataGridView();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestionhabitaciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo gestion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo habitacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo gestion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha Gestion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(280, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Modulo Gestion Habitaciones";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(609, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fecha actual";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(702, 28);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(75, 13);
            this.lblfecha.TabIndex = 8;
            this.lblfecha.Text = "Imprimir Fecha";
            // 
            // txtcodigogestion
            // 
            this.txtcodigogestion.BackColor = System.Drawing.SystemColors.Control;
            this.txtcodigogestion.Location = new System.Drawing.Point(112, 14);
            this.txtcodigogestion.Name = "txtcodigogestion";
            this.txtcodigogestion.Size = new System.Drawing.Size(100, 20);
            this.txtcodigogestion.TabIndex = 9;
            // 
            // cboxcodigoempleado
            // 
            this.cboxcodigoempleado.FormattingEnabled = true;
            this.cboxcodigoempleado.Location = new System.Drawing.Point(112, 49);
            this.cboxcodigoempleado.Name = "cboxcodigoempleado";
            this.cboxcodigoempleado.Size = new System.Drawing.Size(121, 21);
            this.cboxcodigoempleado.TabIndex = 10;
            // 
            // cboxestado
            // 
            this.cboxestado.FormattingEnabled = true;
            this.cboxestado.Items.AddRange(new object[] {
            "Creada",
            "Pendiente",
            "Progreso",
            "Completa",
            "Cancelada"});
            this.cboxestado.Location = new System.Drawing.Point(112, 155);
            this.cboxestado.Name = "cboxestado";
            this.cboxestado.Size = new System.Drawing.Size(121, 21);
            this.cboxestado.TabIndex = 12;
            // 
            // cboxtipogestion
            // 
            this.cboxtipogestion.FormattingEnabled = true;
            this.cboxtipogestion.Items.AddRange(new object[] {
            "Preparacion",
            "Limpieza",
            "Observacion",
            "Alimentacion"});
            this.cboxtipogestion.Location = new System.Drawing.Point(112, 102);
            this.cboxtipogestion.Name = "cboxtipogestion";
            this.cboxtipogestion.Size = new System.Drawing.Size(121, 21);
            this.cboxtipogestion.TabIndex = 13;
            // 
            // cboxcodigohabitacion
            // 
            this.cboxcodigohabitacion.FormattingEnabled = true;
            this.cboxcodigohabitacion.Location = new System.Drawing.Point(112, 77);
            this.cboxcodigohabitacion.Name = "cboxcodigohabitacion";
            this.cboxcodigohabitacion.Size = new System.Drawing.Size(121, 21);
            this.cboxcodigohabitacion.TabIndex = 14;
            // 
            // dtpFechagestion
            // 
            this.dtpFechagestion.Location = new System.Drawing.Point(112, 127);
            this.dtpFechagestion.Name = "dtpFechagestion";
            this.dtpFechagestion.Size = new System.Drawing.Size(200, 20);
            this.dtpFechagestion.TabIndex = 15;
            // 
            // dgvGestionhabitaciones
            // 
            this.dgvGestionhabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGestionhabitaciones.Location = new System.Drawing.Point(12, 243);
            this.dgvGestionhabitaciones.Name = "dgvGestionhabitaciones";
            this.dgvGestionhabitaciones.Size = new System.Drawing.Size(776, 175);
            this.dgvGestionhabitaciones.TabIndex = 16;
            this.dgvGestionhabitaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGestionhabitaciones_CellClick);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(690, 95);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(98, 23);
            this.btnagregar.TabIndex = 17;
            this.btnagregar.Text = "➕AGREGAR";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(690, 148);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(98, 23);
            this.btneditar.TabIndex = 18;
            this.btneditar.Text = "✏EDITAR";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(690, 201);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(98, 23);
            this.btncancelar.TabIndex = 19;
            this.btncancelar.Text = "🚮CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(542, 424);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(93, 23);
            this.btneliminar.TabIndex = 20;
            this.btneliminar.Text = "❌ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(677, 424);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(91, 23);
            this.btnsalir.TabIndex = 21;
            this.btnsalir.Text = "⭕ SALIR";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFechagestion);
            this.groupBox1.Controls.Add(this.cboxcodigohabitacion);
            this.groupBox1.Controls.Add(this.cboxtipogestion);
            this.groupBox1.Controls.Add(this.cboxestado);
            this.groupBox1.Controls.Add(this.cboxcodigoempleado);
            this.groupBox1.Controls.Add(this.txtcodigogestion);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 195);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // GestionHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dgvGestionhabitaciones);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Name = "GestionHabitacion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestionhabitaciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.TextBox txtcodigogestion;
        private System.Windows.Forms.ComboBox cboxcodigoempleado;
        private System.Windows.Forms.ComboBox cboxestado;
        private System.Windows.Forms.ComboBox cboxtipogestion;
        private System.Windows.Forms.ComboBox cboxcodigohabitacion;
        private System.Windows.Forms.DateTimePicker dtpFechagestion;
        private System.Windows.Forms.DataGridView dgvGestionhabitaciones;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

