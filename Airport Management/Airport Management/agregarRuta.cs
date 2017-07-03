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
    public partial class agregarRuta : Form
    {
        AccesoDatos ad = new AccesoDatos();
        GestionRutas gr = new GestionRutas();
        public agregarRuta()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                gr.AgregarRuta(cmbAtoPartida.Text, cmbAtoLlegada.Text, Int32.Parse(txtETA.Text), Int32.Parse(txtPosta.Text));         
                
            }
            catch (SyntaxErrorException re)
            {
                MessageBox.Show(re.ToString());
            }
            
        }

        private void agregarRuta_Load(object sender, EventArgs e)
        {
            ad.AgregaraComboBox("select distinct codigo_ATO from aeropuertos", ref cmbAtoPartida);
            ad.AgregaraComboBox("select distinct codigo_ATO from aeropuertos", ref cmbAtoLlegada);
            btnAgregar.Enabled = false;
        }

        private void cmbAtoPartida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAtoPartida.Text == cmbAtoLlegada.Text && cmbAtoLlegada.Text.Length != 0)
            {
                MessageBox.Show("El aeropuerto de partida y el de llegada no pueden ser los mismos");
            }  
        }

        private void cmbAtoLlegada_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAtoPartida.Text == cmbAtoLlegada.Text && cmbAtoLlegada.Text.Length != 0)
            {
                MessageBox.Show("El aeropuerto de partida y el de llegada no pueden ser los mismos"); 
            }
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

        private void txtETA_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtPosta_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtPosta_TextChanged(object sender, EventArgs e)
        {
            if (txtETA.Text == "" || txtPosta.Text == "") btnAgregar.Enabled = false;
            else btnAgregar.Enabled = true;
        }

        private void txtETA_TextChanged(object sender, EventArgs e)
        {
            if (txtETA.Text == "" || txtPosta.Text == "") btnAgregar.Enabled = false;
            else btnAgregar.Enabled = true;
        }
    }
}
