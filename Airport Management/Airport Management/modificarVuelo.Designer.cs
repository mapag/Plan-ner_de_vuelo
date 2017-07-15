namespace Airport_Management
{
    partial class modificarVuelo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer_Fecha = new System.Windows.Forms.DateTimePicker();
            this.cmb_Ruta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(28, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de vuelo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(28, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código de ruta:";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(102, 228);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(170, 24);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar vuelo";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Menú modificar vuelo";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Codigo.Location = new System.Drawing.Point(163, 81);
            this.txt_Codigo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(200, 26);
            this.txt_Codigo.TabIndex = 30;
            this.txt_Codigo.TextChanged += new System.EventHandler(this.txt_Codigo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(28, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Fecha de salida:";
            // 
            // timer_Fecha
            // 
            this.timer_Fecha.Location = new System.Drawing.Point(163, 177);
            this.timer_Fecha.MinDate = new System.DateTime(2017, 7, 3, 0, 0, 0, 0);
            this.timer_Fecha.Name = "timer_Fecha";
            this.timer_Fecha.Size = new System.Drawing.Size(200, 20);
            this.timer_Fecha.TabIndex = 34;
            this.timer_Fecha.Value = new System.DateTime(2017, 7, 3, 10, 10, 43, 0);
            // 
            // cmb_Ruta
            // 
            this.cmb_Ruta.FormattingEnabled = true;
            this.cmb_Ruta.Location = new System.Drawing.Point(163, 131);
            this.cmb_Ruta.Name = "cmb_Ruta";
            this.cmb_Ruta.Size = new System.Drawing.Size(200, 21);
            this.cmb_Ruta.TabIndex = 35;
            // 
            // modificarVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(375, 270);
            this.Controls.Add(this.cmb_Ruta);
            this.Controls.Add(this.timer_Fecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "modificarVuelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "modificarVuelo";
            this.Load += new System.EventHandler(this.modificarVuelo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker timer_Fecha;
        private System.Windows.Forms.ComboBox cmb_Ruta;
    }
}