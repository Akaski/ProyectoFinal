using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocio;

namespace SistemaClinica
{
    public partial class FrmBuscarDetalle : Form
    {
        CDetalle objd = new CDetalle();
        public FrmBuscarDetalle()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtbuscar.Text != "")
            {
                this.dgvbusdetalle.DataSource = objd.Buscar_Detalle(this.txtbuscar.Text);
            }
            else
            {
                MessageBox.Show("Inserte el CI del cliente a Buscar");
            }
        }
    }
}
