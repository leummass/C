using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela
{
    class AdministraAlumno
    {
        private Alumno[] alumnos = new Alumno[30];
        private int cuentaAlumnos=0;




        public bool InscribeAlumno(string nombre, string correo, string carrera)
        {
            bool retorno = false;
            if(cuentaAlumnos < 30)
            {
                alumnos[cuentaAlumnos]= new Alumno(nombre,  correo, carrera);
                cuentaAlumnos++;
                retorno = true;
            }
            return retorno;
        }
        public string[] RegresaAlumnos()
        {
            string[] stringAux = new string[cuentaAlumnos];
            for ( int i = 0; i < cuentaAlumnos; i++)
            {
                stringAux[i] = alumnos[i].ToString();
            }
            return stringAux;
        }
        public bool ExisteNumControl(int numControl)
        {
            bool encontro = false;
            for (int i = 0; i < cuentaAlumnos; i++)
            {
                if (alumnos[i].pNumcontrol == numControl)
                {
                    encontro = true;
                }
            }
            return encontro;
        }
        public Alumno RegresaAlumnoxNum(int numcontrol)
        {
            Alumno alum = null;
            for (int i = 0; i < cuentaAlumnos; i++)
            {
                if (alumnos[i].pNumcontrol == numcontrol)
                {
                    alum = alumnos[i];
                    break;
                }
            }

            return alum;
        }

        public void CambiaNombre(int numC, string nvoNombre)
        {
            for (int i = 0; i < cuentaAlumnos; i++)
            {
                if (alumnos[i].pNumcontrol == numC)
                {
                    alumnos[i].pNombre = nvoNombre;
                }
            }
        }
        public void CambiaCorreo(int numC, string nvCorreo)
        {
            for (int i = 0; i < cuentaAlumnos; i++)
            {
                if (alumnos[i].pNumcontrol == numC)
                {
                    alumnos[i].pCorreo = nvCorreo;
                }
            }
        }
        public void CambiaCarrera(int numC, string nvCarrera)
        {
            for (int i = 0; i < cuentaAlumnos; i++)
            {
                if (alumnos[i].pNumcontrol == numC)
                {
                    alumnos[i].pCarrera = nvCarrera;
                }
            }
        }
        public string[] alumnoscarrera (string carrera)
        {
            int contador = 0, contador2 = 0; ;
            for(int i = 0; i < cuentaAlumnos; i++)
            {
                if (alumnos[i].pCarrera == carrera)
                    contador++;
            }
            string[] alumnoscarrera = new string[contador];
            for(int i = 0; i < cuentaAlumnos; i++)
            {
                if (alumnos[i].pCarrera == carrera)
                {
                    alumnoscarrera[contador2] = alumnos[i].ToString();
                    contador2++;
                }
            }
            return alumnoscarrera;
        }
        public bool existecarrera(string carrera)
        {
            bool retorno = false;
            for (int i = 0; i < cuentaAlumnos; i++)
            {
                if (alumnos[i].pCarrera == carrera)
                {
                    retorno = true;
                    return retorno;
                    
                }
            }
            return retorno;
        }
    }
}
