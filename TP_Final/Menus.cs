﻿using System;
using Acciones;

namespace TP_Final
{
    public static class Menus
    {
        public static char MenuPrincipal()
        {
            Console.WriteLine("1: Ingresar al menu de cliente");
            Console.WriteLine("2: Ingresar al menu de paquete");
            Console.WriteLine("3: Opcion de prueba");
            Console.WriteLine("ESC: Terminar programa");

            var opc = Console.ReadKey(true);
            while ((opc.KeyChar < '1' || opc.KeyChar > '2'))
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

        public static char MenuOpcionesCliente()
        {
            Console.WriteLine("1: Crear nuevo cliente");
            Console.WriteLine("2: Mostrar todos los clientes");
            Console.WriteLine("3: Buscar un cliente por ID");
            Console.WriteLine("4: Buscar cliente por DNI");
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

        public static char MenuOpcionesPaquete()
        {
            Console.WriteLine("1: Crear nuevo paquete");
            Console.WriteLine("2: Mostrar todos los paquetes");
            Console.WriteLine("3: Buscar un paquete por ID");
            Console.WriteLine("ESC: Volver");
            var opc = Console.ReadKey(true);
            while (opc.KeyChar < '1' || opc.KeyChar > '3')
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