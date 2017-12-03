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
    public partial class InformeAeropuertos : Form
    {
        AccesoDatos ad = new AccesoDatos();
        DataSet dsInformes = new DataSet();
        DataSet dsAeropuerto = new DataSet();
        public InformeAeropuertos()
        {
            InitializeComponent();
        }

        private void InformeAeropuertos_Load(object sender, EventArgs e)
        {
            cmbFIltro.Items.Add("Aeropuertos por arrivo");
            cmbFIltro.Items.Add("Aeropuertos por partida");
            cmbFIltro.Items.Add("Aeropuertos por arrivo este mes");
            cmbFIltro.Items.Add("Aeropuertos por partida este mes");
        }

        private void btnMostrarInforme_Click(object sender, EventArgs e)
        {
            if (cmbFIltro.Text == "Aeropuertos por arrivo") AeropxArrivo();
            if (cmbFIltro.Text == "Aeropuertos por partida") AeropxPartida();
            if (cmbFIltro.Text == "Aeropuertos por arrivo este mes") AeropxArrivoMes();
            if (cmbFIltro.Text == "Aeropuertos por partida este mes") AeropxPartidaoMes();
        }

        private void AeropxArrivo()
        {
            string ClausulaSQL = "select a.nombre_ATO as nombre, a.pais_ATO as pais, a.provincia_ATO as provincia, COUNT(v.codigo_VLO) as cantidad from vuelos v inner join rutas r on v.codigo_RTA = r.codigo_RTA inner join aeropuertos a on a.codigo_ATO = r.ATOarrivo_RTA group by a.nombre_ATO, a.pais_ATO, a.provincia_ATO";
            ad.IniciarTabla(ClausulaSQL, "Todos", ref dsAeropuerto, ref grdInformeAeropuertos);
        }
        private void AeropxPartida()
        {
            string ClausulaSQL = "select a.nombre_ATO as nombre, a.pais_ATO as pais, a.provincia_ATO as provincia, COUNT(v.codigo_VLO) as cantidad from vuelos v inner join rutas r on v.codigo_RTA = r.codigo_RTA inner join aeropuertos a on a.codigo_ATO = r.ATOpartida_RTA group by a.nombre_ATO, a.pais_ATO, a.provincia_ATO";
            ad.IniciarTabla(ClausulaSQL, "Todos", ref dsAeropuerto, ref grdInformeAeropuertos);
        }
        private void AeropxArrivoMes()
        {
            string ClausulaSQL = "select a.nombre_ATO as nombre, a.pais_ATO as pais, a.provincia_ATO as provincia, COUNT(v.codigo_VLO) as cantidad from vuelos v inner join rutas r on v.codigo_RTA = r.codigo_RTA inner join aeropuertos a on a.codigo_ATO = r.ATOarrivo_RTA WHERE MONTH(v.fecha_salida_VLO) > MONTH(GETDATE()) - 1 and v.fecha_salida_VLO < GETDATE() group by a.nombre_ATO, a.pais_ATO, a.provincia_ATO";
            ad.IniciarTabla(ClausulaSQL, "Todos", ref dsAeropuerto, ref grdInformeAeropuertos);
        }
        private void AeropxPartidaoMes()
        {
            string ClausulaSQL = "select a.nombre_ATO as nombre, a.pais_ATO as pais, a.provincia_ATO as provincia, COUNT(v.codigo_VLO) as cantidad from vuelos v inner join rutas r on v.codigo_RTA = r.codigo_RTA inner join aeropuertos a on a.codigo_ATO = r.ATOpartida_RTA WHERE MONTH(v.fecha_salida_VLO) > MONTH(GETDATE()) - 1 and v.fecha_salida_VLO < GETDATE() group by a.nombre_ATO, a.pais_ATO, a.provincia_ATO";
            ad.IniciarTabla(ClausulaSQL, "Todos", ref dsAeropuerto, ref grdInformeAeropuertos);
        }
    }
}
