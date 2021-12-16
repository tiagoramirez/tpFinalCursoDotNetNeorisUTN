using System;
using Acciones;

namespace TP_Final
{
    public static class MenusPaquete
    {
        public static void MenuCrearPaquete()
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
                AccionesPaquete.CrearPaqueteNacionalYSubirBd();
            }
            else
            {
                AccionesPaquete.CrearPaqueteInternacionalYSubirBd();
            }
        }
    }
}
