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
        public eliminarAvion()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 0 || txtCodigo.Text.Length != 7) MessageBox.Show("Debe ingresar un código válido");

        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            GestionAviones ga = new GestionAviones();
            AccesoDatos ad = new AccesoDatos();
            DataSet ds = new DataSet();

            if ( ga.CodigoExiste(txtCodigo.Text) )
            {
                MessageBox.Show("HPLÑA");
                ds = ga.TraerAvionCodigo(txtCodigo.Text);
                string tipo = ds.Tables[0].Rows[0]["tipo_AV"].ToString();
                string sql = "select fabricante_TA, modelo_TA from tipos_de_aviones where codigo_TA = " + tipo;
                ad.cargaTabla("Modelos", sql, ref ds);

                txtFabricante.Text = ds.Tables["Modelos"].Rows[0]["fabricante_TA"].ToString();
                txtModelo.Text = ds.Tables["Modelos"].Rows[0]["modelo_TA"].ToString();
            }
        }
    }
}
