using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
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
                _provincia=value;
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
