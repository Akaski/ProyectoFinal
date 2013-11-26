using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocio;
using Reportes;
using System.Data.SqlClient;

namespace SistemaClinica
{
    public partial class FrmDetalle : Form
    {
        FrmTrabajo frm = new FrmTrabajo();
        SqlConnection conexion = new SqlConnection();
        public FrmDetalle()
        {
            InitializeComponent();
            InicializarConexion();
            CargarDatos();
            CargarDatos1();
        }
        public void InicializarConexion()
        {
            string c = @"Data Source=GROVER-PC;Initial Catalog=dbclinica;Integrated Security= true";
           
            conexion.ConnectionString = c;
        }
        public void CargarDatos()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from trabajo", conexion);
            sda.Fill(dt);
            this.dgvlistatrabajos.DataSource = dt;
        }
        public void CargarDatos1()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from DetalleTrabajo", conexion);
            sda.Fill(dt);
            this.dgvdetalle.DataSource = dt;
        }
        public void mostrar()
        {
            dgvdetalle.DataSource = CDetalle.GetInstance().getAll();
        }
        public void Limpiar()
        {
            txtidtrabajo.Clear();
            txtdescripcion.Clear();
            txtidcliente.Clear();
            txtnropago.Clear();
            txtmontopago.Clear();
        }
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtidtrabajo.Text != "")
                {
                    DetalleTrabajo objde = new DetalleTrabajo();
                    objde.idtrabajo = int.Parse(txtidtrabajo.Text);
                    objde.descripcion = txtdescripcion.Text;
                    objde.costo = txtprecio.Text;
                    objde.idcliente = txtidcliente.Text;
                    objde.fecha = DateTime.Parse(dtfecha.Text);
                    objde.hora = lblclock.Text;
                    objde.nropago = int.Parse(txtnropago.Text);
                    objde.monto = int.Parse(txtmontopago.Text);
                    CDetalle.GetInstance().adicionar(objde);
                    mostrar();
                    Limpiar();

                    MessageBox.Show("Detalle guardado");
                }
                else
                {
                    MessageBox.Show("Inserte Datos del Detalle");
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Hay Un Error" + E);
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void registrarTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frm.Show();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBusquedaCliente oform = new FrmBusquedaCliente();
            try
            {
                if (oform.ShowDialog() == DialogResult.OK)
                {
                    string cod = (string)oform.dgvbusquedacliente.CurrentRow.Cells[4].Value;
                    string nombre = (string)oform.dgvbusquedacliente.CurrentRow.Cells[1].Value;
                    MessageBox.Show("El Codigo del Cliente Seleccionado es: " + (cod.ToString()));
                    txtidcliente.Text = ((cod));
                    txtcliente.Text = ((nombre));

                }
            }
            catch (Exception )
            {
                MessageBox.Show("Seleccione un Cliente");
            }
        }


        private void tmrRefesh_Tick(object sender, EventArgs e)
        {
            lblclock.Text = DateTime.Now.ToLongTimeString();
        }

        private void dgvlistatrabajos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtidtrabajo.Text = dgvlistatrabajos[0, e.RowIndex].Value.ToString();
                txtdescripcion.Text = dgvlistatrabajos[1, e.RowIndex].Value.ToString();
                txtprecio.Text = dgvlistatrabajos[2, e.RowIndex].Value.ToString();


            }
        }

        

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarDetalle f = new FrmBuscarDetalle();
            f.ShowDialog();
        }

        private void reporteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reportes.Frmreportes fr = new Frmreportes();
            fr.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDetalle_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblclock.Text = DateTime.Now.ToLongTimeString();
        }

      
        }
    }

