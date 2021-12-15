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
            }
        }

        public static List<Paquete> ObtenerPaquetes()
        {
            List<Paquete> paquetes = null;
            try
            {
                using (var context = new TPContext())
                {
                    paquetes = context.Paquetes.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error!!!! \n {e.Message}");
            }

            return paquetes;
        }

    }
}
