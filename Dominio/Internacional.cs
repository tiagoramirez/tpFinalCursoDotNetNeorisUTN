using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Internacional : Paquete
    {
        private bool requiereVisa;
        private double contisacionDolar;
       
        public Internacional(int _cuotaMax)
        {
            this.CuotaMaxima = _cuotaMax;
        }



        public bool RequiereVisa { get => requiereVisa; set => requiereVisa = value; }
        public double ContisacionDolar { get => contisacionDolar; set => contisacionDolar = value; }

        public double SetImpuestoFijo(double impuesto)
        {
            return PrecioBase + impuesto;
        }

        public override void insertarPaquete()
        {
            base.insertarPaquete();
            Console.Write("El paquete requiere visa: ");
            Console.WriteLine("1: SI");
            Console.WriteLine("2: NO");
            var opc = Console.ReadKey(true);
            while (opc.KeyChar < '1' || opc.KeyChar > '2')
            {
                opc = Console.ReadKey(true);
            }
            if (opc.KeyChar == '1')
                this.requiereVisa = true;
            else
                this.requiereVisa = false;
            Console.Clear();
            Console.Write("Ingrese la cotisacion del dolar: ");
            Double.TryParse(Console.ReadLine(), out this.contisacionDolar);
            Console.Clear();
        }
        public override bool cargarPago(int cantidadCoutas, double porcentaje)
        {
            double valorPorCuota = 0;

            if (cantidadCoutas > 0)
            {
                valorPorCuota = SetImpuestoFijo(porcentaje) / cantidadCoutas;
            }
            if (cantidadCoutas > CuotaMaxima)
                return false;
            else
            {
                this.pago = new Pago(cantidadCoutas, valorPorCuota);
                return true;
            }

        }
    }
}
