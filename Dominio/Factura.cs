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
        public int IdFactura { get; set; }
        public int IdCliente { get; set; }
        public int IdPaquete { get; set; }
        public double ImporteTotal { get; set; }
        public DateTime FechaEmisionFactura { get; set; } = DateTime.Now;

        public Factura()
        {   }
        public Factura(int idCliente,int idPaquete)
        {

        }
    }
}
