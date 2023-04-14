using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArregloVentas
{
    class Program
    {
        double[] arregloVentas = new double[7];
        string[] dias = {"Lunes","Martes","Miercoles","Jueves","Viernes","Sabado","Doming" };
        static void Main(string[] args)
        {
            Program program = new Program();
            int opcion = 0;
            do
            {
                Console.WriteLine("Opciones disponbiles");
                Console.WriteLine("1. Agrega ventas");
                Console.WriteLine("2. Ventas de un dia");
                Console.WriteLine("3. Ventas de todos los dias");
                Console.WriteLine("4. Cancelar venta");
                Console.WriteLine("5. Mostrar la mayor venta");
                Console.WriteLine("0. Salir");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1: program.AgregaVentas(); break;
                    case 2: program.VentaspDia(); break;
                    case 3: program.PresentarTVentas(); break;
                    case 4: program.CancelarVenta(); break;
                    case 5: program.MayorVenta(); break;
                }

            } while (opcion != 0);


            Console.ReadKey();


        }
        public void AgregaVentas()
        {
            Console.Write("Proporcione el dia de la venta: ");
            int dia = Convert.ToInt32(Console.ReadLine());
            int pos = ValidacionesVentas.ValidaDia(dia);

            if (pos >= 0){
                Console.Write("Importe de la venta: ");
                double venta = Convert.ToDouble(Console.ReadLine());

                arregloVentas[pos] = arregloVentas[pos] + venta;
                Console.WriteLine("Venta acumulada del día {0}: {1}", dia, arregloVentas[pos]);
            }

        }
        public void VentaspDia()
        {
            Console.Write("Proporcione el dia de la venta: ");
            int dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Venta acumulada del día {0}: {1}", dia, arregloVentas[dia - 1]);
        }
        public void PresentarTVentas()
        {
            for (int i = 0; i < arregloVentas.Length; i++)
            {
                Console.WriteLine("Ventas del dia {0}: {1}", dias[i], arregloVentas[i]);
            }

        }
        public void CancelarVenta()
        {
            Console.Write("Dia de la venta a cancelar: ");
            int dia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Importe: ");
            double restaventa = Convert.ToDouble(Console.ReadLine());

            arregloVentas[dia - 1] = arregloVentas[dia - 1] - restaventa;
        }
        public void MayorVenta()
        {
            int dia = 0;
            double mayorventa = 0;
            for(int i = 0; i < arregloVentas.Length; i++)
            {
                if (arregloVentas[i] > mayorventa)
                {
                    mayorventa = arregloVentas[i];
                    dia = i;
                }
            }
            Console.WriteLine("El día con mayor cantidad de ventas fue el {0} con un total de: ${1}",dias[dia],mayorventa);

        }
    }
}
