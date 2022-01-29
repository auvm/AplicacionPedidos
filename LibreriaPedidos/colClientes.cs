using System;
using System.Collections.Generic;

namespace LibreriaPedidos
{
    public class colClientes
    {
        #region Propiedades
        public List<clsClientes> items { get; set; }
        
        #endregion


        #region Constructor
        public colClientes()
        {
            clsRepositorioClientes repo = new clsRepositorioClientes();
            List<clsClientes> intermedio = new List<clsClientes>();
            repo.ObtenerClientes(ref intermedio);
            items = intermedio;
        }
        #endregion


        #region Metodos

        public clsClientes ObtenerPorNombre(string nombre)
        {
            clsClientes clienteRegresa = null;

            clienteRegresa = items.Find(x => x.NombreCompleto.StartsWith(nombre));
            return clienteRegresa;
        }
        #endregion

    }
}
