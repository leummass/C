using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela
{
    class Program
    {
        static void Main(string[] args)
        {
            AdministraAlumno administra = new AdministraAlumno();
            CapaPresentacionAlumnos presenta = new CapaPresentacionAlumnos(administra);
            presenta.Menu();

            //Menu
            Console.ReadKey();

        }
    }
}
