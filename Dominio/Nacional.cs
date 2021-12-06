using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Nacional : Paquete
    {
        public Nacional(bool requiereVisa, double contisacionDolar, string nombre, double precioBase,
            Lugar[] listaLugares, int cantidadDiasTotales, DateTime fechaDeViaje, bool vigente  )
         : base(nombre, precioBase, listaLugares, cantidadDiasTotales, fechaDeViaje, vigente )
        {

        }
        public double SetImpuestoPorcentaje(double porcentaje)
        {
            return (PrecioBase * porcentaje) + PrecioBase;
        }

        protected override bool cargarPago(int cantidadDeCuotas, double valorPorCuota)
        {
            throw new NotImplementedException();
        }
    }
}
