/*using System;
using Dominio;
using Controlador;

namespace Acciones
{
    public class AccionesFactura
    {
        public Factura CargarFactura()
        {
            var dniCliente = IngresarDniCliente();
            var existe = BusquedaDni(dniCliente);

            if (existe)
            {
                Console.Write("Ingresa un Id de Paquete: ");
                //Falta el controlador de paquete
            }
            int idPaquete = 0;//esto hay que sacarlo!
            var facturaResultado = new Factura(dniCliente, idPaquete);
            return facturaResultado;
        }

        private int IngresarDniCliente()
        {
            Console.Write("Ingresa D.N.I. del cliente: ");
            var esInt = int.TryParse(Console.ReadLine(), out int dni);
            while (!esInt)
            {
                Console.WriteLine("Ingresa un numero por favor: ");
                esInt = int.TryParse(Console.ReadLine(), out dni);
            }
            return dni;
        }

        private bool BusquedaDni(int dni)
        {
            
            var existe = ControladorCliente.ExisteClienteDni(dni);
            if (!existe)
            {
                Console.WriteLine($"No existe el cliente con D.N.I. {dni}");
                return false;
            }
            return true;
        }
    }
}
*/