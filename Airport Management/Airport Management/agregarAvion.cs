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
            if (!ga.CodigoExiste(txtCodigo.Text) && txtCodigo.TextLength < 11) btnAgregar.Enabled = true;
            else btnAgregar.Enabled = false;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
        }
    }
}
