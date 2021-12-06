using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Particular : Cliente
    {
        private long dni;
        private string apellido;
        private string nombre;

        public Particular():base() {
            IngresarDni();
            Console.WriteLine("Ingresa apellido: ");
            this.apellido = Console.ReadLine();
            Console.WriteLine("Ingresa nombre: ");
            this.nombre = Console.ReadLine();
        }

        public long Dni
        {
            get => dni;
            set => dni = value;
        }

        public string Apellido
        {
            get => apellido;
            set => apellido = value;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public override void MostrarCliente()
        {
            base.MostrarCliente();
            Console.WriteLine($"D.N.I.: {this.dni}");
            Console.WriteLine($"Apellido: {this.apellido}");
            Console.WriteLine($"Nombre: {this.nombre}");
        }

        private void IngresarDni()
        {
            Console.Write("Ingresar D.N.I.: ");
            var dniString = Console.ReadLine();
            var esInt = int.TryParse(dniString, out int dni);
            while(!esInt || dniString.Length != 8)
            {
                dniString = Console.ReadLine();
                esInt = int.TryParse(dniString, out dni);
            }
            this.dni=dni;
        }
    }
}
