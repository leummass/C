
namespace Pedidos
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarPedidoAEntregadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repartidoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarRepartidoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarRepartidoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarRepartidorAPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaIndividualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidosToolStripMenuItem,
            this.repartidoresToolStripMenuItem,
            this.asignarRepartidorAPedidoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(376, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarPedidoToolStripMenuItem,
            this.consultarPedidosToolStripMenuItem,
            this.cambiarPedidoAEntregadoToolStripMenuItem});
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // agregarPedidoToolStripMenuItem
            // 
            this.agregarPedidoToolStripMenuItem.Name = "agregarPedidoToolStripMenuItem";
            this.agregarPedidoToolStripMenuItem.Size = new System.Drawing.Size(388, 22);
            this.agregarPedidoToolStripMenuItem.Text = "Agregar pedido";
            this.agregarPedidoToolStripMenuItem.Click += new System.EventHandler(this.agregarPedidoToolStripMenuItem_Click);
            // 
            // consultarPedidosToolStripMenuItem
            // 
            this.consultarPedidosToolStripMenuItem.Name = "consultarPedidosToolStripMenuItem";
            this.consultarPedidosToolStripMenuItem.Size = new System.Drawing.Size(388, 22);
            this.consultarPedidosToolStripMenuItem.Text = "Consultar pedidos";
            this.consultarPedidosToolStripMenuItem.Click += new System.EventHandler(this.consultarPedidosToolStripMenuItem_Click);
            // 
            // cambiarPedidoAEntregadoToolStripMenuItem
            // 
            this.cambiarPedidoAEntregadoToolStripMenuItem.Name = "cambiarPedidoAEntregadoToolStripMenuItem";
            this.cambiarPedidoAEntregadoToolStripMenuItem.Size = new System.Drawing.Size(388, 22);
            this.cambiarPedidoAEntregadoToolStripMenuItem.Text = "Cambiar pedido a entregado/Consulta individual de pedido";
            this.cambiarPedidoAEntregadoToolStripMenuItem.Click += new System.EventHandler(this.cambiarPedidoAEntregadoToolStripMenuItem_Click);
            // 
            // repartidoresToolStripMenuItem
            // 
            this.repartidoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarRepartidoresToolStripMenuItem,
            this.consultarRepartidoresToolStripMenuItem});
            this.repartidoresToolStripMenuItem.Name = "repartidoresToolStripMenuItem";
            this.repartidoresToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.repartidoresToolStripMenuItem.Text = "Repartidores";
            // 
            // agregarRepartidoresToolStripMenuItem
            // 
            this.agregarRepartidoresToolStripMenuItem.Name = "agregarRepartidoresToolStripMenuItem";
            this.agregarRepartidoresToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.agregarRepartidoresToolStripMenuItem.Text = "Agregar repartidores";
            this.agregarRepartidoresToolStripMenuItem.Click += new System.EventHandler(this.agregarRepartidoresToolStripMenuItem_Click);
            // 
            // consultarRepartidoresToolStripMenuItem
            // 
            this.consultarRepartidoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaIndividualToolStripMenuItem,
            this.consultaGeneralToolStripMenuItem});
            this.consultarRepartidoresToolStripMenuItem.Name = "consultarRepartidoresToolStripMenuItem";
            this.consultarRepartidoresToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.consultarRepartidoresToolStripMenuItem.Text = "Consultar repartidores";
            this.consultarRepartidoresToolStripMenuItem.Click += new System.EventHandler(this.consultarRepartidoresToolStripMenuItem_Click);
            // 
            // asignarRepartidorAPedidoToolStripMenuItem
            // 
            this.asignarRepartidorAPedidoToolStripMenuItem.Name = "asignarRepartidorAPedidoToolStripMenuItem";
            this.asignarRepartidorAPedidoToolStripMenuItem.Size = new System.Drawing.Size(163, 20);
            this.asignarRepartidorAPedidoToolStripMenuItem.Text = "Asignar pedido a repartidor";
            this.asignarRepartidorAPedidoToolStripMenuItem.Click += new System.EventHandler(this.asignarRepartidorAPedidoToolStripMenuItem_Click);
            // 
            // consultaIndividualToolStripMenuItem
            // 
            this.consultaIndividualToolStripMenuItem.Name = "consultaIndividualToolStripMenuItem";
            this.consultaIndividualToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultaIndividualToolStripMenuItem.Text = "Consulta individual";
            this.consultaIndividualToolStripMenuItem.Click += new System.EventHandler(this.consultaIndividualToolStripMenuItem_Click);
            // 
            // consultaGeneralToolStripMenuItem
            // 
            this.consultaGeneralToolStripMenuItem.Name = "consultaGeneralToolStripMenuItem";
            this.consultaGeneralToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultaGeneralToolStripMenuItem.Text = "Consulta general";
            this.consultaGeneralToolStripMenuItem.Click += new System.EventHandler(this.consultaGeneralToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 200);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "Menu principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repartidoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarRepartidoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarRepartidoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarRepartidorAPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarPedidoAEntregadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaIndividualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaGeneralToolStripMenuItem;
    }
}

