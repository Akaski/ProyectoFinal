namespace SistemaClinica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.IDENTIFICACION = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.btningresar = new System.Windows.Forms.Button();
            this.solonumeros1 = new SistemaClinica.solonumeros();
            this.IDENTIFICACION.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // IDENTIFICACION
            // 
            this.IDENTIFICACION.Controls.Add(this.txtusuario);
            this.IDENTIFICACION.Controls.Add(this.solonumeros1);
            this.IDENTIFICACION.Controls.Add(this.label2);
            this.IDENTIFICACION.Controls.Add(this.label1);
            this.IDENTIFICACION.Location = new System.Drawing.Point(30, 28);
            this.IDENTIFICACION.Name = "IDENTIFICACION";
            this.IDENTIFICACION.Size = new System.Drawing.Size(215, 98);
            this.IDENTIFICACION.TabIndex = 0;
            this.IDENTIFICACION.TabStop = false;
            this.IDENTIFICACION.Text = "IDENTIFICACION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PIN";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(87, 24);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(100, 20);
            this.txtusuario.TabIndex = 3;
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(104, 146);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(75, 23);
            this.btningresar.TabIndex = 1;
            this.btningresar.Text = "INGRESAR";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // solonumeros1
            // 
            this.solonumeros1.Location = new System.Drawing.Point(87, 60);
            this.solonumeros1.Name = "solonumeros1";
            this.solonumeros1.Size = new System.Drawing.Size(100, 20);
            this.solonumeros1.TabIndex = 2;
            this.solonumeros1.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 208);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.IDENTIFICACION);
            this.Name = "Form1";
            this.Text = "Form1";
            this.IDENTIFICACION.ResumeLayout(false);
            this.IDENTIFICACION.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox IDENTIFICACION;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private solonumeros solonumeros1;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Button btningresar;


    }
}

