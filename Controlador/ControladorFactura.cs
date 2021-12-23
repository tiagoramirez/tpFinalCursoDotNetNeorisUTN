using System;
using Dominio;
using Datos;
using System.Collections.Generic;
using System.Linq;

namespace Controlador
{
    public class ControladorFactura
    {
        public static void AgregarBd(Factura factura,List<Paquete> listpaquetes)
        {
            factura.ListaPaquetes = new List<Paquete>();
            try
            {
                using (var context = new TPContext())
                {   
                    context.Facturas.Add(factura);
                    context.SaveChanges();              
                    foreach (Paquete p in listpaquetes){    
                        var fact = context.Facturas.FirstOrDefault(i => i.IdFactura== factura.IdFactura);
                        var paq = context.Paquetes.FirstOrDefault(j => j.IdPaquete == p.IdPaquete);
                        fact.ListaPaquetes.Add(paq);
                        context.SaveChanges();
                    }
                    
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
