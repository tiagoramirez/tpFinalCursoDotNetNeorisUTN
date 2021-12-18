using System;
using Dominio;
using Datos;

namespace Controlador
{
    public class ControladorFactura
    {
        public static void AgregarBd(Factura factura)
        {
            try
            {
                using (var context = new TPContext())
                {
                    context.Facturas.Add(factura);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error!!!! \n {e.Message}");
                Console.WriteLine($"Error!!!! \n {e.InnerException}");
            }
        }
    }
}
