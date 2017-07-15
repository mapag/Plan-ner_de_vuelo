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
    public partial class eliminarVuelo : Form
    {
        public eliminarVuelo()
        {
            InitializeComponent();
        }
        AccesoDatos ad = new AccesoDatos();
        GestionVuelos gv;
        private void btnModificar_Click(object sender, EventArgs e)
        {
            ad.EjecutarConsulta("delete from vuelos where codigo_VLO = '" + txtCodigo.Text + "'");
            txtCodigo.Text = "";
        }

        private void eliminarVuelo_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            gv = new GestionVuelos();
            if (gv.VueloExiste(txtCodigo.Text))
            {
                btnEliminar.Enabled = true;
            }
            else btnEliminar.Enabled = false;
        }
    }
}
