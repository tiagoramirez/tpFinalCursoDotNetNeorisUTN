using Dominio;
using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace TP_Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var terminar = false;
            while (!terminar)
            {
                Menus.MostrarMenuPrincipal();
                var opc = Console.ReadKey(true);
                while (opc.KeyChar != '1' && opc.KeyChar != '2' && opc.KeyChar != '3' && opc.KeyChar != '4' && opc.KeyChar != '5' && opc.KeyChar != '6')
                {
                    opc = Console.ReadKey(true);
                }
                Console.Clear();

                switch (opc.KeyChar)
                {
                    case '1':
                        break;
                    case '2':
                        break;
                    case '3':
                        break;
                    case '4':
                        break;
                    case '5':
                        break;
                    case '6':terminar = true;
                        break;
                }
            }
            
            //Esto por el momento lo vamos a inutilizar y a la larga agregarlo en alguna parte de la creacion del cliente!

            /*Cliente c = new Cliente();
            ConsoleKeyInfo continuar;
            string prov;

            do
            {
                Console.WriteLine("Ingrese Provincia: ");
                prov = Console.ReadLine();
                //formateo de texto de entrada
                //se quitan los espacios y
                //se ponen las primeras letras en mayúsculas
                prov = (CultureInfo.InvariantCulture.TextInfo.ToTitleCase(prov));
                Console.WriteLine(prov);
                prov = Regex.Replace(prov, @"\s", "");

                Console.WriteLine(prov);
                c.Provincia = prov;

                Console.WriteLine("Continuar? (s/n)");
                continuar = Console.ReadKey(true);
            } while (continuar.KeyChar != 'n' && continuar.KeyChar != 'N');
            Console.WriteLine(c.Provincia);*/
        }
    }
}
