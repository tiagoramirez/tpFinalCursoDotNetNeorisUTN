using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public static List<Cliente> ObtenerPaquetes()
        {
            List<Cliente> paquetes = null;
            try
            {
                using (var context = new TPContext())
                {
                    paquetes = context.Clientes.ToList();
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
