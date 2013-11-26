using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaClinica
{
    public partial class FrmTrabajo : Form
    {
        Negocio.CTrabajo objtrabajo2 = new Negocio.CTrabajo();
        SqlConnection conexion = new SqlConnection();
        public FrmTrabajo()
        {
            InitializeComponent();
            InicializarConexion();
            CargarDatos();
        }
        public void InicializarConexion()
        {
            string c = @"Data Source=GROVER-PC;Initial Catalog= dbclinica;Integrated Security= true";
            conexion.ConnectionString = c;
        }
        public void CargarDatos()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from trabajo", conexion);
            sda.Fill(dt);
            this.dgvtrabajo.DataSource = dt;
        }
        public void limpiar()
        {
            txtid.Clear();
            txtdescripcion.Clear();
            txtprecio.Clear();
        }
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtdescripcion.Text != "")
                {
                    objtrabajo2.p_descripcion = txtdescripcion.Text;
                    objtrabajo2.p_precio = txtprecio.Text;

                    if (objtrabajo2.guardar() == 1)
                    {
                        lblresultado1.Text = "Guardado Correctamente";
                        limpiar();
                        CargarDatos();
                    }
                    else
                    {
                        lblresultado1.Text = "Error al Guardar";
                    }
                }
                else
                {
                    lblresultado1.Text = "Inserte Datos del Trabajo";
                }

            }
            catch (Exception E)
            {
                lblresultado1.Text = E.Message;


            }
            
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtid.Text != "")
                {
                    objtrabajo2.p_idtrabajo = int.Parse(txtid.Text);
                    objtrabajo2.p_descripcion = txtdescripcion.Text;
                    objtrabajo2.p_precio = txtprecio.Text;

                    if (objtrabajo2.eliminar() == 1)
                    {
                        lblresultado1.Text = "Eliminado Correctamente";
                        limpiar();
                        CargarDatos();
                    }
                    else
                    {
                        lblresultado1.Text = "Error al Eliminar";
                    }
                }
                else
                {
                    lblresultado1.Text = "Buscar un Trabajo para Eliminar";
                }

            }
            catch (Exception E)
            {
                lblresultado1.Text = E.Message;


            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtid.Text != "")
                {
                    objtrabajo2.p_idtrabajo = int.Parse(txtid.Text);
                    objtrabajo2.p_descripcion = txtdescripcion.Text;
                    objtrabajo2.p_precio = txtprecio.Text;


                    if (objtrabajo2.modificar() == 1)
                    {
                        lblresultado1.Text = "Modificado Correctamente";
                        limpiar();
                        CargarDatos();
                    }
                    else
                    {
                        lblresultado1.Text = "Error al Modificar";
                    }
                }
                else
                {
                    lblresultado1.Text = "Buscar un Trabajo para Modificar";
                }

            }
            catch (Exception E)
            {
                lblresultado1.Text = E.Message;


            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvtrabajo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtid.Text = dgvtrabajo[0, e.RowIndex].Value.ToString();
                txtdescripcion.Text = dgvtrabajo[1, e.RowIndex].Value.ToString();
                txtprecio.Text = dgvtrabajo[2, e.RowIndex].Value.ToString();


            }
        }
    }
}
