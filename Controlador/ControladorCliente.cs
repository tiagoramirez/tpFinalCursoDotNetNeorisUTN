using Datos;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Controlador
{
    public class ControladorCliente
    {
        public static void AgregarBd(Cliente cliente)
        {
            try
            {
                using (var context = new TPContext())
                {
                    context.Clientes.Add(cliente);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error!!!! \n {e.Message}");
            }
        }

        public static List<Cliente> ObtenerClientes()
        {
            List<Cliente> clientes = null;
            try
            {
                using (var context = new TPContext())
                {
                    clientes = context.Clientes.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error!!!! \n {e.Message}");
            }

            if (clientes == null)
            {
                Console.WriteLine($"No hay clientes.");
                Console.Write("Ingrese una tecla para continuar...");
                Console.ReadKey(true);
                Console.Clear();
            }

            return clientes;
        }

        public static Cliente ObtenerClienteId(int id)
        {
            Cliente res=null;
            try
            {
                using (var context = new TPContext())
                {
                    res=context.Clientes.Find(id);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error!!!! \n {e.Message}");
            }
            if (res == null)
            {
                Console.WriteLine($"El cliente con ID {id} no fue encontrado.");
                Console.Write("Ingrese una tecla para continuar...");
                Console.ReadKey(true);
                Console.Clear();
            }
            return res;
        }

        public static bool ExisteClienteId(int id)
        {
            bool res=false;
            try
            {
                using (var context = new TPContext())
                {
                    res=context.Clientes.Any(x=>x.IdCliente==id);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error!!!! \n {e.Message}");
            }
            if (res == false)
            {
                Console.WriteLine($"El cliente con ID {id} no fue encontrado.");
                Console.Write("Ingrese una tecla para continuar...");
                Console.ReadKey(true);
                Console.Clear();
            }
            return res;
        }

        public static List<Factura> ObtenerFacturasId(int idCliente)
        {
            var facturas = new List<Factura>();
            if (ExisteClienteId(idCliente))
            {
                try
                {
                    using (var context = new TPContext())
                    {
                        facturas = context.Facturas.Include("ListaPaquetes").Where(x => x.IdCliente == idCliente).ToList();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error!!!! \n {e.Message}");
                    Console.WriteLine($"Error!!!! \n {e.InnerException}");
                }
            }
            else
            {
                Console.WriteLine($"El cliente con ID {idCliente} no fue encontrado.");
                Console.Write("Ingrese una tecla para continuar...");
                Console.ReadKey(true);
                Console.Clear();
            }
            return facturas;
        }

    }
}