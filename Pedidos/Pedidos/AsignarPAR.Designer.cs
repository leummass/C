
namespace Pedidos
{
    partial class AsignarPAR
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
            this.cmbPedidos = new System.Windows.Forms.ComboBox();
            this.cmbRepartidor = new System.Windows.Forms.ComboBox();
            this.lblNumPed = new System.Windows.Forms.Label();
            this.lblNomRep = new System.Windows.Forms.Label();
            this.gboxDatosP = new System.Windows.Forms.GroupBox();
            this.checkQueso = new System.Windows.Forms.CheckBox();
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
            this.gboxDatosR = new System.Windows.Forms.GroupBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblLic = new System.Windows.Forms.Label();
            this.lblDescV = new System.Windows.Forms.Label();
            this.lblNumRep = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtNLic = new System.Windows.Forms.TextBox();
            this.txtDescV = new System.Windows.Forms.TextBox();
            this.txtNR = new System.Windows.Forms.TextBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gboxDatosP.SuspendLayout();
            this.gboxDatosR.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbPedidos
            // 
            this.cmbPedidos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPedidos.FormattingEnabled = true;
            this.cmbPedidos.Location = new System.Drawing.Point(12, 37);
            this.cmbPedidos.Name = "cmbPedidos";
            this.cmbPedidos.Size = new System.Drawing.Size(121, 21);
            this.cmbPedidos.TabIndex = 0;
            this.cmbPedidos.SelectedIndexChanged += new System.EventHandler(this.cmbPedidos_SelectedIndexChanged);
            // 
            // cmbRepartidor
            // 
            this.cmbRepartidor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRepartidor.FormattingEnabled = true;
            this.cmbRepartidor.Location = new System.Drawing.Point(12, 241);
            this.cmbRepartidor.Name = "cmbRepartidor";
            this.cmbRepartidor.Size = new System.Drawing.Size(121, 21);
            this.cmbRepartidor.TabIndex = 1;
            this.cmbRepartidor.SelectedIndexChanged += new System.EventHandler(this.cmbRepartidor_SelectedIndexChanged);
            // 
            // lblNumPed
            // 
            this.lblNumPed.AutoSize = true;
            this.lblNumPed.Location = new System.Drawing.Point(9, 21);
            this.lblNumPed.Name = "lblNumPed";
            this.lblNumPed.Size = new System.Drawing.Size(94, 13);
            this.lblNumPed.TabIndex = 2;
            this.lblNumPed.Text = "Numero de pedido";
            // 
            // lblNomRep
            // 
            this.lblNomRep.AutoSize = true;
            this.lblNomRep.Location = new System.Drawing.Point(12, 225);
            this.lblNomRep.Name = "lblNomRep";
            this.lblNomRep.Size = new System.Drawing.Size(108, 13);
            this.lblNomRep.TabIndex = 3;
            this.lblNomRep.Text = "Nombre del repartidor";
            // 
            // gboxDatosP
            // 
            this.gboxDatosP.Controls.Add(this.checkQueso);
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
            this.gboxDatosP.Location = new System.Drawing.Point(15, 64);
            this.gboxDatosP.Name = "gboxDatosP";
            this.gboxDatosP.Size = new System.Drawing.Size(351, 158);
            this.gboxDatosP.TabIndex = 4;
            this.gboxDatosP.TabStop = false;
            this.gboxDatosP.Text = "Datos del pedido";
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
            // gboxDatosR
            // 
            this.gboxDatosR.Controls.Add(this.lblEdad);
            this.gboxDatosR.Controls.Add(this.lblLic);
            this.gboxDatosR.Controls.Add(this.lblDescV);
            this.gboxDatosR.Controls.Add(this.lblNumRep);
            this.gboxDatosR.Controls.Add(this.txtEdad);
            this.gboxDatosR.Controls.Add(this.txtNLic);
            this.gboxDatosR.Controls.Add(this.txtDescV);
            this.gboxDatosR.Controls.Add(this.txtNR);
            this.gboxDatosR.Location = new System.Drawing.Point(15, 280);
            this.gboxDatosR.Name = "gboxDatosR";
            this.gboxDatosR.Size = new System.Drawing.Size(222, 158);
            this.gboxDatosR.TabIndex = 5;
            this.gboxDatosR.TabStop = false;
            this.gboxDatosR.Text = "Datos del repartidor";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(121, 97);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 10;
            this.lblEdad.Text = "Edad";
            // 
            // lblLic
            // 
            this.lblLic.AutoSize = true;
            this.lblLic.Location = new System.Drawing.Point(8, 99);
            this.lblLic.Name = "lblLic";
            this.lblLic.Size = new System.Drawing.Size(98, 13);
            this.lblLic.TabIndex = 9;
            this.lblLic.Text = "Numero de licencia";
            // 
            // lblDescV
            // 
            this.lblDescV.AutoSize = true;
            this.lblDescV.Location = new System.Drawing.Point(8, 59);
            this.lblDescV.Name = "lblDescV";
            this.lblDescV.Size = new System.Drawing.Size(123, 13);
            this.lblDescV.TabIndex = 8;
            this.lblDescV.Text = "Descripción del vehiculo";
            // 
            // lblNumRep
            // 
            this.lblNumRep.AutoSize = true;
            this.lblNumRep.Location = new System.Drawing.Point(6, 20);
            this.lblNumRep.Name = "lblNumRep";
            this.lblNumRep.Size = new System.Drawing.Size(108, 13);
            this.lblNumRep.TabIndex = 7;
            this.lblNumRep.Text = "Numero del repartidor";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(124, 113);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.Size = new System.Drawing.Size(74, 20);
            this.txtEdad.TabIndex = 4;
            // 
            // txtNLic
            // 
            this.txtNLic.Location = new System.Drawing.Point(9, 113);
            this.txtNLic.Name = "txtNLic";
            this.txtNLic.ReadOnly = true;
            this.txtNLic.Size = new System.Drawing.Size(109, 20);
            this.txtNLic.TabIndex = 3;
            // 
            // txtDescV
            // 
            this.txtDescV.Location = new System.Drawing.Point(9, 76);
            this.txtDescV.Name = "txtDescV";
            this.txtDescV.ReadOnly = true;
            this.txtDescV.Size = new System.Drawing.Size(189, 20);
            this.txtDescV.TabIndex = 2;
            // 
            // txtNR
            // 
            this.txtNR.Location = new System.Drawing.Point(9, 36);
            this.txtNR.Name = "txtNR";
            this.txtNR.ReadOnly = true;
            this.txtNR.Size = new System.Drawing.Size(189, 20);
            this.txtNR.TabIndex = 1;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(244, 300);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(122, 36);
            this.btnAsignar.TabIndex = 6;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(244, 365);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(122, 36);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // AsignarPAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.gboxDatosR);
            this.Controls.Add(this.gboxDatosP);
            this.Controls.Add(this.lblNomRep);
            this.Controls.Add(this.lblNumPed);
            this.Controls.Add(this.cmbRepartidor);
            this.Controls.Add(this.cmbPedidos);
            this.Name = "AsignarPAR";
            this.Text = "Asignar pedido a repartidor";
            this.Load += new System.EventHandler(this.AsignarPAR_Load);
            this.gboxDatosP.ResumeLayout(false);
            this.gboxDatosP.PerformLayout();
            this.gboxDatosR.ResumeLayout(false);
            this.gboxDatosR.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPedidos;
        private System.Windows.Forms.ComboBox cmbRepartidor;
        private System.Windows.Forms.Label lblNumPed;
        private System.Windows.Forms.Label lblNomRep;
        private System.Windows.Forms.GroupBox gboxDatosP;
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
        private System.Windows.Forms.GroupBox gboxDatosR;
        private System.Windows.Forms.CheckBox checkPeperoni;
        private System.Windows.Forms.Label lblIngExtras;
        private System.Windows.Forms.CheckBox checkQueso;
        private System.Windows.Forms.CheckBox checkSalsa;
        private System.Windows.Forms.TextBox txtNR;
        private System.Windows.Forms.TextBox txtDescV;
        private System.Windows.Forms.TextBox txtNLic;
        private System.Windows.Forms.Label lblDescV;
        private System.Windows.Forms.Label lblNumRep;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblLic;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnSalir;
    }
}