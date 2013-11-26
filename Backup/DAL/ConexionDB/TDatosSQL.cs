﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class TDatosSQL
    {
        #region "Atributos"

        protected string Servidor;
        protected string BaseDatos;
        protected string Usuario;
        protected string Password;
        protected bool ModoMixto;
        protected string CadenaConexion;
        protected SqlConnection mConexion;
        protected System.Collections.Hashtable ColComandos = new System.Collections.Hashtable();

        #endregion

        #region "Constructores"

        public TDatosSQL()
        {
            Servidor = @"REY-PC\SQL2008R2";
            BaseDatos = "dbclinica";
            Usuario = "";
            Password = "";
            ModoMixto = false;
            CadenaConexion = pCadenaConexion;
        }

        #endregion

        #region "Propiedades"

        /// <summary>
        /// Nombre del equipo servidor de datos.
        /// </summary>

        public string pServidor
        {
            get
            {
                return Servidor;
            }
            set
            {
                Servidor = value;
            }
        }

        /// <summary>
        /// Nombre de la base de datos a utilizar.
        /// </summary>

        public string pBaseDatos
        {
            get
            {
                return BaseDatos;
            }
            set
            {
                BaseDatos = value;
            }
        }

        /// <summary>
        /// Cadena de conexión completa a la base.
        /// </summary>

        public string pCadenaConexion
        {
            get
            {
                if ((Servidor.Length != 0) && (BaseDatos.Length != 0))
                {
                    System.Text.StringBuilder strCadena = new System.Text.StringBuilder();
                    Servidor = @"REY-PC\SQL2008R2";
                    BaseDatos = "dbclinica";
                    if (ModoMixto == true)
                    {
                        strCadena.Append("data source=<SERVIDOR>;");
                        strCadena.Append("initial catalog=<BASEDATOS>;password='';");
                        strCadena.Append("persist security info=True;");
                        strCadena.Append("user id=<USUARIO>;pwd=<PASSWORD>;packet size=4096");
                        strCadena.Replace("<USUARIO>", this.Usuario);/// 'PARA REEMPLAZAR LOS VALORES DE strCadena
                        strCadena.Replace("<SERVIDOR>", this.Servidor);/// 'PARA REEMPLAZAR LOS VALORES DE strCadena
                        strCadena.Replace("<BASEDATOS>", this.BaseDatos);/// ' IDEM PARA BASE DE DATOS
                        strCadena.Replace("<PASSWORD>", this.Password);/// 'IDEM PARA PASSWORD
                    }
                    else
                    {
                        ///CadenaConexion = "Data Source=PC-10AF49FB76BE\SQLEXPRESS;Initial Catalog=db_sipad;Integrated Security=True"
                        strCadena.Append("data source=<SERVIDOR>;");
                        strCadena.Append("initial catalog=<BASEDATOS>;");
                        strCadena.Append("Integrated Security=True");
                        strCadena.Replace("<SERVIDOR>", this.Servidor);/// 'PARA REEMPLAZAR LOS VALORES DE strCadena
                        strCadena.Replace("<BASEDATOS>", this.BaseDatos);/// ' IDEM PARA BASE DE DATOS
                    }
                    return strCadena.ToString();
                }
                else
                {
                    System.Exception Ex = new System.Exception("No se puede establecer la cadena de conexión");
                    throw Ex;
                }
            }
            set
            {
                CadenaConexion = value;
            }
        }

        #endregion

        #region "Privadas"
        /// <summary>
        /// Crea u obtiene un objeto para conectarse a la base de dtaos.
        /// </summary>
        protected SqlConnection CrearConexion(string CadenaConexion)
        {
            return (SqlConnection)new System.Data.SqlClient.SqlConnection(CadenaConexion);
        }


        protected SqlConnection Conexion
        {
            get
            {
                if (null == mConexion)
                {
                    mConexion = CrearConexion(pCadenaConexion);
                }
                if (mConexion.State != ConnectionState.Open)
                    mConexion.Open();
                return mConexion;
            }
        }
        #endregion

        #region "Lecturas"
        /// <summary>
        /// Obtiene un DataSet a partir de un Procedimiento Almacenado.
        /// </summary>
        protected SqlCommand Comando(string ProcedimientoAlmacenado)
        {
            SqlCommand Com;
            if (ColComandos.Contains(ProcedimientoAlmacenado))
                Com = (SqlCommand)ColComandos[ProcedimientoAlmacenado];
            else
            {
                SqlConnection Con2 = new SqlConnection(pCadenaConexion);
                Con2.Open();
                Com = new SqlCommand(ProcedimientoAlmacenado, Con2);
                Com.CommandType = CommandType.StoredProcedure;
                SqlCommandBuilder.DeriveParameters(Com);
                Con2.Close();
                Con2.Dispose();
                ColComandos.Add(ProcedimientoAlmacenado, Com);

            }
            Com.Connection = (SqlConnection)this.Conexion;
            Com.Transaction = (SqlTransaction)this.mTransaccion;
            return (SqlCommand)Com;
        }

        protected SqlCommand Comando(string ProcedimientoAlmacenado, SqlTransaction tran)
        {
            SqlCommand Com;
            if (ColComandos.Contains(ProcedimientoAlmacenado))
                Com = (SqlCommand)ColComandos[ProcedimientoAlmacenado];
            else
            {
                SqlConnection Con2 = new SqlConnection(pCadenaConexion);
                Con2.Open();
                Com = new SqlCommand(ProcedimientoAlmacenado, Con2);
                Com.CommandType = CommandType.StoredProcedure;
                SqlCommandBuilder.DeriveParameters(Com);
                Con2.Close();
                Con2.Dispose();
                ColComandos.Add(ProcedimientoAlmacenado, Com);

            }
            Com.Connection = tran.Connection;
            Com.Transaction = tran;
            return (SqlCommand)Com;
        }

        protected void CargarParametros(SqlCommand Com, System.Object[] Args)
        {
            int Limite = Com.Parameters.Count;
            for (int i = 1; i < Com.Parameters.Count; i++)
            {
                SqlParameter P = (SqlParameter)Com.Parameters[i];
                if (i <= Args.Length)
                    P.Value = Args[i - 1];
                else
                    P.Value = null;
            }
        }

        protected SqlDataAdapter CrearDataAdapter(string ProcedimientoAlmacenado, params System.Object[] Args)
        {
            SqlDataAdapter Da = new SqlDataAdapter((SqlCommand)Comando(ProcedimientoAlmacenado));
            if (Args.Length != 0)
                CargarParametros(Da.SelectCommand, Args);
            return (SqlDataAdapter)Da;
        }


        public System.Data.DataSet TraerDataset(string ProcedimientoAlmacenado)
        {
            DataSet mDataSet = new DataSet();
            this.CrearDataAdapter(ProcedimientoAlmacenado).Fill(mDataSet);
            return mDataSet;
        }
        /// <summary>
        /// Obtiene un DataSet a partir de un Procedimiento Almacenado y sus parámetros.
        /// </summary>
        public System.Data.DataSet TraerDataset(string ProcedimientoAlmacenado, params System.Object[] Args)
        {
            DataSet mDataSet = new DataSet();
            this.CrearDataAdapter(ProcedimientoAlmacenado, Args).Fill(mDataSet);
            return mDataSet;
        }
        /// <summary>
        /// Obtiene un DataTable a partir de un Procedimiento Almacenado.
        /// </summary>

        public System.Data.DataTable TraerDataTable(string ProcedimientoAlmacenado)
        {
            return TraerDataset(ProcedimientoAlmacenado).Tables[0].Copy();
        }
        /// <summary>
        /// Obtiene un DataSet a partir de un Procedimiento Almacenado y sus parámetros.
        /// </summary>
        public System.Data.DataTable TraerDataTable(string ProcedimientoAlmacenado, System.Object[] Args)
        {
            return TraerDataset(ProcedimientoAlmacenado, Args).Tables[0].Copy();
        }
        /// <summary>
        /// Obtiene un Valor a partir de un Procedimiento Almacenado.
        /// </summary>
        public System.Object TraerValor(string ProcedimientoAlmacenado)
        {
            SqlCommand Com = Comando(ProcedimientoAlmacenado);
            Com.ExecuteNonQuery();
            System.Object Resp = null;
            foreach (SqlParameter Par in Com.Parameters)
                if (Par.Direction == ParameterDirection.InputOutput || Par.Direction == ParameterDirection.Output)
                    Resp = Par.Value;
            return Resp;
        }
        /// <summary>
        /// Obtiene un Valor a partir de un Procedimiento Almacenado, y sus parámetros.
        /// </summary>
        public System.Object TraerValor(string ProcedimientoAlmacenado, params System.Object[] Args)
        {
            SqlCommand Com = Comando(ProcedimientoAlmacenado);
            CargarParametros(Com, Args);
            Com.ExecuteNonQuery();
            System.Object Resp = null;
            foreach (SqlParameter Par in Com.Parameters)
                if (Par.Direction == ParameterDirection.InputOutput || Par.Direction == ParameterDirection.Output)
                    Resp = Par.Value;
            return Resp;
        }
        #endregion

        #region "Acciones"
        /// <summary>
        /// Ejecuta un Procedimiento Almacenado en la base.
        /// </summary>
        public int Ejecutar(string ProcedimientoAlmacenado)
        {
            return Comando(ProcedimientoAlmacenado).ExecuteNonQuery();
        }
        /// <summary>
        /// Ejecuta un Procedimiento Almacenado en la base, utilizando los parámetros.
        /// </summary>
        public int Ejecutar(string ProcedimientoAlmacenado, System.Object[] Args)
        {
            SqlCommand Com = Comando(ProcedimientoAlmacenado);
            CargarParametros(Com, Args);
            int Resp = Com.ExecuteNonQuery();
            for (int i = 0; i < Com.Parameters.Count - 1; i++)
            {
                SqlParameter Par = (SqlParameter)Com.Parameters[i];
                if (Par.Direction == ParameterDirection.InputOutput || Par.Direction == ParameterDirection.Output)
                    Args.SetValue(Par.Value, i);
            }
            return Resp;
        }
        public int Ejecutar(string ProcedimientoAlmacenado, System.Object[] Args, SqlTransaction tran)
        {
            SqlCommand Com = Comando(ProcedimientoAlmacenado, tran);
            CargarParametros(Com, Args);
            int Resp = Com.ExecuteNonQuery();
            for (int i = 0; i < Com.Parameters.Count - 1; i++)
            {
                SqlParameter Par = (SqlParameter)Com.Parameters[i];
                if (Par.Direction == ParameterDirection.InputOutput || Par.Direction == ParameterDirection.Output)
                    Args.SetValue(Par.Value, i);
            }
            return Resp;
        }

        public System.Object[] EjecutarConDosRespuestas(string ProcedimientoAlmacenado, System.Object[] Args, SqlTransaction tran)
        {
            SqlCommand Com = Comando(ProcedimientoAlmacenado, tran);
            CargarParametros(Com, Args);
            System.Object[] arresp = new System.Object[2];
            Com.ExecuteNonQuery();
            int dimen = 0;
            for (int i = 0; i < Com.Parameters.Count; i++)
            {
                SqlParameter Par = (SqlParameter)Com.Parameters[i];
                if (Par.Direction == ParameterDirection.InputOutput || Par.Direction == ParameterDirection.Output)
                {
                    arresp[dimen] = Par.Value;
                    dimen++;
                }
            }
            return arresp;
        }

        #endregion

        #region "Transacciones"
        protected SqlTransaction mTransaccion;
        protected bool EnTransaccion = false;
        /// <summary>
        /// Comienza una Transacción en la base en uso.
        /// </summary>
        public SqlTransaction IniciarTransaccion()
        {
            SqlConnection oCon = new SqlConnection();
            oCon = this.CrearConexion(pCadenaConexion);
            oCon.Open();
            mTransaccion = oCon.BeginTransaction();
            EnTransaccion = true;
            return mTransaccion;
        }

        /// <summary>
        /// Confirma la transacción activa.
        /// </summary>
        public void TerminarTransaccion()
        {
            try
            {
                mTransaccion.Commit();
            }
            catch (System.Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                mTransaccion = null;
                EnTransaccion = false;
            }
        }
        /// <summary>
        /// Cancela la transacción activa.
        /// </summary>
        public void AbortarTransaccion()
        {
            try
            {
                mTransaccion.Rollback();
            }
            catch (System.Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                mTransaccion = null;
                EnTransaccion = false;
            }
        }
        #endregion

        #region"TraerConsulta"

        public System.Data.DataSet TraerConsultaDB(string Consulta)
        {

            //Variables para almacenar datos
            System.Data.DataSet dSetQuery = new System.Data.DataSet();
            //System.Data.SqlClient.SqlTransaction tran ;                                                 
            //Creando cadena de conexion
            System.Data.SqlClient.SqlConnectionStringBuilder SQLString = new System.Data.SqlClient.SqlConnectionStringBuilder();
            SQLString.DataSource = Servidor;
            SQLString.InitialCatalog = BaseDatos ;
            SQLString.IntegratedSecurity = true;
            //Creando conexion
            System.Data.SqlClient.SqlConnection ConnectionSQL = new System.Data.SqlClient.SqlConnection(SQLString.ConnectionString);
            //inicio la conexion
            try
            {
                ConnectionSQL.Open();
                //-----------------------------------------------------
                ////inicia la transaccion
                //tran = ConnectionSQL.BeginTransaction();
                ////un "try" que verifica errores
                //try
                //{
                //-----------------------------------------------------
                //Creando comando
                System.Data.SqlClient.SqlCommand CommandSQL = new System.Data.SqlClient.SqlCommand(Consulta, ConnectionSQL/*, tran*/);
                //Creando el data adapter
                System.Data.SqlClient.SqlDataAdapter DAdapterSQL = new System.Data.SqlClient.SqlDataAdapter(CommandSQL);
                //realisa la consulta y guarda los datos en el data adapter
                DAdapterSQL.Fill(dSetQuery);
                //-----------------------------------------------------
                //}
                //catch
                //{
                //    //Niega transaccion
                //    tran.Rollback();
                //}
                //finally
                //{
                //    //Confirma transaccion
                //    tran.Commit();
                //    // retorna el data set                
                //} 
                //-----------------------------------------------------
                //termina la conexion"
                ConnectionSQL.Close();

            }
            catch
            {

                dSetQuery.Tables.Add("Error");
            }

            return dSetQuery;

        }

        #endregion

    }
}
