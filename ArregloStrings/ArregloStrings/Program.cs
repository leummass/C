using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArregloStrings
{
    class Program
    {
        string[] cadenas = new string[5];
        static void Main(string[] args)
        {
            Program program = new Program();
            int opcion = 0;
            do
            {
                Console.WriteLine("Opciones disponbiles");
                Console.WriteLine("1. Capturar");
                Console.WriteLine("2. Imprimir en minusculas");
                Console.WriteLine("3. Imprimir en mayusculas");
                Console.WriteLine("4. Invertir orden de arreglo");
                Console.WriteLine("5. Editar un elemento");
                Console.WriteLine("0. Salir");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1: program.CapturaString();break;
                    case 2: program.ImprimirStringMinus();break;
                    case 3:program.ImprimirStringMayus(); break;
                    case 4: program.InvertirOrden();break;
                    case 5: program.EditarElemento();break;
                }

            } while (opcion != 0);

            
            Console.ReadKey();
        }
        public void CapturaString()
        {
            for (int i = 0; i < cadenas.Length; i++)
            {
                Console.Write("Teclee la cadena {0}: ", i);
                cadenas[i] = Console.ReadLine();
            }
        }
        public void ImprimirStringMinus()
        {
            foreach(string s in cadenas)
            {
                Console.WriteLine(s.ToLower());
                
            }
        }
        public void ImprimirStringMayus()
        {
            foreach (string s in cadenas)
            {
                Console.WriteLine(s.ToUpper());

            }
        }
        public void InvertirOrden()
        {
            string aux;
            for (int i = 0; i < cadenas.Length/2; i++)
            {
                aux = cadenas[i];
                cadenas[i] = cadenas[cadenas.Length-i-1];
                cadenas[cadenas.Length - i-1] = aux;

            }
        }
        public void EditarElemento()
        {
            int i;
            Console.Write("Posición del elemento que quiere editar(0-{0}): ", cadenas.Length - 1);
            i = Convert.ToInt32(Console.ReadLine());
            while (i < 0 && i >= cadenas.Length)
            {
                Console.WriteLine("Teclee un numero entero que esté dentro del rango");
                Console.Write("Posición del elemento que quiere editar(0-{0}): ", cadenas.Length - 1);
                i = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Introduzca la nueva cadena: ");
            cadenas[i] = Console.ReadLine();
        }
    }
}
