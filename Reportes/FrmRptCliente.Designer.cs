namespace Reportes
{
    partial class FrmRptCliente
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
            this.Visor1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // Visor1
            // 
            this.Visor1.ActiveViewIndex = -1;
            this.Visor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Visor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Visor1.Location = new System.Drawing.Point(0, 0);
            this.Visor1.Name = "Visor1";
            this.Visor1.SelectionFormula = "";
            this.Visor1.Size = new System.Drawing.Size(292, 266);
            this.Visor1.TabIndex = 0;
            this.Visor1.ViewTimeSelectionFormula = "";
            // 
            // FrmRptCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.Visor1);
            this.Name = "FrmRptCliente";
            this.Text = "FrmRptCliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRptCliente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer Visor1;
    }
}