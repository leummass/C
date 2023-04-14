
namespace Pedidos
{
    partial class ConsultarRepartidores
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
            this.cmbRepartidores = new System.Windows.Forms.ComboBox();
            this.dgvRepartidores = new System.Windows.Forms.DataGridView();
            this.lblRepartidores = new System.Windows.Forms.Label();
            this.NumeroRep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreRep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NLic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepartidores)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRepartidores
            // 
            this.cmbRepartidores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRepartidores.FormattingEnabled = true;
            this.cmbRepartidores.Items.AddRange(new object[] {
            "Todos",
            "Activos",
            "Ocupados"});
            this.cmbRepartidores.Location = new System.Drawing.Point(12, 29);
            this.cmbRepartidores.Name = "cmbRepartidores";
            this.cmbRepartidores.Size = new System.Drawing.Size(121, 21);
            this.cmbRepartidores.TabIndex = 0;
            this.cmbRepartidores.SelectedIndexChanged += new System.EventHandler(this.cmbRepartidores_SelectedIndexChanged);
            // 
            // dgvRepartidores
            // 
            this.dgvRepartidores.AllowUserToAddRows = false;
            this.dgvRepartidores.AllowUserToDeleteRows = false;
            this.dgvRepartidores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepartidores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroRep,
            this.NombreRep,
            this.DescV,
            this.NLic,
            this.Edad,
            this.Estado});
            this.dgvRepartidores.Location = new System.Drawing.Point(12, 56);
            this.dgvRepartidores.Name = "dgvRepartidores";
            this.dgvRepartidores.ReadOnly = true;
            this.dgvRepartidores.Size = new System.Drawing.Size(571, 381);
            this.dgvRepartidores.TabIndex = 1;
            // 
            // lblRepartidores
            // 
            this.lblRepartidores.AutoSize = true;
            this.lblRepartidores.Location = new System.Drawing.Point(13, 10);
            this.lblRepartidores.Name = "lblRepartidores";
            this.lblRepartidores.Size = new System.Drawing.Size(67, 13);
            this.lblRepartidores.TabIndex = 2;
            this.lblRepartidores.Text = "Repartidores";
            // 
            // NumeroRep
            // 
            this.NumeroRep.HeaderText = "Numero de repartidor";
            this.NumeroRep.Name = "NumeroRep";
            this.NumeroRep.ReadOnly = true;
            this.NumeroRep.Width = 80;
            // 
            // NombreRep
            // 
            this.NombreRep.HeaderText = "Nombre de repartidor";
            this.NombreRep.Name = "NombreRep";
            this.NombreRep.ReadOnly = true;
            this.NombreRep.Width = 130;
            // 
            // DescV
            // 
            this.DescV.HeaderText = "Descripción del vehiculo";
            this.DescV.Name = "DescV";
            this.DescV.ReadOnly = true;
            this.DescV.Width = 130;
            // 
            // NLic
            // 
            this.NLic.HeaderText = "Número de licencia";
            this.NLic.Name = "NLic";
            this.NLic.ReadOnly = true;
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            this.Edad.Width = 40;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 50;
            // 
            // ConsultarRepartidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.lblRepartidores);
            this.Controls.Add(this.dgvRepartidores);
            this.Controls.Add(this.cmbRepartidores);
            this.Name = "ConsultarRepartidores";
            this.Text = "ConsultarRepartidores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepartidores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRepartidores;
        private System.Windows.Forms.DataGridView dgvRepartidores;
        private System.Windows.Forms.Label lblRepartidores;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroRep;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreRep;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NLic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}