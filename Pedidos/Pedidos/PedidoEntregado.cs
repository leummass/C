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
    public partial class PedidoEntregado : Form
    {
        admPedido admP;
        admRepartidor admR;
        public PedidoEntregado(admRepartidor admR,admPedido admP)
        {
            this.admP = admP;
            this.admR = admR;
            InitializeComponent();
        }

        private void cmbPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string numpedido = cmbPedidos.SelectedItem.ToString();
            Pedido pedido = admP.GetPedido(numpedido);
            txtNombreC.Text = pedido.pNombreCliente;
            txtPlatillo.Text = pedido.pPlatillo;
            txtCantidad.Text = pedido.pCantidadPlatillo.ToString();
            checkPeperoni.Checked = pedido.pPeperoni;
            checkQueso.Checked = pedido.pQueso;
            checkSalsa.Checked = pedido.pSalsa;
            txtSubTotal.Text = pedido.pSTotal.ToString();
            txtIva.Text = pedido.pIva.ToString();
            txtTotal.Text = pedido.pTotal.ToString();
            txtNR.Text = pedido.pNRepartidor.ToString();
            txtNombreRep.Text = admR.GetNombreConNR(pedido.pNRepartidor);
        }

        private void PedidoEntregado_Load(object sender, EventArgs e)
        {
            Loadcmb();
        }
        private void Loadcmb()
        {
            cmbPedidos.Items.Clear();
            
            string[] arregloNumPed = admP.GetNumsPedidoPorEntregar();
            


            if (arregloNumPed == null || arregloNumPed.Length == 0)
            {
                MessageBox.Show("No hay pedidos por entregar/ no hay pedidos registrados", "Mensaje pedidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCantidad.Text = "";
                txtNombreC.Text = "";
                txtPlatillo.Text = "";
                txtSubTotal.Text = "";
                txtIva.Text = "";
                txtTotal.Text = "";
                txtNR.Text = "";
                txtNombreRep.Text = "";
                checkPeperoni.Checked = false;
                checkQueso.Checked = false;
                checkSalsa.Checked = false;
                btnEntregado.Enabled = false;
            }
            else
            {
                foreach (string numped in arregloNumPed)
                {
                    cmbPedidos.Items.Add(numped);
                }
                cmbPedidos.SelectedIndex = 0;
                btnEntregado.Enabled = true;
            }
        }

        private void btnEntregado_Click(object sender, EventArgs e)
        {
            string numpedido = cmbPedidos.SelectedItem.ToString();
            Pedido pedido = admP.GetPedido(numpedido);
            string numrepartidor = txtNR.Text;
            Repartidor repartidor = admR.GetRepartidor(numrepartidor);
            
            pedido.pEstado = "Entregado";
            repartidor.pActivo = true;
            Loadcmb();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultaPedidos CP = new ConsultaPedidos(admP, admR);
            CP.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
