namespace Sistema_Proyecto
{
    partial class FrmModulopagoempleado
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
            this.lblfecha = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxcodigoempleado = new System.Windows.Forms.ComboBox();
            this.txttotalmonto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMontohorasextras = new System.Windows.Forms.TextBox();
            this.dtpfechapago = new System.Windows.Forms.DateTimePicker();
            this.txtbono = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtPagoempleados = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxestado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.dvgEmpleados = new System.Windows.Forms.DataGridView();
            this.btneliminar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(644, 16);
            this.lblfecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(72, 13);
            this.lblfecha.TabIndex = 36;
            this.lblfecha.Text = "Imprimir fecha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(564, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Fecha actual:";
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(592, 381);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(102, 27);
            this.btnsalir.TabIndex = 34;
            this.btnsalir.Text = "⭕ Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxcodigoempleado);
            this.groupBox1.Controls.Add(this.txttotalmonto);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtMontohorasextras);
            this.groupBox1.Controls.Add(this.dtpfechapago);
            this.groupBox1.Controls.Add(this.txtbono);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSueldo);
            this.groupBox1.Controls.Add(this.txtPagoempleados);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboxestado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 241);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // cboxcodigoempleado
            // 
            this.cboxcodigoempleado.FormattingEnabled = true;
            this.cboxcodigoempleado.Location = new System.Drawing.Point(144, 49);
            this.cboxcodigoempleado.Name = "cboxcodigoempleado";
            this.cboxcodigoempleado.Size = new System.Drawing.Size(121, 21);
            this.cboxcodigoempleado.TabIndex = 36;
            this.cboxcodigoempleado.SelectedIndexChanged += new System.EventHandler(this.cboxcodigoempleado_SelectedIndexChanged);
            // 
            // txttotalmonto
            // 
            this.txttotalmonto.Location = new System.Drawing.Point(372, 19);
            this.txttotalmonto.Name = "txttotalmonto";
            this.txttotalmonto.ReadOnly = true;
            this.txttotalmonto.Size = new System.Drawing.Size(100, 20);
            this.txttotalmonto.TabIndex = 35;
            this.txttotalmonto.TextChanged += new System.EventHandler(this.txttotalmonto_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(265, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Total monto";
            // 
            // txtMontohorasextras
            // 
            this.txtMontohorasextras.Location = new System.Drawing.Point(128, 171);
            this.txtMontohorasextras.Name = "txtMontohorasextras";
            this.txtMontohorasextras.Size = new System.Drawing.Size(100, 20);
            this.txtMontohorasextras.TabIndex = 33;
            this.txtMontohorasextras.TextChanged += new System.EventHandler(this.txtMontohorasextras_TextChanged);
            // 
            // dtpfechapago
            // 
            this.dtpfechapago.Location = new System.Drawing.Point(128, 76);
            this.dtpfechapago.Name = "dtpfechapago";
            this.dtpfechapago.Size = new System.Drawing.Size(200, 20);
            this.dtpfechapago.TabIndex = 28;
            // 
            // txtbono
            // 
            this.txtbono.Location = new System.Drawing.Point(128, 143);
            this.txtbono.Name = "txtbono";
            this.txtbono.ReadOnly = true;
            this.txtbono.Size = new System.Drawing.Size(100, 20);
            this.txtbono.TabIndex = 27;
            this.txtbono.TextChanged += new System.EventHandler(this.txtbono_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 83);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Fecha pago";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gabriola", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(318, -38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 39);
            this.label6.TabIndex = 32;
            this.label6.Text = "Modulo Pago empleados";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(128, 109);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.ReadOnly = true;
            this.txtSueldo.Size = new System.Drawing.Size(100, 20);
            this.txtSueldo.TabIndex = 20;
            this.txtSueldo.TextChanged += new System.EventHandler(this.txtSueldo_TextChanged);
            // 
            // txtPagoempleados
            // 
            this.txtPagoempleados.Location = new System.Drawing.Point(144, 16);
            this.txtPagoempleados.Name = "txtPagoempleados";
            this.txtPagoempleados.ReadOnly = true;
            this.txtPagoempleados.Size = new System.Drawing.Size(100, 20);
            this.txtPagoempleados.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 19);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Codigo pago empleados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 207);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Bono";
            // 
            // cboxestado
            // 
            this.cboxestado.FormattingEnabled = true;
            this.cboxestado.Items.AddRange(new object[] {
            "Pendiente",
            "Proceso",
            "Pagado",
            "Rechazado"});
            this.cboxestado.Location = new System.Drawing.Point(114, 199);
            this.cboxestado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxestado.Name = "cboxestado";
            this.cboxestado.Size = new System.Drawing.Size(140, 21);
            this.cboxestado.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sueldo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monto Horas Extras";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo empleados";
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(685, 156);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(102, 27);
            this.btncancelar.TabIndex = 29;
            this.btncancelar.Text = "✖Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(685, 119);
            this.btneditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(102, 27);
            this.btneditar.TabIndex = 7;
            this.btneditar.Text = "✏EDITAR";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(685, 82);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(102, 27);
            this.btnagregar.TabIndex = 6;
            this.btnagregar.Text = "➕AGREGAR";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // dvgEmpleados
            // 
            this.dvgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgEmpleados.Location = new System.Drawing.Point(13, 324);
            this.dvgEmpleados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dvgEmpleados.Name = "dvgEmpleados";
            this.dvgEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgEmpleados.Size = new System.Drawing.Size(410, 184);
            this.dvgEmpleados.TabIndex = 31;
            this.dvgEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgEmpleados_CellClick);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(471, 381);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(102, 27);
            this.btneliminar.TabIndex = 30;
            this.btneliminar.Text = "✖ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gabriola", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(360, 2);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 39);
            this.label8.TabIndex = 37;
            this.label8.Text = "Modulo Pago Empleados";
            // 
            // FrmModulopagoempleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dvgEmpleados);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btneditar);
            this.Name = "FrmModulopagoempleado";
            this.Text = "Modulopagoempleado";
            this.Load += new System.EventHandler(this.Modulopagoempleado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.DateTimePicker dtpfechapago;
        private System.Windows.Forms.TextBox txtbono;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.TextBox txtPagoempleados;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxestado;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dvgEmpleados;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttotalmonto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMontohorasextras;
        private System.Windows.Forms.ComboBox cboxcodigoempleado;
    }
}