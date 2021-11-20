using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace TPFinal
{
    class Program
    {
        static void Main(string[] args)
        {

            
            ConsoleKeyInfo continuar;
            long dni;
            string prov, nac, nombre, apellido, dir, tel;
            
            do
            {
                Console.WriteLine("Ingrese DNI: ");
                dni = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Ingrese Nombre: ");
                nombre = Console.ReadLine();
                
                Console.WriteLine("Ingrese Apellido: ");
                apellido = Console.ReadLine();
                
                Console.WriteLine("Ingrese Nacionalidad: ");
                nac = Console.ReadLine();
                
                Console.WriteLine("Ingrese Provincia: ");
                prov = Console.ReadLine();
                //formateo de texto de entrada
                //se quitan los espacios y
                //se ponen las primeras letras en mayúsculas
                prov = (CultureInfo.InvariantCulture.TextInfo.ToTitleCase(prov));
                Console.WriteLine(prov);
                prov = Regex.Replace(prov, @"\s", "");
                //Console.WriteLine(prov);  <-- for testing
                //c.Provincia = prov; <-- for testing
                
                Console.WriteLine("Ingrese Direccion: ");
                dir = Console.ReadLine();
                
                Console.WriteLine("Ingrese Telefono: ");
                tel = Console.ReadLine();
                
                Console.WriteLine("Continuar? (s/n)");
                continuar = Console.ReadKey(true);
            }while (continuar.KeyChar!='n' && continuar.KeyChar!='N');

            Particular p = new Particular(nac, prov, dir, tel, dni, apellido, nombre);
            p.mostrarCliente(p);
        }
    }
}