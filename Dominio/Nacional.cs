using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Nacional:Paquete
    {
        public Nacional(bool requiereVisa, double contisacionDolar, string nombre, double precioBase,
            Lugar[] listaLugares, int cantidadDiasTotales, DateTime fechaDeViaje, bool vigente, int cantidadDeCuotas, double valorPorCuota)
         : base(nombre, precioBase, listaLugares, cantidadDiasTotales, fechaDeViaje, vigente, cantidadDeCuotas, valorPorCuota)
        {
            
        }
        public double SetImpuestoPorcentaje(double porcentaje)
        {
            return (PrecioBase  * porcentaje)+ PrecioBase;
        }
    }
}
