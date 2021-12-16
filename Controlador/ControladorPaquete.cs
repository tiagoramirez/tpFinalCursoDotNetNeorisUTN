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
        public static bool ActualisarPrecioPaquete(string nombrePaquete,int precio)
        {
            try {
                using (var context = new TPContext())
                {
                    var result = context.Paquetes.SingleOrDefault(b => b.Nombre == nombrePaquete);
                    if (result != null)
                    {
                        result.Precio = precio;
                        context.SaveChanges();
                        return true;
                    }                 
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
        public static bool cambiarEstadoPaquete(string nombrePaquete, bool  estado)
        {
            try
            {
                using (var context = new TPContext())
                {
                    var result = context.Paquetes.SingleOrDefault(b => b.Nombre == nombrePaquete);
                    if (result != null && result.Vigente!=estado)
                    {
                        result.Vigente = estado;
                        context.SaveChanges();
                        return true;
                    }
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
    }
}
