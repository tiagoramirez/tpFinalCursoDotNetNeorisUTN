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
    }
}
