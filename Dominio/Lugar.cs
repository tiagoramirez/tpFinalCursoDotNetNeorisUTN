using System;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Lugar
    {
        [Key]
        public int Id { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        //Navigation Properties
        public int PaqueteId { get; set; }
        public Paquete Paquete { get; set; }

        public Lugar() { }
        public Lugar(string ciudad, string estado, string pais)
        {
            this.Ciudad=ciudad;
            this.Estado=estado;
            this.Pais=pais;
        }

        public void IngresarLugar()
        {
            Console.Write("Ingrese pais el cual va a visitar: ");
            Estado = Console.ReadLine();
            Console.Clear();

            Console.Write("Ingrese estado el cual va a visitar: ");
            Estado = Console.ReadLine();
            Console.Clear();

            Console.Write("Ingrese la Ciudad: ");
            Ciudad = Console.ReadLine();
            Console.Clear();
        }
        
        public void MostrarLugar()
        {
            Console.WriteLine($"Ciudad: {Ciudad}");
            Console.WriteLine($"Estado: {Estado}");
            Console.WriteLine($"Pais: {Pais}");
        }
    }
}
