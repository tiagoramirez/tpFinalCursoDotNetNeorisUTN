using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final
{
    internal class Menus
    {
        public static void MostrarMenuPrincipal()
        {
            Console.WriteLine("1: Crear nuevo cliente");
            Console.WriteLine("2: Listar facturas de un cliente y el total de sus ventas");
            Console.WriteLine("3: Inactivar un paquete");
            Console.WriteLine("4: Actualizar precio de un paquete");
            Console.WriteLine("5: Listar clientes que tuvieron al menos 2 ventas");
            Console.WriteLine("6: Terminar programa");
        }
    }
}
