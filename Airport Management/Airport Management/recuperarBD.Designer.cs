namespace Airport_Management
{
    partial class recuperarBD
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
            this.grd_backups = new System.Windows.Forms.DataGridView();
            this.btn_cargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd_backups)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_backups
            // 
            this.grd_backups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_backups.Location = new System.Drawing.Point(12, 12);
            this.grd_backups.Name = "grd_backups";
            this.grd_backups.Size = new System.Drawing.Size(660, 404);
            this.grd_backups.TabIndex = 0;
            // 
            // btn_cargar
            // 
            this.btn_cargar.Location = new System.Drawing.Point(236, 422);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(234, 23);
            this.btn_cargar.TabIndex = 1;
            this.btn_cargar.Text = "Cargar Este BackUp";
            this.btn_cargar.UseVisualStyleBackColor = true;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // recuperarBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 455);
            this.Controls.Add(this.btn_cargar);
            this.Controls.Add(this.grd_backups);
            this.Name = "recuperarBD";
            this.Text = "recuperarBD";
            this.Load += new System.EventHandler(this.recuperarBD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_backups)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grd_backups;
        private System.Windows.Forms.Button btn_cargar;
    }
}