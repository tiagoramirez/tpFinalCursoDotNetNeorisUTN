using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Internacional : Paquete,IPago
    {
        public bool RequiereVisa { get; set; }
        private double cotizacionDolar;
        public double CotizacionDolar { get => cotizacionDolar; set => cotizacionDolar = value; }
        private int cantidadDeCuotas;
        public int CantidadDeCuotas { get => cantidadDeCuotas; set => cantidadDeCuotas = value; }
        public double ValorPorCuota { get; set; }

        public Internacional()
        {   }

        public bool SetImpuestoFijo(double impuesto)
        {
            if (impuesto > 0)
            {
                Precio += impuesto;
                return true;
            }
            return false;
        }

        public override void CargarPaquete()
        {
            base.CargarPaquete();

            Console.Write("El paquete requiere visa: ");
            Console.WriteLine("1: SI");
            Console.WriteLine("2: NO");
            var opc = Console.ReadKey(true);
            while (opc.KeyChar < '1' || opc.KeyChar > '2')
            {
                opc = Console.ReadKey(true);
            }
            if (opc.KeyChar == '1')
                RequiereVisa = true;
            else
                RequiereVisa = false;
            Console.Clear();

            Console.Write("Ingrese la cotizacion del dolar: ");
            var esDouble = Double.TryParse(Console.ReadLine(), out cotizacionDolar);
            while (!esDouble)
            {
                Console.Write("No se ingreso un numero decimal. Vuelve a ingresar un numero: ");
                esDouble = Double.TryParse(Console.ReadLine(), out cotizacionDolar);
            }
            Console.Clear();
            Precio /= cotizacionDolar;

            Console.Write("Ingresa el monto fijo de impuesto: ");
            var esDouble2 = Double.TryParse(Console.ReadLine(), out double impuesto);
            while (!esDouble2 || !SetImpuestoFijo(impuesto))
            {
                Console.Write("No se ingreso un numero decimal. Vuelve a ingresar un numero: ");
                esDouble2 = Double.TryParse(Console.ReadLine(), out impuesto);
            }
            Console.Clear();

            CargarPago();
        }

        public void CargarPago()
        {
            Console.Write("Ingresa la cantidad de cuotas (1, 3, 6): ");
            var esInt = int.TryParse(Console.ReadLine(), out cantidadDeCuotas);
            while(!esInt || (cantidadDeCuotas!=1 && cantidadDeCuotas!=3 && cantidadDeCuotas != 6))
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
            Console.WriteLine($"Requiere visa: {RequiereVisa}");
            Console.WriteLine($"Precio en dolares: U$D{Precio}");
            Console.WriteLine($"Cantidad de cuotas del pago: {CantidadDeCuotas}");
            Console.WriteLine($"Valor por cuota: U$D{ValorPorCuota}");
        }
    }
}
