
namespace Pedidos
{
    partial class AnadeRepartidor
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
            this.txtNombreRep = new System.Windows.Forms.TextBox();
            this.txtNumRep = new System.Windows.Forms.TextBox();
            this.txtDescV = new System.Windows.Forms.TextBox();
            this.txtLic = new System.Windows.Forms.TextBox();
            this.numUDEdadRep = new System.Windows.Forms.NumericUpDown();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNumRep = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblLic = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.errorPRepartidor = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numUDEdadRep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPRepartidor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreRep
            // 
            this.txtNombreRep.Location = new System.Drawing.Point(153, 12);
            this.txtNombreRep.Name = "txtNombreRep";
            this.txtNombreRep.Size = new System.Drawing.Size(179, 20);
            this.txtNombreRep.TabIndex = 0;
            this.txtNombreRep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreRep_KeyPress);
            this.txtNombreRep.Validated += new System.EventHandler(this.txtNombreRep_Validated);
            // 
            // txtNumRep
            // 
            this.txtNumRep.Location = new System.Drawing.Point(153, 48);
            this.txtNumRep.Name = "txtNumRep";
            this.txtNumRep.ReadOnly = true;
            this.txtNumRep.Size = new System.Drawing.Size(99, 20);
            this.txtNumRep.TabIndex = 1;
            // 
            // txtDescV
            // 
            this.txtDescV.Location = new System.Drawing.Point(153, 84);
            this.txtDescV.Name = "txtDescV";
            this.txtDescV.Size = new System.Drawing.Size(179, 20);
            this.txtDescV.TabIndex = 2;
            this.txtDescV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescV_KeyPress);
            this.txtDescV.Validated += new System.EventHandler(this.textBox1_Validated);
            // 
            // txtLic
            // 
            this.txtLic.Location = new System.Drawing.Point(153, 125);
            this.txtLic.Name = "txtLic";
            this.txtLic.Size = new System.Drawing.Size(179, 20);
            this.txtLic.TabIndex = 3;
            this.txtLic.TextChanged += new System.EventHandler(this.txtLic_TextChanged);
            this.txtLic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLic_KeyPress);
            this.txtLic.Validated += new System.EventHandler(this.txtLic_Validated);
            // 
            // numUDEdadRep
            // 
            this.numUDEdadRep.Location = new System.Drawing.Point(153, 162);
            this.numUDEdadRep.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numUDEdadRep.Name = "numUDEdadRep";
            this.numUDEdadRep.ReadOnly = true;
            this.numUDEdadRep.Size = new System.Drawing.Size(99, 20);
            this.numUDEdadRep.TabIndex = 4;
            this.numUDEdadRep.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(103, 15);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // lblNumRep
            // 
            this.lblNumRep.AutoSize = true;
            this.lblNumRep.Location = new System.Drawing.Point(51, 51);
            this.lblNumRep.Name = "lblNumRep";
            this.lblNumRep.Size = new System.Drawing.Size(96, 13);
            this.lblNumRep.TabIndex = 6;
            this.lblNumRep.Text = "Numero Repartidor";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(24, 84);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(123, 13);
            this.lblDesc.TabIndex = 7;
            this.lblDesc.Text = "Descripción del vehiculo";
            // 
            // lblLic
            // 
            this.lblLic.AutoSize = true;
            this.lblLic.Location = new System.Drawing.Point(49, 128);
            this.lblLic.Name = "lblLic";
            this.lblLic.Size = new System.Drawing.Size(98, 13);
            this.lblLic.TabIndex = 8;
            this.lblLic.Text = "Numero de licencia";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(112, 164);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 9;
            this.lblEdad.Text = "Edad";
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(52, 202);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(75, 23);
            this.btnAñadir.TabIndex = 10;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(153, 202);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 11;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(257, 202);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(153, 246);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // errorPRepartidor
            // 
            this.errorPRepartidor.ContainerControl = this;
            // 
            // AnadeRepartidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 294);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblLic);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblNumRep);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.numUDEdadRep);
            this.Controls.Add(this.txtLic);
            this.Controls.Add(this.txtDescV);
            this.Controls.Add(this.txtNumRep);
            this.Controls.Add(this.txtNombreRep);
            this.Name = "AnadeRepartidor";
            this.Text = "Añadir repartidores";
            this.Load += new System.EventHandler(this.AnadeRepartidor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUDEdadRep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPRepartidor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreRep;
        private System.Windows.Forms.TextBox txtNumRep;
        private System.Windows.Forms.TextBox txtDescV;
        private System.Windows.Forms.TextBox txtLic;
        private System.Windows.Forms.NumericUpDown numUDEdadRep;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNumRep;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblLic;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider errorPRepartidor;
    }
}