namespace SistemaClinica
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarDetalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionClienteToolStripMenuItem,
            this.gestionTrabajoToolStripMenuItem,
            this.buscarDetalleToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(427, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionClienteToolStripMenuItem
            // 
            this.gestionClienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarClienteToolStripMenuItem});
            this.gestionClienteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gestionClienteToolStripMenuItem.Name = "gestionClienteToolStripMenuItem";
            this.gestionClienteToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.gestionClienteToolStripMenuItem.Text = "GESTION CLIENTE";
            // 
            // registrarClienteToolStripMenuItem
            // 
            this.registrarClienteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.registrarClienteToolStripMenuItem.Name = "registrarClienteToolStripMenuItem";
            this.registrarClienteToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.registrarClienteToolStripMenuItem.Text = "Registrar Cliente";
            this.registrarClienteToolStripMenuItem.Click += new System.EventHandler(this.registrarClienteToolStripMenuItem_Click);
            // 
            // gestionTrabajoToolStripMenuItem
            // 
            this.gestionTrabajoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarTrabajoToolStripMenuItem});
            this.gestionTrabajoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gestionTrabajoToolStripMenuItem.Name = "gestionTrabajoToolStripMenuItem";
            this.gestionTrabajoToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.gestionTrabajoToolStripMenuItem.Text = "GESTION TRABAJO";
            // 
            // registrarTrabajoToolStripMenuItem
            // 
            this.registrarTrabajoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.registrarTrabajoToolStripMenuItem.Name = "registrarTrabajoToolStripMenuItem";
            this.registrarTrabajoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.registrarTrabajoToolStripMenuItem.Text = "Registrar Trabajo";
            this.registrarTrabajoToolStripMenuItem.Click += new System.EventHandler(this.registrarTrabajoToolStripMenuItem_Click);
            // 
            // buscarDetalleToolStripMenuItem
            // 
            this.buscarDetalleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buscarDetalleToolStripMenuItem.Name = "buscarDetalleToolStripMenuItem";
            this.buscarDetalleToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.buscarDetalleToolStripMenuItem.Text = "GESTION DETALLE";
            this.buscarDetalleToolStripMenuItem.Click += new System.EventHandler(this.buscarDetalleToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.salirToolStripMenuItem.Text = "SALIR";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaClinica.Properties.Resources.clc3adnica_dental_art_dent_7;
            this.pictureBox1.Location = new System.Drawing.Point(22, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(132, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "CLINICA BLUE-DENT";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionTrabajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarTrabajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarDetalleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}