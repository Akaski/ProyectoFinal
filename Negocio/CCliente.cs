using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class CCliente:DAL.TDatosSQL
    {
         #region "Atributos"
        private int idcliente;
        private string nombre;
        private string ap_paterno;
        private string ap_materno;
        private string ci;
        private string direccion;
        private string telefono;
        #endregion
        #region "Constructor"
        public CCliente()
        {
            idcliente = 0;
            nombre = "";
            ap_paterno = "";
            ap_materno = "";
            direccion = "";
            telefono = "";
        }
        #endregion
        #region "Propiedades de Acceso"
        public int p_idCliente
        {
            get { return idcliente; }
            set { idcliente = value; }
        }
        public string p_nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string p_appaterno
        {
            get { return ap_paterno; }
            set { ap_paterno = value; }
        }
        public string p_apmaterno
        {
            get { return ap_materno; }
            set { ap_materno = value; }
        }
        public string p_ci
        {
            get { return ci; }
            set { ci = value; }
        }
        public string p_direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        
        public string p_telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        
        #endregion
        #region"metodos"
        public int ABM(Utilitarios.Utilitarios.Operacion op)
        {
            Object[] p = new Object[9];
            p[0] = op;
            p[1] = idcliente;
            p[2] = nombre;
            p[3] = ap_paterno;
            p[4] = ap_materno;
            p[5] = ci;
            p[6] = direccion;
            p[7] = telefono;
            p[8] = 0;
            return Ejecutar("sp_abmCliente", p);

        }
        public int guardar()
        {
            return ABM(Utilitarios.Utilitarios.Operacion.guardar);
        }
        public int modificar()
        {
            return ABM(Utilitarios.Utilitarios.Operacion.modificar);
        }
        public int eliminar()
        {
            return ABM(Utilitarios.Utilitarios.Operacion.eliminar);
        }
        public DataTable buscar(string criterio)
        {
            Object[] p = new Object[1];
            p[0] = criterio;
            return TraerDataTable("sp_BuscarCliente", p);
        }

        public DataTable Traer_cliente()
        {
            System.Object[] args = new Object[1];
            args[0] = idcliente;
            return TraerDataTable("sp_TraerCliente", args);
        }
        public DataTable traer_Cliente()
        {
            string strselect = "select * from Cliente";
            return this.TraerDataTablestrSql(strselect);
        }
        public DataTable TraerDataTablestrSql(String strSql)
        {
            string pCadenaConexion = @"Data Source=ENRIQUE-PC;Initial Catalog=dbclinica;Integrated Security=true";
            SqlCommand Com = new SqlCommand();
            Com.Connection = new SqlConnection(pCadenaConexion);
            Com.Connection.Open();
            Com.CommandText = strSql;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = Com;

            da.Fill(dt);
            Com.Connection.Close();
            Com.Dispose();
            da.Dispose();
            return dt;
        }
        #endregion
    }
}
