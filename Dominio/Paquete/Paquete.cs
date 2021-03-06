using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public abstract class Paquete 
    {
        [Key]
        public int IdPaquete { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int CantidadDiasTotales { get; set; }
        public DateTime FechaDeViaje { get; set; }
        public DateTime FechaDeRegreso { get; set; }
        public bool Vigente { get; set; }
        public int CantidadDeCuotas { get; set; }
        public double ValorPorCuota { get; set; }

        //Navigation Properties
        public List<Lugar> ListaLugares { get; set; }
        public List<Factura> ListaFacturas { get; set; }
        //End Navigation Properties

        public Paquete()
        {
            ListaLugares = new List<Lugar>();
        }

        public virtual void CargarPaquete()
        {
            IngresarNombre();
            IngresaPrecio();
            IngresarFechaViaje();
            IngresaCantidadDiasTotales();
            Vigente = true;
        }

        private void IngresarNombre()
        {
            Console.Write("Ingresar el nombre del paquete: ");
            Nombre = Console.ReadLine();
            Console.Clear();
        }

        private void IngresaPrecio()
        {
            double precio;
            Console.Write("Ingresar el precio base del paquete en pesos: ");
            var esDouble = Double.TryParse(Console.ReadLine(), out precio);
            while (!esDouble)
            {
                Console.Write("No se ingreso un numero decimal. Vuelve a ingresar un numero: ");
                esDouble = Double.TryParse(Console.ReadLine(), out precio);
            }
            Precio= precio;
            Console.Clear();
        }

        private void IngresarFechaViaje()
        {
            var fechaValida = false;
            while (!fechaValida)
            {
                try
                {
                    Console.Write("Ingresa el dia: ");
                    var esInt = int.TryParse(Console.ReadLine(), out int dia);
                    while (!esInt)
                    {
                        Console.WriteLine("No ingresaste un numero. Vuelve a ingresar un numero: ");
                        esInt = int.TryParse(Console.ReadLine(), out dia);
                    }
                    Console.Clear();

                    Console.Write("Ingresa el mes: ");
                    esInt = int.TryParse(Console.ReadLine(), out int mes);
                    while (!esInt)
                    {
                        Console.WriteLine("No ingresaste un numero. Vuelve a ingresar un numero: ");
                        esInt = int.TryParse(Console.ReadLine(), out mes);
                    }
                    Console.Clear();

                    Console.Write("Ingresa el anio: ");
                    esInt = int.TryParse(Console.ReadLine(), out int anio);
                    while (!esInt)
                    {
                        Console.WriteLine("No ingresaste un numero. Vuelve a ingresar un numero: ");
                        esInt = int.TryParse(Console.ReadLine(), out anio);
                    }
                    Console.Clear();

                    FechaDeViaje = new DateTime(anio, mes, dia);
                    fechaValida = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("La fecha ingresada no existe. Vuelva a ingresar los datos!");
                }
            }
            Console.Clear();
        }

        private void IngresaCantidadDiasTotales()
        {
            int cantidadDiasTotales;
            Console.Write("Ingrese la cantidad de dias totales: ");
            var esInt = int.TryParse(Console.ReadLine(), out cantidadDiasTotales);
            while (!esInt)
            {
                Console.WriteLine("No ingresaste un numero. Vuelve a ingresar un numero: ");
                esInt = int.TryParse(Console.ReadLine(), out cantidadDiasTotales);
            }
            CantidadDiasTotales = cantidadDiasTotales;
            FechaDeRegreso = FechaDeViaje.AddDays(CantidadDiasTotales);
            Console.Clear();
        }

        public virtual void MostrarPaquete()
        {
            Console.WriteLine($"idPaquete: {IdPaquete}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine("Lugares: ");
            foreach(var item in ListaLugares)
            {
                item.MostrarLugar();
            }
            Console.WriteLine($"Fecha de viaje: {FechaDeViaje}");
            Console.WriteLine($"Fecha de regreso: {FechaDeRegreso}");
            Console.WriteLine($"Cantidad de dias totales de viaje: {CantidadDiasTotales}");
            Console.WriteLine($"Vigente: {Vigente}");
        }

        protected int IngresaCantidadLugares()
        {
            Console.Write("Ingrese la cantidad de lugares a los que viaja en este paquete (maximo 10): ");
            var esInt = int.TryParse(Console.ReadLine(), out int cantidad);
            while (!esInt || cantidad > 10)
            {
                Console.WriteLine("No ingresaste un numero o el ingresado es mayor a 10. Vuelve a ingresar un numero: ");
                esInt = int.TryParse(Console.ReadLine(), out cantidad);
            }
            Console.Clear();
            return cantidad;
        }
    }
}
