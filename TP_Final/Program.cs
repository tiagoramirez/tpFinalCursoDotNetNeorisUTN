using Dominio;
using Controlador;
using System;
using Acciones;

namespace TP_Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var terminar = false;
            while (!terminar)
            {
                var opcMenuPrincipal = MenusPrincipal.MenuPrincipal();
                
                switch (opcMenuPrincipal)
                {
                    case '1'://Menu Cliente
                        var opcCliente= MenusPrincipal.MenuOpcionesCliente();
                        switch (opcCliente)
                        {
                            case '1':MenusCliente.MenuCrearCliente();
                                break;

                            case '2':AccionesCliente.MostrarTodosLosClientes();
                                break;

                            case (char)27:Console.Clear();
                                break;
                        }
                    break;

                    case '2'://Menu Paquete
                        var opcPaquete= MenusPrincipal.MenuOpcionesPaquete();
                        switch (opcPaquete)
                        {
                            case '1':MenusPaquete.MenuCrearPaquete();
                                break;

                            case '2':AccionesPaquete.MostrarTodosLosPaquetes();
                                break;

                            case (char)27:
                                Console.Clear();
                                break;
                        }
                    break;

                    case '3'://Prueba
                        ControladorPaquete.ActualisarPrecioPaquete("Patagonia", 100);
                        break;

                    case (char)27:terminar = true;
                        break;
                }
            }
        }
    }
}
