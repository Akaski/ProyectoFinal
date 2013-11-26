namespace SistemaClinica
{
    partial class FrmDetalle
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
            this.components = new System.ComponentModel.Container();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvdetalle = new System.Windows.Forms.DataGridView();
            this.idtrabajoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nropagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleTrabajoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new SistemaClinica.DataSet1();
            this.lblresultado = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvlistatrabajos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.lblclock = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.txtidtrabajo = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmontopago = new System.Windows.Forms.TextBox();
            this.txtnropago = new System.Windows.Forms.TextBox();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleTrabajoTableAdapter = new SistemaClinica.DataSet1TableAdapters.DetalleTrabajoTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleTrabajoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistatrabajos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvdetalle);
            this.groupBox3.Location = new System.Drawing.Point(26, 350);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(674, 137);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de Detalles";
            // 
            // dgvdetalle
            // 
            this.dgvdetalle.AllowUserToAddRows = false;
            this.dgvdetalle.AllowUserToDeleteRows = false;
            this.dgvdetalle.AutoGenerateColumns = false;
            this.dgvdetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtrabajoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.costoDataGridViewTextBoxColumn,
            this.idclienteDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.nropagoDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn});
            this.dgvdetalle.DataSource = this.detalleTrabajoBindingSource;
            this.dgvdetalle.Location = new System.Drawing.Point(14, 13);
            this.dgvdetalle.Name = "dgvdetalle";
            this.dgvdetalle.Size = new System.Drawing.Size(642, 118);
            this.dgvdetalle.TabIndex = 2;
            // 
            // idtrabajoDataGridViewTextBoxColumn
            // 
            this.idtrabajoDataGridViewTextBoxColumn.DataPropertyName = "idtrabajo";
            this.idtrabajoDataGridViewTextBoxColumn.HeaderText = "idtrabajo";
            this.idtrabajoDataGridViewTextBoxColumn.Name = "idtrabajoDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // costoDataGridViewTextBoxColumn
            // 
            this.costoDataGridViewTextBoxColumn.DataPropertyName = "costo";
            this.costoDataGridViewTextBoxColumn.HeaderText = "costo";
            this.costoDataGridViewTextBoxColumn.Name = "costoDataGridViewTextBoxColumn";
            // 
            // idclienteDataGridViewTextBoxColumn
            // 
            this.idclienteDataGridViewTextBoxColumn.DataPropertyName = "idcliente";
            this.idclienteDataGridViewTextBoxColumn.HeaderText = "idcliente";
            this.idclienteDataGridViewTextBoxColumn.Name = "idclienteDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            // 
            // nropagoDataGridViewTextBoxColumn
            // 
            this.nropagoDataGridViewTextBoxColumn.DataPropertyName = "nropago";
            this.nropagoDataGridViewTextBoxColumn.HeaderText = "nropago";
            this.nropagoDataGridViewTextBoxColumn.Name = "nropagoDataGridViewTextBoxColumn";
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            // 
            // detalleTrabajoBindingSource
            // 
            this.detalleTrabajoBindingSource.DataMember = "DetalleTrabajo";
            this.detalleTrabajoBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(195, 147);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(0, 13);
            this.lblresultado.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvlistatrabajos);
            this.groupBox2.Location = new System.Drawing.Point(26, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(674, 137);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista Trabajos";
            // 
            // dgvlistatrabajos
            // 
            this.dgvlistatrabajos.AllowUserToAddRows = false;
            this.dgvlistatrabajos.AllowUserToDeleteRows = false;
            this.dgvlistatrabajos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistatrabajos.Location = new System.Drawing.Point(13, 13);
            this.dgvlistatrabajos.Name = "dgvlistatrabajos";
            this.dgvlistatrabajos.Size = new System.Drawing.Size(642, 118);
            this.dgvlistatrabajos.TabIndex = 2;
            this.dgvlistatrabajos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlistatrabajos_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.txtdescripcion);
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Controls.Add(this.txtidcliente);
            this.groupBox1.Controls.Add(this.txtidtrabajo);
            this.groupBox1.Controls.Add(this.txtprecio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtmontopago);
            this.groupBox1.Controls.Add(this.txtnropago);
            this.groupBox1.Controls.Add(this.txtcliente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 168);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Detalle Trabajo";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.dtfecha);
            this.groupBox4.Controls.Add(this.lblclock);
            this.groupBox4.Location = new System.Drawing.Point(275, 90);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(393, 72);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fecha y Hora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Fecha";
            // 
            // dtfecha
            // 
            this.dtfecha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtfecha.Location = new System.Drawing.Point(58, 36);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(200, 21);
            this.dtfecha.TabIndex = 15;
            // 
            // lblclock
            // 
            this.lblclock.AutoSize = true;
            this.lblclock.Enabled = false;
            this.lblclock.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclock.Location = new System.Drawing.Point(277, 36);
            this.lblclock.Name = "lblclock";
            this.lblclock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblclock.Size = new System.Drawing.Size(76, 27);
            this.lblclock.TabIndex = 20;
            this.lblclock.Text = "label1";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Enabled = false;
            this.txtdescripcion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcion.Location = new System.Drawing.Point(112, 19);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.ReadOnly = true;
            this.txtdescripcion.Size = new System.Drawing.Size(100, 25);
            this.txtdescripcion.TabIndex = 8;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(112, 114);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(90, 23);
            this.btnbuscar.TabIndex = 19;
            this.btnbuscar.Text = "Buscar Cliente";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtidcliente
            // 
            this.txtidcliente.Location = new System.Drawing.Point(557, 12);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.ReadOnly = true;
            this.txtidcliente.Size = new System.Drawing.Size(100, 20);
            this.txtidcliente.TabIndex = 17;
            this.txtidcliente.Visible = false;
            // 
            // txtidtrabajo
            // 
            this.txtidtrabajo.Location = new System.Drawing.Point(557, 52);
            this.txtidtrabajo.Name = "txtidtrabajo";
            this.txtidtrabajo.ReadOnly = true;
            this.txtidtrabajo.Size = new System.Drawing.Size(100, 20);
            this.txtidtrabajo.TabIndex = 16;
            this.txtidtrabajo.Visible = false;
            // 
            // txtprecio
            // 
            this.txtprecio.Enabled = false;
            this.txtprecio.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio.Location = new System.Drawing.Point(112, 55);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.ReadOnly = true;
            this.txtprecio.Size = new System.Drawing.Size(100, 25);
            this.txtprecio.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Precio";
            // 
            // txtmontopago
            // 
            this.txtmontopago.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmontopago.Location = new System.Drawing.Point(373, 59);
            this.txtmontopago.Name = "txtmontopago";
            this.txtmontopago.Size = new System.Drawing.Size(100, 25);
            this.txtmontopago.TabIndex = 11;
            // 
            // txtnropago
            // 
            this.txtnropago.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnropago.Location = new System.Drawing.Point(373, 19);
            this.txtnropago.Name = "txtnropago";
            this.txtnropago.Size = new System.Drawing.Size(100, 25);
            this.txtnropago.TabIndex = 10;
            // 
            // txtcliente
            // 
            this.txtcliente.Enabled = false;
            this.txtcliente.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcliente.Location = new System.Drawing.Point(112, 87);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.ReadOnly = true;
            this.txtcliente.Size = new System.Drawing.Size(100, 25);
            this.txtcliente.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(272, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Monto a Pagar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nro. Pago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Desc. Trabajo";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.registrarTrabajoToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.reporteToolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // registrarTrabajoToolStripMenuItem
            // 
            this.registrarTrabajoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.registrarTrabajoToolStripMenuItem.Name = "registrarTrabajoToolStripMenuItem";
            this.registrarTrabajoToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.registrarTrabajoToolStripMenuItem.Text = "Registrar Trabajo";
            this.registrarTrabajoToolStripMenuItem.Click += new System.EventHandler(this.registrarTrabajoToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.buscarToolStripMenuItem.Text = "Buscar Detalle";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem1
            // 
            this.reporteToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.reporteToolStripMenuItem1.Name = "reporteToolStripMenuItem1";
            this.reporteToolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.reporteToolStripMenuItem1.Text = "Reporte";
            this.reporteToolStripMenuItem1.Click += new System.EventHandler(this.reporteToolStripMenuItem1_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // detalleTrabajoTableAdapter
            // 
            this.detalleTrabajoTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 499);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDetalle";
            this.Text = "FrmDetalle";
            this.Load += new System.EventHandler(this.FrmDetalle_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleTrabajoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistatrabajos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvdetalle;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dgvlistatrabajos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblclock;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtidcliente;
        private System.Windows.Forms.TextBox txtidtrabajo;
        private System.Windows.Forms.DateTimePicker dtfecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmontopago;
        private System.Windows.Forms.TextBox txtnropago;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarTrabajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource detalleTrabajoBindingSource;
        private SistemaClinica.DataSet1TableAdapters.DetalleTrabajoTableAdapter detalleTrabajoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtrabajoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nropagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer timer1;
    }
}