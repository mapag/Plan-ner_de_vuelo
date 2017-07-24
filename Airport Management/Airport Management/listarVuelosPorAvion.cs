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
            string ClausulaSQL = "SELECT a.codigo_VLO AS Vuelo, d.ATOpartida_RTA AS [Aeropuerto de partida], d.ATOarrivo_RTA AS [Aeropuerto de llegada], d.ETA_RTA AS [Tiempo de vuelo (En horas)], b.fecha_salida_VLO AS [Fecha de partida], a.codigo_AV AS Avion, e.modelo_TA AS Modelo , e.descripcion_TA AS Descripción from VLO_por_AV AS a inner join vuelos AS b ON a.codigo_VLO = b.codigo_VLO inner join aviones AS c ON c.codigo_AV = a.codigo_AV inner join rutas AS d ON d.codigo_RTA = b.codigo_RTA inner join tipos_de_aviones as E ON c.tipo_AV = e.codigo_TA where a.codigo_VLO like '%'";
            ad.IniciarTabla(ClausulaSQL, "Todos", ref dsVLOxAV, ref grdListarVLOxAV);

            CargarComboTexto(ref cmbCodigoVuelo);
            CargarComboTexto(ref cmbCodigoAvion);
            CargarComboNumerico(ref cmbTiempoVuelo);
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            string ClausulaSQL = "SELECT a.codigo_VLO AS Vuelo, d.ATOpartida_RTA AS [Aeropuerto de partida], d.ATOarrivo_RTA AS [Aeropuerto de llegada], d.ETA_RTA AS [Tiempo de vuelo (En horas)], b.fecha_salida_VLO AS [Fecha de partida], a.codigo_AV AS Avion, e.modelo_TA AS Modelo , e.descripcion_TA AS Descripción from VLO_por_AV AS a inner join vuelos AS b ON a.codigo_VLO = b.codigo_VLO inner join aviones AS c ON c.codigo_AV = a.codigo_AV inner join rutas AS d ON d.codigo_RTA = b.codigo_RTA inner join tipos_de_aviones as E ON c.tipo_AV = e.codigo_TA where a.codigo_VLO like '%'";
            ad.IniciarTabla(ClausulaSQL, "Todos", ref dsVLOxAV, ref grdListarVLOxAV);

            cmbCodigoAvion.Text = "";
            cmbCodigoVuelo.Text = "";

            txtCodigoVuelo.Text = "";
            txtCodigoAvion.Text = "";
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string ClausulaSQL = "SELECT a.codigo_VLO AS Vuelo, d.ATOpartida_RTA AS [Aeropuerto de partida], d.ATOarrivo_RTA AS [Aeropuerto de llegada], d.ETA_RTA AS [Tiempo de vuelo (En horas)], b.fecha_salida_VLO AS [Fecha de partida], a.codigo_AV AS Avion, e.modelo_TA AS Modelo , e.descripcion_TA AS Descripción from VLO_por_AV AS a inner join vuelos AS b ON a.codigo_VLO = b.codigo_VLO inner join aviones AS c ON c.codigo_AV = a.codigo_AV inner join rutas AS d ON d.codigo_RTA = b.codigo_RTA inner join tipos_de_aviones as E ON c.tipo_AV = e.codigo_TA where a.codigo_VLO like '%'";
            if (cmbCodigoVuelo.Text != "" && txtCodigoVuelo.Text != "")
                cons.ConstructorConsultaTextual("VLO_por_AV", "a.codigo_VLO", cmbCodigoVuelo.Text, txtCodigoVuelo.Text, ref ClausulaSQL);

            if (cmbCodigoAvion.Text != "" && txtCodigoAvion.Text!= "")
                cons.ConstructorConsultaTextual("VLO_por_AV", "a.codigo_AV", cmbCodigoAvion.Text, txtCodigoAvion.Text, ref ClausulaSQL);

            if (cmbTiempoVuelo.Text != "" && txtTiempoVuelo.Text != "")
                cons.ConstructorConsultaNumerica("VLO_por_AV", "d.ETA_RTA",cmbTiempoVuelo.Text, txtTiempoVuelo.Text, ref ClausulaSQL);

            ad.IniciarTabla(ClausulaSQL, "filtro", ref dsVLOxAV, ref grdListarVLOxAV);
        }
        
    }
}
