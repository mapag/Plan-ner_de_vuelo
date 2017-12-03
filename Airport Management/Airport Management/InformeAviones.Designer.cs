namespace Airport_Management
{
    partial class InformeAviones
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
            this.cmbFIltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrarInforme = new System.Windows.Forms.Button();
            this.grdInformeAviones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdInformeAviones)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFIltro
            // 
            this.cmbFIltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFIltro.FormattingEnabled = true;
            this.cmbFIltro.Location = new System.Drawing.Point(179, 35);
            this.cmbFIltro.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFIltro.Name = "cmbFIltro";
            this.cmbFIltro.Size = new System.Drawing.Size(317, 32);
            this.cmbFIltro.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "Filtro de selección";
            // 
            // btnMostrarInforme
            // 
            this.btnMostrarInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarInforme.Location = new System.Drawing.Point(548, 31);
            this.btnMostrarInforme.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrarInforme.Name = "btnMostrarInforme";
            this.btnMostrarInforme.Size = new System.Drawing.Size(235, 38);
            this.btnMostrarInforme.TabIndex = 37;
            this.btnMostrarInforme.Text = "Mostrar";
            this.btnMostrarInforme.UseVisualStyleBackColor = true;
            this.btnMostrarInforme.Click += new System.EventHandler(this.btnMostrarInforme_Click);
            // 
            // grdInformeAviones
            // 
            this.grdInformeAviones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdInformeAviones.Location = new System.Drawing.Point(83, 133);
            this.grdInformeAviones.Name = "grdInformeAviones";
            this.grdInformeAviones.Size = new System.Drawing.Size(625, 363);
            this.grdInformeAviones.TabIndex = 41;
            // 
            // InformeAviones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(792, 554);
            this.Controls.Add(this.grdInformeAviones);
            this.Controls.Add(this.cmbFIltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrarInforme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InformeAviones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformeAviones";
            this.Load += new System.EventHandler(this.InformeAviones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdInformeAviones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFIltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrarInforme;
        private System.Windows.Forms.DataGridView grdInformeAviones;
    }
}