using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos
{
    public class Pedido
    {
        private string Platillo;
        private string NombreCliente;
        private int CantidadPlatillo;
        
        private double STotal, Iva, Total;
        private bool Peperoni, Salsa, Queso;
        private string Estado;
        private string NRepartidor;


        public Pedido (string platillo,string nombrecliente, int cantidad, double stotal, double iva, double total, bool peperoni, bool salsa, bool queso, string estado, string nrepartidor)
        {
            Platillo = platillo;
            NombreCliente = nombrecliente;
            CantidadPlatillo = cantidad;
            STotal = stotal;
            Iva = iva;
            Total = total;
            Peperoni = peperoni;
            Salsa = salsa;
            Queso = queso;
            Estado = estado;
            NRepartidor = nrepartidor;

        }
        public string pPlatillo
        {
            set
            {
                Platillo = value;
            }
            get
            {
                return Platillo;
            }
        }
        public string pNombreCliente
        {
            set
            {
                NombreCliente = value;
            }
            get
            {
                return NombreCliente;
            }
        }
        public int pCantidadPlatillo
        {
            set
            {
                CantidadPlatillo = value;
            }
            get
            {
                return CantidadPlatillo;
            }
        }
        public double pSTotal
        {
            set
            {
                STotal = value;
            }
            get
            {
                return STotal;
            }
        }
        public double pIva
        {
            set
            {
                Iva = value;
            }
            get
            {
                return Iva;
            }
        }
        public double pTotal
        {
            set
            {
                Total = value;
            }
            get
            {
                return Total;
            }
        }
        public bool pPeperoni
        {
            set
            {
                Peperoni = value;
            }
            get
            {
                return Peperoni;
            }
        }
        public bool pSalsa
        {
            set
            {
                Salsa = value;
            }
            get
            {
                return Salsa;
            }
        }
        public bool pQueso
        {
            set
            {
                Queso= value;
            }
            get
            {
                return Queso;
            }
        }
        public string pEstado
        {
            set
            {
                Estado = value;
            }
            get
            {
                return Estado;
            }
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


    }
}
