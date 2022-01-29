using System;
using System.Collections.Generic;

namespace LibreriaPedidos
{
    public class clsPedidos
    {

        #region Propiedades
        public int Folio { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Subtotal { get; set; }
        public decimal MontoIva { get; set; }
        public decimal Total { get; set; }
        public clsClientes Cliente { get; set; }
        #endregion


        #region Constructor
        public clsPedidos()
        {
            Cliente = new clsClientes();
        }
        #endregion


        #region Metodos
        #endregion

    }
}
