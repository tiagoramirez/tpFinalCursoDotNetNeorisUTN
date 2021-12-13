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
                        
                        var opcCase2 = Menus.MenuCrearPaquete();
                        int cantidadCuotas=0;
                        Paquete nuevoPaquete;
                        double impuesto;
                        if (opcCase2 == '1')
                        {
                        
                            nuevoPaquete = new Nacional(12);
                            nuevoPaquete.insertarPaquete();
                            Console.Write("Ingrese el porcentaje del paquete nacional ");
                            double.TryParse(Console.ReadLine(), out impuesto);
                            Console.Clear();
                            while (impuesto< 0 || impuesto > 100 )
                            {
                                Console.Write("El porcentaje debe estar entre 0 y 100 ");
                                Console.Write("Ingrese el porcentaje del paquete nacional ");
                                double.TryParse(Console.ReadLine(), out impuesto);
                            }
                        }
                        else
                        {
                            nuevoPaquete = new Internacional(6);
                            nuevoPaquete.insertarPaquete();
                            Console.Write("Ingrese el valor del impuesto a aplicar del paquete internacional ");
                            double.TryParse(Console.ReadLine(), out impuesto);
                            Console.Clear();                           
                        }

                        Console.Write("Ingrese la cantidad de cuotas");
                        int.TryParse(Console.ReadLine(), out cantidadCuotas);
                       
                        while (!nuevoPaquete.cargarPago(cantidadCuotas, impuesto))
                        {
                            Console.Write($"La cantidad de cuotas no puede ser mayor a {nuevoPaquete.CuotaMaxima}");
                            int.TryParse(Console.ReadLine(), out cantidadCuotas);
                        }

                        ControladorPaquete.AgregarBd(nuevoPaquete);
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
