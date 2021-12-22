using Dominio;
using System;
using Controlador;
using System.Collections.Generic;

namespace Acciones
{
    public class AccionesFactura
    {
        public static void CrearFacturaYSubirBd()
        {
            var idCliente = IngresarCliente();
            var paquetes = IngresarPaquetes();
            var nuevaFactura = new Factura(idCliente, paquetes);
            ControladorFactura.AgregarBd(nuevaFactura, paquetes);
        }

        private static int IngresarCliente()
        {
            var existeId = false;
            int idCliente=0;
            while (!existeId)
            {
                Console.WriteLine("Ingresa el ID del cliente: ");
                var esInt = int.TryParse(Console.ReadLine(), out idCliente);
                while (!esInt)
                {
                    esInt = int.TryParse(Console.ReadLine(), out idCliente);
                }
                existeId = ControladorCliente.ExisteClienteId(idCliente);
            }
            Console.Clear();
            return idCliente;
        }

        private static List<Paquete> IngresarPaquetes()
        {
            Console.Write("Ingrese el ID de los paquetes que compro el cliente (Termina ingresando 0): ");
            var paquetes = new List<Paquete>();
            var esInt = int.TryParse(Console.ReadLine(), out int idPaquete);
            var paquete = ControladorPaquete.ObtenerPaqueteId(idPaquete);
            while ((!esInt && paquete==null) || idPaquete!=0)
            {
                if (idPaquete == 0)
                {
                    return paquetes;
                }
                if (paquete != null)
                {
                    paquetes.Add(paquete);

                }
                Console.Write("Ingresa otro ID del paquete: ");
                esInt = int.TryParse(Console.ReadLine(), out idPaquete);
                paquete = ControladorPaquete.ObtenerPaqueteId(idPaquete);
            }
            return paquetes;
        }

        private static  List<Factura>  RecuperarFacturasPorDni()
        {
            int dni=0;
            Console.Write("Ingrese el dni del cliente ");
            var esInt = int.TryParse(Console.ReadLine(), out dni);
            while (!esInt || dni == 0)
            {
                Console.Write("Ingrese el dni del cliente ");
                esInt = int.TryParse(Console.ReadLine(), out dni);
            }
            return ControladorFactura.RecuperarBd(dni);
        }

        public static void MostrarFacturas()
        {
            List<Factura> facturas = RecuperarFacturasPorDni();
            if (facturas != null)
            {
                foreach (var f in facturas)
                {
                    f.MostrarFactura();
                    Console.WriteLine("\n--------------------------------------\n");
                }
            }
            Console.WriteLine("\n--------------------------------------\n");
            Console.WriteLine("Total compras del Cliente");
            Console.WriteLine(CalcularTotalVentas(facturas));
            Console.WriteLine("Presione alguna tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

        }

        private static double CalcularTotalVentas(List<Factura> facturas)
        {
            double Total=0;
            foreach(Factura f in facturas)
            {
                Total += f.ImporteTotalPesos;
            }
            return Total;
        }
    }
}
