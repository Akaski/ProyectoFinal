using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public sealed class CDetalle
    {
        DataLinqDataContext ctx = new DataLinqDataContext();

        // Instancia única de la clase.
        public static CDetalle Instancia = new CDetalle();
        public CDetalle()
        {

        }
        public static CDetalle GetInstance()
        {
            return Instancia;
        }
        public object getAll()//mostrar todo
        {

            var detalle_trabajo = from DetalleTrabajo in ctx.DetalleTrabajo//nacionalidades es una variable q vos creas y nacionalidad es la tabla en el archivo linq
                                  select new
                                  {
                                      DetalleTrabajo.idtrabajo,
                                      DetalleTrabajo.descripcion,
                                      DetalleTrabajo.costo,
                                      DetalleTrabajo.idcliente,
                                      DetalleTrabajo.fecha,
                                      DetalleTrabajo.hora,
                                      DetalleTrabajo.nropago,
                                      DetalleTrabajo.monto,
                                      

                                  };
            return detalle_trabajo;
        }
        public void adicionar( DetalleTrabajo detalle_trabajos)
        {
            ctx.DetalleTrabajo.InsertOnSubmit(detalle_trabajos);
            ctx.SubmitChanges();
        }


        public void eliminar(int n)
        {
            var detalle_trabajos = from DetalleTrabajo in ctx.DetalleTrabajo
                                  where
                    DetalleTrabajo.idtrabajo == n
                                  select DetalleTrabajo;
            foreach (var del in detalle_trabajos)
            {
                ctx.DetalleTrabajo.DeleteOnSubmit(del);
            }
            ctx.SubmitChanges();
        }
        public void modificar(int idtra,string desc,string cost, string idcli,DateTime fech, string hora, int nropa,int mont)
        {
            var detalle_trabajos = from DetalleTrabajo in ctx.DetalleTrabajo
                                  where
                    DetalleTrabajo.idtrabajo == idtra
                                   select DetalleTrabajo;
            foreach (var DetalleTrabajo in detalle_trabajos)
            {
                DetalleTrabajo.descripcion = desc;
                DetalleTrabajo.costo = cost;
                DetalleTrabajo.idcliente=idcli;
                DetalleTrabajo.fecha=fech;
                DetalleTrabajo.hora=hora;
                DetalleTrabajo.nropago=nropa;
                DetalleTrabajo.monto = mont;
                                      
                

            }
            ctx.SubmitChanges();
        }
        public DataTable traer_detalle()
        {
            string strselect = "select * from DetalleTrabajo";            
            return this.TraerDataTablestrSql(strselect);
        }
        public DataTable TraerDataTablestrSql(String strSql)
        {
            string pCadenaConexion = @"Data Source=GROVER-PC;Initial Catalog=dbclinica;Integrated Security=true";
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
        public DataTable Buscar_Detalle(string criterio)
        {
            DAL.TDatosSQL objdal = new DAL.TDatosSQL();
            Object[] p = new Object[1];
            p[0] = criterio;
            return objdal.TraerDataTable("sp_BuscarDetalle", p);
        }


    }
}
