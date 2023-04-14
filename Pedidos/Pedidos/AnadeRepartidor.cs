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
    public partial class AnadeRepartidor : Form
    {
        private string nombre, DescV, NLic;
        private int edad;
        admRepartidor admR;
        public AnadeRepartidor(admRepartidor admRepartidor)
        {
            admR = admRepartidor;
            InitializeComponent();
        }

        private void AnadeRepartidor_Load(object sender, EventArgs e)
        {
            txtNumRep.Text = admR.CalcularNumRepartidor();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (!StringVacio(txtNombreRep.Text))
            {
                nombre = txtNombreRep.Text.ToUpper();
                txtDescV.Focus();
                errorPRepartidor.SetError(txtDescV, "Campo vacío");
            }
            if (!StringVacio(txtDescV.Text))
            {
                DescV = txtDescV.Text;
                txtLic.Focus();
                errorPRepartidor.SetError(txtLic, "Campo vacío");
            }
            if (!StringVacio(txtLic.Text))
            {
                NLic = txtLic.Text.ToUpper(); ;
            }
            edad = Convert.ToInt32(numUDEdadRep.Value);
            string NRepartidor = txtNumRep.Text;
            if(nombre!=null && DescV!=null && NLic != null)
            {
                admR.AgregarRepartidor(NRepartidor, nombre, DescV, edad, NLic);
                txtNumRep.Text = admR.CalcularNumRepartidor();
                txtNombreRep.Focus();
                Limpiar();
                MessageBox.Show("Repartidor agregado", "Repartidor agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nombre = null;
                DescV = null;
                NLic = null;
                edad = 0;
                
            }

        }
        private void Limpiar()
        {
            txtNombreRep.Text = "";
            txtLic.Text = "";
            txtDescV.Text = "";
            numUDEdadRep.Value = 18;
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            if (!StringVacio(txtDescV.Text))
            {
                DescV = txtDescV.Text;
                errorPRepartidor.SetError(txtDescV, null);

            }
            else
            {
                errorPRepartidor.SetError(txtDescV, "Campo vacío");
                txtDescV.Focus();
                DescV = null;
            }
        }

        private void txtLic_Validated(object sender, EventArgs e)
        {
            if (!StringVacio(txtLic.Text))
            {
                NLic = txtNombreRep.Text;
                errorPRepartidor.SetError(txtLic, null);

            }
            else
            {
                errorPRepartidor.SetError(txtLic, "Campo vacío");
                txtLic.Focus();
                NLic = null;
            }
        }

        private void txtNombreRep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsControl(e.KeyChar)) && (!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtDescV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsControl(e.KeyChar)) && (!char.IsLetterOrDigit(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtLic_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsControl(e.KeyChar)) && (!char.IsLetterOrDigit(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultarRepartidores CR = new ConsultarRepartidores(admR);
            CR.ShowDialog();
        }

        private bool StringVacio(string s)
        {
            bool retorno = false;
            if (string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s))
            {
                retorno = true;
            }
            return retorno;
        }

        private void txtNombreRep_Validated(object sender, EventArgs e)
        {
            if (!StringVacio(txtNombreRep.Text))
            {
                nombre = txtNombreRep.Text;
                errorPRepartidor.SetError(txtNombreRep, null);

            }
            else
            {
                errorPRepartidor.SetError(txtNombreRep, "Campo vacío");
                txtNombreRep.Focus();
                nombre = null;
            }
        }
    }
}
