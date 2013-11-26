using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class CTrabajo:DAL.TDatosSQL
    {
        
         #region "Atributos"
            private int idtrabajo;
            private string descripcion;           
            private string precio;           
          #endregion
        #region "Constructor"
            public CTrabajo()
            {
                idtrabajo = 0;
                descripcion = "";               
                precio = "";
                
           }
        #endregion
        #region "PropiDestinoes de Acceso"
            public int p_idtrabajo
            {
                get { return idtrabajo; }
                set { idtrabajo = value; }
            }
            public string p_descripcion
            {
                get { return descripcion; }
                set { descripcion = value; }
            }
            public string p_precio
            {
                get { return precio; }
                set { precio = value; }
            }
           
           
            #endregion
            #region"metodos"
            public int ABM(Utilitarios.Utilitarios.Operacion op)
            {
                Object[] p = new Object[5];
                p[0] = op;
                p[1] = idtrabajo;
                p[2] = descripcion;
                p[3] = precio;                
                p[4] = 0;
                return Ejecutar("sp_abmTrabajo", p);

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
                return TraerDataTable("sp_BuscarTrabajo", p);
            }
            public DataTable Traer_trabajo()
            {
                System.Object[] args = new Object[1];
                args[0] = idtrabajo;
                return TraerDataTable("sp_TraerTrabajo", args);
            }
            
                
            
            #endregion
    }
}
