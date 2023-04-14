
namespace Pedidos
{
    partial class ConsultaPedidos
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
            this.lblPedidos = new System.Windows.Forms.Label();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.NPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Platillo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peperoni = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Salsa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Queso = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.STotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NRepartidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreRepartidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPedidos
            // 
            this.cmbPedidos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPedidos.FormattingEnabled = true;
            this.cmbPedidos.Items.AddRange(new object[] {
            "Todos",
            "Activo",
            "Por entregar",
            "Entregado"});
            this.cmbPedidos.Location = new System.Drawing.Point(12, 35);
            this.cmbPedidos.Name = "cmbPedidos";
            this.cmbPedidos.Size = new System.Drawing.Size(121, 21);
            this.cmbPedidos.TabIndex = 0;
            this.cmbPedidos.SelectedIndexChanged += new System.EventHandler(this.cmbPedidos_SelectedIndexChanged);
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.Location = new System.Drawing.Point(13, 13);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(45, 13);
            this.lblPedidos.TabIndex = 1;
            this.lblPedidos.Text = "Pedidos";
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NPedido,
            this.NombreCliente,
            this.Platillo,
            this.Cantidad,
            this.Peperoni,
            this.Salsa,
            this.Queso,
            this.STotal,
            this.Iva,
            this.Total,
            this.NRepartidor,
            this.NombreRepartidor,
            this.Estado});
            this.dgvPedidos.Location = new System.Drawing.Point(12, 63);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.Size = new System.Drawing.Size(984, 375);
            this.dgvPedidos.TabIndex = 2;
            // 
            // NPedido
            // 
            this.NPedido.HeaderText = "Numero de pedido";
            this.NPedido.Name = "NPedido";
            this.NPedido.ReadOnly = true;
            this.NPedido.Width = 50;
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "Cliente";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            this.NombreCliente.Width = 110;
            // 
            // Platillo
            // 
            this.Platillo.HeaderText = "Platillo";
            this.Platillo.Name = "Platillo";
            this.Platillo.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 50;
            // 
            // Peperoni
            // 
            this.Peperoni.HeaderText = "Peperoni";
            this.Peperoni.Name = "Peperoni";
            this.Peperoni.ReadOnly = true;
            this.Peperoni.Width = 50;
            // 
            // Salsa
            // 
            this.Salsa.HeaderText = "Salsa";
            this.Salsa.Name = "Salsa";
            this.Salsa.ReadOnly = true;
            this.Salsa.Width = 50;
            // 
            // Queso
            // 
            this.Queso.HeaderText = "Queso";
            this.Queso.Name = "Queso";
            this.Queso.ReadOnly = true;
            this.Queso.Width = 50;
            // 
            // STotal
            // 
            this.STotal.HeaderText = "SubTotal";
            this.STotal.Name = "STotal";
            this.STotal.ReadOnly = true;
            this.STotal.Width = 60;
            // 
            // Iva
            // 
            this.Iva.HeaderText = "Iva";
            this.Iva.Name = "Iva";
            this.Iva.ReadOnly = true;
            this.Iva.Width = 60;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 70;
            // 
            // NRepartidor
            // 
            this.NRepartidor.HeaderText = "Numero de repartidor";
            this.NRepartidor.Name = "NRepartidor";
            this.NRepartidor.ReadOnly = true;
            this.NRepartidor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NRepartidor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NRepartidor.Width = 80;
            // 
            // NombreRepartidor
            // 
            this.NombreRepartidor.HeaderText = "Repartidor";
            this.NombreRepartidor.Name = "NombreRepartidor";
            this.NombreRepartidor.ReadOnly = true;
            this.NombreRepartidor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NombreRepartidor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NombreRepartidor.Width = 110;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado del pedido";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ConsultaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 450);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.lblPedidos);
            this.Controls.Add(this.cmbPedidos);
            this.Name = "ConsultaPedidos";
            this.Text = "ConsultaPedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPedidos;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Platillo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Peperoni;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Salsa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Queso;
        private System.Windows.Forms.DataGridViewTextBoxColumn STotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRepartidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreRepartidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}