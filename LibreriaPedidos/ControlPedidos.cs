using System;
using System.Collections.Generic;

namespace LibreriaPedidos
{
    static public class ControlPedidos
    {
        #region Propiedades
        public static clsProductos Produto = new clsProductos();
        public static clsClientes Cliente = new clsClientes();
        public static clsPedidos Pedido = new clsPedidos();
        #endregion

        /*No se requiere constructor ya que no se instancía*/

        #region Metodos
        public static void CrearPedido()
        {
            Pedido = new clsPedidos();
        }

        public static void SeleccionaCliente()
        {
            colClientes Clientes = new colClientes();
            Console.WriteLine("Dame el inicio del nombre del cliente: ");
            string cadenaInicioNombre = Console.ReadLine();
            clsClientes Cliente = Clientes.ObtenerPorNombre(cadenaInicioNombre);
            if (Cliente != null)
            {
                Console.WriteLine("El nombre del cliente encontrado es: " +
                                    Cliente.NombreCompleto + " con clave: " +
                                    Cliente.Clave);
                Pedido.Cliente = (clsClientes)Cliente.Clone();
            }
            else
                Console.WriteLine("No se encontró un cliente con el inicio del nombre.");
            Console.ReadKey();
        }

        public static void AgregarProducto()
        {
            clsProductos producto = new clsProductos();
            producto.Precio = 100;
            producto.PorcentajeIva = 16;
            producto.Ieps = 0.02m;
            producto.EsMontoIeps = true;
            decimal PrecioSiIvaSinIeps = 0m;
            decimal MontoIeps = producto.DesglosaIeps(out PrecioSiIvaSinIeps);
            Console.WriteLine("El resultado del precio sin iva sin ieps es: {0} y el IEPS es: {1}"
                                , PrecioSiIvaSinIeps, MontoIeps);
            Console.WriteLine("El resultado del precio sin iva es: {0}", producto.PrecioSinIva());
            Console.ReadKey();
        }

        public static void EliminarProductoPedido()
        {

        }

        public static string MuestraPedido()
        {
            return Pedido.Cliente.ToString();

        }
        #endregion

    }
}



