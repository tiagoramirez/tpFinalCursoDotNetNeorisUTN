using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Internacional:Paquete
    {
        private bool requiereVisa;
        private double contisacionDolar;

        public Internacional(bool requiereVisa, double contisacionDolar, string nombre, double precioBase, 
            Lugar[] listaLugares, int cantidadDiasTotales, DateTime fechaDeViaje, bool vigente, int cantidadDeCuotas, double valorPorCuota) 
         :base( nombre,  precioBase,  listaLugares,  cantidadDiasTotales,  fechaDeViaje,  vigente,  cantidadDeCuotas,  valorPorCuota)
        {
            this.requiereVisa = requiereVisa;
            this.contisacionDolar = contisacionDolar;
        }

        public bool RequiereVisa { get => requiereVisa; set => requiereVisa = value; }
        public double ContisacionDolar { get => contisacionDolar; set => contisacionDolar = value; }

        public double SetImpuestoFijo(double impuesto) {
            return PrecioBase + impuesto;
        }
    }
}
