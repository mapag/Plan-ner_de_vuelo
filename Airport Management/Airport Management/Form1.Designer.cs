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
            this.listarAvionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarAviónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarAviónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vUELOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarVueloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarVueloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarVueloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarVueloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rUTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarRutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarRutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarRutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarRutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pLANESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aEROPUERTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarAeropuertosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarAeropuertoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarAeropuertoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONFIGURACIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cREARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bACKUPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarBackUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recuperarBackUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aVIONESToolStripMenuItem,
            this.vUELOSToolStripMenuItem,
            this.rUTAToolStripMenuItem,
            this.pLANESToolStripMenuItem,
            this.aEROPUERTOSToolStripMenuItem,
            this.cONFIGURACIONToolStripMenuItem,
            this.bACKUPToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(856, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aVIONESToolStripMenuItem
            // 
            this.aVIONESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarAvionesToolStripMenuItem,
            this.agregarAviónToolStripMenuItem,
            this.eliminarAviónToolStripMenuItem});
            this.aVIONESToolStripMenuItem.Name = "aVIONESToolStripMenuItem";
            this.aVIONESToolStripMenuItem.Size = new System.Drawing.Size(66, 22);
            this.aVIONESToolStripMenuItem.Text = "AVIONES";
            // 
            // listarAvionesToolStripMenuItem
            // 
            this.listarAvionesToolStripMenuItem.Name = "listarAvionesToolStripMenuItem";
            this.listarAvionesToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.listarAvionesToolStripMenuItem.Text = "Listar aviones";
            this.listarAvionesToolStripMenuItem.Click += new System.EventHandler(this.listarAvionesToolStripMenuItem_Click);
            // 
            // agregarAviónToolStripMenuItem
            // 
            this.agregarAviónToolStripMenuItem.Name = "agregarAviónToolStripMenuItem";
            this.agregarAviónToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.agregarAviónToolStripMenuItem.Text = "Agregar avión";
            this.agregarAviónToolStripMenuItem.Click += new System.EventHandler(this.agregarAviónToolStripMenuItem_Click);
            // 
            // eliminarAviónToolStripMenuItem
            // 
            this.eliminarAviónToolStripMenuItem.Name = "eliminarAviónToolStripMenuItem";
            this.eliminarAviónToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.eliminarAviónToolStripMenuItem.Text = "Eliminar avión";
            this.eliminarAviónToolStripMenuItem.Click += new System.EventHandler(this.eliminarAviónToolStripMenuItem_Click);
            // 
            // vUELOSToolStripMenuItem
            // 
            this.vUELOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarVueloToolStripMenuItem,
            this.agregarVueloToolStripMenuItem,
            this.modificarVueloToolStripMenuItem,
            this.eliminarVueloToolStripMenuItem});
            this.vUELOSToolStripMenuItem.Name = "vUELOSToolStripMenuItem";
            this.vUELOSToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.vUELOSToolStripMenuItem.Text = "VUELOS";
            // 
            // listarVueloToolStripMenuItem
            // 
            this.listarVueloToolStripMenuItem.Name = "listarVueloToolStripMenuItem";
            this.listarVueloToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.listarVueloToolStripMenuItem.Text = "Listar vuelo";
            this.listarVueloToolStripMenuItem.Click += new System.EventHandler(this.listarVueloToolStripMenuItem_Click);
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
            // rUTAToolStripMenuItem
            // 
            this.rUTAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarRutaToolStripMenuItem,
            this.agregarRutaToolStripMenuItem,
            this.modificarRutaToolStripMenuItem,
            this.eliminarRutaToolStripMenuItem});
            this.rUTAToolStripMenuItem.Name = "rUTAToolStripMenuItem";
            this.rUTAToolStripMenuItem.Size = new System.Drawing.Size(54, 22);
            this.rUTAToolStripMenuItem.Text = "RUTAS";
            // 
            // listarRutaToolStripMenuItem
            // 
            this.listarRutaToolStripMenuItem.Name = "listarRutaToolStripMenuItem";
            this.listarRutaToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.listarRutaToolStripMenuItem.Text = "Listar ruta";
            this.listarRutaToolStripMenuItem.Click += new System.EventHandler(this.listarRutaToolStripMenuItem_Click);
            // 
            // agregarRutaToolStripMenuItem
            // 
            this.agregarRutaToolStripMenuItem.Name = "agregarRutaToolStripMenuItem";
            this.agregarRutaToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.agregarRutaToolStripMenuItem.Text = "Agregar ruta";
            this.agregarRutaToolStripMenuItem.Click += new System.EventHandler(this.agregarRutaToolStripMenuItem_Click);
            // 
            // modificarRutaToolStripMenuItem
            // 
            this.modificarRutaToolStripMenuItem.Name = "modificarRutaToolStripMenuItem";
            this.modificarRutaToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.modificarRutaToolStripMenuItem.Text = "Modificar ruta";
            this.modificarRutaToolStripMenuItem.Click += new System.EventHandler(this.modificarRutaToolStripMenuItem_Click);
            // 
            // eliminarRutaToolStripMenuItem
            // 
            this.eliminarRutaToolStripMenuItem.Name = "eliminarRutaToolStripMenuItem";
            this.eliminarRutaToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.eliminarRutaToolStripMenuItem.Text = "Eliminar ruta";
            this.eliminarRutaToolStripMenuItem.Click += new System.EventHandler(this.eliminarRutaToolStripMenuItem_Click);
            // 
            // pLANESToolStripMenuItem
            // 
            this.pLANESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarPlanToolStripMenuItem,
            this.mostrarPlanToolStripMenuItem});
            this.pLANESToolStripMenuItem.Name = "pLANESToolStripMenuItem";
            this.pLANESToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.pLANESToolStripMenuItem.Text = "PLANES";
            // 
            // generarPlanToolStripMenuItem
            // 
            this.generarPlanToolStripMenuItem.Name = "generarPlanToolStripMenuItem";
            this.generarPlanToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.generarPlanToolStripMenuItem.Text = "Generar plan";
            this.generarPlanToolStripMenuItem.Click += new System.EventHandler(this.generarPlanToolStripMenuItem_Click);
            // 
            // mostrarPlanToolStripMenuItem
            // 
            this.mostrarPlanToolStripMenuItem.Name = "mostrarPlanToolStripMenuItem";
            this.mostrarPlanToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.mostrarPlanToolStripMenuItem.Text = "Mostrar Plan";
            this.mostrarPlanToolStripMenuItem.Click += new System.EventHandler(this.mostrarPlanToolStripMenuItem_Click);
            // 
            // aEROPUERTOSToolStripMenuItem
            // 
            this.aEROPUERTOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarAeropuertosToolStripMenuItem,
            this.agregarAeropuertoToolStripMenuItem,
            this.eliminarAeropuertoToolStripMenuItem});
            this.aEROPUERTOSToolStripMenuItem.Name = "aEROPUERTOSToolStripMenuItem";
            this.aEROPUERTOSToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.aEROPUERTOSToolStripMenuItem.Text = "AEROPUERTOS";
            // 
            // listarAeropuertosToolStripMenuItem
            // 
            this.listarAeropuertosToolStripMenuItem.Name = "listarAeropuertosToolStripMenuItem";
            this.listarAeropuertosToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.listarAeropuertosToolStripMenuItem.Text = "Listar aeropuertos";
            this.listarAeropuertosToolStripMenuItem.Click += new System.EventHandler(this.listarAeropuertosToolStripMenuItem_Click);
            // 
            // agregarAeropuertoToolStripMenuItem
            // 
            this.agregarAeropuertoToolStripMenuItem.Name = "agregarAeropuertoToolStripMenuItem";
            this.agregarAeropuertoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.agregarAeropuertoToolStripMenuItem.Text = "Agregar aeropuerto";
            this.agregarAeropuertoToolStripMenuItem.Click += new System.EventHandler(this.agregarAeropuertoToolStripMenuItem_Click);
            // 
            // eliminarAeropuertoToolStripMenuItem
            // 
            this.eliminarAeropuertoToolStripMenuItem.Name = "eliminarAeropuertoToolStripMenuItem";
            this.eliminarAeropuertoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.eliminarAeropuertoToolStripMenuItem.Text = "Eliminar aeropuerto";
            this.eliminarAeropuertoToolStripMenuItem.Click += new System.EventHandler(this.eliminarAeropuertoToolStripMenuItem_Click);
            // 
            // cONFIGURACIONToolStripMenuItem
            // 
            this.cONFIGURACIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cREARToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.cONFIGURACIONToolStripMenuItem.Name = "cONFIGURACIONToolStripMenuItem";
            this.cONFIGURACIONToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.cONFIGURACIONToolStripMenuItem.Text = "CONFIGURACIÓN";
            // 
            // cREARToolStripMenuItem
            // 
            this.cREARToolStripMenuItem.Name = "cREARToolStripMenuItem";
            this.cREARToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cREARToolStripMenuItem.Text = "Crear usuario";
            this.cREARToolStripMenuItem.Click += new System.EventHandler(this.cREARToolStripMenuItem_Click);
            // 
            // bACKUPToolStripMenuItem
            // 
            this.bACKUPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarBackUpToolStripMenuItem,
            this.recuperarBackUpToolStripMenuItem});
            this.bACKUPToolStripMenuItem.Name = "bACKUPToolStripMenuItem";
            this.bACKUPToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.bACKUPToolStripMenuItem.Text = "BACK UP";
            // 
            // generarBackUpToolStripMenuItem
            // 
            this.generarBackUpToolStripMenuItem.Name = "generarBackUpToolStripMenuItem";
            this.generarBackUpToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.generarBackUpToolStripMenuItem.Text = "Generar BackUp";
            this.generarBackUpToolStripMenuItem.Click += new System.EventHandler(this.generarBackUpToolStripMenuItem_Click);
            // 
            // recuperarBackUpToolStripMenuItem
            // 
            this.recuperarBackUpToolStripMenuItem.Name = "recuperarBackUpToolStripMenuItem";
            this.recuperarBackUpToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.recuperarBackUpToolStripMenuItem.Text = "Recuperar BackUp";
            this.recuperarBackUpToolStripMenuItem.Click += new System.EventHandler(this.recuperarBackUpToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Airport_Management.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(856, 487);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aVIONESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarAviónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarAviónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vUELOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarVueloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarVueloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarVueloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pLANESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONFIGURACIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarAvionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarVueloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rUTAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarRutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarRutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarRutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarRutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aEROPUERTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarAeropuertosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarAeropuertoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarAeropuertoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cREARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bACKUPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarBackUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recuperarBackUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;

    }
}

