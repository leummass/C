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
    public partial class ConsultaIndRepartidores : Form
    {
        admRepartidor admR;
        public ConsultaIndRepartidores(admRepartidor admR)
        {
            this.admR = admR;
            InitializeComponent();
        }

        private void cmbNR_SelectedIndexChanged(object sender, EventArgs e)
        {
            string numrepartidor = cmbRepartidor.SelectedItem.ToString();
            Repartidor repartidor = admR.GetRepartidor(numrepartidor);
            txtNombre.Text = repartidor.pNombre;
            txtNLic.Text = repartidor.pNLic;
            txtEdad.Text = repartidor.pEdad.ToString();
            txtDescV.Text = repartidor.pDescV;
            string estado;
            if (repartidor.pActivo == true)
            {
                estado = "Activo";
            }
            else
            {
                estado = "Ocupado";
            }
            txtEstado.Text = estado;
        }

        private void ConsultaIndRepartidores_Load(object sender, EventArgs e)
        {
            Repartidor[] repartidores = admR.GetNumsRepartidor();
            if (repartidores == null || repartidores.Length == 0)
            {
                MessageBox.Show("No hay repartidores disponibles/ no hay repartidores registrados", "Mensaje repartidores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                txtNombre.Text = "";
                txtDescV.Text = "";
                txtNLic.Text = "";
                txtEdad.Text = "";
                txtEstado.Text = "";
            }
            else
            {
                foreach (Repartidor r in repartidores)
                {
                    cmbRepartidor.Items.Add(r.pNRepartidor);

                }
                cmbRepartidor.SelectedIndex = 0;
                
            }
            
        }
    }
}

