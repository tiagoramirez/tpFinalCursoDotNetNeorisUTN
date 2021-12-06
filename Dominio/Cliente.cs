using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {
        private int _id;
        private string _nacionalidad;
        private string _provincia;
        private string _direccion;
        private string _telefono;

        public Cliente() {
            Console.Write("Ingresa nacionalidad: ");
            this._nacionalidad = Console.ReadLine();
            IngresarProvincia();
            Console.Write("Ingresa direccion: ");
            this._direccion = Console.ReadLine();
            Console.Write("Ingresa telefono: ");
            this._telefono = Console.ReadLine();
        }

        public string Nacionalidad
        {
            get => _nacionalidad;
            set => _nacionalidad = value;
        }

        public string Provincia
        {
            get => _provincia;
            set => _provincia = value;
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

        public virtual void MostrarCliente()
        {
            Console.WriteLine("Nacionalidad: " + this._nacionalidad);
            Console.WriteLine("Provincia: " + this._provincia);
            Console.WriteLine("Direccion: " + this._direccion);
            Console.WriteLine("Telefono: " + this._telefono);
        }

        private void IngresarProvincia()
        {
            var opc=MostrarProvinciasEIngresarOpcion();
            SetProvincia(opc);
        }

        private int MostrarProvinciasEIngresarOpcion()
        {
            Console.WriteLine("1: Buenos Aires");
            Console.WriteLine("2: Capital Federal");
            Console.WriteLine("3: Catamarca");
            Console.WriteLine("4: Chaco");
            Console.WriteLine("5: Chubut");
            Console.WriteLine("6: Córdoba");
            Console.WriteLine("7: Corrientes");
            Console.WriteLine("8: Entre Ríos");
            Console.WriteLine("9: Formosa");
            Console.WriteLine("10: Jujuy");
            Console.WriteLine("11: La Pampa");
            Console.WriteLine("12: La Rioja");
            Console.WriteLine("13: Mendoza");
            Console.WriteLine("14: Misiones");
            Console.WriteLine("15: Neuquén");
            Console.WriteLine("16: Río Negro");
            Console.WriteLine("17: Salta");
            Console.WriteLine("18: San Juan");
            Console.WriteLine("19: San Luis");
            Console.WriteLine("20: Santa Cruz");
            Console.WriteLine("21: Santa Fe");
            Console.WriteLine("22: Santiago del Estero");
            Console.WriteLine("23: Tierra del Fuego");
            Console.WriteLine("24: Tucumán");

            var esInt = int.TryParse(Console.ReadLine(), out int opc);
            while (opc < 1 || opc > 24 || !esInt)
            {
                Console.WriteLine("Opcion Incorrecta!");
                Console.Write("Vuelve a ingresar una opcion: ");
                esInt = int.TryParse(Console.ReadLine(), out opc);
            }
            Console.Clear();
            return opc;
        }

        private void SetProvincia(int opc)
        {
            switch (opc)
            {
                case 1: _provincia= "Buenos Aires";
                    break;
                case 2: _provincia = "Capital Federal";
                    break;
                case 3: _provincia = "Catamarca";
                    break;
                case 4: _provincia = "Chaco";
                    break;
                case 5: _provincia = "Chubut";
                    break;
                case 6: _provincia = "Córdoba";
                    break;
                case 7: _provincia = "Corrientes";
                    break;
                case 8: _provincia = "Entre Ríos";
                    break;
                case 9: _provincia = "Formosa";
                    break;
                case 10: _provincia = "Jujuy";
                    break;
                case 11: _provincia = "La Pampa";
                    break;
                case 12: _provincia = "La Rioja";
                    break;
                case 13: _provincia = "Mendoza";
                    break;
                case 14: _provincia = "Misiones";
                    break;
                case 15: _provincia = "Neuquén";
                    break;
                case 16: _provincia = "Río Negro";
                    break;
                case 17: _provincia = "Salta";
                    break;
                case 18: _provincia = "San Juan";
                    break;
                case 19: _provincia = "San Luis";
                    break;
                case 20: _provincia = "Santa Cruz";
                    break;
                case 21: _provincia = "Santa Fe";
                    break;
                case 22: _provincia = "Santiago del Estero";
                    break;
                case 23: _provincia = "Tierra del Fuego";
                    break;
                case 24: _provincia = "Tucumán";
                    break;
            }
        }
    }
}
