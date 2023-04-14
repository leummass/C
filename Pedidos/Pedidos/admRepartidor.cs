using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos
{
    public class admRepartidor
    {
        private List<Repartidor> Repartidores = new List<Repartidor>();
        private int numconsecutivo = 1;

        public string CalcularNumRepartidor()
        {
            string numrepartidor = "REP00" + Convert.ToString(numconsecutivo);
            return numrepartidor;
        }
        public void AgregarRepartidor(string NRepartidor, string Nombre, string DescV, int edad, string NLic)
        {
            Repartidores.Add(new Repartidor(NRepartidor, Nombre, DescV, edad, NLic, true));
            numconsecutivo++;
        }
        public Repartidor GetRepartidor(string numrep)
        {
            Repartidor repartidor = null;
            foreach (Repartidor r in Repartidores)
            {
                if (r.pNRepartidor == numrep)
                    repartidor = r;
            }
            return repartidor;
        }
        public Repartidor[] GetNumsRepartidoractivo()
        {
            Repartidor[] numsrepartidoractivo;
            int i = 0;
            foreach (Repartidor r in Repartidores)
            {
                if (r.pActivo == true)
                    i++;
            }
            numsrepartidoractivo = new Repartidor[i];
            int j = 0;
            foreach (Repartidor r in Repartidores)
            {
                if (r.pActivo == true)
                {
                    numsrepartidoractivo[j] = r;
                    j++;
                }
            }
            return numsrepartidoractivo;
        }
        public Repartidor[] GetNumsRepartidorocupado()
        {
            Repartidor[] numsrepartidorocupado;
            int i = 0;
            foreach (Repartidor r in Repartidores)
            {
                if (r.pActivo == false)
                    i++;
            }
            numsrepartidorocupado = new Repartidor[i];
            int j = 0;
            foreach (Repartidor r in Repartidores)
            {
                if (r.pActivo == false)
                {
                    numsrepartidorocupado[j] = r;
                    j++;
                }
            }
            return numsrepartidorocupado;
        }
        public Repartidor[] GetNumsRepartidor()
        {
            Repartidor[] numsrepartidor= new Repartidor[Repartidores.Count];
            int i = 0;
            foreach (Repartidor r in Repartidores)
            {
                numsrepartidor[i] = r;
                i++;
            }
            
            return numsrepartidor;
        }
        public string GetNombreConNR(string numrep)
        {
            string nombre = "";
            foreach(Repartidor r in Repartidores)
            {
                if (r.pNRepartidor == numrep)
                    nombre = r.pNombre;
            }
            return nombre;
        }
        public string GetNRConNombre(string nombre)
        {
            string nr = "";
            foreach (Repartidor r in Repartidores)
            {
                if (r.pNombre==nombre)
                    nr = r.pNRepartidor;
            }
            return nr;
        }
    }
}
