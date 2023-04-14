using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela
{
    class Alumno
    {
        private int numcontrol;
        private string nombre;
        private string correo;
        private string carrera;
        public static int CuentaNControl=1000;
        public Alumno(string nombre, string correo,string carrera)
        {
            numcontrol = CuentaNControl;
            this.nombre = nombre;
            this.correo = correo;
            this.carrera = carrera;
            CuentaNControl++;
        }

        public int pNumcontrol
        {
            get
            {
                return numcontrol;
            }
        }
        public string pNombre
        {
            get {
                return nombre;

            }
            set
            {
                nombre = value;
            }
        }
        public string pCarrera
        {
            get
            {
                return carrera;

            }
            set
            {
                carrera = value;
            }
        }
        public string pCorreo
        {
            get
            {
                return correo;

            }
            set
            {
                correo = value;
            }
        }
        override
        public string ToString()
        {
            return "Nombre del alumno: " + nombre + " Carrera del alumno: " + carrera + " Numero de control: " + numcontrol + " Correo: " + correo;
        }
    }
}
