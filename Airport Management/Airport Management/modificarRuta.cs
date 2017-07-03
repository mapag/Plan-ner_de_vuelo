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
            ad.AgregaraComboBox("select distinct codigo_ATO from aeropuertos", ref cmbAtoPartida);
            ad.AgregaraComboBox("select distinct codigo_ATO from aeropuertos", ref cmbAtoLlegada);
            btnModificar.Enabled = false;
            btnChequear.Enabled = false;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            btnChequear.Enabled = true;
            if (txtCodigo.Text == "") btnChequear.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e) // button1 es btnChequear
        {
            if (gr.CodigoExiste(txtCodigo.Text))
            {
                btnModificar.Enabled = true;
            }

            else MessageBox.Show("La ruta ingresada no existe");
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            bool aux = gr.modificarRuta(txtCodigo.Text, cmbAtoPartida.Text, cmbAtoLlegada.Text, Int32.Parse(txtETA.Text), Int32.Parse(txtPosta.Text));

            if (aux) MessageBox.Show("La ruta se ha modificado con exito");
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
            if (cmbAtoPartida.Text == cmbAtoLlegada.Text && cmbAtoLlegada.Text.Length != 0)
            {
                MessageBox.Show("El aeropuerto de partida y el de llegada no pueden ser los mismos");
                btnModificar.Enabled = false;
            }

            else btnModificar.Enabled = true;
        }

        private void cmbAtoLlegada_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAtoPartida.Text == cmbAtoLlegada.Text && cmbAtoLlegada.Text.Length != 0)
            {
                MessageBox.Show("El aeropuerto de partida y el de llegada no pueden ser los mismos");
                btnModificar.Enabled = false;
            }

            else btnModificar.Enabled = true;
        }
    }
}
