namespace Airport_Management
{
    partial class listarRutas
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
            this.txtAtoLlegada = new System.Windows.Forms.TextBox();
            this.txtAtoPartida = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAtoLlegada = new System.Windows.Forms.ComboBox();
            this.cmbAtoPartida = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRuta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdListarRutas = new System.Windows.Forms.DataGridView();
            this.txtEta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbEta = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPosta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbPosta = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdListarRutas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(584, 107);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(140, 38);
            this.btnReset.TabIndex = 30;
            this.btnReset.Text = "Mostrar Todo";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtAtoLlegada
            // 
            this.txtAtoLlegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtoLlegada.Location = new System.Drawing.Point(366, 115);
            this.txtAtoLlegada.Margin = new System.Windows.Forms.Padding(2);
            this.txtAtoLlegada.Name = "txtAtoLlegada";
            this.txtAtoLlegada.Size = new System.Drawing.Size(171, 29);
            this.txtAtoLlegada.TabIndex = 29;
            // 
            // txtAtoPartida
            // 
            this.txtAtoPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtoPartida.Location = new System.Drawing.Point(366, 72);
            this.txtAtoPartida.Margin = new System.Windows.Forms.Padding(2);
            this.txtAtoPartida.Name = "txtAtoPartida";
            this.txtAtoPartida.Size = new System.Drawing.Size(171, 29);
            this.txtAtoPartida.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(322, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(322, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = ":";
            // 
            // cmbAtoLlegada
            // 
            this.cmbAtoLlegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAtoLlegada.FormattingEnabled = true;
            this.cmbAtoLlegada.Location = new System.Drawing.Point(172, 113);
            this.cmbAtoLlegada.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAtoLlegada.Name = "cmbAtoLlegada";
            this.cmbAtoLlegada.Size = new System.Drawing.Size(147, 32);
            this.cmbAtoLlegada.TabIndex = 25;
            // 
            // cmbAtoPartida
            // 
            this.cmbAtoPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAtoPartida.FormattingEnabled = true;
            this.cmbAtoPartida.Location = new System.Drawing.Point(172, 73);
            this.cmbAtoPartida.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAtoPartida.Name = "cmbAtoPartida";
            this.cmbAtoPartida.Size = new System.Drawing.Size(147, 32);
            this.cmbAtoPartida.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "ATO de llegada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "ATO de partida";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(584, 67);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(140, 38);
            this.btnFiltrar.TabIndex = 21;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuta.Location = new System.Drawing.Point(366, 30);
            this.txtRuta.Margin = new System.Windows.Forms.Padding(2);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(171, 29);
            this.txtRuta.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(322, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = ":";
            // 
            // cmbRuta
            // 
            this.cmbRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRuta.FormattingEnabled = true;
            this.cmbRuta.Location = new System.Drawing.Point(172, 30);
            this.cmbRuta.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRuta.Name = "cmbRuta";
            this.cmbRuta.Size = new System.Drawing.Size(147, 32);
            this.cmbRuta.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Código de ruta";
            // 
            // grdListarRutas
            // 
            this.grdListarRutas.AllowUserToAddRows = false;
            this.grdListarRutas.AllowUserToDeleteRows = false;
            this.grdListarRutas.AllowUserToResizeColumns = false;
            this.grdListarRutas.AllowUserToResizeRows = false;
            this.grdListarRutas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdListarRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListarRutas.Location = new System.Drawing.Point(6, 247);
            this.grdListarRutas.Margin = new System.Windows.Forms.Padding(2);
            this.grdListarRutas.Name = "grdListarRutas";
            this.grdListarRutas.ReadOnly = true;
            this.grdListarRutas.RowTemplate.Height = 28;
            this.grdListarRutas.Size = new System.Drawing.Size(724, 299);
            this.grdListarRutas.TabIndex = 16;
            // 
            // txtEta
            // 
            this.txtEta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEta.Location = new System.Drawing.Point(366, 156);
            this.txtEta.Margin = new System.Windows.Forms.Padding(2);
            this.txtEta.Name = "txtEta";
            this.txtEta.Size = new System.Drawing.Size(171, 29);
            this.txtEta.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(322, 160);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 24);
            this.label7.TabIndex = 33;
            this.label7.Text = ":";
            // 
            // cmbEta
            // 
            this.cmbEta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEta.FormattingEnabled = true;
            this.cmbEta.Location = new System.Drawing.Point(172, 154);
            this.cmbEta.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEta.Name = "cmbEta";
            this.cmbEta.Size = new System.Drawing.Size(147, 32);
            this.cmbEta.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 156);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 24);
            this.label8.TabIndex = 31;
            this.label8.Text = "ETA";
            // 
            // txtPosta
            // 
            this.txtPosta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosta.Location = new System.Drawing.Point(366, 197);
            this.txtPosta.Margin = new System.Windows.Forms.Padding(2);
            this.txtPosta.Name = "txtPosta";
            this.txtPosta.Size = new System.Drawing.Size(171, 29);
            this.txtPosta.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(322, 201);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 24);
            this.label9.TabIndex = 37;
            this.label9.Text = ":";
            // 
            // cmbPosta
            // 
            this.cmbPosta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPosta.FormattingEnabled = true;
            this.cmbPosta.Location = new System.Drawing.Point(172, 195);
            this.cmbPosta.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPosta.Name = "cmbPosta";
            this.cmbPosta.Size = new System.Drawing.Size(147, 32);
            this.cmbPosta.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 197);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 24);
            this.label10.TabIndex = 35;
            this.label10.Text = "POSTA";
            // 
            // listarRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(737, 554);
            this.Controls.Add(this.txtPosta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbPosta);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbEta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtAtoLlegada);
            this.Controls.Add(this.txtAtoPartida);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbAtoLlegada);
            this.Controls.Add(this.cmbAtoPartida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbRuta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdListarRutas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "listarRutas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "listarRuta";
            this.Load += new System.EventHandler(this.listarRutas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdListarRutas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtAtoLlegada;
        private System.Windows.Forms.TextBox txtAtoPartida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAtoLlegada;
        private System.Windows.Forms.ComboBox cmbAtoPartida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRuta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdListarRutas;
        private System.Windows.Forms.TextBox txtEta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbEta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPosta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbPosta;
        private System.Windows.Forms.Label label10;

    }
}