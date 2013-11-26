using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaClinica
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente formcli = new FrmCliente();
            formcli.Show();
        }

        private void registrarTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrabajo fr = new FrmTrabajo();
            fr.Show();
        }

        private void buscarDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDetalle fr = new FrmDetalle();
            fr.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
       
    }
}
