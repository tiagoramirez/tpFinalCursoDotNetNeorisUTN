using System;
using Acciones;

namespace TP_Final
{
    internal class MenusCliente
    {
        public static void MenuCrearCliente()
        {
            Console.WriteLine("1: Cliente Particular");
            Console.WriteLine("2: Cliente Corporativo");

            var opc = Console.ReadKey(true);
            while (opc.KeyChar < '1' || opc.KeyChar > '2')
            {
                opc = Console.ReadKey(true);
            }
            Console.Clear();
            if (opc.KeyChar == '1')
            {
                AccionesCliente.CrearClienteParticularYSubirBd();
            }
            else
            {
                AccionesCliente.CrearClienteCorporativoYSubirBd();
            }
        }
    }
}
