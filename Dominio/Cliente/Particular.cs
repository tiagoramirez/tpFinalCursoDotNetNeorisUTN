using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Particular : Cliente
    {
        public int Dni { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }

        public Particular():base()
        {   }

        public override void CargarCliente()
        {
            base.CargarCliente();
            IngresarDni();
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

        private void IngresarDni()
        {
            Console.Write("Ingresar D.N.I. del viajante: ");
            var dniString = Console.ReadLine();
            var esInt = int.TryParse(dniString, out int dni);
            while(!esInt || dniString.Length != 8)
            {
                Console.WriteLine("D.N.I. incorrecto!");
                Console.Write("Vuelve a ingresar el D.N.I. del viajante: ");
                dniString = Console.ReadLine();
                esInt = int.TryParse(dniString, out dni);
            }
            this.Dni=dni;
        }
    }
}
