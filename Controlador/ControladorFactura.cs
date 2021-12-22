using System;
using Dominio;
using Datos;
using System.Collections.Generic;
using System.Linq;

namespace Controlador
{
    /*static class Extensions
    {
        public static List<T> Clone<T>(this List<T> listoclone) where T : ICloneable
        {
            return listoclone.Select(item => (T)item.Clone()).ToList();
        }
    }*/
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

        public static List<Factura> RecuperarBd(int dni)
        {
            List<Factura> facturas = new List<Factura>();
            try
            {
               
                using (var context = new TPContext())
                {
                    var cliente = context.Clientes.FirstOrDefault(i => i.Dni == dni);
                    facturas = context.Facturas.Include("ListaPaquetes").Where(x => x.IdCliente == cliente.IdCliente).ToList();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"Error!!!! \n {e.Message}");
                Console.WriteLine($"Error!!!! \n {e.InnerException}");
            }
            return facturas;
        }

    }
}
