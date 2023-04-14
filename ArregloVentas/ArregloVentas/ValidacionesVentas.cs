using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArregloVentas
{
    class ValidacionesVentas
    {
        public static int ValidaDia(int dia)
        {
            int retorno = -1;
            if((dia>=1) && (dia <= 7)){
                retorno = dia + retorno;
            }

            return retorno;
        }
        public static string Dia(int dia) {
            if ((dia >= 1) && (dia <= 7))
            {
                switch (dia)
                {
                    case 1: return "Lunes"; break;
                    case 2: return "Martes"; break;
                    case 3: return "Miercoles"; break;
                    case 4: return "Jueves"; break;
                    case 5: return "Viernes"; break;
                    case 6: return "Sabado"; break;
                    case 7: return "Domingo"; break;
                }
            }
            return "";
        }

    }
}
