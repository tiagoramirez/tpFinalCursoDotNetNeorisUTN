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
        
        public void MostrarLugar()
        {
            Console.WriteLine($"{Ciudad}, {Estado}, {Pais}");
        }
    }
}
