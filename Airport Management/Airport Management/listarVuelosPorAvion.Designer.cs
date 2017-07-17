namespace Airport_Management
{
    partial class listarVuelosPorAvion
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
            this.btnReset = new System.Windows.Forms.Button();
            this.txtCodigoAvion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCodigoAvion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtCodigoVuelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCodigoVuelo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdListarVLOxAV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdListarVLOxAV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(583, 97);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(197, 38);
            this.btnReset.TabIndex = 32;
            this.btnReset.Text = "Mostrar Todo";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtCodigoAvion
            // 
            this.txtCodigoAvion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoAvion.Location = new System.Drawing.Point(367, 101);
            this.txtCodigoAvion.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoAvion.Name = "txtCodigoAvion";
            this.txtCodigoAvion.Size = new System.Drawing.Size(171, 29);
            this.txtCodigoAvion.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(323, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = ":";
            // 
            // cmbCodigoAvion
            // 
            this.cmbCodigoAvion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCodigoAvion.FormattingEnabled = true;
            this.cmbCodigoAvion.Location = new System.Drawing.Point(173, 102);
            this.cmbCodigoAvion.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCodigoAvion.Name = "cmbCodigoAvion";
            this.cmbCodigoAvion.Size = new System.Drawing.Size(147, 32);
            this.cmbCodigoAvion.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Codigo de avión";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(583, 55);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(197, 38);
            this.btnFiltrar.TabIndex = 23;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtCodigoVuelo
            // 
            this.txtCodigoVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoVuelo.Location = new System.Drawing.Point(367, 59);
            this.txtCodigoVuelo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoVuelo.Name = "txtCodigoVuelo";
            this.txtCodigoVuelo.Size = new System.Drawing.Size(171, 29);
            this.txtCodigoVuelo.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = ":";
            // 
            // cmbCodigoVuelo
            // 
            this.cmbCodigoVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCodigoVuelo.FormattingEnabled = true;
            this.cmbCodigoVuelo.Location = new System.Drawing.Point(173, 59);
            this.cmbCodigoVuelo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCodigoVuelo.Name = "cmbCodigoVuelo";
            this.cmbCodigoVuelo.Size = new System.Drawing.Size(147, 32);
            this.cmbCodigoVuelo.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Código de vuelo";
            // 
            // grdListarVLOxAV
            // 
            this.grdListarVLOxAV.AllowUserToAddRows = false;
            this.grdListarVLOxAV.AllowUserToDeleteRows = false;
            this.grdListarVLOxAV.AllowUserToResizeColumns = false;
            this.grdListarVLOxAV.AllowUserToResizeRows = false;
            this.grdListarVLOxAV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdListarVLOxAV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListarVLOxAV.Location = new System.Drawing.Point(10, 180);
            this.grdListarVLOxAV.Margin = new System.Windows.Forms.Padding(2);
            this.grdListarVLOxAV.Name = "grdListarVLOxAV";
            this.grdListarVLOxAV.ReadOnly = true;
            this.grdListarVLOxAV.RowTemplate.Height = 28;
            this.grdListarVLOxAV.Size = new System.Drawing.Size(773, 366);
            this.grdListarVLOxAV.TabIndex = 18;
            // 
            // listarVuelosPorAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(792, 554);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtCodigoAvion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCodigoAvion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtCodigoVuelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCodigoVuelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdListarVLOxAV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "listarVuelosPorAvion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "listarVuelosPorAvion";
            this.Load += new System.EventHandler(this.listarVuelosPorAvion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdListarVLOxAV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtCodigoAvion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCodigoAvion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtCodigoVuelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCodigoVuelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdListarVLOxAV;
    }
}