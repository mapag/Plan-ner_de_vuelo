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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cmbFIltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnMostrarInforme = new System.Windows.Forms.Button();
            this.chartControl = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
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
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(548, 84);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(235, 38);
            this.btnReset.TabIndex = 38;
            this.btnReset.Text = "Borrar selección";
            this.btnReset.UseVisualStyleBackColor = true;
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
            // chartControl
            // 
            this.chartControl.BorderlineColor = System.Drawing.SystemColors.Window;
            chartArea1.Name = "ChartArea1";
            this.chartControl.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartControl.Legends.Add(legend1);
            this.chartControl.Location = new System.Drawing.Point(12, 173);
            this.chartControl.Name = "chartControl";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartControl.Series.Add(series1);
            this.chartControl.Size = new System.Drawing.Size(765, 328);
            this.chartControl.TabIndex = 41;
            this.chartControl.Text = "chart1";
            // 
            // InformeAviones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(792, 554);
            this.Controls.Add(this.chartControl);
            this.Controls.Add(this.cmbFIltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnMostrarInforme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InformeAviones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformeAviones";
<<<<<<< HEAD
            this.Load += new System.EventHandler(this.InformeAviones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdInformeAviones)).EndInit();
=======
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
>>>>>>> 0a5556bdfc91c1324a9f58e941009e2c73f85bdd
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFIltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnMostrarInforme;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartControl;
    }
}