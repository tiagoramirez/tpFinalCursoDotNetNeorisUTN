using System;
using Dominio;
using Datos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControladorLugar
    {
        public static void AgregarBd(Lugar lugar)
        {
            try
            {
                using (var context = new TPContext())
                {
                    context.Lugares.Add(lugar);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error!!!! \n {e.Message}");
            }
        }

        public static List<Lugar> ObtenerLugares()
        {
            List<Lugar> lugares = null;
            try
            {
                using (var context = new TPContext())
                {
                    lugares = context.Lugares.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error!!!! \n {e.Message}");
            }

            return lugares;
        }
    }
}
