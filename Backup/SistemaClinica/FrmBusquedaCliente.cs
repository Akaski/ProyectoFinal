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
    public partial class FrmBusquedaCliente : Form
    {
        CCliente objcliente = new CCliente();
        public FrmBusquedaCliente()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtbuscarcliente.Text != "")
            {
                this.dgvbusquedacliente.DataSource = objcliente.buscar(this.txtbuscarcliente.Text);
            }
            else
            {
                MessageBox.Show("Inserte el CI del Cliente a buscar");
            }
        }

        private void dgvbusquedacliente_DoubleClick(object sender, EventArgs e)
        {
            btnaceptar.PerformClick();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            FrmCliente f = new FrmCliente();
            f.Show();
        }
    }
}
