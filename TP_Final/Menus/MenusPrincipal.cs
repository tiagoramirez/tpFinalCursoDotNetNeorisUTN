using System;

namespace TP_Final
{
    public static class MenusPrincipal
    {
        public static char MenuPrincipal()
        {
            Console.WriteLine("1: Ingresar al menu de cliente");
            Console.WriteLine("2: Ingresar al menu de paquete");
            Console.WriteLine("3: Ingresar al menu de factura");
            Console.WriteLine("ESC: Terminar programa");

            var opc = Console.ReadKey(true);
            while ((opc.KeyChar < '1' || opc.KeyChar > '3'))
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