using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Lugar
    {
        [Key]
        public int Id { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        /*private DateTime fechaLLegada;
        private DateTime fechaSalida;
        public DateTime FechaLLegada { get => fechaLLegada; set => fechaLLegada = value; }
        public DateTime FechaSalida { get => fechaSalida; set => fechaSalida = value; }*/

        public Lugar()
        {   }

        public void IngresarLugar()
        {
            Console.Write("Ingrese el Pais el cual va a visitar: ");
            Pais = Console.ReadLine();
            Console.Clear();

            Console.Write("Ingrese la Ciudad: ");
            Ciudad = Console.ReadLine();
            Console.Clear();

            /*Console.WriteLine("Ingrese la fecha de llegada al lugar en el formato dd / MM / yyyy");
            var esFecha = DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None, out fechaLLegada);
            while (!esFecha)
            {
                Console.WriteLine("Formato de Fecha Incorrecto");
                Console.WriteLine("Ingrese la fecha de llegada al lugar en el formato dd / MM / yyyy");

            }
            Console.Clear();

            Console.WriteLine("Ingrese la fecha de salida del lugar en el formato dd / MM / yyyy");
            var esFecha2 = DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None, out fechaSalida);
            while (!esFecha2)
            {
                Console.WriteLine("Formato de Fecha Incorrecto");
                Console.WriteLine("Ingrese la fecha de salida del lugar en el formato dd / MM / yyyy");

            }
            Console.Clear();*/
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"ID del lugar: {Id}");
            Console.WriteLine($"Pais: {Pais}");
            Console.WriteLine($"Ciudad: {Ciudad}");
        }

    }
}
