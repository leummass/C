using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedidos
{
    public partial class ConsultaPedidos : Form
    {
        admPedido admP;
        admRepartidor admR;
        public ConsultaPedidos(admPedido admP, admRepartidor admR)
        {
            this.admP = admP;
            this.admR = admR;
            InitializeComponent();
        }

        private void cmbPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            dgvPedidos.Rows.Clear();
            string cmbestado = cmbPedidos.SelectedItem.ToString();
            string[] numspedido=null;
            switch (cmbestado)
            {
                case "Activo": numspedido = admP.GetNumsPedidoActivo();break;
                case "Por entregar": numspedido = admP.GetNumsPedidoPorEntregar(); break;
                case "Entregado": numspedido = admP.GetNumsPedidoEntregado(); break;
                case "Todos": numspedido = admP.GetNumsPedido();break;
                default:break;
            }


            if (numspedido == null || numspedido.Length == 0)
            {
                MessageBox.Show("No hay pedidos en este estado", "No se encontraron pedidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (string np in numspedido)
                {
                    Pedido pedido = admP.GetPedido(np);
                    dgvPedidos.Rows.Add(np, pedido.pNombreCliente, pedido.pPlatillo, pedido.pCantidadPlatillo, pedido.pPeperoni, pedido.pSalsa, pedido.pQueso,"$"+pedido.pSTotal, "$" + pedido.pIva, "$" + pedido.pTotal, pedido.pNRepartidor, admR.GetNombreConNR(pedido.pNRepartidor), pedido.pEstado);
                }
            }
            

            
        }
    }
}
