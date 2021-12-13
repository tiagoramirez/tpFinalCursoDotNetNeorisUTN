using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Nacional : Paquete,IPago
    {
        private int cantidadDeCuotas;
        public int CantidadDeCuotas { get; set; }
        public double ValorPorCuota { get; set; }

        public Nacional(){  }
        public override void CargarPaquete()
        {
            base.CargarPaquete();

            Console.Write("Ingresa el porcentaje de impuesto: ");
            var esDouble2 = Double.TryParse(Console.ReadLine(), out double impuesto);
            while (!esDouble2 || !SetImpuestoPorcentaje(impuesto))
            {
                Console.Write("No se ingreso un numero decimal. Vuelve a ingresar un numero: ");
                esDouble2 = Double.TryParse(Console.ReadLine(), out impuesto);
            }
            Console.Clear();

            CargarPago();
        }

        public bool SetImpuestoPorcentaje(double porcentaje)
        {
            if (porcentaje > 0)
            {
                Precio = (Precio * porcentaje) + Precio;
                return true;
            }
            return false;
        }

        public void CargarPago()
        {
            Console.Write("Ingresa la cantidad de cuotas (1, 3, 6, 12): ");
            var esInt = int.TryParse(Console.ReadLine(), out cantidadDeCuotas);
            while (!esInt || (cantidadDeCuotas != 1 && cantidadDeCuotas != 3 && cantidadDeCuotas != 6 && cantidadDeCuotas != 12))
            {
                Console.Write("No ingresaste una opcion valida. Vuelve a ingresar la cantidad de cuotas: ");
                esInt = int.TryParse(Console.ReadLine(), out cantidadDeCuotas);
            }
            ValorPorCuota = Precio / cantidadDeCuotas;
            Console.Clear();
        }

        public override void MostrarPaquete()
        {
            base.MostrarPaquete();
            Console.WriteLine($"Precio en pesos: ${Precio}");
            Console.WriteLine($"Cantidad de cuotas del pago: {CantidadDeCuotas}");
            Console.WriteLine($"Valor por cuota: ${ValorPorCuota}");
        }
    }
}
