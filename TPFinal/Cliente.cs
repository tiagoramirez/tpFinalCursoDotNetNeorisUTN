using System;
using System.Runtime.Serialization;

namespace TPFinal

/*Cliente: Debe contener mínimamente nacionalidad,provincia, dirección y teléfono de contacto. 
    Existen clientes particulares que tendrán dni, apellido y nombre, y corporativo que 
ademas del apellido, nombre y dni del viajante tiene cuit y razón social de la empresa*/
{
//Agregado comentario prueba
    [Flags] public enum Provincias
    {
       
        [EnumMember(Value = "Buenos Aires")]
        BuenosAires,
        Catamarca,
        Chaco,
        Chubut,
        Córdoba,
        Corrientes,
        [EnumMember(Value = "Entre Ríos")]
        EntreRios,
        Formosa,
        Jujuy,
        [EnumMember(Value = "La Pampa")]
        LaPampa,
        [EnumMember(Value = "La Rioja")]
        LaRioja,
        Mendoza,
        Misiones,
        Neuquén,
        [EnumMember(Value = "Río Negro")]
        RíoNegro,
        Salta,
        [EnumMember(Value = "San Juan")]
        SanJuan,
        [EnumMember(Value = "San Luis")]
        SanLuis,
        [EnumMember(Value = "Santa Cruz")]
        SantaCruz,
        [EnumMember(Value = "Santa Fe")]
        SantaFe,
        [EnumMember(Value = "Santiago del Estero")]
        SantiagoDelEstero,
        [EnumMember(Value = "Tierra del Fuego Antártida e Islas del Atlántico Sur,")]
        TierraDelFuego,
        Tucumán
    }

    public class Cliente
    {
        private string _nacionalidad;
        private string _provincia;
        private string _direccion;
        private long _telefono;

        public Cliente(){}

        public Cliente(string nacionalidad, string provincia, string direccion, long telefono)
        {
            this._nacionalidad = nacionalidad;
            this._provincia = provincia;
            this._direccion = direccion;
            this._telefono = telefono;
        }

        public string Nacionalidad
        {
            get => _nacionalidad;
            set => _nacionalidad = value;
        }

        public string Provincia
        {
            get
            {
                return _provincia;
            }
            set
            {
                if (Enum.IsDefined(typeof(Provincias), value))
                {
                    _provincia = value;
                }
                else
                {
                    Console.WriteLine("Entrada invalida");
                }
            }
        }

        public string Direccion
        {
            get => _direccion;
            set => _direccion = value;
        }

        public long Telefono
        {
            get => _telefono;
            set => _telefono = value;
        }
    }

    public class Corporativo : Cliente
    {
        private string _razonSocial;
        private long _cuit;
        public Corporativo(string nacionalidad, string provincia, string direccion, long telefono, string razonSocial, long cuit) 
            : base(nacionalidad, provincia, direccion, telefono)
        {
            this._razonSocial = razonSocial;
            this._cuit = cuit;
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