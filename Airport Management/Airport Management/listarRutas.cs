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
    public partial class listarRutas : Form
    {

        DataSet dsRutas = new DataSet();
        ConstructorCodSQL cons = new ConstructorCodSQL();
        AccesoDatos ad = new AccesoDatos();

        public listarRutas()
        {
            InitializeComponent();
        }
        private void listarRutas_Load(object sender, EventArgs e)
        {
            string ClausulaSQL = "select a.codigo_RTA as Codigo, a.ATOpartida_RTA as 'ATO de partida', a.ATOarrivo_RTA as 'ATO de llegada', a.ETA_RTA as 'Tiempo de vuelo', a.posta_RTA as 'Tiempo de descanso' from rutas a  where a.codigo_RTA like '%'";
            ad.IniciarTabla(ClausulaSQL, "Todos", ref dsRutas, ref grdListarRutas);

            CargarComboTexto(ref cmbRuta);
            CargarComboTexto(ref cmbAtoPartida);
            CargarComboTexto(ref cmbAtoLlegada);
            CargarComboNumerico(ref cmbEta);
            CargarComboNumerico(ref cmbPosta);
        }

        private void CargarComboTexto(ref ComboBox NombreCombo)
        {
            NombreCombo.Items.Add("Comienza con");
            NombreCombo.Items.Add("Termina en");
            NombreCombo.Items.Add("Contiene");
            NombreCombo.Items.Add("Es igual a");
        }
        private void CargarComboNumerico(ref ComboBox NombreCombo)
        {
            NombreCombo.Items.Add("Igual a:");
            NombreCombo.Items.Add("Mayor a:");
            NombreCombo.Items.Add("Menor a:");
            NombreCombo.Items.Add("Mayor o igual a");
            NombreCombo.Items.Add("Menor o igual a");
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string ClausulaSQL = "select a.codigo_RTA as Codigo, a.ATOpartida_RTA as 'ATO de partida', a.ATOarrivo_RTA as 'ATO de llegada', a.ETA_RTA as 'Tiempo de vuelo', a.posta_RTA as 'Tiempo de descanso' from rutas a  where a.codigo_RTA like '%'";

            if (cmbRuta.Text != "" && txtRuta.Text != "")
                cons.ConstructorConsultaTextual("rutas", "a.codigo_RTA", cmbRuta.Text, txtRuta.Text, ref ClausulaSQL);

            if (cmbAtoPartida.Text != "" && txtAtoPartida.Text != "")
                cons.ConstructorConsultaTextual("rutas", "a.ATOpartida_RTA", cmbAtoPartida.Text, txtAtoPartida.Text, ref ClausulaSQL);

            if (cmbAtoLlegada.Text != "" && txtAtoLlegada.Text != "")
                cons.ConstructorConsultaTextual("rutas", "a.ATOarrivo_RTA", cmbAtoLlegada.Text, txtAtoLlegada.Text, ref ClausulaSQL);

            if (cmbEta.Text != "" && txtEta.Text != "")
                cons.ConstructorConsultaNumerica("rutas", "a.ETA_RTA", cmbEta.Text, txtEta.Text, ref ClausulaSQL);

            if (cmbPosta.Text != "" && txtPosta.Text != "")
                cons.ConstructorConsultaNumerica("rutas", "a.posta_RTA", cmbPosta.Text, txtPosta.Text, ref ClausulaSQL);

            ad.IniciarTabla(ClausulaSQL, "filtro", ref dsRutas, ref grdListarRutas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string ClausulaSQL = "select a.codigo_RTA as Codigo, a.ATOpartida_RTA as 'ATO de partida', a.ATOarrivo_RTA as 'ATO de llegada', a.ETA_RTA as 'Tiempo de vuelo', a.posta_RTA as 'Tiempo de descanso' from rutas a  where a.codigo_RTA like '%'";
            ad.IniciarTabla(ClausulaSQL, "Todos", ref dsRutas, ref grdListarRutas);
            
            cmbRuta.Text = "";
            cmbAtoPartida.Text = "";
            cmbAtoLlegada.Text = "";
            cmbEta.Text = "";
            cmbPosta.Text = "";
            
            txtRuta.Text = "";
            txtAtoPartida.Text = "";
            txtAtoLlegada.Text = "";
            txtEta.Text = "";
            txtPosta.Text = "";
        }
        
    }
}
