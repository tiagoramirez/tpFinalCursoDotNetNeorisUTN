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

        public static Cliente EncontrarId(int id)
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
    }
}
