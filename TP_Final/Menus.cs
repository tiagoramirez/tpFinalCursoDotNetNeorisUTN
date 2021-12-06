using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final
{
    internal class Menus
    {
        public static char MostrarMenuPrincipalEIngresarOpcion()
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

        public static int MostrarProvincias()
        {
            Console.WriteLine("1: Buenos Aires");
            Console.WriteLine("2: Capital Federal");
            Console.WriteLine("3: Catamarca");
            Console.WriteLine("4: Chaco");
            Console.WriteLine("5: Chubut");
            Console.WriteLine("6: Córdoba");
            Console.WriteLine("7: Corrientes");
            Console.WriteLine("8: Entre Ríos");
            Console.WriteLine("9: Formosa");
            Console.WriteLine("10: Jujuy");
            Console.WriteLine("11: La Pampa");
            Console.WriteLine("12: La Rioja");
            Console.WriteLine("13: Mendoza");
            Console.WriteLine("14: Misiones");
            Console.WriteLine("15: Neuquén");
            Console.WriteLine("16: Río Negro");
            Console.WriteLine("17: Salta");
            Console.WriteLine("18: San Juan");
            Console.WriteLine("19: San Luis");
            Console.WriteLine("20: Santa Cruz");
            Console.WriteLine("21: Santa Fe");
            Console.WriteLine("22: Santiago del Estero");
            Console.WriteLine("23: Tierra del Fuego");
            Console.WriteLine("24: Tucumán");

            var esInt = int.TryParse(Console.ReadLine(), out int opc);
            while (opc < 1 || opc > 24 || !esInt)
            {
                esInt = int.TryParse(Console.ReadLine(), out opc);
            }
            Console.Clear();
            return opc;
        }
    }
}