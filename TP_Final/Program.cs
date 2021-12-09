using Datos;
using Dominio;
using Controlador;
using System;
using System.Collections.Generic;

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
                                nuevoCliente.CargarCliente();
                                ControladorCliente.AgregarBd(nuevoCliente);
                            }
                            else
                            {
                                var nuevoCliente = new Corporativo();
                                nuevoCliente.CargarCliente();
                                ControladorCliente.AgregarBd(nuevoCliente);
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
