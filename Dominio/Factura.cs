using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Factura
    {
        [Key]
        public int idFactura { set; get; }
        private int idCliente;
        private double importeTotal;
        private Paquete paquete;
        private DateTime fechaEmisionFactura;

        public Factura(int idCliente, double importeTotal, Paquete paquete, DateTime fechaEmisionFactura)
        {
            this.idCliente = idCliente;
            this.importeTotal = importeTotal;
            this.paquete = paquete;
            this.fechaEmisionFactura = fechaEmisionFactura;
        }

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public double ImporteTotal { get => importeTotal; set => importeTotal = value; }
        public Paquete Paquete { get => paquete; set => paquete = value; }
        public DateTime FechaEmisionFactura { get => fechaEmisionFactura; set => fechaEmisionFactura = value; }
       

    }
}
