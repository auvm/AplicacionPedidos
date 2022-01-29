using System;
using System.Collections.Generic;

namespace LibreriaPedidos
{
    public class clsClientes : clsAbstractaPersonas, ICloneable
    {
        #region Propiedades
        public int IdCliente { get; set; }
        public string Clave { get; set; }
        public string Rfc { get; set; }
        public TipoCliente Tipo { get; set; }
        #endregion


        #region Constructor
        public clsClientes()
        {

        }
       
        public clsClientes(string nombre, string clave, string rfc)
        {
            NombreCompleto = nombre;
            Clave = clave;
            Rfc = rfc;
        }

        public object Clone()
        {
            //throw new NotImplementedException();
            clsClientes clienteClonado = new clsClientes();
            clienteClonado.IdCliente = IdCliente;
            clienteClonado.NombreCompleto = NombreCompleto;
            clienteClonado.Clave = Clave;
            clienteClonado.Rfc = Rfc;
            clienteClonado.Tipo = Tipo;
            return clienteClonado;
        }


        #endregion


        #region Metodos
        public override string ToString()
        {
            return "Id:"+IdCliente+" Nombre:"+NombreCompleto+" Clave:"+Clave
                    +" RFC:"+Rfc+" TipoCliente:"+Tipo;
        }
        #endregion

    }
}
