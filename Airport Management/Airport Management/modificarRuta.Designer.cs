namespace Airport_Management
{
    partial class modificarRuta
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
            this.txtPosta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtETA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAtoLlegada = new System.Windows.Forms.ComboBox();
            this.cmbAtoPartida = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnChequear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPosta
            // 
            this.txtPosta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosta.Location = new System.Drawing.Point(157, 246);
            this.txtPosta.Margin = new System.Windows.Forms.Padding(2);
            this.txtPosta.Name = "txtPosta";
            this.txtPosta.Size = new System.Drawing.Size(121, 26);
            this.txtPosta.TabIndex = 31;
            this.txtPosta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPosta_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 249);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Posta:";
            // 
            // txtETA
            // 
            this.txtETA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtETA.Location = new System.Drawing.Point(157, 203);
            this.txtETA.Margin = new System.Windows.Forms.Padding(2);
            this.txtETA.Name = "txtETA";
            this.txtETA.Size = new System.Drawing.Size(121, 26);
            this.txtETA.TabIndex = 29;
            this.txtETA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtETA_KeyPress);
            this.txtETA.Validated += new System.EventHandler(this.txtETA_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "ETA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "ATO de llegada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "ATO de partida:";
            // 
            // cmbAtoLlegada
            // 
            this.cmbAtoLlegada.FormattingEnabled = true;
            this.cmbAtoLlegada.Location = new System.Drawing.Point(157, 165);
            this.cmbAtoLlegada.Name = "cmbAtoLlegada";
            this.cmbAtoLlegada.Size = new System.Drawing.Size(121, 21);
            this.cmbAtoLlegada.TabIndex = 25;
            this.cmbAtoLlegada.SelectedIndexChanged += new System.EventHandler(this.cmbAtoLlegada_SelectedIndexChanged);
            // 
            // cmbAtoPartida
            // 
            this.cmbAtoPartida.FormattingEnabled = true;
            this.cmbAtoPartida.Location = new System.Drawing.Point(157, 123);
            this.cmbAtoPartida.Name = "cmbAtoPartida";
            this.cmbAtoPartida.Size = new System.Drawing.Size(121, 21);
            this.cmbAtoPartida.TabIndex = 24;
            this.cmbAtoPartida.SelectedIndexChanged += new System.EventHandler(this.cmbAtoPartida_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Menú modificar ruta";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(90, 286);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(145, 23);
            this.btnModificar.TabIndex = 22;
            this.btnModificar.Text = "Modificar ruta";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(157, 50);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(121, 26);
            this.txtCodigo.TabIndex = 33;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Código de ruta:";
            // 
            // btnChequear
            // 
            this.btnChequear.Location = new System.Drawing.Point(90, 90);
            this.btnChequear.Margin = new System.Windows.Forms.Padding(2);
            this.btnChequear.Name = "btnChequear";
            this.btnChequear.Size = new System.Drawing.Size(145, 23);
            this.btnChequear.TabIndex = 34;
            this.btnChequear.Text = "Chequear ruta";
            this.btnChequear.UseVisualStyleBackColor = true;
            this.btnChequear.Click += new System.EventHandler(this.button1_Click);
            // 
            // modificarRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(315, 316);
            this.Controls.Add(this.btnChequear);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPosta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtETA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbAtoLlegada);
            this.Controls.Add(this.cmbAtoPartida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnModificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "modificarRuta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "modificarRuta";
            this.Load += new System.EventHandler(this.modificarRuta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPosta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtETA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAtoLlegada;
        private System.Windows.Forms.ComboBox cmbAtoPartida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnChequear;
    }
}