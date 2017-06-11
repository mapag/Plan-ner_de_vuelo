namespace Airport_Management
{
    partial class eliminarVuelo
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.codRuta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código de vuelo:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 26);
            this.textBox1.TabIndex = 3;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(16, 145);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(255, 37);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Eliminar vuelo";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // codRuta
            // 
            this.codRuta.AutoSize = true;
            this.codRuta.Location = new System.Drawing.Point(75, 95);
            this.codRuta.Name = "codRuta";
            this.codRuta.Size = new System.Drawing.Size(113, 20);
            this.codRuta.TabIndex = 6;
            this.codRuta.Text = "Código de ruta";
            // 
            // eliminarVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 219);
            this.Controls.Add(this.codRuta);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "eliminarVuelo";
            this.Text = "eliminarVuelo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label codRuta;
    }
}