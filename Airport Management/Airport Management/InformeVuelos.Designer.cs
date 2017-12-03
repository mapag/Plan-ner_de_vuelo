namespace Airport_Management
{
    partial class InformeVuelos
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
            this.grdInformeVuelos = new System.Windows.Forms.DataGridView();
            this.cmbFIltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrarInforme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdInformeVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // grdInformeVuelos
            // 
            this.grdInformeVuelos.AllowUserToAddRows = false;
            this.grdInformeVuelos.AllowUserToDeleteRows = false;
            this.grdInformeVuelos.AllowUserToResizeColumns = false;
            this.grdInformeVuelos.AllowUserToResizeRows = false;
            this.grdInformeVuelos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdInformeVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdInformeVuelos.Location = new System.Drawing.Point(10, 178);
            this.grdInformeVuelos.Margin = new System.Windows.Forms.Padding(2);
            this.grdInformeVuelos.Name = "grdInformeVuelos";
            this.grdInformeVuelos.ReadOnly = true;
            this.grdInformeVuelos.RowTemplate.Height = 28;
            this.grdInformeVuelos.Size = new System.Drawing.Size(773, 366);
            this.grdInformeVuelos.TabIndex = 20;
            // 
            // cmbFIltro
            // 
            this.cmbFIltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFIltro.FormattingEnabled = true;
            this.cmbFIltro.Location = new System.Drawing.Point(179, 36);
            this.cmbFIltro.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFIltro.Name = "cmbFIltro";
            this.cmbFIltro.Size = new System.Drawing.Size(317, 32);
            this.cmbFIltro.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "Filtro de selección";
            // 
            // btnMostrarInforme
            // 
            this.btnMostrarInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarInforme.Location = new System.Drawing.Point(548, 32);
            this.btnMostrarInforme.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrarInforme.Name = "btnMostrarInforme";
            this.btnMostrarInforme.Size = new System.Drawing.Size(235, 38);
            this.btnMostrarInforme.TabIndex = 37;
            this.btnMostrarInforme.Text = "Mostrar";
            this.btnMostrarInforme.UseVisualStyleBackColor = true;
            this.btnMostrarInforme.Click += new System.EventHandler(this.btnMostrarInforme_Click);
            // 
            // InformeVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(792, 554);
            this.Controls.Add(this.cmbFIltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrarInforme);
            this.Controls.Add(this.grdInformeVuelos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InformeVuelos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformeVuelos";
            this.Load += new System.EventHandler(this.InformeVuelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdInformeVuelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdInformeVuelos;
        private System.Windows.Forms.ComboBox cmbFIltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrarInforme;
    }
}