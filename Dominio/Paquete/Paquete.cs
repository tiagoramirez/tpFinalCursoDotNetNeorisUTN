using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public abstract class Paquete
    {
        [Key]
        public  int IdPaquete { get   ; set ; }
        public string Nombre { get; set; }
        private double precio;
        public double Precio { get => precio; set => precio = value; }
        public int CuotaMaxima { get; set; }
        public List<Lugar> ListaLugares { get; set; }
        private int cantidadDiasTotales;
        public int CantidadDiasTotales { get => cantidadDiasTotales; set => cantidadDiasTotales = value; }
        public DateTime FechaDeViaje { get; set; }
        public bool Vigente { get; set; }
        
        public virtual void CargarPaquete()
        {
            DateTime fechaViaje;
           
            Console.Write("Ingresar el nombre del paquete: ");
            Nombre = Console.ReadLine();
            Console.Clear();

            IngresaPrecioBase();
            Console.Clear();

            int cantidad = IngresaCantidadLugares();
            Console.Clear();
            for (int i = 0; i < cantidad; i++)
            {
                var lugar = new Lugar();
                lugar.IngresarLugar();
                ListaLugares.Add(lugar);
                Console.WriteLine($"{i+1}/{cantidad}");
            }

            IngresaCantidadDiasTotales();
            Console.Clear();

            Console.Write("Ingrese la fecha de inicio del viaje en el formato  dd / MM / yyyy");
            while (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None, out fechaViaje))
            {
                Console.Write("Formato de Fecha Incorrecto");
                Console.Write("Ingrese la fecha de inicio del viaje en el formato  dd / MM / yyyy");
            }
            Vigente = true;
        }

        private void IngresaPrecioBase()
        {
            Console.Write("Ingresar el precio base del paquete en pesos: ");
            var esDouble = Double.TryParse(Console.ReadLine(), out precio);
            while (!esDouble)
            {
                Console.Write("No se ingreso un numero decimal. Vuelve a ingresar un numero: ");
                esDouble = Double.TryParse(Console.ReadLine(), out precio);
            }
        }

        private int IngresaCantidadLugares()
        {
            Console.Write("Ingrese la cantidad de lugares a los que viaja en este paquete (maximo 10): ");
            var esInt = int.TryParse(Console.ReadLine(), out int cantidad);
            while (!esInt || cantidad>10)
            {
                Console.WriteLine("No ingresaste un numero o el ingresado es mayor a 10. Vuelve a ingresar un numero: ");
                esInt = int.TryParse(Console.ReadLine(), out cantidad);
            }
            return cantidad;
        }

        private void IngresaCantidadDiasTotales()
        {
            Console.Write("Ingrese la cantidad de dias totales: ");
            var esInt = int.TryParse(Console.ReadLine(), out cantidadDiasTotales);
            while (!esInt)
            {
                Console.WriteLine("No ingresaste un numero. Vuelve a ingresar un numero: ");
                esInt = int.TryParse(Console.ReadLine(), out cantidadDiasTotales);
            }
        }

        public virtual void MostrarPaquete()
        {
            Console.WriteLine($"idPaquete: {IdPaquete}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine("Lista de lugares al que viaja: ");
            int i = 1;
            foreach (var elemento in ListaLugares)
            {
                Console.WriteLine($"Lugar numero {i}: ");
                elemento.MostrarInfo();
                i++;
            }
            Console.WriteLine($"Cantidad de dias totales de viaje: {CantidadDiasTotales}");
            Console.WriteLine($"FechaDeViaje: {FechaDeViaje}");
            Console.WriteLine($"Vigente: {Vigente}");
        }
    }
}
