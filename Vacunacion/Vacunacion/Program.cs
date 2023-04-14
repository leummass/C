using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacunacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            string nombre;
            Console.Write("Cuál es su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Cuál es su edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            nombre = nombre.ToUpper();
            if (edad >= 18)
            {
                Console.WriteLine(nombre);
                Console.WriteLine("Usted es mayor de edad, si puede vacunar.");
            }
            else
            {
                Console.WriteLine(nombre);
                Console.WriteLine("Usted no se puede vacunar aun porque es menor de edad");
            }
            Console.ReadKey();
        }
    }
}
