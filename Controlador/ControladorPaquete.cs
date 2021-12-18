using System;
using System.Collections.Generic;
using System.Linq;
using Datos;
using Dominio;
namespace Controlador
{
    public class ControladorPaquete
    {
        public static void AgregarBd(Paquete paquete)
        {
            try
            {
                using (var context = new TPContext())
                {
                    context.Paquetes.Add(paquete);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error!!!! \n {e.Message}");
                Console.WriteLine($"Error!!!! \n {e.InnerException}");
            }
        }

        public static List<Paquete> ObtenerPaquetes()
        {
            List<Paquete> paquetes = null;
            try
            {
                using (var context = new TPContext())
                {
                    paquetes = context.Paquetes.Include("ListaLugares").ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error!!!! \n {e.Message}");
                Console.WriteLine($"Error!!!! \n {e.InnerException}");
            }

            return paquetes;
        }

        public static bool ActualizarPrecioPaquete(int idPaquete,double precioNuevo)
        {
            try {
                using (var context = new TPContext())
                {
                    var result = context.Paquetes.SingleOrDefault(b => b.IdPaquete==idPaquete);
                    if (result != null)
                    {
                        result.Precio = precioNuevo;
                        context.SaveChanges();
                        return true;
                    }
                    Console.WriteLine($"Paquete {idPaquete} no encontrado.");
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error!!!! \n {e.Message}");
                Console.WriteLine($"Error!!!! \n {e.InnerException}");
                return false;
            }
        }

        public static bool ActualizarEstadoPaquete(int idPaquete)
        {
            try
            {
                using (var context = new TPContext())
                {
                    var result = context.Paquetes.SingleOrDefault(b => b.IdPaquete == idPaquete);
                    if (result != null)
                    {
                        result.Vigente = !result.Vigente;
                        context.SaveChanges();
                        if (result.Vigente)
                        {
                            Console.WriteLine($"El paquete {result.IdPaquete} fue activado");
                        }
                        else
                        {
                            Console.WriteLine($"El paquete {result.IdPaquete} fue desactivado");
                        }
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey(true);
                        return true;
                    }
                    Console.WriteLine($"Paquete {idPaquete} no encontrado.");
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error!!!! \n {e.Message}");
                Console.WriteLine($"Error!!!! \n {e.InnerException}");
                return false;
            }
        }

        public static Paquete ObtenerPaqueteId(int idPaquete)
        {
            Paquete res=null;
            try
            {
                using (var context = new TPContext())
                {
                    res = context.Paquetes.Find(idPaquete);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error!!!! \n {e.Message}");
            }
            if (res == null)
            {
                Console.WriteLine($"El paquete con ID {idPaquete} no fue encontrado.");
                Console.Write("Ingrese una tecla para continuar...");
                Console.ReadKey(true);
                Console.Clear();
            }
            return res;
        }
    }
}
