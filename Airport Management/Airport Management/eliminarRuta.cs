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
    public partial class eliminarRuta : Form
    {
        AccesoDatos ad = new AccesoDatos();
        GestionRutas gr = new GestionRutas();
        public eliminarRuta()
        {
            InitializeComponent();
        }

        private void eliminarRuta_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            btnEliminar.Enabled = true;
            if (txtCodigo.Text == "") btnEliminar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gr.CodigoExiste(txtCodigo.Text))
            {
                bool aux = gr.eliminarRuta(txtCodigo.Text);

                if (aux) MessageBox.Show("La ruta se ha borrado con exito");
            }
           
            else MessageBox.Show("La ruta ingresada no existe");
        }
    }
}
