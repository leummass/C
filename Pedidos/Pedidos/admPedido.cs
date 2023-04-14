using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos
{
    public class admPedido
    {
        private Dictionary<string, Pedido> Pedidos = new Dictionary<string, Pedido>();
        private int nconsecutivo = 1;
        public string CalcularNumPedido()
        {
            string numpedido = "P00" + Convert.ToString(nconsecutivo);
            return numpedido;
        }

        public void AgregarPedido(string numpedido,string platillo, string nombrecliente, int cantidad, double stotal, double iva, double total, bool peperoni, bool salsa, bool queso)
        {
            Pedidos.Add(numpedido, new Pedido(platillo, nombrecliente, cantidad, stotal, iva, total, peperoni, salsa, queso, "Activo","Por asignar"));
            nconsecutivo++;
        }
        public Pedido GetPedido(string numpedido)
        {
            Pedido pedido=null;
            pedido = Pedidos[numpedido];
            return pedido;
        }
        public string[] GetNumsPedido()
        {
            string[] numspedido = new string[Pedidos.Count];
            Dictionary<string, Pedido>.KeyCollection keyColl = Pedidos.Keys;
            int j = 0;
            foreach (string key in keyColl)
            {
                
                
                    numspedido[j] = key;
                    j++;
                
            }
            return numspedido;
        }
        public string[] GetNumsPedidoActivo()
        {
            string[] activos;
            int i = 0;
            Dictionary<string, Pedido>.KeyCollection keyColl = Pedidos.Keys;
            foreach(string key in keyColl)
            {
                if (Pedidos[key].pEstado == "Activo")
                {
                    i++;
                }
            }
            activos = new string[i];
            int j = 0;
            foreach (string key in keyColl)
            {
                if (Pedidos[key].pEstado == "Activo")
                {
                    activos[j] = key;
                    j++;
                }
            }
            return activos;
        }
        public string[] GetNumsPedidoPorEntregar()
        {
            string[] activos;
            int i = 0;
            Dictionary<string, Pedido>.KeyCollection keyColl = Pedidos.Keys;
            foreach (string key in keyColl)
            {
                if (Pedidos[key].pEstado == "Por entregar")
                {
                    i++;
                }
            }
            activos = new string[i];
            int j = 0;
            foreach (string key in keyColl)
            {
                if (Pedidos[key].pEstado == "Por entregar")
                {
                    activos[j] = key;
                    j++;
                }
            }
            return activos;
        }
        public string[] GetNumsPedidoEntregado()
        {
            string[] activos;
            int i = 0;
            Dictionary<string, Pedido>.KeyCollection keyColl = Pedidos.Keys;
            foreach (string key in keyColl)
            {
                if (Pedidos[key].pEstado == "Entregado")
                {
                    i++;
                }
            }
            activos = new string[i];
            int j = 0;
            foreach (string key in keyColl)
            {
                if (Pedidos[key].pEstado == "Entregado")
                {
                    activos[j] = key;
                    j++;
                }
            }
            return activos;
        }
    }
}
