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
    public partial class Frmreportes : Form
    {
        public Frmreportes()
        {
            InitializeComponent();
        }
        private void mostrarreporte()
        {
            Reportes.CReporte objctrlreportes = new Reportes.CReporte();

            Reportes.RptDetalle objlistadoxcat = new Reportes.RptDetalle();
            objlistadoxcat.SetDataSource(objctrlreportes.Ficha_Detalle());
            this.Visor.ReportSource = objlistadoxcat;

        }

        private void Frmreportes_Load(object sender, EventArgs e)
        {
            mostrarreporte();
        }

        private void Visor_Load(object sender, EventArgs e)
        {

        }
    }
}
