using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public abstract class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string Nacionalidad { get; set; }
        public string Provincia { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int Dni { get; set; }

        //Navigation Properties
        public List<Factura> ListaFacturas { get; set; }
        //End Navigation Properties

        public Cliente() {
            ListaFacturas = new List<Factura>();
        }

        public virtual void CargarCliente()
        {
            IngresarDni();
            IngresarNacionalidad();
            IngresarProvincia();
            IngresarDireccion();
            IngresarTelefono();
        }

        private void IngresarDni()
        {
            Console.Write("Ingresar D.N.I. del cliente: ");
            var dniString = Console.ReadLine();
            var esInt = int.TryParse(dniString, out int dni);
            while (!esInt || dniString.Length != 8)
            {
                Console.WriteLine("D.N.I. incorrecto!");
                Console.Write("Vuelve a ingresar el D.N.I. del viajante: ");
                dniString = Console.ReadLine();
                esInt = int.TryParse(dniString, out dni);
            }
            this.Dni = dni;
            Console.Clear();
        }

        private void IngresarNacionalidad()
        {
            Console.Write("Ingresa nacionalidad: ");
            this.Nacionalidad = Console.ReadLine();
            Console.Clear();
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
            Console.Write("Ingrese provincia: ");

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
                case 1:
                    Provincia = "Buenos Aires";
                    break;
                case 2:
                    Provincia = "Capital Federal";
                    break;
                case 3:
                    Provincia = "Catamarca";
                    break;
                case 4:
                    Provincia = "Chaco";
                    break;
                case 5:
                    Provincia = "Chubut";
                    break;
                case 6:
                    Provincia = "Córdoba";
                    break;
                case 7:
                    Provincia = "Corrientes";
                    break;
                case 8:
                    Provincia = "Entre Ríos";
                    break;
                case 9:
                    Provincia = "Formosa";
                    break;
                case 10:
                    Provincia = "Jujuy";
                    break;
                case 11:
                    Provincia = "La Pampa";
                    break;
                case 12:
                    Provincia = "La Rioja";
                    break;
                case 13:
                    Provincia = "Mendoza";
                    break;
                case 14:
                    Provincia = "Misiones";
                    break;
                case 15:
                    Provincia = "Neuquén";
                    break;
                case 16:
                    Provincia = "Río Negro";
                    break;
                case 17:
                    Provincia = "Salta";
                    break;
                case 18:
                    Provincia = "San Juan";
                    break;
                case 19:
                    Provincia = "San Luis";
                    break;
                case 20:
                    Provincia = "Santa Cruz";
                    break;
                case 21:
                    Provincia = "Santa Fe";
                    break;
                case 22:
                    Provincia = "Santiago del Estero";
                    break;
                case 23:
                    Provincia = "Tierra del Fuego";
                    break;
                case 24:
                    Provincia = "Tucumán";
                    break;
            }
        }

        private void IngresarProvincia()
        {
            var opc = MostrarProvinciasEIngresarOpcion();
            SetProvincia(opc);
            Console.Clear();
        }

        private void IngresarDireccion()
        {
            Console.Write("Ingresa direccion: ");
            this.Direccion = Console.ReadLine();
            Console.Clear();
        }

        private void IngresarTelefono()
        {
            Console.Write("Ingresa telefono: ");
            this.Telefono = Console.ReadLine();
            Console.Clear();
        }

        public virtual void MostrarCliente()
        {
            Console.WriteLine($"ID: {IdCliente}");
            Console.WriteLine($"Nacionalidad: {Nacionalidad}");
            Console.WriteLine($"Provincia: {Provincia}");
            Console.WriteLine($"Direccion: {Direccion}");
            Console.WriteLine($"Telefono: {Telefono}");
            if(ListaFacturas.Count==0 || ListaFacturas == null)
            {
                Console.WriteLine($"No tiene facturas");
            }
            else
            {
                Console.WriteLine("Tiene las facturas: ");
                foreach (var fact in ListaFacturas)
                {
                    Console.WriteLine(" - "+fact.IdFactura);
                }
            }
        }
    }
}