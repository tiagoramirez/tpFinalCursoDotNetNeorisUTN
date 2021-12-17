using Dominio;
using Controlador;
using System;

namespace Acciones
{
    public static class AccionesPaquete
    {
        public static void CrearPaqueteNacionalYSubirBd()
        {
            var nuevoPaquete = new Nacional();
            nuevoPaquete.CargarPaquete();
            ControladorPaquete.AgregarBd(nuevoPaquete);
        }
        public static void CrearPaqueteInternacionalYSubirBd()
        {
            var nuevoPaquete = new Internacional();
            nuevoPaquete.CargarPaquete();
            ControladorPaquete.AgregarBd(nuevoPaquete);
        }

        public static void MostrarTodosLosPaquetes()
        {
            var paquetes = ControladorPaquete.ObtenerPaquetes();
            if (paquetes != null)
            {
                foreach (var paquete in paquetes)
                {
                    paquete.MostrarPaquete();
                    Console.WriteLine("\n--------------------------------------\n");
                }
            }
            Console.WriteLine("Presione alguna tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        public static void ActualizarPrecioPaquete()
        {
            int idPaquete;
            double precioNuevo;
            do
            {
                Console.Write("Ingresa el ID del paquete el cual va a modificar el precio: ");
                var esInt = int.TryParse(Console.ReadLine(), out idPaquete);
                while (!esInt)
                {
                    Console.Write("Ingresa un numero entero por favor: ");
                    esInt = int.TryParse(Console.ReadLine(), out idPaquete);
                }
                Console.Clear();

                Console.Write($"Ingresa el nuevo precio del paquete {idPaquete}: ");
                var esDouble = double.TryParse(Console.ReadLine(), out precioNuevo);
                while (!esDouble)
                {
                    Console.Write("Ingresa un numero decimal por favor: ");
                    esDouble = double.TryParse(Console.ReadLine(), out precioNuevo);
                }
                Console.Clear();
            }
            while (!ControladorPaquete.ActualizarPrecioPaquete(idPaquete, precioNuevo));

            Console.Clear();
        }

        public static void ActualizarEstadoPaquete()
        {
            int idPaquete;
            do
            {
                Console.Write("Ingresa el ID del paquete el cual va a modificar el estado: ");
                var esInt = int.TryParse(Console.ReadLine(), out idPaquete);
                while (!esInt)
                {
                    Console.Write("Ingresa un numero entero por favor: ");
                    esInt = int.TryParse(Console.ReadLine(), out idPaquete);
                }
                Console.Clear();
            }
            while (!ControladorPaquete.ActualizarEstadoPaquete(idPaquete));

            Console.Clear();
        }
        public static void CrearPaquete()
        {
            Console.WriteLine("1: Paquete Nacional");
            Console.WriteLine("2: Paquete Internacional");

            var opc = Console.ReadKey(true);
            while (opc.KeyChar < '1' || opc.KeyChar > '2')
            {
                opc = Console.ReadKey(true);
            }
            Console.Clear();

            if (opc.KeyChar == '1')
            {
                CrearPaqueteNacionalYSubirBd();
            }
            else
            {
                CrearPaqueteInternacionalYSubirBd();
            }
        }
    }
}
