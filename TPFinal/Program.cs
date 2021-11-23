using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace TPFinal
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente c = new Cliente();
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
            }while (continuar.KeyChar!='n' && continuar.KeyChar!='N');
           Console.WriteLine(c.Provincia);
        }
    }
}