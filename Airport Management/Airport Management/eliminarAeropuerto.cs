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
    public partial class eliminarAeropuerto : Form
    {
        GestionAeropuertos ga = new GestionAeropuertos();
        public eliminarAeropuerto()
        {
            InitializeComponent();
        }

        private void eliminarAeropuerto_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!ga.CodigoExiste(txtCodigo.Text))
            {
                btnEliminar.Enabled = false;
                MessageBox.Show("El codigo ingresado no existe");
            }

            else
            {
                try
                {
                    ga.eliminarAeropuerto(txtCodigo.Text);
                }

                catch (System.Exception)
                {
                    MessageBox.Show("El aeropuerto está siendo utilizado, no se puede borrar");
                }
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length !=0) btnEliminar.Enabled = true;
        }
    }
}
