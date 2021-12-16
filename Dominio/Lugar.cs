using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Lugar
    {
        [Key]
        public int IdLugar  { get; set; }


        //Navigation Properties
        public int IdPaquete { get; set; }
        [ForeignKey("IdPaquete")]
        public   Paquete Paquete { get; set; }
        //End Navigation Properties

        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        
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
            Console.WriteLine($"{Ciudad}, {Estado}, {Pais}");
        }
    }
}
