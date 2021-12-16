using System;

namespace Dominio
{
    public class Internacional : Paquete, IPago
    {
        public bool RequiereVisa { get; set; }
        public double CotizacionDolar { get; set; }

        public Internacional() : base()
        {   }

        public override void CargarPaquete()
        {
            base.CargarPaquete();
            IngresarLugares();
            IngresarRequiereVisa();
            CargarImpuestoAPrecio();
            IngresarCotizacionDolar();
            CargarPago();
        }

        public Lugar IngresarLugar()
        {
            Console.Write("Ingrese pais el cual va a visitar: ");
            string pais = Console.ReadLine();

            Console.Write("Ingrese estado el cual va a visitar: ");
            string estado = Console.ReadLine();

            Console.Write("Ingrese la ciudad: ");
            string ciudad = Console.ReadLine();

            return new Lugar(ciudad, estado, pais);
        }

        private void IngresarLugares()
        {
            int cantidad = IngresaCantidadLugares();
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"{i + 1}/{cantidad}");
                Lugar lugar = IngresarLugar();
                ListaLugares.Add(lugar);
            }
            Console.Clear();
        }

        private void IngresarRequiereVisa()
        {
            Console.WriteLine("El paquete requiere visa?");
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
        }

        private bool SetImpuestoFijo(double impuesto)
        {
            if (impuesto > 0)
            {
                Precio += impuesto;
                return true;
            }
            return false;
        }

        private void CargarImpuestoAPrecio()
        {
            Console.Write("Ingresa el monto fijo de impuesto: ");
            var esDouble2 = Double.TryParse(Console.ReadLine(), out double impuesto);
            while (!esDouble2 || !SetImpuestoFijo(impuesto))
            {
                Console.Write("No se ingreso un numero decimal. Vuelve a ingresar un numero: ");
                esDouble2 = Double.TryParse(Console.ReadLine(), out impuesto);
            }
            Console.Clear();
        }

        private void IngresarCotizacionDolar()
        {
            Console.Write("Ingrese la cotizacion del dolar: ");
            var esDouble = Double.TryParse(Console.ReadLine(), out double cotizacionDolar);
            while (!esDouble)
            {
                Console.Write("No se ingreso un numero decimal. Vuelve a ingresar un numero: ");
                esDouble = Double.TryParse(Console.ReadLine(), out cotizacionDolar);
            }
            Console.Clear();
            CotizacionDolar = cotizacionDolar;
            Precio /= cotizacionDolar;
        }

        public void CargarPago()
        {
            Console.Write("Ingresa la cantidad de cuotas (1, 3, 6): ");
            var esInt = int.TryParse(Console.ReadLine(), out int cantidadDeCuotas);
            while (!esInt || (cantidadDeCuotas != 1 && cantidadDeCuotas != 3 && cantidadDeCuotas != 6))
            {
                Console.Write("No ingresaste una opcion valida. Vuelve a ingresar la cantidad de cuotas: ");
                esInt = int.TryParse(Console.ReadLine(), out cantidadDeCuotas);
            }
            ValorPorCuota = Precio / cantidadDeCuotas;
            CantidadDeCuotas = cantidadDeCuotas;
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
