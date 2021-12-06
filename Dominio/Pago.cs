using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public  class Pago
    {
        //si el pago es al contado la cantidad de cuotas seria 0 y el valor por cuota no aplicaria 
        private int cantidadDeCuotas;
        private double valorPorCuota;

        public Pago(int cantidadDeCuotas, double valorPorCuota)
        {
            this.cantidadDeCuotas = cantidadDeCuotas;
            this.valorPorCuota = valorPorCuota;
        }

        public int CantidadDeCuotas { get => cantidadDeCuotas; set => cantidadDeCuotas = value; }
        public double ValorPorCuota { get => valorPorCuota; set => valorPorCuota = value; }

         
        
    }
}
