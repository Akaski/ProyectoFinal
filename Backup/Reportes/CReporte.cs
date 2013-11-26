using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace Reportes
{
    public class CReporte
    {
        public DataSet Ficha_Detalle()
        {
            DataSet ds = new DataSet();
            Negocio.CDetalle objdetalle = new Negocio.CDetalle();
            ds.Tables.Add(objdetalle.traer_detalle());
            ds.Tables[0].TableName = "DetalleTrabajo";         

            return ds;
        }
        public DataSet Ficha_Clientes()
        {
            DataSet ds = new DataSet();
            Negocio.CCliente objcliente = new Negocio.CCliente();
            ds.Tables.Add(objcliente.traer_Cliente());
            ds.Tables[0].TableName = "Cliente";

            return ds;
        }
    }
}
