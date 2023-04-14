
namespace Pedidos
{
    partial class AnadePedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtNombreC = new System.Windows.Forms.TextBox();
            this.txtNumPedido = new System.Windows.Forms.TextBox();
            this.lblNombreC = new System.Windows.Forms.Label();
            this.lblNumPedido = new System.Windows.Forms.Label();
            this.gboxPlatillos = new System.Windows.Forms.GroupBox();
            this.rdEnsalada = new System.Windows.Forms.RadioButton();
            this.rdPizza = new System.Windows.Forms.RadioButton();
            this.rdHamburguesa = new System.Windows.Forms.RadioButton();
            this.gboxIngrExtras = new System.Windows.Forms.GroupBox();
            this.checkQueso = new System.Windows.Forms.CheckBox();
            this.checkSalsa = new System.Windows.Forms.CheckBox();
            this.checkPeperoni = new System.Windows.Forms.CheckBox();
            this.gboxTotal = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.numUDCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.errorPPedido = new System.Windows.Forms.ErrorProvider(this.components);
            this.gboxPlatillos.SuspendLayout();
            this.gboxIngrExtras.SuspendLayout();
            this.gboxTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreC
            // 
            this.txtNombreC.Location = new System.Drawing.Point(145, 12);
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.Size = new System.Drawing.Size(216, 20);
            this.txtNombreC.TabIndex = 0;
            this.txtNombreC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreC_KeyPress);
            this.txtNombreC.Validated += new System.EventHandler(this.txtNombreC_Validated);
            // 
            // txtNumPedido
            // 
            this.txtNumPedido.Location = new System.Drawing.Point(145, 38);
            this.txtNumPedido.Name = "txtNumPedido";
            this.txtNumPedido.ReadOnly = true;
            this.txtNumPedido.Size = new System.Drawing.Size(94, 20);
            this.txtNumPedido.TabIndex = 1;
            // 
            // lblNombreC
            // 
            this.lblNombreC.AutoSize = true;
            this.lblNombreC.Location = new System.Drawing.Point(43, 15);
            this.lblNombreC.Name = "lblNombreC";
            this.lblNombreC.Size = new System.Drawing.Size(96, 13);
            this.lblNombreC.TabIndex = 2;
            this.lblNombreC.Text = "Nombre del Cliente";
            // 
            // lblNumPedido
            // 
            this.lblNumPedido.AutoSize = true;
            this.lblNumPedido.Location = new System.Drawing.Point(43, 41);
            this.lblNumPedido.Name = "lblNumPedido";
            this.lblNumPedido.Size = new System.Drawing.Size(94, 13);
            this.lblNumPedido.TabIndex = 3;
            this.lblNumPedido.Text = "Numero de pedido";
            this.lblNumPedido.Click += new System.EventHandler(this.lblNumPedido_Click);
            // 
            // gboxPlatillos
            // 
            this.gboxPlatillos.Controls.Add(this.rdEnsalada);
            this.gboxPlatillos.Controls.Add(this.rdPizza);
            this.gboxPlatillos.Controls.Add(this.rdHamburguesa);
            this.gboxPlatillos.Location = new System.Drawing.Point(46, 89);
            this.gboxPlatillos.Name = "gboxPlatillos";
            this.gboxPlatillos.Size = new System.Drawing.Size(200, 112);
            this.gboxPlatillos.TabIndex = 4;
            this.gboxPlatillos.TabStop = false;
            this.gboxPlatillos.Text = "Platillos";
            // 
            // rdEnsalada
            // 
            this.rdEnsalada.AutoSize = true;
            this.rdEnsalada.Location = new System.Drawing.Point(7, 89);
            this.rdEnsalada.Name = "rdEnsalada";
            this.rdEnsalada.Size = new System.Drawing.Size(69, 17);
            this.rdEnsalada.TabIndex = 2;
            this.rdEnsalada.Text = "Ensalada";
            this.rdEnsalada.UseVisualStyleBackColor = true;
            this.rdEnsalada.CheckedChanged += new System.EventHandler(this.rdEnsalada_CheckedChanged);
            // 
            // rdPizza
            // 
            this.rdPizza.AutoSize = true;
            this.rdPizza.Location = new System.Drawing.Point(7, 54);
            this.rdPizza.Name = "rdPizza";
            this.rdPizza.Size = new System.Drawing.Size(50, 17);
            this.rdPizza.TabIndex = 1;
            this.rdPizza.Text = "Pizza";
            this.rdPizza.UseVisualStyleBackColor = true;
            this.rdPizza.CheckedChanged += new System.EventHandler(this.rdPizza_CheckedChanged);
            // 
            // rdHamburguesa
            // 
            this.rdHamburguesa.AutoSize = true;
            this.rdHamburguesa.Checked = true;
            this.rdHamburguesa.Location = new System.Drawing.Point(7, 20);
            this.rdHamburguesa.Name = "rdHamburguesa";
            this.rdHamburguesa.Size = new System.Drawing.Size(91, 17);
            this.rdHamburguesa.TabIndex = 0;
            this.rdHamburguesa.TabStop = true;
            this.rdHamburguesa.Text = "Hamburguesa";
            this.rdHamburguesa.UseVisualStyleBackColor = true;
            this.rdHamburguesa.CheckedChanged += new System.EventHandler(this.rdHamburguesa_CheckedChanged);
            // 
            // gboxIngrExtras
            // 
            this.gboxIngrExtras.Controls.Add(this.checkQueso);
            this.gboxIngrExtras.Controls.Add(this.checkSalsa);
            this.gboxIngrExtras.Controls.Add(this.checkPeperoni);
            this.gboxIngrExtras.Location = new System.Drawing.Point(252, 89);
            this.gboxIngrExtras.Name = "gboxIngrExtras";
            this.gboxIngrExtras.Size = new System.Drawing.Size(200, 112);
            this.gboxIngrExtras.TabIndex = 5;
            this.gboxIngrExtras.TabStop = false;
            this.gboxIngrExtras.Text = "Ingredientes extras";
            // 
            // checkQueso
            // 
            this.checkQueso.AutoSize = true;
            this.checkQueso.Location = new System.Drawing.Point(7, 89);
            this.checkQueso.Name = "checkQueso";
            this.checkQueso.Size = new System.Drawing.Size(57, 17);
            this.checkQueso.TabIndex = 2;
            this.checkQueso.Text = "Queso";
            this.checkQueso.UseVisualStyleBackColor = true;
            this.checkQueso.CheckStateChanged += new System.EventHandler(this.checkQueso_CheckStateChanged);
            // 
            // checkSalsa
            // 
            this.checkSalsa.AutoSize = true;
            this.checkSalsa.Location = new System.Drawing.Point(7, 54);
            this.checkSalsa.Name = "checkSalsa";
            this.checkSalsa.Size = new System.Drawing.Size(52, 17);
            this.checkSalsa.TabIndex = 1;
            this.checkSalsa.Text = "Salsa";
            this.checkSalsa.UseVisualStyleBackColor = true;
            this.checkSalsa.CheckStateChanged += new System.EventHandler(this.checkSalsa_CheckStateChanged);
            // 
            // checkPeperoni
            // 
            this.checkPeperoni.AutoSize = true;
            this.checkPeperoni.Location = new System.Drawing.Point(7, 20);
            this.checkPeperoni.Name = "checkPeperoni";
            this.checkPeperoni.Size = new System.Drawing.Size(68, 17);
            this.checkPeperoni.TabIndex = 0;
            this.checkPeperoni.Text = "Peperoni";
            this.checkPeperoni.UseVisualStyleBackColor = true;
            this.checkPeperoni.CheckStateChanged += new System.EventHandler(this.checkPeperoni_CheckStateChanged);
            // 
            // gboxTotal
            // 
            this.gboxTotal.Controls.Add(this.lblTotal);
            this.gboxTotal.Controls.Add(this.lblIva);
            this.gboxTotal.Controls.Add(this.lblSubTotal);
            this.gboxTotal.Controls.Add(this.txtTotal);
            this.gboxTotal.Controls.Add(this.txtIva);
            this.gboxTotal.Controls.Add(this.txtSubTotal);
            this.gboxTotal.Location = new System.Drawing.Point(46, 225);
            this.gboxTotal.Name = "gboxTotal";
            this.gboxTotal.Size = new System.Drawing.Size(236, 138);
            this.gboxTotal.TabIndex = 6;
            this.gboxTotal.TabStop = false;
            this.gboxTotal.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(56, 92);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Location = new System.Drawing.Point(56, 66);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(22, 13);
            this.lblIva.TabIndex = 4;
            this.lblIva.Text = "Iva";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(56, 40);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubTotal.TabIndex = 3;
            this.lblSubTotal.Text = "Sub total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(125, 89);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 2;
            // 
            // txtIva
            // 
            this.txtIva.Location = new System.Drawing.Point(125, 63);
            this.txtIva.Name = "txtIva";
            this.txtIva.ReadOnly = true;
            this.txtIva.Size = new System.Drawing.Size(100, 20);
            this.txtIva.TabIndex = 1;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(125, 37);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubTotal.TabIndex = 0;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(288, 255);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 7;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(288, 286);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(288, 320);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 9;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(377, 286);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // numUDCantidad
            // 
            this.numUDCantidad.Location = new System.Drawing.Point(145, 65);
            this.numUDCantidad.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numUDCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDCantidad.Name = "numUDCantidad";
            this.numUDCantidad.ReadOnly = true;
            this.numUDCantidad.Size = new System.Drawing.Size(94, 20);
            this.numUDCantidad.TabIndex = 11;
            this.numUDCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDCantidad.ValueChanged += new System.EventHandler(this.numUDCantidad_ValueChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(38, 67);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(101, 13);
            this.lblCantidad.TabIndex = 12;
            this.lblCantidad.Text = "Cantidad de platillos";
            // 
            // errorPPedido
            // 
            this.errorPPedido.ContainerControl = this;
            // 
            // AnadePedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 393);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.numUDCantidad);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.gboxTotal);
            this.Controls.Add(this.gboxIngrExtras);
            this.Controls.Add(this.gboxPlatillos);
            this.Controls.Add(this.lblNumPedido);
            this.Controls.Add(this.lblNombreC);
            this.Controls.Add(this.txtNumPedido);
            this.Controls.Add(this.txtNombreC);
            this.Name = "AnadePedidos";
            this.Text = "Añadir pedidos";
            this.Load += new System.EventHandler(this.AnadePedidos_Load);
            this.gboxPlatillos.ResumeLayout(false);
            this.gboxPlatillos.PerformLayout();
            this.gboxIngrExtras.ResumeLayout(false);
            this.gboxIngrExtras.PerformLayout();
            this.gboxTotal.ResumeLayout(false);
            this.gboxTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreC;
        private System.Windows.Forms.TextBox txtNumPedido;
        private System.Windows.Forms.Label lblNombreC;
        private System.Windows.Forms.Label lblNumPedido;
        private System.Windows.Forms.GroupBox gboxPlatillos;
        private System.Windows.Forms.RadioButton rdEnsalada;
        private System.Windows.Forms.RadioButton rdPizza;
        private System.Windows.Forms.RadioButton rdHamburguesa;
        private System.Windows.Forms.GroupBox gboxIngrExtras;
        private System.Windows.Forms.CheckBox checkQueso;
        private System.Windows.Forms.CheckBox checkSalsa;
        private System.Windows.Forms.CheckBox checkPeperoni;
        private System.Windows.Forms.GroupBox gboxTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.NumericUpDown numUDCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ErrorProvider errorPPedido;
    }
}