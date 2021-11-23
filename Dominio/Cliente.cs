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
        private string _telefono;

        public Cliente() { }

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

        public void mostrarCliente()
        {
            Console.WriteLine("Cliente particular: \n"
                              + "Nacionalidad: " + this._nacionalidad + "\n"
                              + "Provincia: " + this._provincia + "\n"
                              + "Direccion: " + this._direccion + "\n"
                              + "Telefono: " + this._telefono + "\n");
        }
    }

   
}