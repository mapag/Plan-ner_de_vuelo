namespace Airport_Management
{
    partial class InformeAeropuertos
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
            this.grdInformeAeropuertos = new System.Windows.Forms.DataGridView();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnMostrarInforme = new System.Windows.Forms.Button();
            this.cmbFIltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdInformeAeropuertos)).BeginInit();
            this.SuspendLayout();
            // 
            // grdInformeAeropuertos
            // 
            this.grdInformeAeropuertos.AllowUserToAddRows = false;
            this.grdInformeAeropuertos.AllowUserToDeleteRows = false;
            this.grdInformeAeropuertos.AllowUserToResizeColumns = false;
            this.grdInformeAeropuertos.AllowUserToResizeRows = false;
            this.grdInformeAeropuertos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdInformeAeropuertos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdInformeAeropuertos.Location = new System.Drawing.Point(10, 178);
            this.grdInformeAeropuertos.Margin = new System.Windows.Forms.Padding(2);
            this.grdInformeAeropuertos.Name = "grdInformeAeropuertos";
            this.grdInformeAeropuertos.ReadOnly = true;
            this.grdInformeAeropuertos.RowTemplate.Height = 28;
            this.grdInformeAeropuertos.Size = new System.Drawing.Size(773, 366);
            this.grdInformeAeropuertos.TabIndex = 19;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(548, 83);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(235, 38);
            this.btnReset.TabIndex = 34;
            this.btnReset.Text = "Borrar selección";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnMostrarInforme
            // 
            this.btnMostrarInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarInforme.Location = new System.Drawing.Point(548, 30);
            this.btnMostrarInforme.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrarInforme.Name = "btnMostrarInforme";
            this.btnMostrarInforme.Size = new System.Drawing.Size(235, 38);
            this.btnMostrarInforme.TabIndex = 33;
            this.btnMostrarInforme.Text = "Mostrar";
            this.btnMostrarInforme.UseVisualStyleBackColor = true;
            this.btnMostrarInforme.Click += new System.EventHandler(this.btnMostrarInforme_Click);
            // 
            // cmbFIltro
            // 
            this.cmbFIltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFIltro.FormattingEnabled = true;
            this.cmbFIltro.Location = new System.Drawing.Point(179, 34);
            this.cmbFIltro.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFIltro.Name = "cmbFIltro";
            this.cmbFIltro.Size = new System.Drawing.Size(317, 32);
            this.cmbFIltro.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "Filtro de selección";
            // 
            // InformeAeropuertos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(792, 554);
            this.Controls.Add(this.cmbFIltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnMostrarInforme);
            this.Controls.Add(this.grdInformeAeropuertos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InformeAeropuertos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformeAeropuertos";
            this.Load += new System.EventHandler(this.InformeAeropuertos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdInformeAeropuertos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdInformeAeropuertos;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnMostrarInforme;
        private System.Windows.Forms.ComboBox cmbFIltro;
        private System.Windows.Forms.Label label1;
    }
}