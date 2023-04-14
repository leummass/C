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
    public partial class AsignarPAR : Form
    {
        admPedido admP;
        admRepartidor admR;
        public AsignarPAR(admPedido admPedido,admRepartidor admRepartidor)
        {
            admP = admPedido;
            admR = admRepartidor;
            InitializeComponent();
        }

        private void AsignarPAR_Load(object sender, EventArgs e)
        {
            Loadcmbs();
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
        }

        private void cmbRepartidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string numrepartidor = admR.GetNRConNombre(cmbRepartidor.SelectedItem.ToString());
            Repartidor repartidor = admR.GetRepartidor(numrepartidor);
            txtNR.Text = repartidor.pNRepartidor;
            txtNLic.Text = repartidor.pNLic;
            txtEdad.Text = repartidor.pEdad.ToString();
            txtDescV.Text = repartidor.pDescV;
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            string numpedido = cmbPedidos.SelectedItem.ToString();
            Pedido pedido = admP.GetPedido(numpedido);
            string numrepartidor = txtNR.Text;
            Repartidor repartidor = admR.GetRepartidor(numrepartidor);
            pedido.pNRepartidor = numrepartidor;
            pedido.pEstado = "Por entregar";
            repartidor.pActivo = false;
            Loadcmbs();
        }
        private void Loadcmbs()
        {
            cmbPedidos.Items.Clear();
            cmbRepartidor.Items.Clear();
            string[] arregloNumPed = admP.GetNumsPedidoActivo();
            Repartidor[] repartidoresactv = admR.GetNumsRepartidoractivo();
            
            
            if (arregloNumPed == null || arregloNumPed.Length == 0)
            {
                MessageBox.Show("No hay pedidos por entregar/ no hay pedidos registrados", "Mensaje pedidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCantidad.Text = "";
                txtNombreC.Text = "";
                txtPlatillo.Text = "";
                txtSubTotal.Text = "";
                txtIva.Text = "";
                txtTotal.Text = "";
                checkPeperoni.Checked = false;
                checkQueso.Checked = false;
                checkSalsa.Checked = false;
                btnAsignar.Enabled = false;
            }
            else
            {
                foreach (string numped in arregloNumPed)
                {
                    cmbPedidos.Items.Add(numped);
                }
                cmbPedidos.SelectedIndex = 0;
                btnAsignar.Enabled = true;
            }
            if (repartidoresactv == null || repartidoresactv.Length == 0)
            {
                MessageBox.Show("No hay repartidores disponibles/ no hay repartidores registrados", "Mensaje repartidores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnAsignar.Enabled = false;
                txtNR.Text = "";
                txtDescV.Text = "";
                txtNLic.Text = "";
                txtEdad.Text = "";
            }
            else
            {
                foreach (Repartidor r in repartidoresactv)
                {
                    cmbRepartidor.Items.Add(r.pNombre);
                    
                }
                cmbRepartidor.SelectedIndex = 0;
                btnAsignar.Enabled = true;
            }
            if((arregloNumPed == null || arregloNumPed.Length == 0) || (repartidoresactv == null || repartidoresactv.Length == 0))
            {
                btnAsignar.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
