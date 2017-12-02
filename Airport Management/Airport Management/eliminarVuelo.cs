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
        DataSet ds = new DataSet();
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                gv = new GestionVuelos();
                
                if (txtCodigo.Text.Length == 0)
                {
                    MessageBox.Show("Debe ingresar código de vuelo");
                }
                else if (!gv.VueloExiste(txtCodigo.Text))
                {
                    MessageBox.Show("El vuelvo ingresado no existe");
                    txtCodigo.Text = "";
                }

                else
                {
                    ad.EjecutarConsulta("delete from vuelos where codigo_VLO = '" + txtCodigo.Text + "'");
                    txtCodigo.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("El vuelo no se puede eliminar, se encuentra activo en el plan de vuelo");
            }
        }

        private void eliminarVuelo_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = true;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            gv = new GestionVuelos();
            if (gv.VueloExiste(txtCodigo.Text))
            {
                ds = gv.TraerVueloCodigo(txtCodigo.Text);

                txtSalida.Text = (ds.Tables["Vuelos"].Rows[0]["codigo_RTA"].ToString());
            }
            else
            {
                txtSalida.Text = "No existe";
            }
        }
    }
}
