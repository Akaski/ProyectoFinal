using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reportes
{
    public partial class FrmRptCliente : Form
    {
        public FrmRptCliente()
        {
            InitializeComponent();
        }
        private void mostrarreporte()
        {
            Reportes.CReporte objctrlreportes = new Reportes.CReporte();

            Reportes.RptClientes objlistadoxcat = new Reportes.RptClientes();
            objlistadoxcat.SetDataSource(objctrlreportes.Ficha_Clientes());
            this.Visor1.ReportSource = objlistadoxcat;

        }

        private void FrmRptCliente_Load(object sender, EventArgs e)
        {
            mostrarreporte();
        }
    }
}
