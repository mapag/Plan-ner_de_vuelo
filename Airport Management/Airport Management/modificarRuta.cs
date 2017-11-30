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
    public partial class modificarRuta : Form
    {
        AccesoDatos ad = new AccesoDatos();
        GestionRutas gr = new GestionRutas();
        public modificarRuta()
        {
            InitializeComponent();
        }

        private void modificarRuta_Load(object sender, EventArgs e)
        {
            ad.AgregaraComboBox("select distinct codigo_RTA from rutas", ref cmbCodigo);
            btnModificar.Enabled = true;

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // button1 es btnChequear
        {

        }


        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (cmbCodigo.Text != "")
            {
                bool aux = gr.modificarRuta(cmbCodigo.Text, Int32.Parse(txtETA.Text), Int32.Parse(txtPosta.Text));

                if (aux) MessageBox.Show("La ruta se ha modificado con exito");
            }
            else
                MessageBox.Show("Debe ingresar un código de ruta");
        }

        private void txtETA_Validated(object sender, EventArgs e)
        {

        }

        private void txtETA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 47 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtPosta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 47 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void cmbAtoPartida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbAtoLlegada_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            if (gr.CodigoExiste(cmbCodigo.Text))
            {
                ds = gr.TraerRutaCodigo(cmbCodigo.Text);
                txtETA.Text = (ds.Tables["Rutas"].Rows[0]["ETA_RTA"].ToString());
                txtPosta.Text = ds.Tables["Rutas"].Rows[0]["posta_RTA"].ToString();
                btnModificar.Enabled = true;

            }
        }

        private void cmbCodigo_Leave(object sender, EventArgs e)
        {

        }

        private void txtETA_Leave(object sender, EventArgs e)
        {
            if (txtETA.Text == "" || txtPosta.Text == "") btnModificar.Enabled = false;
            else btnModificar.Enabled = true;
        }

        private void txtPosta_Leave(object sender, EventArgs e)
        {
            if (txtETA.Text == "" || txtPosta.Text == "") btnModificar.Enabled = false;
            else btnModificar.Enabled = true;
        }
    }
}
