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
        private string nombre;
        private double precioBase;
        private Lugar[] listaLugares = new Lugar[10];
        private int cantidadDiasTotales;
        private DateTime fechaDeViaje;
        private bool vigente;
        protected Pago pago;
        public int CuotaMaxima { get; set; }

        public string Nombre { get => nombre; set => nombre = value; }
        public double PrecioBase { get => precioBase; set => precioBase = value; }
        public int CantidadDiasTotales { get => cantidadDiasTotales; set => cantidadDiasTotales = value; }
        public DateTime FechaDeViaje { get => fechaDeViaje; set => fechaDeViaje = value; }
        public bool Vigente { get => vigente; set => vigente = value; }
         
        public  Lugar[] ListaLugares { get => listaLugares; set => listaLugares = value; }
        public   abstract bool cargarPago(int cantidadCoutas,double porcentaje);
        
        public virtual void insertarPaquete()
        {
            int cantidad=0;
            int dias;
            DateTime fechaViaje;
           
            Console.Write("Ingresar el nombre del paquete: ");
            this.nombre = Console.ReadLine();
            Console.Clear();

            Console.Write("Ingresar el precio base del paquete: ");
            Double.TryParse(Console.ReadLine(), out this.precioBase);
            Console.Clear();
            do
            {
                Console.Write("Ingrese la cantidad de lugares a los que viaja en este paquete");
                int.TryParse(Console.ReadLine(), out cantidad);
                Console.Clear();
            } while (cantidad > 10);
            for(int i = 0; i < cantidad; i++)
            {
               listaLugares[i] = ingresarLugar();
            }
            Console.Write("Ingrese la cantidad de dias totales");
             int.TryParse(Console.ReadLine(),out this.cantidadDiasTotales);
            Console.Clear();

            Console.Write("Ingrese la fecha de inicio del viaje en el formato  dd / MM / yyyy");
            while (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None, out fechaViaje))
            {
                Console.Write("Formato de Fecha Incorrecto");
                Console.Write("Ingrese la fecha de inicio del viaje en el formato  dd / MM / yyyy");
            }
            this.vigente = true;
        }
        public Lugar ingresarLugar()
        {
            DateTime fechaLlegada, fechaSalida;
            Console.Write("Ingrese el Pais");
            string pais = Console.ReadLine();
            Console.Clear();
            Console.Write("Ingrese la Ciudad");
            string ciudad = Console.ReadLine();
            Console.Clear();
            Console.Write("Ingrese la fecha de llegada al lugar en el formato dd / MM / yyyy");
            while (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None, out fechaLlegada))
            {
                Console.Write("Formato de Fecha Incorrecto");
                Console.Write("Ingrese la fecha de llegada al lugar en el formato dd / MM / yyyy");

            }

            Console.Clear();
            Console.Write("Ingrese la fecha de salida del lugar en el formato dd / MM / yyyy");
            while (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None, out fechaSalida))
            {
                Console.Write("Formato de Fecha Incorrecto");
                Console.Write("Ingrese la fecha de salida del lugar en el formato dd / MM / yyyy");

            }
            Console.Clear();
            return new Lugar(pais, ciudad, fechaLlegada, fechaSalida);
        }
        public virtual void MostrarPaquete()
        {
            Console.WriteLine($"idPaquete: {IdPaquete}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"PrecioBase: {precioBase}");
            Console.WriteLine("Lista de lugares al que viaja");
            for (int i = 0; i < listaLugares.Length; i++)
            {
                Console.WriteLine($"Pais: {ListaLugares[i].Pais}");
                Console.WriteLine($"Ciudad: {ListaLugares[i].Ciudad}");
                Console.WriteLine($"FechaLLegada: {ListaLugares[i].FechaLLegada}");
                Console.WriteLine($"FechaSalida: {ListaLugares[i].FechaSalida}");
            }
            Console.WriteLine($"Direccion: {CantidadDiasTotales}");
            Console.WriteLine($"FechaDeViaje: {fechaDeViaje}");
            Console.WriteLine($"Vigente: {vigente}");
        }
    }
}
