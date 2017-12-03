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
    public partial class InformeAviones : Form
    {
        AccesoDatos ad = new AccesoDatos();
        DataSet dsInformes = new DataSet();
        DataSet dsAviones = new DataSet();
        public InformeAviones()
        {
            InitializeComponent();
        }

        private void InformeAviones_Load(object sender, EventArgs e)
        {
            cmbFIltro.Items.Add("Rutas recorridas por avión");
            cmbFIltro.Items.Add("Rutas recorridas por avión este mes");
        }

        private void btnMostrarInforme_Click(object sender, EventArgs e)
        {
            if (cmbFIltro.Text == "Rutas recorridas por avión") RutaxAvion();
            if (cmbFIltro.Text == "Rutas recorridas por avión este mes") RutaxAvionMes();
        }

        private void RutaxAvion()
        {
            string ClausulaSQL = "select a.codigo_AV as 'codigo del avión', v.codigo_RTA as ruta, v.fecha_salida_VLO  as fecha, r.ETA_RTA as 'Duracion vuelo' from aviones a inner join VLO_por_AV va on a.codigo_AV = va.codigo_AV inner join vuelos v on va.codigo_VLO = v.codigo_VLO inner join rutas r on v.codigo_RTA = r.codigo_RTA";            
            ad.IniciarTabla(ClausulaSQL, "Todos", ref dsAviones, ref grdInformeAviones);
        }

        private void RutaxAvionMes()
        {
            string ClausulaSQL = "select a.codigo_AV as 'codigo del avión', v.codigo_RTA as ruta, v.fecha_salida_VLO  as fecha, r.ETA_RTA as 'Duracion vuelo (horas)' from aviones a inner join VLO_por_AV va on a.codigo_AV = va.codigo_AV inner join vuelos v on va.codigo_VLO = v.codigo_VLO inner join rutas r on v.codigo_RTA = r.codigo_RTA WHERE MONTH(v.fecha_salida_VLO) > MONTH(GETDATE()) - 1 and v.fecha_salida_VLO < GETDATE()";
            ad.IniciarTabla(ClausulaSQL, "Todos", ref dsAviones, ref grdInformeAviones);
        }

    }
}
