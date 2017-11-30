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
            btnEliminar.Enabled = true;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            //if (txtCodigo.Text == "") btnEliminar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigo.Text == "")
                {
                    MessageBox.Show("Debe ingresar código de ruta");
                }

                else if (gr.CodigoExiste(txtCodigo.Text))
                {
                    bool aux = gr.eliminarRuta(txtCodigo.Text);

                    if (aux) MessageBox.Show("La ruta se ha borrado con exito");
                }

                else MessageBox.Show("La ruta ingresada no existe");
            }

            catch
            {
                MessageBox.Show("No se puede borrar, la ruta está siendo utilizada");
            }
        }
    }
}
