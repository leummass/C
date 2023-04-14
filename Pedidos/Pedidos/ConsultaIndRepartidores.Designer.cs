
namespace Pedidos
{
    partial class ConsultaIndRepartidores
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
            this.gboxDatosR = new System.Windows.Forms.GroupBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblLic = new System.Windows.Forms.Label();
            this.lblDescV = new System.Windows.Forms.Label();
            this.lblNumRep = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtNLic = new System.Windows.Forms.TextBox();
            this.txtDescV = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNomRep = new System.Windows.Forms.Label();
            this.cmbRepartidor = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.gboxDatosR.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxDatosR
            // 
            this.gboxDatosR.Controls.Add(this.txtEstado);
            this.gboxDatosR.Controls.Add(this.lblEstado);
            this.gboxDatosR.Controls.Add(this.lblEdad);
            this.gboxDatosR.Controls.Add(this.lblNomRep);
            this.gboxDatosR.Controls.Add(this.lblLic);
            this.gboxDatosR.Controls.Add(this.lblDescV);
            this.gboxDatosR.Controls.Add(this.txtEdad);
            this.gboxDatosR.Controls.Add(this.txtNLic);
            this.gboxDatosR.Controls.Add(this.txtDescV);
            this.gboxDatosR.Controls.Add(this.txtNombre);
            this.gboxDatosR.Location = new System.Drawing.Point(15, 64);
            this.gboxDatosR.Name = "gboxDatosR";
            this.gboxDatosR.Size = new System.Drawing.Size(287, 223);
            this.gboxDatosR.TabIndex = 8;
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
            this.lblNumRep.Location = new System.Drawing.Point(12, 9);
            this.lblNumRep.Name = "lblNumRep";
            this.lblNumRep.Size = new System.Drawing.Size(108, 13);
            this.lblNumRep.TabIndex = 7;
            this.lblNumRep.Text = "Numero del repartidor";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(126, 113);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.Size = new System.Drawing.Size(74, 20);
            this.txtEdad.TabIndex = 4;
            // 
            // txtNLic
            // 
            this.txtNLic.Location = new System.Drawing.Point(11, 113);
            this.txtNLic.Name = "txtNLic";
            this.txtNLic.ReadOnly = true;
            this.txtNLic.Size = new System.Drawing.Size(109, 20);
            this.txtNLic.TabIndex = 3;
            // 
            // txtDescV
            // 
            this.txtDescV.Location = new System.Drawing.Point(11, 76);
            this.txtDescV.Name = "txtDescV";
            this.txtDescV.ReadOnly = true;
            this.txtDescV.Size = new System.Drawing.Size(189, 20);
            this.txtDescV.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(11, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(189, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNomRep
            // 
            this.lblNomRep.AutoSize = true;
            this.lblNomRep.Location = new System.Drawing.Point(12, 20);
            this.lblNomRep.Name = "lblNomRep";
            this.lblNomRep.Size = new System.Drawing.Size(108, 13);
            this.lblNomRep.TabIndex = 7;
            this.lblNomRep.Text = "Nombre del repartidor";
            // 
            // cmbRepartidor
            // 
            this.cmbRepartidor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRepartidor.FormattingEnabled = true;
            this.cmbRepartidor.Location = new System.Drawing.Point(12, 25);
            this.cmbRepartidor.Name = "cmbRepartidor";
            this.cmbRepartidor.Size = new System.Drawing.Size(121, 21);
            this.cmbRepartidor.TabIndex = 6;
            this.cmbRepartidor.SelectedIndexChanged += new System.EventHandler(this.cmbNR_SelectedIndexChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(8, 145);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 11;
            this.lblEstado.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(11, 161);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(189, 20);
            this.txtEstado.TabIndex = 12;
            // 
            // ConsultaIndRepartidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 299);
            this.Controls.Add(this.gboxDatosR);
            this.Controls.Add(this.cmbRepartidor);
            this.Controls.Add(this.lblNumRep);
            this.Name = "ConsultaIndRepartidores";
            this.Text = "Consulta individual de repartidores";
            this.Load += new System.EventHandler(this.ConsultaIndRepartidores_Load);
            this.gboxDatosR.ResumeLayout(false);
            this.gboxDatosR.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxDatosR;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblNomRep;
        private System.Windows.Forms.Label lblLic;
        private System.Windows.Forms.Label lblDescV;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtNLic;
        private System.Windows.Forms.TextBox txtDescV;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNumRep;
        private System.Windows.Forms.ComboBox cmbRepartidor;
    }
}