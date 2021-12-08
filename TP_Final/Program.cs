using Dominio;
using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace TP_Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var terminar = false;
            while (!terminar)
            {
                var opc = Menus.MenuPrincipal();
                
                switch (opc)
                {
                    case '1':
                        {
                            var opcCase1 = Menus.MenuCrearCliente();
                            if (opcCase1 == '1')
                            {
                                var nuevoCliente = new Particular();
                                //nuevoCliente.MostrarCliente(); para probar si funciona
                            }
                            else
                            {
                                var nuevoCliente = new Corporativo();
                                //nuevoCliente.MostrarCliente(); para probar si funciona
                            }
                        }
                        break;
                    case '2':
                        break;
                    case '3':
                        break;
                    case '4':
                        break;
                    case '5':
                        break;
                    case '6':terminar = true;
                        break;
                }
            }
        }
    }
}
