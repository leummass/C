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
    

    public partial class MenuPrincipal : Form
    {
        admPedido admP = new admPedido();
        admRepartidor admR = new admRepartidor();
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void agregarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnadePedidos AP = new AnadePedidos(admP,admR);
            AP.ShowDialog();
        }

        private void asignarRepartidorAPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignarPAR APAR = new AsignarPAR(admP, admR);
            APAR.ShowDialog();
        }

        private void agregarRepartidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnadeRepartidor AR = new AnadeRepartidor(admR);
            AR.ShowDialog();
        }

        private void consultarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaPedidos CP = new ConsultaPedidos(admP, admR);
            CP.ShowDialog();
        }

        private void consultarRepartidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cambiarPedidoAEntregadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PedidoEntregado PE = new PedidoEntregado(admR, admP);
            PE.ShowDialog();
        }

        private void consultaGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarRepartidores CR = new ConsultarRepartidores(admR);
            CR.ShowDialog();
        }

        private void consultaIndividualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaIndRepartidores CIR = new ConsultaIndRepartidores(admR);
            CIR.ShowDialog();
        }
    }
}
