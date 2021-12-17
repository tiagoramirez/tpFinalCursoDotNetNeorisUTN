using Dominio;
using Controlador;
using System;

namespace Acciones
{
    public static class AccionesCliente
    {
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
                    cliente.MostrarCliente();
                    Console.WriteLine("\n--------------------------------------\n");
                }
            }
            Console.WriteLine("Presione alguna tecla para continuar...");
            Console.ReadKey();
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
                AccionesCliente.CrearClienteParticularYSubirBd();
            }
            else
            {
                AccionesCliente.CrearClienteCorporativoYSubirBd();
            }
        }
    }
}