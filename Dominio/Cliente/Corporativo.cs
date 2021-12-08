using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Corporativo : Particular
    {
        private string _razonSocial;
        private long _cuit;

        public Corporativo():base()
        {
            Console.Write("Ingresar razon social: ");
            this._razonSocial=Console.ReadLine();
            Console.Clear();
            IngresarCuit();
            Console.Clear();
        }

        public override void MostrarCliente()
        {
            base.MostrarCliente();
            Console.WriteLine($"Razon social: {_razonSocial}");
            Console.WriteLine($"C.U.I.T.: {_cuit}");
        }

        public string RazonSocial
        {
            get => _razonSocial;
            set => _razonSocial = value;
        }

        public long Cuit
        {
            get => _cuit;
            set => _cuit = value;
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
            this._cuit = cuit;
        }
    }
}
