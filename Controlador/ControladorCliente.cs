using Datos;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            return clientes;
        }

        public static Cliente ObtenerId(int id)
        {
            var res=new Particular();
            try
            {
                using (var context = new TPContext())
                {
                    res=(Particular)context.Clientes.Find(id);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error!!!! \n {e.Message}");
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
                    res=context.Clientes.Any(x=>x.Id==id);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error!!!! \n {e.Message}");
            }
            return res;
        }

        public static bool ExisteClienteDni(int dni)
        {
            bool res = false;
            try
            {
                using (var context = new TPContext())
                {
                    res = context.Clientes.Any(x=>x.Dni==dni);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error!!!! \n {e.Message}");
            }
            return res;
        }
    }
}