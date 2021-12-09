using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Particular : Cliente
    {
        public string Apellido { get; set; }
        public string Nombre { get; set; }

        public Particular():base()
        {   }

        public override void CargarCliente()
        {
            base.CargarCliente();
            Console.Clear();
            Console.Write("Ingresa apellido: ");
            this.Apellido = Console.ReadLine();
            Console.Clear();
            Console.Write("Ingresa nombre: ");
            this.Nombre = Console.ReadLine();
            Console.Clear();
        }

        public override void MostrarCliente()
        {
            base.MostrarCliente();
            Console.WriteLine($"D.N.I. del viajante: {this.Dni}");
            Console.WriteLine($"Apellido: {this.Apellido}");
            Console.WriteLine($"Nombre: {this.Nombre}");
        }
    }
}
