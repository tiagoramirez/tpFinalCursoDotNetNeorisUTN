using System;

namespace TP_Final
{
    internal class Menus
    {
        public static char MenuPrincipal()
        {
            Console.WriteLine("1: Crear nuevo cliente");
            Console.WriteLine("2: Listar facturas de un cliente y el total de sus ventas");
            Console.WriteLine("3: Inactivar un paquete");
            Console.WriteLine("4: Actualizar precio de un paquete");
            Console.WriteLine("5: Listar clientes que tuvieron al menos 2 ventas");
            Console.WriteLine("6: Terminar programa");

            var opc = Console.ReadKey(true);
            while (opc.KeyChar < '1' || opc.KeyChar > '6')
            {
                opc = Console.ReadKey(true);
            }
            Console.Clear();
            return opc.KeyChar;
        }

        public static char MenuCrearCliente()
        {
            Console.WriteLine("1: Cliente Particular");
            Console.WriteLine("2: Cliente Corporativo");

            var opc = Console.ReadKey(true);
            while (opc.KeyChar < '1' || opc.KeyChar > '2')
            {
                opc = Console.ReadKey(true);
            }
            Console.Clear();
            return opc.KeyChar;
        }
        public static char MenuCrearPaquete()
        {
            Console.WriteLine("1: Paquete Nacional");
            Console.WriteLine("2: Paquete Internacional");

            var opc = Console.ReadKey(true);
            while (opc.KeyChar < '1' || opc.KeyChar > '2')
            {
                opc = Console.ReadKey(true);
            }
            Console.Clear();
            return opc.KeyChar;
        }
        
    }
}