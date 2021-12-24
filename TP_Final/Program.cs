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
                        var opcCliente= MenusCliente.OpcionesCliente();
                        switch (opcCliente)
                        {
                            case '1':
                                AccionesCliente.CrearCliente();
                                break;

                            case '2':
                                AccionesCliente.MostrarTodosLosClientes();
                                break;

                            case '3':
                                AccionesCliente.MostrarClienteId();
                                break;

                            case '4':
                                AccionesCliente.MostrarClientes2Ventas();
                                break;

                            case (char)27:
                                Console.Clear();
                                break;
                        }
                    break;

                    case '2'://Menu Paquete
                        var opcPaquete= MenusPaquete.OpcionesPaquete();
                        switch (opcPaquete)
                        {
                            case '1':
                                AccionesPaquete.CrearPaquete();
                                break;

                            case '2':
                                AccionesPaquete.MostrarTodosLosPaquetes();
                                break;

                            case '3':
                                AccionesPaquete.MostrarPaqueteId();
                                break;

                            case '4':
                                AccionesPaquete.ActualizarPrecioPaquete();
                                break;

                            case '5':
                                AccionesPaquete.ActualizarEstadoPaquete();
                                break;

                            case (char)27:
                                Console.Clear();
                                break;
                        }
                    break;

                    case '3'://Menu Factura
                        var opcFactura = MenusFactura.OpcionesFactura();
                        switch (opcFactura)
                        {
                            case '1':
                                AccionesFactura.CrearFacturaYSubirBd();
                            break;
                            case '2':
                                AccionesFactura.MostrarFacturas();
                            break;

                            case (char)27:
                                Console.Clear();
                                break;
                        }
                    break;

                    case (char)27:
                        terminar = true;
                        break;
                }
            }
        }
    }
}
