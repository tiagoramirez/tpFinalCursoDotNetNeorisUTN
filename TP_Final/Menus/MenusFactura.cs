using System;

namespace TP_Final
{
    public static class MenusFactura
    {
        public static char OpcionesFactura()
        {
            Console.WriteLine("1: Realizar nueva factura");
            Console.WriteLine("2: Mostrar todas las facturas");
            Console.WriteLine("ESC: Volver");
            var opc = Console.ReadKey(true);
            while (opc.KeyChar < '1' || opc.KeyChar > '2')
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
