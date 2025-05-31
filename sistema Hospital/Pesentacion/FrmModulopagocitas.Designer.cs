namespace Sistema_Proyecto
{
    partial class modulopagocitas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.cboxCCI = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCPC = new System.Windows.Forms.TextBox();
            this.txtMC = new System.Windows.Forms.TextBox();
            this.txtI = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboxTP = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFP = new System.Windows.Forms.DateTimePicker();
            this.txtD = new System.Windows.Forms.TextBox();
            this.bntcancelar = new System.Windows.Forms.Button();
            this.dvgpagocitas = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgpagocitas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo Cita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monto cita";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Impuestos";
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(690, 79);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(102, 27);
            this.btnagregar.TabIndex = 6;
            this.btnagregar.Text = "➕AGREGAR";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click_1);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(690, 114);
            this.btneditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(102, 27);
            this.btneditar.TabIndex = 7;
            this.btneditar.Text = "✏EDITAR";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click_1);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(506, 341);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(102, 27);
            this.btneliminar.TabIndex = 8;
            this.btneliminar.Text = "✖ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click_1);
            // 
            // cboxCCI
            // 
            this.cboxCCI.FormattingEnabled = true;
            this.cboxCCI.Location = new System.Drawing.Point(128, 44);
            this.cboxCCI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxCCI.Name = "cboxCCI";
            this.cboxCCI.Size = new System.Drawing.Size(140, 21);
            this.cboxCCI.TabIndex = 10;
            this.cboxCCI.SelectedIndexChanged += new System.EventHandler(this.cboxCCI_SelectedIndexChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Descuento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 207);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha pago";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 19);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Codigo Pago Cita";
            // 
            // txtCPC
            // 
            this.txtCPC.Location = new System.Drawing.Point(128, 16);
            this.txtCPC.Name = "txtCPC";
            this.txtCPC.ReadOnly = true;
            this.txtCPC.Size = new System.Drawing.Size(100, 20);
            this.txtCPC.TabIndex = 18;
            // 
            // txtMC
            // 
            this.txtMC.Location = new System.Drawing.Point(128, 84);
            this.txtMC.Name = "txtMC";
            this.txtMC.ReadOnly = true;
            this.txtMC.Size = new System.Drawing.Size(100, 20);
            this.txtMC.TabIndex = 19;
            this.txtMC.TextChanged += new System.EventHandler(this.txtMC_TextChanged);
            // 
            // txtI
            // 
            this.txtI.Location = new System.Drawing.Point(128, 115);
            this.txtI.Name = "txtI";
            this.txtI.ReadOnly = true;
            this.txtI.Size = new System.Drawing.Size(100, 20);
            this.txtI.TabIndex = 20;
            this.txtI.TextChanged += new System.EventHandler(this.txtI_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 182);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Total pago";
            // 
            // txtTP
            // 
            this.txtTP.Location = new System.Drawing.Point(128, 177);
            this.txtTP.Name = "txtTP";
            this.txtTP.ReadOnly = true;
            this.txtTP.Size = new System.Drawing.Size(100, 20);
            this.txtTP.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Tipo pago";
            // 
            // cboxTP
            // 
            this.cboxTP.FormattingEnabled = true;
            this.cboxTP.Items.AddRange(new object[] {
            "Tarjeta ",
            "Efectivo",
            "Tarjeta"});
            this.cboxTP.Location = new System.Drawing.Point(351, 24);
            this.cboxTP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxTP.Name = "cboxTP";
            this.cboxTP.Size = new System.Drawing.Size(140, 21);
            this.cboxTP.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFP);
            this.groupBox1.Controls.Add(this.txtD);
            this.groupBox1.Controls.Add(this.cboxTP);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTP);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtI);
            this.groupBox1.Controls.Add(this.txtMC);
            this.groupBox1.Controls.Add(this.txtCPC);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboxCCI);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 233);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtpFP
            // 
            this.dtpFP.Location = new System.Drawing.Point(128, 203);
            this.dtpFP.Name = "dtpFP";
            this.dtpFP.Size = new System.Drawing.Size(100, 20);
            this.dtpFP.TabIndex = 31;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(128, 150);
            this.txtD.Name = "txtD";
            this.txtD.ReadOnly = true;
            this.txtD.Size = new System.Drawing.Size(100, 20);
            this.txtD.TabIndex = 29;
            this.txtD.TextChanged += new System.EventHandler(this.txtD_TextChanged);
            // 
            // bntcancelar
            // 
            this.bntcancelar.Location = new System.Drawing.Point(690, 161);
            this.bntcancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bntcancelar.Name = "bntcancelar";
            this.bntcancelar.Size = new System.Drawing.Size(102, 27);
            this.bntcancelar.TabIndex = 32;
            this.bntcancelar.Text = "✖Cancelar";
            this.bntcancelar.UseVisualStyleBackColor = true;
            this.bntcancelar.Click += new System.EventHandler(this.bntcancelar_Click);
            // 
            // dvgpagocitas
            // 
            this.dvgpagocitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgpagocitas.Location = new System.Drawing.Point(2, 272);
            this.dvgpagocitas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dvgpagocitas.Name = "dvgpagocitas";
            this.dvgpagocitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgpagocitas.Size = new System.Drawing.Size(470, 176);
            this.dvgpagocitas.TabIndex = 24;
            this.dvgpagocitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgpagocitas_CellClick_1);
            this.dvgpagocitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgpagocitas_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gabriola", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(344, -1);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 39);
            this.label6.TabIndex = 25;
            this.label6.Text = "Modulo Pago Citas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(536, 13);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Fecha actual:";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(616, 13);
            this.lblfecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(72, 13);
            this.lblfecha.TabIndex = 30;
            this.lblfecha.Text = "Imprimir fecha";
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(641, 341);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(102, 27);
            this.btnsalir.TabIndex = 33;
            this.btnsalir.Text = "⭕Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // modulopagocitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.bntcancelar);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dvgpagocitas);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btneditar);
            this.Name = "modulopagocitas";
            this.Text = "modulopagocitas";
            this.Load += new System.EventHandler(this.modulopagocitas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgpagocitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.ComboBox cboxCCI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCPC;
        private System.Windows.Forms.TextBox txtMC;
        private System.Windows.Forms.TextBox txtI;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboxTP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dvgpagocitas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFP;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Button bntcancelar;
        private System.Windows.Forms.Button btnsalir;
    }
}