using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Factura
    {
        [Key]
        public int IdFactura { get; set; }
        public double ImporteTotalPesos { get; set; } = 0;
        public double ImporteTotalDolares { get; set; } = 0;
        public DateTime FechaEmisionFactura { get; set; } = DateTime.Now;

        //Navigation Properties
        public List<Paquete> ListaPaquetes { get; set; }
        public int IdCliente { get; set; }
        [ForeignKey("IdCliente")]
        public Cliente Cliente { get; set; }
        //End Navigation Properties
        public Factura(){}
        public Factura(int idCliente, List<Paquete> paquetes)
        {
            IdCliente = idCliente;
            ListaPaquetes = paquetes;
            foreach (var paquete in ListaPaquetes)
            {
                if (paquete != null)
                {
                    if (paquete is Nacional)
                    {
                        ImporteTotalPesos += paquete.Precio;
                    }
                    else
                    {
                        ImporteTotalDolares += paquete.Precio;
                    }
                }
            }
        }

        public void MostrarFactura()
        {
            Console.WriteLine($"ID de la factura: {IdFactura}");
            Console.WriteLine($"Emision de la factura: {FechaEmisionFactura}");
            Console.WriteLine($"Cliente: {IdCliente}");
            Console.WriteLine("Detalles: ");
            foreach (var paquete in ListaPaquetes)
            {
                Console.WriteLine($"ID del paquete: {paquete.IdPaquete}");
                Console.WriteLine($"Nombre del paquete: {paquete.Nombre}");
                if (paquete is Internacional)
                {
                    Console.WriteLine($"Importe del paquete: U$D{paquete.Precio}");
                    /*ImporteTotalDolares += paquete.Precio;*/
                }
                else
                {
                    Console.WriteLine($"Importe del paquete: ${paquete.Precio}");
                    /*ImporteTotalPesos += paquete.Precio;*/
                }
            }
            Console.WriteLine("\n------------------------------------\n");
            Console.WriteLine($"Importe total en pesos: ${ImporteTotalPesos}");
            Console.WriteLine($"Importe total en dolares: U$D{ImporteTotalDolares}");
        }
    }
}