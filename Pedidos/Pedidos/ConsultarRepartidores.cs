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
    public partial class ConsultarRepartidores : Form
    {
        admRepartidor admR;
        public ConsultarRepartidores(admRepartidor admR)
        {
            this.admR = admR;
            InitializeComponent();
        }

        private void cmbRepartidores_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvRepartidores.Rows.Clear();
            string cmbestado = cmbRepartidores.SelectedItem.ToString();
            Repartidor[] repartidores = null;
            switch (cmbestado)
            {
                case "Todos": repartidores = admR.GetNumsRepartidor(); break;
                case "Activos": repartidores = admR.GetNumsRepartidoractivo(); break;
                case "Ocupados": repartidores = admR.GetNumsRepartidorocupado(); break;
                
                default: break;
            }


            if (repartidores == null || repartidores.Length == 0)
            {
                MessageBox.Show("No hay repartidores en este estado", "No se encontraron pedidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (Repartidor rp in repartidores)
                {
                    string estado = "";
                    if (rp.pActivo)
                        estado = "Activo";
                    else
                        estado = "Ocupado";
                    dgvRepartidores.Rows.Add(rp.pNRepartidor,rp.pNombre,rp.pDescV,rp.pNLic,rp.pEdad,estado);
                }
            }
        }
    }
}
