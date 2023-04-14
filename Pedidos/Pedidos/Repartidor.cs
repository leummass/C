using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos
{
    public class Repartidor
    {
        private string NRepartidor, Nombre, DescV;
        private int edad;
        private string NLic;
        private bool activo;

        public Repartidor(string NRepartidor, string Nombre, string DescV, int edad, string NLic, bool activo)
        {
            this.NRepartidor = NRepartidor;
            this.Nombre = Nombre;
            this.DescV = DescV;
            this.edad = edad;
            this.NLic = NLic;
            this.activo = activo;
        }

        public string pNRepartidor
        {
            set
            {
                NRepartidor = value;
            }
            get
            {
                return NRepartidor;
            }
        }
        public string pNombre
        {
            set
            {
                Nombre = value;
            }
            get
            {
                return Nombre;
            }
        }
        public string pDescV
        {
            set
            {
                DescV = value;
            }
            get
            {
                return DescV;
            }
        }
        public int pEdad
        {
            set
            {
                edad = value;
            }
            get
            {
                return edad;
            }
        }
        public string pNLic
        {
            set
            {
                NLic = value;
            }
            get
            {
                return NLic;
            }
        }
        public bool pActivo
        {
            set
            {
                activo = value;
            }
            get
            {
                return activo;
            }
        }
    }
}
