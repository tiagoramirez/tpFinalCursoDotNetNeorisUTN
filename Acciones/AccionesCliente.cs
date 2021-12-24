using Dominio;
using Controlador;
using System;

namespace Acciones
{
    public static class AccionesCliente
    {
        public static int IngresarIdCliente()
        {
            Console.Write("Ingrese el id del cliente: ");
            var esInt = int.TryParse(Console.ReadLine(), out int id);
            while (!esInt || id < 0)
            {
                Console.WriteLine("Valor incorrecto.");
                Console.Write("Ingrese otra vez el id del cliente: ");
                esInt = int.TryParse(Console.ReadLine(), out id);
            }
            Console.Clear();
            return id;
        }

        public static void CrearClienteParticularYSubirBd()
        {
            var nuevoCliente = new Particular();
            nuevoCliente.CargarCliente();
            ControladorCliente.AgregarBd(nuevoCliente);
        }

        public static void CrearClienteCorporativoYSubirBd()
        {
            var nuevoCliente = new Corporativo();
            nuevoCliente.CargarCliente();
            ControladorCliente.AgregarBd(nuevoCliente);
        }

        public static void MostrarTodosLosClientes()
        {
            var clientes = ControladorCliente.ObtenerClientes();
            if (clientes != null)
            {
                foreach (var cliente in clientes)
                {
                    var listaFacturas = ControladorCliente.ObtenerFacturasId(cliente.IdCliente);
                    cliente.ListaFacturas = listaFacturas;
                    cliente.MostrarCliente();
                    Console.WriteLine("\n--------------------------------------\n");
                }
            }
            Console.WriteLine("Presione alguna tecla para continuar...");
            Console.ReadKey(true);
            Console.Clear();
        }

        public static void CrearCliente()
        {
            Console.WriteLine("1: Cliente Particular");
            Console.WriteLine("2: Cliente Corporativo");

            var opc = Console.ReadKey(true);
            while (opc.KeyChar < '1' || opc.KeyChar > '2')
            {
                opc = Console.ReadKey(true);
            }
            Console.Clear();
            if (opc.KeyChar == '1')
            {
                CrearClienteParticularYSubirBd();
            }
            else
            {
                CrearClienteCorporativoYSubirBd();
            }
        }

        public static void MostrarClienteId()
        {
            var id = IngresarIdCliente();
            var cliente = ControladorCliente.ObtenerClienteId(id);
            if (cliente != null)
            {
                var facturas = ControladorCliente.ObtenerFacturasId(cliente.IdCliente);
                cliente.ListaFacturas = facturas;
                cliente.MostrarCliente();
            }
            Console.WriteLine("Presione alguna tecla para continuar...");
            Console.ReadKey(true);
            Console.Clear();
        }

        public static void MostrarClientes2Ventas()
        {
            var clientes = ControladorCliente.ObtenerClientes();
            foreach(var cliente in clientes)
            {
                cliente.ListaFacturas = ControladorCliente.ObtenerFacturasId(cliente.IdCliente);
                if (cliente.ListaFacturas.Count >= 2)
                {
                    cliente.MostrarCliente();
                    Console.WriteLine("\n--------------------------------------\n");
                }
            }
            Console.WriteLine("Presione alguna tecla para continuar...");
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}