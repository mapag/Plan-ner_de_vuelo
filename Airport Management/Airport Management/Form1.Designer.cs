namespace Airport_Management
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aVIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarAviónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarAviónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarAviónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vUELOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarVueloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarVueloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarVueloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pLANESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONFIGURACIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aVIONESToolStripMenuItem,
            this.vUELOSToolStripMenuItem,
            this.pLANESToolStripMenuItem,
            this.rEPORTESToolStripMenuItem,
            this.cONFIGURACIONToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(303, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aVIONESToolStripMenuItem
            // 
            this.aVIONESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarAviónToolStripMenuItem,
            this.modificarAviónToolStripMenuItem,
            this.eliminarAviónToolStripMenuItem});
            this.aVIONESToolStripMenuItem.Name = "aVIONESToolStripMenuItem";
            this.aVIONESToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.aVIONESToolStripMenuItem.Text = "AVIONES";
            // 
            // agregarAviónToolStripMenuItem
            // 
            this.agregarAviónToolStripMenuItem.Name = "agregarAviónToolStripMenuItem";
            this.agregarAviónToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.agregarAviónToolStripMenuItem.Text = "Agregar avión";
            this.agregarAviónToolStripMenuItem.Click += new System.EventHandler(this.agregarAviónToolStripMenuItem_Click);
            // 
            // modificarAviónToolStripMenuItem
            // 
            this.modificarAviónToolStripMenuItem.Name = "modificarAviónToolStripMenuItem";
            this.modificarAviónToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.modificarAviónToolStripMenuItem.Text = "Modificar avión";
            this.modificarAviónToolStripMenuItem.Click += new System.EventHandler(this.modificarAviónToolStripMenuItem_Click);
            // 
            // eliminarAviónToolStripMenuItem
            // 
            this.eliminarAviónToolStripMenuItem.Name = "eliminarAviónToolStripMenuItem";
            this.eliminarAviónToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.eliminarAviónToolStripMenuItem.Text = "Eliminar avión";
            this.eliminarAviónToolStripMenuItem.Click += new System.EventHandler(this.eliminarAviónToolStripMenuItem_Click);
            // 
            // vUELOSToolStripMenuItem
            // 
            this.vUELOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarVueloToolStripMenuItem,
            this.modificarVueloToolStripMenuItem,
            this.eliminarVueloToolStripMenuItem});
            this.vUELOSToolStripMenuItem.Name = "vUELOSToolStripMenuItem";
            this.vUELOSToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.vUELOSToolStripMenuItem.Text = "VUELOS";
            // 
            // agregarVueloToolStripMenuItem
            // 
            this.agregarVueloToolStripMenuItem.Name = "agregarVueloToolStripMenuItem";
            this.agregarVueloToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.agregarVueloToolStripMenuItem.Text = "Agregar vuelo";
            this.agregarVueloToolStripMenuItem.Click += new System.EventHandler(this.agregarVueloToolStripMenuItem_Click);
            // 
            // modificarVueloToolStripMenuItem
            // 
            this.modificarVueloToolStripMenuItem.Name = "modificarVueloToolStripMenuItem";
            this.modificarVueloToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.modificarVueloToolStripMenuItem.Text = "Modificar vuelo";
            this.modificarVueloToolStripMenuItem.Click += new System.EventHandler(this.modificarVueloToolStripMenuItem_Click);
            // 
            // eliminarVueloToolStripMenuItem
            // 
            this.eliminarVueloToolStripMenuItem.Name = "eliminarVueloToolStripMenuItem";
            this.eliminarVueloToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.eliminarVueloToolStripMenuItem.Text = "Eliminar vuelo";
            this.eliminarVueloToolStripMenuItem.Click += new System.EventHandler(this.eliminarVueloToolStripMenuItem_Click);
            // 
            // pLANESToolStripMenuItem
            // 
            this.pLANESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarPlanToolStripMenuItem});
            this.pLANESToolStripMenuItem.Name = "pLANESToolStripMenuItem";
            this.pLANESToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.pLANESToolStripMenuItem.Text = "PLANES";
            // 
            // generarPlanToolStripMenuItem
            // 
            this.generarPlanToolStripMenuItem.Name = "generarPlanToolStripMenuItem";
            this.generarPlanToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.generarPlanToolStripMenuItem.Text = "Generar plan";
            // 
            // rEPORTESToolStripMenuItem
            // 
            this.rEPORTESToolStripMenuItem.Name = "rEPORTESToolStripMenuItem";
            this.rEPORTESToolStripMenuItem.Size = new System.Drawing.Size(74, 22);
            this.rEPORTESToolStripMenuItem.Text = "REPORTES";
            // 
            // cONFIGURACIONToolStripMenuItem
            // 
            this.cONFIGURACIONToolStripMenuItem.Name = "cONFIGURACIONToolStripMenuItem";
            this.cONFIGURACIONToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.cONFIGURACIONToolStripMenuItem.Text = "CONFIGURACIÓN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 274);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aVIONESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarAviónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarAviónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarAviónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vUELOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarVueloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarVueloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarVueloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pLANESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONFIGURACIONToolStripMenuItem;

    }
}

