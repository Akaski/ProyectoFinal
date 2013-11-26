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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionClienteToolStripMenuItem,
            this.gestionTrabajoToolStripMenuItem,
            this.buscarDetalleToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(654, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionClienteToolStripMenuItem
            // 
            this.gestionClienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarClienteToolStripMenuItem});
            this.gestionClienteToolStripMenuItem.Name = "gestionClienteToolStripMenuItem";
            this.gestionClienteToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.gestionClienteToolStripMenuItem.Text = "Gestion Cliente";
            // 
            // registrarClienteToolStripMenuItem
            // 
            this.registrarClienteToolStripMenuItem.Name = "registrarClienteToolStripMenuItem";
            this.registrarClienteToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.registrarClienteToolStripMenuItem.Text = "Registrar Cliente";
            this.registrarClienteToolStripMenuItem.Click += new System.EventHandler(this.registrarClienteToolStripMenuItem_Click);
            // 
            // gestionTrabajoToolStripMenuItem
            // 
            this.gestionTrabajoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarTrabajoToolStripMenuItem});
            this.gestionTrabajoToolStripMenuItem.Name = "gestionTrabajoToolStripMenuItem";
            this.gestionTrabajoToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.gestionTrabajoToolStripMenuItem.Text = "Gestion Trabajo";
            // 
            // registrarTrabajoToolStripMenuItem
            // 
            this.registrarTrabajoToolStripMenuItem.Name = "registrarTrabajoToolStripMenuItem";
            this.registrarTrabajoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.registrarTrabajoToolStripMenuItem.Text = "Registrar Trabajo";
            this.registrarTrabajoToolStripMenuItem.Click += new System.EventHandler(this.registrarTrabajoToolStripMenuItem_Click);
            // 
            // buscarDetalleToolStripMenuItem
            // 
            this.buscarDetalleToolStripMenuItem.Name = "buscarDetalleToolStripMenuItem";
            this.buscarDetalleToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.buscarDetalleToolStripMenuItem.Text = "Gestion de Detalle";
            this.buscarDetalleToolStripMenuItem.Click += new System.EventHandler(this.buscarDetalleToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 365);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}