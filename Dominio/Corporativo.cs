using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal
{
    public class Corporativo : Particular
    {
        private string _razonSocial;
        private long _cuit;

        public Corporativo(string razonSocial, long cuit)
        {
            _razonSocial = razonSocial;
            _cuit = cuit;
        }

        public Corporativo(string nacionalidad, string provincia, string direccion, string telefono, long dni, string apellido, string nombre, string razonSocial, long cuit) : base(nacionalidad, provincia, direccion, telefono, dni, apellido, nombre)
        {
            _razonSocial = razonSocial;
            _cuit = cuit;
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
    }
}
