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
                idCliente = AccionesCliente.IngresarIdCliente();
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
            
            while (idPaquete!=0)
            {
                if (esInt && idPaquete > 0)
                {
                    var paquete = ControladorPaquete.ObtenerPaqueteId(idPaquete);
                    if (paquete != null)
                    {
                        paquetes.Add(paquete);
                    }
                }

                Console.Write("Ingresa otro ID del paquete: ");
                esInt = int.TryParse(Console.ReadLine(), out idPaquete);
            }
            Console.Clear();
            return paquetes;
        }

        public static void MostrarFacturas()
        {
            var id = AccionesCliente.IngresarIdCliente();

            List<Factura> facturas = ControladorCliente.ObtenerFacturasId(id);
            if (facturas != null)
            {
                foreach (var f in facturas)
                {
                    f.MostrarFactura();
                    Console.WriteLine("\n--------------------------------------\n");
                }
            }
            Console.WriteLine("Presione alguna tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
