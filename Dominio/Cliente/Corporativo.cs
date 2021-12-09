using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Corporativo : Particular
    {
        public string RazonSocial { get; set; }
        public long Cuit { get; set; }

        public Corporativo():base()
        {   }

        public override void CargarCliente()
        { 
            base.CargarCliente();
            Console.Write("Ingresar razon social: ");
            this.RazonSocial = Console.ReadLine();
            Console.Clear();
            IngresarCuit();
            Console.Clear();
        }

        public override void MostrarCliente()
        {
            base.MostrarCliente();
            Console.WriteLine($"Razon social: {RazonSocial}");
            Console.WriteLine($"C.U.I.T.: {Cuit}");
        }

        private void IngresarCuit()
        {
            Console.Write("Ingresar C.U.I.T.: ");
            var cuitString = Console.ReadLine();
            var esLong = long.TryParse(cuitString, out long cuit);
            while(!esLong || cuitString.Length != 11)
            {
                Console.WriteLine("C.U.I.T. incorrecto!");
                Console.Write("Vuelve a ingresar el C.U.I.T.: ");
                cuitString = Console.ReadLine();
                esLong = long.TryParse(cuitString, out cuit);
            }
            this.Cuit = cuit;
        }
    }
}
