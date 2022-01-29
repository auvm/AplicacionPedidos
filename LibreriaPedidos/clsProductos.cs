using System;
using System.Collections.Generic;

namespace LibreriaPedidos
{
    public class clsProductos : clsAbstractaProductos
    {
        #region Propiedades

        public String CodigoBarras { get; set; }
        public decimal Precio { get; set; }
        public decimal PorcentajeIva { get; set; }
        public decimal Ieps { get; set; }
        public bool EsMontoIeps { get; set; }

        #endregion


        #region Constructor

        public clsProductos() { }

        public clsProductos(int idProducto, string clave, string descripcion, string codigoBarras, decimal precio, decimal porcentajeIva)
        {
            this.idProducto = idProducto;
            this.Clave = clave;
            this.Descripcion = descripcion;
            this.CodigoBarras = codigoBarras;
            this.Precio = precio;
            this.PorcentajeIva = porcentajeIva;
        }

        #endregion


        #region Metodos
        public decimal DesgloceIva()
        {
            return Math.Round((Precio / (1 + PorcentajeIva / 100))* PorcentajeIva/100,2);
        }

        public virtual decimal PrecioSinIva()
        {
            return Math.Round((Precio / (1 + PorcentajeIva / 100)), 2);
        }

        public decimal DesglosaIeps(out decimal PrecioSinIvaSinIeps)
        {
            //no utilizo el metodo para conservar decimales
            //redondeo solamente al final
            decimal PrecioSinIva = Precio / (1 + PorcentajeIva / 100);
            decimal MontoIeps = 0m;
            if (EsMontoIeps)
            {
                MontoIeps = Ieps;
                PrecioSinIvaSinIeps = Math.Round(PrecioSinIva - MontoIeps, 2);
            }
            else
            {
                PrecioSinIvaSinIeps = Math.Round(PrecioSinIva / ( 1 + PorcentajeIva / 100),2);
                MontoIeps = Math.Round(PrecioSinIvaSinIeps * Ieps /100, 2);
            }
            return MontoIeps;
        }
        

        #endregion

    }
}
