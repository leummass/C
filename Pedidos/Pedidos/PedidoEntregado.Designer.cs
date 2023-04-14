
namespace Pedidos
{
    partial class PedidoEntregado
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
            this.gboxDatosP = new System.Windows.Forms.GroupBox();
            this.txtNR = new System.Windows.Forms.TextBox();
            this.lblNumRep = new System.Windows.Forms.Label();
            this.txtNombreRep = new System.Windows.Forms.TextBox();
            this.checkQueso = new System.Windows.Forms.CheckBox();
            this.lblNomRep = new System.Windows.Forms.Label();
            this.checkSalsa = new System.Windows.Forms.CheckBox();
            this.checkPeperoni = new System.Windows.Forms.CheckBox();
            this.lblIngExtras = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPlatillo = new System.Windows.Forms.Label();
            this.lblNombreC = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPlatillo = new System.Windows.Forms.TextBox();
            this.txtNombreC = new System.Windows.Forms.TextBox();
            this.lblNumPed = new System.Windows.Forms.Label();
            this.cmbPedidos = new System.Windows.Forms.ComboBox();
            this.btnEntregado = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gboxDatosP.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxDatosP
            // 
            this.gboxDatosP.Controls.Add(this.txtNR);
            this.gboxDatosP.Controls.Add(this.lblNumRep);
            this.gboxDatosP.Controls.Add(this.txtNombreRep);
            this.gboxDatosP.Controls.Add(this.checkQueso);
            this.gboxDatosP.Controls.Add(this.lblNomRep);
            this.gboxDatosP.Controls.Add(this.checkSalsa);
            this.gboxDatosP.Controls.Add(this.checkPeperoni);
            this.gboxDatosP.Controls.Add(this.lblIngExtras);
            this.gboxDatosP.Controls.Add(this.lblTotal);
            this.gboxDatosP.Controls.Add(this.lblIva);
            this.gboxDatosP.Controls.Add(this.lblSubTotal);
            this.gboxDatosP.Controls.Add(this.lblCantidad);
            this.gboxDatosP.Controls.Add(this.lblPlatillo);
            this.gboxDatosP.Controls.Add(this.lblNombreC);
            this.gboxDatosP.Controls.Add(this.txtTotal);
            this.gboxDatosP.Controls.Add(this.txtIva);
            this.gboxDatosP.Controls.Add(this.txtSubTotal);
            this.gboxDatosP.Controls.Add(this.txtCantidad);
            this.gboxDatosP.Controls.Add(this.txtPlatillo);
            this.gboxDatosP.Controls.Add(this.txtNombreC);
            this.gboxDatosP.Location = new System.Drawing.Point(15, 58);
            this.gboxDatosP.Name = "gboxDatosP";
            this.gboxDatosP.Size = new System.Drawing.Size(555, 158);
            this.gboxDatosP.TabIndex = 8;
            this.gboxDatosP.TabStop = false;
            this.gboxDatosP.Text = "Datos del pedido";
            // 
            // txtNR
            // 
            this.txtNR.Location = new System.Drawing.Point(353, 109);
            this.txtNR.Name = "txtNR";
            this.txtNR.ReadOnly = true;
            this.txtNR.Size = new System.Drawing.Size(105, 20);
            this.txtNR.TabIndex = 17;
            // 
            // lblNumRep
            // 
            this.lblNumRep.AutoSize = true;
            this.lblNumRep.Location = new System.Drawing.Point(350, 84);
            this.lblNumRep.Name = "lblNumRep";
            this.lblNumRep.Size = new System.Drawing.Size(108, 13);
            this.lblNumRep.TabIndex = 16;
            this.lblNumRep.Text = "Numero del repartidor";
            // 
            // txtNombreRep
            // 
            this.txtNombreRep.Location = new System.Drawing.Point(353, 52);
            this.txtNombreRep.Name = "txtNombreRep";
            this.txtNombreRep.ReadOnly = true;
            this.txtNombreRep.Size = new System.Drawing.Size(189, 20);
            this.txtNombreRep.TabIndex = 15;
            // 
            // checkQueso
            // 
            this.checkQueso.AutoSize = true;
            this.checkQueso.Enabled = false;
            this.checkQueso.Location = new System.Drawing.Point(139, 117);
            this.checkQueso.Name = "checkQueso";
            this.checkQueso.Size = new System.Drawing.Size(57, 17);
            this.checkQueso.TabIndex = 14;
            this.checkQueso.Text = "Queso";
            this.checkQueso.UseVisualStyleBackColor = true;
            // 
            // lblNomRep
            // 
            this.lblNomRep.AutoSize = true;
            this.lblNomRep.Location = new System.Drawing.Point(350, 36);
            this.lblNomRep.Name = "lblNomRep";
            this.lblNomRep.Size = new System.Drawing.Size(108, 13);
            this.lblNomRep.TabIndex = 7;
            this.lblNomRep.Text = "Nombre del repartidor";
            // 
            // checkSalsa
            // 
            this.checkSalsa.AutoSize = true;
            this.checkSalsa.Enabled = false;
            this.checkSalsa.Location = new System.Drawing.Point(81, 117);
            this.checkSalsa.Name = "checkSalsa";
            this.checkSalsa.Size = new System.Drawing.Size(52, 17);
            this.checkSalsa.TabIndex = 13;
            this.checkSalsa.Text = "Salsa";
            this.checkSalsa.UseVisualStyleBackColor = true;
            // 
            // checkPeperoni
            // 
            this.checkPeperoni.AutoSize = true;
            this.checkPeperoni.Enabled = false;
            this.checkPeperoni.Location = new System.Drawing.Point(7, 117);
            this.checkPeperoni.Name = "checkPeperoni";
            this.checkPeperoni.Size = new System.Drawing.Size(68, 17);
            this.checkPeperoni.TabIndex = 12;
            this.checkPeperoni.Text = "Peperoni";
            this.checkPeperoni.UseVisualStyleBackColor = true;
            // 
            // lblIngExtras
            // 
            this.lblIngExtras.AutoSize = true;
            this.lblIngExtras.Location = new System.Drawing.Point(3, 100);
            this.lblIngExtras.Name = "lblIngExtras";
            this.lblIngExtras.Size = new System.Drawing.Size(96, 13);
            this.lblIngExtras.TabIndex = 11;
            this.lblIngExtras.Text = "Ingredientes extras";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(243, 116);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Location = new System.Drawing.Point(243, 77);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(22, 13);
            this.lblIva.TabIndex = 7;
            this.lblIva.Text = "Iva";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(243, 36);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(46, 13);
            this.lblSubTotal.TabIndex = 9;
            this.lblSubTotal.Text = "Subtotal";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(115, 61);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 8;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblPlatillo
            // 
            this.lblPlatillo.AutoSize = true;
            this.lblPlatillo.Location = new System.Drawing.Point(6, 59);
            this.lblPlatillo.Name = "lblPlatillo";
            this.lblPlatillo.Size = new System.Drawing.Size(37, 13);
            this.lblPlatillo.TabIndex = 7;
            this.lblPlatillo.Text = "Platillo";
            // 
            // lblNombreC
            // 
            this.lblNombreC.AutoSize = true;
            this.lblNombreC.Location = new System.Drawing.Point(3, 20);
            this.lblNombreC.Name = "lblNombreC";
            this.lblNombreC.Size = new System.Drawing.Size(95, 13);
            this.lblNombreC.TabIndex = 6;
            this.lblNombreC.Text = "Nombre del cliente";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(246, 132);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(89, 20);
            this.txtTotal.TabIndex = 5;
            // 
            // txtIva
            // 
            this.txtIva.Location = new System.Drawing.Point(246, 93);
            this.txtIva.Name = "txtIva";
            this.txtIva.ReadOnly = true;
            this.txtIva.Size = new System.Drawing.Size(89, 20);
            this.txtIva.TabIndex = 4;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(246, 52);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(89, 20);
            this.txtSubTotal.TabIndex = 3;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(118, 77);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(77, 20);
            this.txtCantidad.TabIndex = 2;
            // 
            // txtPlatillo
            // 
            this.txtPlatillo.Location = new System.Drawing.Point(6, 77);
            this.txtPlatillo.Name = "txtPlatillo";
            this.txtPlatillo.ReadOnly = true;
            this.txtPlatillo.Size = new System.Drawing.Size(97, 20);
            this.txtPlatillo.TabIndex = 1;
            // 
            // txtNombreC
            // 
            this.txtNombreC.Location = new System.Drawing.Point(6, 36);
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.ReadOnly = true;
            this.txtNombreC.Size = new System.Drawing.Size(189, 20);
            this.txtNombreC.TabIndex = 0;
            // 
            // lblNumPed
            // 
            this.lblNumPed.AutoSize = true;
            this.lblNumPed.Location = new System.Drawing.Point(9, 15);
            this.lblNumPed.Name = "lblNumPed";
            this.lblNumPed.Size = new System.Drawing.Size(94, 13);
            this.lblNumPed.TabIndex = 6;
            this.lblNumPed.Text = "Numero de pedido";
            // 
            // cmbPedidos
            // 
            this.cmbPedidos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPedidos.FormattingEnabled = true;
            this.cmbPedidos.Location = new System.Drawing.Point(12, 31);
            this.cmbPedidos.Name = "cmbPedidos";
            this.cmbPedidos.Size = new System.Drawing.Size(121, 21);
            this.cmbPedidos.TabIndex = 5;
            this.cmbPedidos.SelectedIndexChanged += new System.EventHandler(this.cmbPedidos_SelectedIndexChanged);
            // 
            // btnEntregado
            // 
            this.btnEntregado.Location = new System.Drawing.Point(28, 222);
            this.btnEntregado.Name = "btnEntregado";
            this.btnEntregado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEntregado.Size = new System.Drawing.Size(120, 43);
            this.btnEntregado.TabIndex = 9;
            this.btnEntregado.Text = "Marcar como entregado";
            this.btnEntregado.UseVisualStyleBackColor = true;
            this.btnEntregado.Click += new System.EventHandler(this.btnEntregado_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(230, 222);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnConsultar.Size = new System.Drawing.Size(120, 43);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.Text = "Consultar pedidos";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(421, 222);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSalir.Size = new System.Drawing.Size(120, 43);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // PedidoEntregado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 291);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnEntregado);
            this.Controls.Add(this.gboxDatosP);
            this.Controls.Add(this.lblNumPed);
            this.Controls.Add(this.cmbPedidos);
            this.Name = "PedidoEntregado";
            this.Text = "Pedido entregado";
            this.Load += new System.EventHandler(this.PedidoEntregado_Load);
            this.gboxDatosP.ResumeLayout(false);
            this.gboxDatosP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxDatosP;
        private System.Windows.Forms.CheckBox checkQueso;
        private System.Windows.Forms.CheckBox checkSalsa;
        private System.Windows.Forms.CheckBox checkPeperoni;
        private System.Windows.Forms.Label lblIngExtras;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPlatillo;
        private System.Windows.Forms.Label lblNombreC;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPlatillo;
        private System.Windows.Forms.TextBox txtNombreC;
        private System.Windows.Forms.Label lblNomRep;
        private System.Windows.Forms.Label lblNumPed;
        private System.Windows.Forms.ComboBox cmbPedidos;
        private System.Windows.Forms.TextBox txtNombreRep;
        private System.Windows.Forms.TextBox txtNR;
        private System.Windows.Forms.Label lblNumRep;
        private System.Windows.Forms.Button btnEntregado;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSalir;
    }
}