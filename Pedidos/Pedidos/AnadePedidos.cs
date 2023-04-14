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
    public partial class AnadePedidos : Form
    {
        admPedido admP;
        admRepartidor admR;
        private string nombre;
        public AnadePedidos(admPedido admPedido,admRepartidor admRepartidor)
        {
            admP = admPedido;
            admR = admRepartidor;
            InitializeComponent();
        }

        private void lblNumPedido_Click(object sender, EventArgs e)
        {

        }

        private void AnadePedidos_Load(object sender, EventArgs e)
        {
            txtNumPedido.Text = admP.CalcularNumPedido();
            CalcularPrecios();
        }
        private void CalcularPrecios()
        {
            int numplatillos = Convert.ToInt32(numUDCantidad.Value);
            double precioplatillo = 0, iva, total, stotal, extras=CalcularExtras();
            if (rdHamburguesa.Checked == true)
            {
                precioplatillo = 85;
            }
            if (rdPizza.Checked == true)
            {
                precioplatillo = 250;
            }
            if (rdEnsalada.Checked == true)
            {
                precioplatillo = 100;
            }
            stotal = (precioplatillo + extras) * numplatillos;
            iva = stotal * .15;
            total = stotal + iva;
            txtSubTotal.Text = Convert.ToString(stotal);
            txtIva.Text = Convert.ToString(iva);
            txtTotal.Text = Convert.ToString(total);



        }
        private double CalcularExtras()
        {
            double extras = 0;
            if (checkPeperoni.Checked == true)
                extras = extras + 35;
            if (checkSalsa.Checked == true)
                extras = extras + 20;
            if (checkQueso.Checked == true)
                extras = extras + 30;
            return extras;
        }

        private void rdHamburguesa_CheckedChanged(object sender, EventArgs e)
        {
            CalcularPrecios();
        }

        private void rdPizza_CheckedChanged(object sender, EventArgs e)
        {
            CalcularPrecios();
        }

        private void rdEnsalada_CheckedChanged(object sender, EventArgs e)
        {
            CalcularPrecios();
        }

        private void checkPeperoni_CheckStateChanged(object sender, EventArgs e)
        {
            CalcularPrecios();
        }

        private void checkSalsa_CheckStateChanged(object sender, EventArgs e)
        {
            CalcularPrecios();
        }

        private void checkQueso_CheckStateChanged(object sender, EventArgs e)
        {
            CalcularPrecios();
        }

        private void numUDCantidad_ValueChanged(object sender, EventArgs e)
        {
            CalcularPrecios();
        }

        private void txtNombreC_Validated(object sender, EventArgs e)
        {
            if (!StringVacio(txtNombreC.Text))
            {
                nombre = txtNombreC.Text;
                errorPPedido.SetError(txtNombreC, null);

            }
            else
            {
                errorPPedido.SetError(txtNombreC, "Campo vacío");
                txtNombreC.Focus();
                nombre = null;
            }
        }
        private bool StringVacio(string s)
        {
            bool retorno =false;
            if (string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s))
            {
                retorno = true;
            }
            return retorno;
        }

        private void txtNombreC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsControl(e.KeyChar)) && (!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        public void Limpiar()
        {
            txtNombreC.Text = "";
            rdHamburguesa.Checked = true;
            checkQueso.Checked = false;
            checkSalsa.Checked = false;
            checkPeperoni.Checked = false;
            numUDCantidad.Value = 1;
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            string numpedido=txtNumPedido.Text;
            string platillo="";
            if (rdEnsalada.Checked)
                platillo = "Ensalada";
            if (rdHamburguesa.Checked)
                platillo = "Hamburguesa";
            if (rdPizza.Checked)
                platillo = "Pizza";
            int cantidad = Convert.ToInt32(numUDCantidad.Value);
            double stotal = Convert.ToDouble(txtSubTotal.Text);
            double iva=Convert.ToDouble(txtIva.Text);
            double total= Convert.ToDouble(txtTotal.Text);
            bool peperoni = checkPeperoni.Checked;
            bool salsa = checkSalsa.Checked;
            bool queso = checkQueso.Checked;
            if (!StringVacio(txtNombreC.Text))
            {
                nombre = txtNombreC.Text.ToUpper();
            }
            if (nombre != null)
            {
                admP.AgregarPedido(numpedido, platillo, nombre, cantidad, stotal, iva, total, peperoni, salsa, queso);
                MessageBox.Show("Pedido agregado", "Pedido agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumPedido.Text = admP.CalcularNumPedido();
                
                Limpiar();
                txtNombreC.Focus();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
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
