using System;

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
            IngresarRazonSocial();
            IngresarCuit();
        }

        private void IngresarRazonSocial()
        {
            Console.Write("Ingresar razon social: ");
            this.RazonSocial = Console.ReadLine();
            Console.Clear();
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
            Console.Clear();
        }

        public override void MostrarCliente()
        {
            base.MostrarCliente();
            Console.WriteLine($"Razon social: {RazonSocial}");
            Console.WriteLine($"C.U.I.T.: {Cuit}");
        }

    }
}
