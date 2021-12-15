using Dominio;
using Controlador;
using System;

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
                        var opcCase2 = Menus.MenuCrearPaquete();
                        if (opcCase2 == '1')
                        {
                            var nuevoPaquete = new Nacional();
                            nuevoPaquete.CargarPaquete();
                            Console.Clear();
                            nuevoPaquete.MostrarPaquete();
                            Console.ReadKey();
                            ControladorPaquete.AgregarBd(nuevoPaquete);
                        }
                        else
                        {
                            var nuevoPaquete = new Internacional();
                            nuevoPaquete.CargarPaquete();
                            ControladorPaquete.AgregarBd(nuevoPaquete);
                        }
                        break;
                    case '3':
                        var paquetes=ControladorPaquete.ObtenerPaquetes();
                        foreach (var paquete in paquetes)
                        {
                            paquete.MostrarPaquete();
                        }
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
