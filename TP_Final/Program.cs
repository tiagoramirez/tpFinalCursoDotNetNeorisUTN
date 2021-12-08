using Datos;
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
                                try
                                {
                                    using (var context = new TPContext())
                                    {
                                        context.Clientes.Add(nuevoCliente);
                                        context.SaveChanges();
                                    }
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine($"Error!!!! \n {e.Message}");
                                }
                                
                            }
                            else
                            {
                                var nuevoCliente = new Corporativo();
                                try
                                {
                                    using (var context = new TPContext())
                                    {
                                        context.Clientes.Add(nuevoCliente);
                                        context.SaveChanges();
                                    }
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine($"Error!!!! \n {e.Message}");
                                }
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
