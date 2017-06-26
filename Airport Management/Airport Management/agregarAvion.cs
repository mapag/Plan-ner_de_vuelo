using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Airport_Management.Clases;

namespace Airport_Management
{
    public partial class agregarAvion : Form
    {
        AccesoDatos ad = new AccesoDatos();
        GestionAviones ga = new GestionAviones();
        
        public void enabilizador(){
            GestionAviones ga = new GestionAviones();
            string texto ="";
            int i = 0;
            if (txtCodigo.TextLength != 7){
                i++;
                texto += "El codigo debe tener 7 carácteres. ";
            }
            else if('A' > txtCodigo.Text[0] || txtCodigo.Text[0] > 'Z' ||
               'A' > txtCodigo.Text[1] || txtCodigo.Text[1] > 'Z' ||
               'A' > txtCodigo.Text[2] || txtCodigo.Text[2] > 'Z' ||
               txtCodigo.Text[3] != '-' ||
               '0' > txtCodigo.Text[4] || txtCodigo.Text[4] > '9' ||
               '0' > txtCodigo.Text[5] || txtCodigo.Text[5] > '9' ||
               '0' > txtCodigo.Text[6] || txtCodigo.Text[6] > '9'
                )
            {
                i++;
                texto += "El formato de codigo es 3 letras mayusculas, un guion '-' y 3 numeros. ";
            }

            if (ga.CodigoExiste(txtCodigo.Text))
            {
                i++;
                texto += "El codigo de avión ya existe. ";
            }

            if (cmb_fabricante.Text == "" || cmb_modelo.Text == "") i++;
            
            if (i == 0) btnAgregar.Enabled = true;
            else
            {
                if (cmb_fabricante.Text != "" || cmb_modelo.Text != "") MessageBox.Show(texto);
                btnAgregar.Enabled = false;
            }
        }

        public agregarAvion()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ga.AgregarAvion(txtCodigo.Text, cmb_fabricante.Text, cmb_modelo.Text);
            }
            catch(SyntaxErrorException re)
            {
                MessageBox.Show(re.ToString());
            }
            txtCodigo.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmb_fabricante_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_modelo.Items.Clear();
            string ConsultaSQL = "select modelo_TA from tipos_de_aviones where fabricante_TA = '" + cmb_fabricante.Text + "'";
            ad.AgregaraComboBox(ConsultaSQL, ref cmb_modelo);
        }

        private void agregarAvion_Load(object sender, EventArgs e)
        {
            ad.AgregaraComboBox("select distinct fabricante_TA from tipos_de_aviones", ref cmb_fabricante);
            btnAgregar.Enabled = false;
        }

        private void cmb_modelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            enabilizador();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            enabilizador();
        }
    }
}
