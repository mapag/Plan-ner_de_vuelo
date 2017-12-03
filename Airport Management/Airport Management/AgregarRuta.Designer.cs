namespace Airport_Management
{
    partial class agregarRuta
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAtoLlegada = new System.Windows.Forms.ComboBox();
            this.cmbAtoPartida = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtETA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPosta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "ATO de llegada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "ATO de partida:";
            // 
            // cmbAtoLlegada
            // 
            this.cmbAtoLlegada.FormattingEnabled = true;
            this.cmbAtoLlegada.Location = new System.Drawing.Point(159, 124);
            this.cmbAtoLlegada.Name = "cmbAtoLlegada";
            this.cmbAtoLlegada.Size = new System.Drawing.Size(121, 21);
            this.cmbAtoLlegada.TabIndex = 15;
            this.cmbAtoLlegada.SelectedIndexChanged += new System.EventHandler(this.cmbAtoLlegada_SelectedIndexChanged);
            // 
            // cmbAtoPartida
            // 
            this.cmbAtoPartida.FormattingEnabled = true;
            this.cmbAtoPartida.Location = new System.Drawing.Point(159, 81);
            this.cmbAtoPartida.Name = "cmbAtoPartida";
            this.cmbAtoPartida.Size = new System.Drawing.Size(121, 21);
            this.cmbAtoPartida.TabIndex = 14;
            this.cmbAtoPartida.SelectedIndexChanged += new System.EventHandler(this.cmbAtoPartida_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Menú agregar ruta";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(85, 260);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(145, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar ruta";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtETA
            // 
            this.txtETA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtETA.Location = new System.Drawing.Point(159, 162);
            this.txtETA.Margin = new System.Windows.Forms.Padding(2);
            this.txtETA.Name = "txtETA";
            this.txtETA.Size = new System.Drawing.Size(121, 26);
            this.txtETA.TabIndex = 19;
            this.txtETA.TextChanged += new System.EventHandler(this.txtETA_TextChanged);
            this.txtETA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtETA_KeyPress);
            this.txtETA.Leave += new System.EventHandler(this.txtETA_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 168);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "ETA:";
            // 
            // txtPosta
            // 
            this.txtPosta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosta.Location = new System.Drawing.Point(159, 205);
            this.txtPosta.Margin = new System.Windows.Forms.Padding(2);
            this.txtPosta.Name = "txtPosta";
            this.txtPosta.Size = new System.Drawing.Size(121, 26);
            this.txtPosta.TabIndex = 21;
            this.txtPosta.TextChanged += new System.EventHandler(this.txtPosta_TextChanged);
            this.txtPosta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPosta_KeyPress);
            this.txtPosta.Leave += new System.EventHandler(this.txtPosta_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Posta:";
            // 
            // agregarRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(315, 316);
            this.Controls.Add(this.txtPosta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtETA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbAtoLlegada);
            this.Controls.Add(this.cmbAtoPartida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "agregarRuta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "agregarRuta";
            this.Load += new System.EventHandler(this.agregarRuta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAtoLlegada;
        private System.Windows.Forms.ComboBox cmbAtoPartida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtETA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPosta;
        private System.Windows.Forms.Label label5;
    }
}