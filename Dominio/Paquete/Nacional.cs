using System;

namespace Dominio
{
    public class Nacional : Paquete,IPago
    {
        public Nacional():base() {  }
        public override void CargarPaquete()
        {
            base.CargarPaquete();

            int cantidad = IngresaCantidadLugares();
            Console.Clear();
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"{i + 1}/{cantidad}");
                Lugar lugar = IngresarLugar();
                ListaLugares.Add(lugar);
            }
            Console.Clear();

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
                Precio = (Precio * (porcentaje/100)) + Precio;
                return true;
            }
            return false;
        }

        public void CargarPago()
        {
            Console.Write("Ingresa la cantidad de cuotas (1, 3, 6, 12): ");
            var esInt = int.TryParse(Console.ReadLine(), out int cantidadDeCuotas);
            while (!esInt || (cantidadDeCuotas != 1 && cantidadDeCuotas != 3 && cantidadDeCuotas != 6 && cantidadDeCuotas != 12))
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
            Console.WriteLine($"Precio en pesos: ${Precio}");
            Console.WriteLine($"Cantidad de cuotas del pago: {CantidadDeCuotas}");
            Console.WriteLine($"Valor por cuota: ${ValorPorCuota}");
        }

        public Lugar IngresarLugar()
        {
            Console.Write("Ingrese estado el cual va a visitar: ");
            string estado = Console.ReadLine();

            Console.Write("Ingrese la ciudad: ");
            string ciudad = Console.ReadLine();

            return new Lugar(ciudad,estado,"Argentina");
        }
    }
}
