using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal
{
    public class Particular : Cliente
    {
        //dni se usará como id
        private long dni;
        private string apellido;
        private string nombre;

        public Particular() { }

        public Particular(string nacionalidad, string provincia, string direccion, string telefono, long dni, string apellido, string nombre)
            : base(nacionalidad, provincia, direccion, telefono)
        {
            this.dni = dni;
            this.apellido = apellido;
            this.nombre = nombre;
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

        public void mostrarCliente(Particular p)
        {
            base.mostrarCliente();
            Console.WriteLine(p.dni);
            //TODO: seguir generando codigo para mostrar info
        }
    }
}
