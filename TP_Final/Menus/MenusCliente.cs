using System;
using Acciones;

namespace TP_Final
{
    internal class MenusCliente
    {
        public static char OpcionesCliente()
        {
            Console.WriteLine("1: Crear nuevo cliente");
            Console.WriteLine("2: Mostrar todos los clientes");
            Console.WriteLine("3: Buscar un cliente por ID");
            Console.WriteLine("4: Mostrar clientes con al menos 2 compras");
            Console.WriteLine("ESC: Volver");
            var opc = Console.ReadKey(true);
            while (opc.KeyChar < '1' || opc.KeyChar > '4')
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
