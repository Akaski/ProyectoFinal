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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // lblclock.Text= DateTime.Now.ToLongTimeString();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            FrmPrincipal oprin = new FrmPrincipal();
            if (txtusuario.Text.ToUpper() == "ENRIQUE" && solonumeros1.Text.ToUpper() == "123")
                oprin.ShowDialog();
            else
                MessageBox.Show("Usuario no identificado");
        }

       
        
    }
}
