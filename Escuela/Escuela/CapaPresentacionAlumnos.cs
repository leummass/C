using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela
{
    class CapaPresentacionAlumnos
    {
        AdministraAlumno administraAlumno;
        Validacion validacion1 = new Validacion();
        public CapaPresentacionAlumnos(AdministraAlumno admA)
        {
            administraAlumno = admA;
        }
        public void AgregaAlumno()
        {
            Console.WriteLine("Registro de alumnos");
            Console.WriteLine("Nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Carrera: ");
            string carrera = Console.ReadLine();
            Console.WriteLine("Correo: ");
            string correo = Console.ReadLine();
            bool inscripcion=administraAlumno.InscribeAlumno(nombre, correo, carrera);
            if (inscripcion)
            {
                Console.WriteLine("Se agrego alumno");
            }
            else
            {
                Console.WriteLine("No se pudo agregar alumno");
            }
            
        }
        public void CambiarNombreA()
        {
            string nombre="";
            int numControl = 0;
            Console.WriteLine("Cambiar nombre del alumno");
            do
            {
                Console.WriteLine("Numero de control: ");
                numControl = Convert.ToInt32(Console.ReadLine());
                if (!validacion1.ValidarNum(numControl))
                {
                    Console.WriteLine("Teclee un numero de control valido");
                }
            } while (!validacion1.ValidarNum(numControl));
            if (administraAlumno.ExisteNumControl(numControl))
            {
                Alumno alumno = administraAlumno.RegresaAlumnoxNum(numControl);
                Console.Write("Alumno encontrado: ");
                Console.WriteLine(alumno);
                do
                {
                    Console.WriteLine("Nombre: ");
                    nombre = Console.ReadLine();

                    if (validacion1.StringVacio(nombre))
                    {
                        Console.WriteLine("No se puede poner un nombre vacío");
                    }
                    else
                    {

                        administraAlumno.CambiaNombre(numControl, nombre);
                        alumno = administraAlumno.RegresaAlumnoxNum(numControl);
                        Console.Write("Cambio realizado: ");
                        Console.WriteLine(alumno);
                    }
                } while (validacion1.StringVacio(nombre));
            }
            else
            {
                Console.WriteLine("No existe el alumno");
            }
            

        }
        public void CambiarCorreoA()
        {
            string correo = "";
            int numControl = 0;
            Console.WriteLine("Cambiar correo del alumno");
            do
            {
                Console.WriteLine("Numero de control: ");
                numControl = Convert.ToInt32(Console.ReadLine());
                if (!validacion1.ValidarNum(numControl))
                {
                    Console.WriteLine("Teclee un numero de control valido");
                }
            } while (!validacion1.ValidarNum(numControl));
            if (administraAlumno.ExisteNumControl(numControl))
            {
                Alumno alumno = administraAlumno.RegresaAlumnoxNum(numControl);
                Console.Write("Alumno encontrado: ");
                Console.WriteLine(alumno);
                do
                {
                    Console.WriteLine("Correo: ");
                    correo = Console.ReadLine();

                    if (validacion1.StringVacio(correo)==true)
                    {
                        Console.WriteLine("No se puede poner un correo vacío");
                    }
                    else
                    {

                        administraAlumno.CambiaCorreo(numControl, correo);
                        alumno = administraAlumno.RegresaAlumnoxNum(numControl);
                        Console.Write("Cambio realizado: ");
                        Console.WriteLine(alumno);
                    }
                } while (validacion1.StringVacio(correo));
            }
            else
            {
                Console.WriteLine("No existe el alumno");
            }
            

        }
        public void CambiarCarreraA()
        {
            string carrera = "";
            int numControl = 0;
            Console.WriteLine("Cambiar carrera del alumno");
            do
            {
                Console.WriteLine("Numero de control: ");
                numControl = Convert.ToInt32(Console.ReadLine());
                if (!validacion1.ValidarNum(numControl))
                {
                    Console.WriteLine("Teclee un numero de control valido");
                }
            } while (!validacion1.ValidarNum(numControl));
            if (administraAlumno.ExisteNumControl(numControl))
            {
                Alumno alumno = administraAlumno.RegresaAlumnoxNum(numControl);
                Console.Write("Alumno encontrado: ");
                Console.WriteLine(alumno);
                do
                {
                    Console.WriteLine("Carrera: ");
                    carrera = Console.ReadLine();

                    if (validacion1.StringVacio(carrera))
                    {
                        Console.WriteLine("No se puede poner un nombre vacío");
                    }
                    else
                    {

                        administraAlumno.CambiaCarrera(numControl, carrera);
                        alumno = administraAlumno.RegresaAlumnoxNum(numControl);
                        Console.Write("Cambio realizado: ");
                        Console.WriteLine(alumno);
                    }
                } while (validacion1.StringVacio(carrera));
            }
            else
            {
                Console.WriteLine("No existe el alumno");
            }
            

        }
        public void AlumnosInscritos()
        {
            string[] ArregloAlum=administraAlumno.RegresaAlumnos();
            foreach(string s in ArregloAlum)
            {
                Console.WriteLine(s);
            }
            
        }
        public void AlumnosCarrera()
        {
            string carrera;
            string[] aux;
            do
            {
                Console.Write("Nombre de carrera: ");
                carrera = Console.ReadLine();
                if (validacion1.StringVacio(carrera))
                {
                    Console.WriteLine("Nombre de carrera vacio/no existe carrera");
                }
                else { 
                    if (administraAlumno.existecarrera(carrera))
                     {
                        aux = administraAlumno.alumnoscarrera(carrera);
                        for (int i = 0; i < aux.Length; i++)
                        {
                            Console.WriteLine(aux[i].ToString());
                        }
                    }
                    else
                    {
                        Console.WriteLine("No existe carrera/alumno con esa carrera");
                    }
                }
            } while (validacion1.StringVacio(carrera));
            
            
        }
        public void Menu()
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("Seleccione una opcion");
                Console.WriteLine("1. Agregar alumno");
                Console.WriteLine("2. Mostrar todos los alumnos inscritos");
                Console.WriteLine("3. Mostrar alumnos de una sola carrera");
                Console.WriteLine("4. Cambiar nombre de alumno");
                Console.WriteLine("5. Cambiar correo de alumno");
                Console.WriteLine("6. Cambiar carrera de alumno");
                Console.Write("Opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1: AgregaAlumno();break;
                    case 2: AlumnosInscritos();break;
                    case 3: AlumnosCarrera();break;
                    case 4: CambiarNombreA();break;
                    case 5: CambiarCorreoA();break;
                    case 6: CambiarCarreraA();break;
                    case 0: break;
                    default:break;

                }
                


            } while (opcion != 0);
            
        }
        


    }
}
