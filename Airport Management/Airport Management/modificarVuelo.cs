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
    public partial class modificarVuelo : Form
    {
        public modificarVuelo()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            GestionVuelos gv = new GestionVuelos();

            try
            {
                if (txtVuelo.Text == "") MessageBox.Show("Debe ingresar un código de vuelo");
                else if (txtVuelo.Text != "" && txtRuta.Text == "") MessageBox.Show("Debe ingresar un código de ruta");



            }

            catch (SyntaxErrorException re)
            {
                MessageBox.Show(re.ToString());
            }
        }
    }
}
