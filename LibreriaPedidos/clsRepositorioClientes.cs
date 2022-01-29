using System;
using System.Collections.Generic;

namespace LibreriaPedidos
{
    public class clsRepositorioClientes : IRepositorioClientes
    {
        #region Propiedades
        #endregion


        #region Constructor
        #endregion


        #region Metodos

        public void CrearCliente(clsClientes cliente)
        {
            //throw new NotImplementedException();
        }

        public void EliminaCliente(clsClientes cliente)
        {
            //throw new NotImplementedException();
        }

        public void ModificaCliente(clsClientes cliente)
        {
            //throw new NotImplementedException();
        }

        public void ObtenerCliente(clsClientes cliente)
        {
            //throw new NotImplementedException();
        }

        public void ObtenerClientes(ref List<clsClientes> clientes)
        {
            //throw new NotImplementedException();
            clientes.Clear();
            clientes.Add(new clsClientes{ IdCliente = 1, Clave = "C001", NombreCompleto = "Angel Velasco",
                                Rfc = "VEMA", Tipo = TipoCliente.Publico});
            clientes.Add(new clsClientes{ IdCliente = 1, Clave = "C002", NombreCompleto = "Uriel Velasco",
                                Rfc = "VEME", Tipo = TipoCliente.Publico});
            clientes.Add(new clsClientes{ IdCliente = 1, Clave = "C003", NombreCompleto = "Miguel Velasco",
                                Rfc = "VEMI", Tipo = TipoCliente.Medio});
            clientes.Add(new clsClientes{ IdCliente = 1, Clave = "C004", NombreCompleto = "Eduardo Velasco",
                                Rfc = "VEMO", Tipo = TipoCliente.Medio});
            clientes.Add(new clsClientes{ IdCliente = 1, Clave = "C005", NombreCompleto = "Altäir Velasco",
                                Rfc = "VEMU", Tipo = TipoCliente.Mayoreo});
            
            //clientes[0] = new clsClientes { IdCliente = 1, Clave = "C001", NombreCompleto = "Angel Velasco",
            //    Rfc = "VEMA", Tipo = TipoCliente.Publico };
            //clientes[1] = new clsClientes { IdCliente = 1, Clave = "C002", NombreCompleto = "Uriel Velasco",
            //    Rfc = "VEME", Tipo = TipoCliente.Publico };
            //clientes[2] = new clsClientes { IdCliente = 1, Clave = "C003", NombreCompleto = "Miguel Velasco",
            //    Rfc = "VEMI", Tipo = TipoCliente.Medio };
            //clientes[3] = new clsClientes { IdCliente = 1, Clave = "C004", NombreCompleto = "Eduardo Velasco",
            //    Rfc = "VEMO", Tipo = TipoCliente.Medio };
            //clientes[4] = new clsClientes{ IdCliente = 1, Clave = "C005", NombreCompleto = "Altäir Velasco",
            //                    Rfc = "VEMU", Tipo = TipoCliente.Mayoreo};
        }

        #endregion
    }
}
