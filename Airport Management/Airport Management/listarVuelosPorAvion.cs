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
    public partial class listarVuelosPorAvion : Form
    {

        DataSet dsVLOxAV = new DataSet();
        ConstructorCodSQL cons = new ConstructorCodSQL();
        AccesoDatos ad = new AccesoDatos();
        public listarVuelosPorAvion()
        {
            InitializeComponent();
        }

        private void listarVuelosPorAvion_Load(object sender, EventArgs e)
        {
            string ClausulaSQL = "select a.codigo_VLO as Vuelo, a.codigo_AV as Avion from VLO_por_AV AS a where a.codigo_VLO like '%'";
            ad.IniciarTabla(ClausulaSQL, "Todos", ref dsVLOxAV, ref grdListarVLOxAV);

            CargarComboTexto(ref cmbCodigoVuelo);
            CargarComboTexto(ref cmbCodigoAvion);
        }

        private void CargarComboTexto(ref ComboBox NombreCombo)
        {
            NombreCombo.Items.Add("Comienza con");
            NombreCombo.Items.Add("Termina en");
            NombreCombo.Items.Add("Contiene");
            NombreCombo.Items.Add("Es igual a");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string ClausulaSQL = "select a.codigo_VLO as Vuelo, a.codigo_AV as Avion from VLO_por_AV AS a where a.codigo_VLO like '%'";
            ad.IniciarTabla(ClausulaSQL, "Todos", ref dsVLOxAV, ref grdListarVLOxAV);

            cmbCodigoAvion.Text = "";
            cmbCodigoVuelo.Text = "";

            txtCodigoVuelo.Text = "";
            txtCodigoAvion.Text = "";
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string ClausulaSQL = "select a.codigo_VLO as Vuelo, a.codigo_AV as Avion from VLO_por_AV AS a where a.codigo_VLO like '%'";
            if (cmbCodigoVuelo.Text != "" && txtCodigoVuelo.Text != "")
                cons.ConstructorConsultaTextual("VLO_por_AV", "a.codigo_VLO", cmbCodigoVuelo.Text, txtCodigoVuelo.Text, ref ClausulaSQL);

            if (cmbCodigoAvion.Text != "" && txtCodigoAvion.Text!= "")
                cons.ConstructorConsultaTextual("VLO_por_AV", "a.codigo_AV", cmbCodigoAvion.Text, txtCodigoAvion.Text, ref ClausulaSQL);

            ad.IniciarTabla(ClausulaSQL, "filtro", ref dsVLOxAV, ref grdListarVLOxAV);
        }
        
    }
}
