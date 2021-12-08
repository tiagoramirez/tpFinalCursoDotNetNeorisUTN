using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Particular : Cliente
    {
        private long _dni;
        private string _apellido;
        private string _nombre;

        public Particular():base() {
            IngresarDni();
            Console.Clear();
            Console.Write("Ingresa apellido: ");
            this._apellido = Console.ReadLine();
            Console.Clear();
            Console.Write("Ingresa nombre: ");
            this._nombre = Console.ReadLine();
            Console.Clear();
        }

        public long Dni
        {
            get => _dni;
            set => _dni = value;
        }

        public string Apellido
        {
            get => _apellido;
            set => _apellido = value;
        }

        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }

        public override void MostrarCliente()
        {
            base.MostrarCliente();
            Console.WriteLine($"D.N.I. del viajante: {this._dni}");
            Console.WriteLine($"Apellido: {this._apellido}");
            Console.WriteLine($"Nombre: {this._nombre}");
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
            this._dni=dni;
        }
    }
}
