using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPedidos
{
    internal interface IRepositorioClientes
    {
        void ObtenerClientes(ref List<clsClientes> clientes);
        void ObtenerCliente(clsClientes cliente);
        void CrearCliente(clsClientes cliente);
        void ModificaCliente(clsClientes cliente);
        void EliminaCliente(clsClientes cliente);
    }
}
