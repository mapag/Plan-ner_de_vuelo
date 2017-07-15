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
    public partial class listarVuelos : Form
    {
        DataSet dsVuelos;
        ConstructorCodSQL cons = new ConstructorCodSQL();
        AccesoDatos ad = new AccesoDatos();
        public listarVuelos()
        {
            InitializeComponent();
        }

        private void listarVuelos_Load(object sender, EventArgs e)
        {

            reiniciarTabla();

            cons.CargarComboTexto(ref cmbCodigo);
            cons.CargarComboTexto(ref cmbRuta);
            cons.CargarComboTiempo(ref cmbFecha);
        }

        private void reiniciarTabla(){
            dsVuelos = new DataSet();
            string consultaSQL = "select codigo_VLO as Código, codigo_RTA as Ruta, fecha_salida_VLO as [Fecha de salida] from vuelos";
            ad.IniciarTabla(consultaSQL, "Vuelos", ref dsVuelos, ref grdListarVuelos);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string consultaSQL = "select codigo_VLO as Código, codigo_RTA as Ruta, fecha_salida_VLO as [Fecha de salida] from vuelos where codigo_VLO like '%'";
            dsVuelos = new DataSet();
            if (!txtCodigo.Text.Equals("") && !cmbCodigo.Text.Equals(""))
            {
                cons.ConstructorConsultaTextual("vuelos", "codigo_VLO", cmbCodigo.Text, txtCodigo.Text, ref consultaSQL);
            }
            if (!txtRuta.Text.Equals("") && !cmbRuta.Text.Equals(""))
            {
                cons.ConstructorConsultaTextual("vuelos", "codigo_RTA", cmbRuta.Text, txtRuta.Text, ref consultaSQL);
            }
            if (!cmbFecha.Text.Equals(""))
            {
                string prov = timer_Fecha.Value.ToString();
                string[] fecha = prov.Split();
                if (fecha[2] == "a.m.") fecha[2] = "am";
                else fecha[2] = "pm";

                cons.ConstructorConsultaTemporal("vuelos", "fecha_salida_VLO", cmbFecha.Text, fecha[0] + " " + fecha[1] + " " + fecha[2], ref consultaSQL);
            }
            ad.IniciarTabla(consultaSQL, "Vuelos", ref dsVuelos, ref grdListarVuelos);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reiniciarTabla();
        }
    }
}
