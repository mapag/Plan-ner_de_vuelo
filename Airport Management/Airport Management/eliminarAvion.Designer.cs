namespace Airport_Management
{
    partial class eliminarAvion
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.tipoAvion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(81, 28);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(152, 26);
            this.txtCodigo.TabIndex = 5;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(16, 160);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(217, 35);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Eliminar avión";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // tipoAvion
            // 
            this.tipoAvion.AutoSize = true;
            this.tipoAvion.Location = new System.Drawing.Point(77, 89);
            this.tipoAvion.Name = "tipoAvion";
            this.tipoAvion.Size = new System.Drawing.Size(102, 20);
            this.tipoAvion.TabIndex = 8;
            this.tipoAvion.Text = "Tipo de avión";
            // 
            // eliminarAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 229);
            this.Controls.Add(this.tipoAvion);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label3);
            this.Name = "eliminarAvion";
            this.Text = "eliminarAvion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label tipoAvion;
    }
}