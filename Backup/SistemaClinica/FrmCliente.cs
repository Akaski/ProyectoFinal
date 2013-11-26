using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Negocio;

namespace SistemaClinica
{
    public partial class FrmCliente : Form
    {
        Negocio.CCliente objcliente = new Negocio.CCliente();
        SqlConnection conexion = new SqlConnection();
        public FrmCliente()
        {
            InitializeComponent();
            InicializarConexion();
            CargarDatos();
        }

        public void InicializarConexion()
        {
            string c = @"Data Source= REY-PC\SQL2008R2;Initial Catalog= dbclinica;Integrated Security= true";
            conexion.ConnectionString = c;
        }
        public void CargarDatos()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Cliente", conexion);
            sda.Fill(dt);
            this.dgvcliente.DataSource = dt;
        }
        public void Limpiar()
        {
            txtid.Clear();
            txtnombre.Clear();
            txtpaterno.Clear();
            txtmaterno.Clear();
            txtci.Clear();
            txtdireccion.Clear();
            txttelefono.Clear();

        }
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnombre.Text != "")
                {
                    objcliente.p_nombre = txtnombre.Text;
                    objcliente.p_appaterno = txtpaterno.Text;
                    objcliente.p_apmaterno = txtmaterno.Text;
                    objcliente.p_ci = txtci.Text;
                    objcliente.p_direccion = txtdireccion.Text;
                    objcliente.p_telefono = txttelefono.Text;

                    if (objcliente.guardar() == 1)
                    {
                        lblresultado.Text = "Guardado Correctamente";
                        Limpiar();
                        CargarDatos();
                    }
                    else
                    {
                        lblresultado.Text = "Error al Guardar";
                    }
                }
                else
                {
                    lblresultado.Text = "Inserte Datos del Cliente";
                }

            }
            catch (Exception E)
            {
                lblresultado.Text = E.Message;


            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtid.Text != "")
                {
                    objcliente.p_idCliente = int.Parse(txtid.Text);
                    objcliente.p_nombre = txtnombre.Text;
                    objcliente.p_appaterno = txtpaterno.Text;
                    objcliente.p_apmaterno = txtmaterno.Text;
                    objcliente.p_ci = txtci.Text;
                    objcliente.p_direccion = txtdireccion.Text;
                    objcliente.p_telefono = txttelefono.Text;

                    if (objcliente.modificar() == 1)
                    {
                        lblresultado.Text = "Modificado Correctamente";
                        Limpiar();
                        CargarDatos();
                    }
                    else
                    {
                        lblresultado.Text = "Error al Modificar";
                    }
                }
                else
                {
                    lblresultado.Text = "Buscar un Cliente para Modificar";
                }

            }
             catch (Exception E)
            {
                lblresultado.Text = E.Message;


            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtid.Text != "")
                {
                    objcliente.p_idCliente = int.Parse(txtid.Text);
                    objcliente.p_nombre = txtnombre.Text;
                    objcliente.p_appaterno = txtpaterno.Text;
                    objcliente.p_apmaterno = txtmaterno.Text;
                    objcliente.p_ci = txtci.Text;
                    objcliente.p_direccion = txtdireccion.Text;
                    objcliente.p_telefono = txttelefono.Text;
                    if (objcliente.eliminar() == 1)
                    {
                        lblresultado.Text = "Eliminado Correctamente";
                        Limpiar();
                        CargarDatos();
                    }
                    else
                    {
                        lblresultado.Text = "Error al Eliminar";
                    }
                }
                else
                {
                    lblresultado.Text = "Buscar un Cliente para Eliminar";
                }

            }
            catch (Exception E)
            {
                lblresultado.Text = E.Message;


            }
           
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.FrmRptCliente f = new Reportes.FrmRptCliente();
            f.ShowDialog();
        }

        private void dgvcliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtid.Text = dgvcliente[0, e.RowIndex].Value.ToString();
                txtnombre.Text = dgvcliente[1, e.RowIndex].Value.ToString();
                txtpaterno.Text = dgvcliente[2, e.RowIndex].Value.ToString();
                txtmaterno.Text = dgvcliente[3, e.RowIndex].Value.ToString();
                txtci.Text = dgvcliente[4, e.RowIndex].Value.ToString();
                txtdireccion.Text = dgvcliente[5, e.RowIndex].Value.ToString();
                txttelefono.Text = dgvcliente[6, e.RowIndex].Value.ToString();

            }
        }

       

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
