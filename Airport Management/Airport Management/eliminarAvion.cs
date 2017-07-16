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
    public partial class eliminarAvion : Form
    {

        GestionAviones ga = new GestionAviones();
        AccesoDatos ad = new AccesoDatos();
        DataSet ds = new DataSet();

        public eliminarAvion()
        {
            InitializeComponent();
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            

            if ( ga.CodigoExiste(txtCodigo.Text) )
            {
                ds = ga.TraerAvionCodigo(txtCodigo.Text);
                string tipo = ds.Tables[0].Rows[0]["tipo_AV"].ToString();
                string sql = "select fabricante_TA, modelo_TA from tipos_de_aviones where codigo_TA = '" + tipo+ "'";
                ad.cargaTabla("Modelos", sql, ref ds);

                txtFabricante.Text = (ds.Tables["Modelos"].Rows[0]["fabricante_TA"].ToString());
                txtModelo.Text = ds.Tables["Modelos"].Rows[0]["modelo_TA"].ToString();
                btnEliminar.Enabled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ga.eliminarAvion(txtCodigo.Text, ds.Tables["Aviones"].Rows[0]["baja_AV"].ToString());
                if (ds.Tables["Aviones"].Rows[0]["baja_AV"].ToString() == "1")
                {
                    MessageBox.Show("El avión ha sido dado de baja.");
                }
                else
                {
                    MessageBox.Show("El avión ha sido dado de alta.");
                }
            }
            catch 
            {
                MessageBox.Show("No se pudo dar de baja el avión.");
            }
        }
    }
}
