using System;
using Acciones;
using Controlador;

namespace TP_Final
{
    public static class MenusPaquete
    {
        public static char OpcionesPaquete()
        {
            Console.WriteLine("1: Crear nuevo paquete");
            Console.WriteLine("2: Mostrar todos los paquetes");
            Console.WriteLine("3: Buscar un paquete por ID");
            Console.WriteLine("4: Actualizar precio");
            Console.WriteLine("5: Activar/Desactivar un paquete");
            Console.WriteLine("ESC: Volver");
            var opc = Console.ReadKey(true);
            while (opc.KeyChar < '1' || opc.KeyChar > '5')
            {
                if (opc.KeyChar == (char)27)
                {
                    return opc.KeyChar;
                }
                opc = Console.ReadKey(true);
            }
            Console.Clear();
            return opc.KeyChar;
        }
    }
}
