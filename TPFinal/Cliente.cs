using System;
using System.Runtime.Serialization;
using System.Transactions;

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

    public abstract class Cliente
    {
        private string _nacionalidad;
        private string _provincia;
        private string _direccion;
        private string _telefono;

        public Cliente(){}

        public Cliente(string nacionalidad, string provincia, string direccion, string telefono)
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

        public string Telefono
        {
            get => _telefono;
            set => _telefono = value;
        }
        
        public  void mostrarCliente()
        {
            Console.WriteLine("Cliente particular: \n" 
                              + "Nacionalidad: " + this._nacionalidad + "\n" 
                              + "Provincia: " + this._provincia + "\n"
                              + "Direccion: " + this._direccion + "\n"
                              + "Telefono: " + this._telefono + "\n");
        }
    }

    public class Particular : Cliente
    {
        //dni se usará como id
        private long dni;
        private string apellido;
        private string nombre;

        public Particular(){}

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