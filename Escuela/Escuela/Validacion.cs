using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela
{
    class Validacion
    {
        public bool StringVacio(string s)
        {
            bool retorno =false;
            if (s=="")
            {
                retorno= true;
            }
            else
            {
                retorno =false; ;
            }
            return retorno;
        }
        public bool ValidarNum(int n)
        {
            bool retorno = false;
            if((n>=1000 && n <= 1030))
            {
                retorno = true;
            }
            return retorno;
        }


    }
}
