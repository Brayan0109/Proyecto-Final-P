namespace Sistema_Proyecto
{
    partial class FrmModulomedicamentos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.dtpfechaven = new System.Windows.Forms.DateTimePicker();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCos = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtCodigoM = new System.Windows.Forms.TextBox();
            this.cboxEstado = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxTM = new System.Windows.Forms.ComboBox();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dvgMedicamentos = new System.Windows.Forms.DataGridView();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMedicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btncancelar);
            this.groupBox1.Controls.Add(this.dtpfechaven);
            this.groupBox1.Controls.Add(this.txtstock);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtCos);
            this.groupBox1.Controls.Add(this.txtN);
            this.groupBox1.Controls.Add(this.txtCodigoM);
            this.groupBox1.Controls.Add(this.cboxEstado);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboxTM);
            this.groupBox1.Controls.Add(this.btneditar);
            this.groupBox1.Controls.Add(this.btnagregar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 241);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(525, 171);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(102, 27);
            this.btncancelar.TabIndex = 29;
            this.btncancelar.Text = "✖Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // dtpfechaven
            // 
            this.dtpfechaven.Location = new System.Drawing.Point(128, 171);
            this.dtpfechaven.Name = "dtpfechaven";
            this.dtpfechaven.Size = new System.Drawing.Size(200, 20);
            this.dtpfechaven.TabIndex = 28;
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(128, 143);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(100, 20);
            this.txtstock.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 182);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Fecha vencimiento";
            // 
            // txtCos
            // 
            this.txtCos.Location = new System.Drawing.Point(128, 115);
            this.txtCos.Name = "txtCos";
            this.txtCos.ReadOnly = true;
            this.txtCos.Size = new System.Drawing.Size(100, 20);
            this.txtCos.TabIndex = 20;
            this.txtCos.TextChanged += new System.EventHandler(this.txtCos_TextChanged);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(128, 46);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 19;
            // 
            // txtCodigoM
            // 
            this.txtCodigoM.Location = new System.Drawing.Point(128, 16);
            this.txtCodigoM.Name = "txtCodigoM";
            this.txtCodigoM.ReadOnly = true;
            this.txtCodigoM.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoM.TabIndex = 18;
            this.txtCodigoM.TextChanged += new System.EventHandler(this.txtCodigoM_TextChanged);
            // 
            // cboxEstado
            // 
            this.cboxEstado.FormattingEnabled = true;
            this.cboxEstado.Items.AddRange(new object[] {
            "Dsiponibe",
            "Vencido",
            "Agotado",
            "Retirado",
            "Transito"});
            this.cboxEstado.Location = new System.Drawing.Point(128, 199);
            this.cboxEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxEstado.Name = "cboxEstado";
            this.cboxEstado.Size = new System.Drawing.Size(140, 21);
            this.cboxEstado.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 19);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Codigo Medicamento";
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
            this.label4.Location = new System.Drawing.Point(16, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Stock";
            // 
            // cboxTM
            // 
            this.cboxTM.FormattingEnabled = true;
            this.cboxTM.Items.AddRange(new object[] {
            "Jarabe",
            "Suero",
            "Crema",
            "Tableta",
            "Aereosol",
            "Inyeccion"});
            this.cboxTM.Location = new System.Drawing.Point(128, 83);
            this.cboxTM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxTM.Name = "cboxTM";
            this.cboxTM.Size = new System.Drawing.Size(140, 21);
            this.cboxTM.TabIndex = 10;
            this.cboxTM.SelectedIndexChanged += new System.EventHandler(this.cboxTM_SelectedIndexChanged);
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
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(525, 65);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(102, 27);
            this.btnagregar.TabIndex = 6;
            this.btnagregar.Text = "➕AGREGAR";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Costo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo Medicamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(471, 374);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(102, 27);
            this.btneliminar.TabIndex = 8;
            this.btneliminar.Text = "✖ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gabriola", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(380, -8);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 39);
            this.label6.TabIndex = 25;
            this.label6.Text = "Modulo Medicamento";
            // 
            // dvgMedicamentos
            // 
            this.dvgMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgMedicamentos.Location = new System.Drawing.Point(13, 317);
            this.dvgMedicamentos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dvgMedicamentos.Name = "dvgMedicamentos";
            this.dvgMedicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgMedicamentos.Size = new System.Drawing.Size(410, 184);
            this.dvgMedicamentos.TabIndex = 24;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(592, 374);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(102, 27);
            this.btnsalir.TabIndex = 27;
            this.btnsalir.Text = "⭕ Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(564, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Fecha actual:";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(644, 9);
            this.lblfecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(72, 13);
            this.lblfecha.TabIndex = 29;
            this.lblfecha.Text = "Imprimir fecha";
            // 
            // FrmModulomedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dvgMedicamentos);
            this.Controls.Add(this.btneliminar);
            this.Name = "FrmModulomedicamentos";
            this.Text = "Modulomedicamentos";
            this.Load += new System.EventHandler(this.Modulomedicamentos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMedicamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCos;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtCodigoM;
        private System.Windows.Forms.ComboBox cboxEstado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dvgMedicamentos;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.ComboBox cboxTM;
        private System.Windows.Forms.DateTimePicker dtpfechaven;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblfecha;
    }
}