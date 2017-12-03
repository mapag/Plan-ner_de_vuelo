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
    public partial class InformeVuelos : Form
    {
        AccesoDatos ad = new AccesoDatos();
        DataSet dsInformes = new DataSet();
        DataSet dsVuelos = new DataSet();
        public InformeVuelos()
        {
            InitializeComponent();
        }

        private void InformeVuelos_Load(object sender, EventArgs e)
        {
            cmbFIltro.Items.Add("Rutas mas transitadas");
            cmbFIltro.Items.Add("Rutas mas transitadas este mes");
        }
        private void btnMostrarInforme_Click(object sender, EventArgs e)
        {
            if (cmbFIltro.Text == "Rutas mas transitadas") RutasTransitadas();
            if (cmbFIltro.Text == "Rutas mas transitadas este mes") RutasTransitadasMes();
        }

        private void RutasTransitadas()
        {
            string ClausulaSQL = "select COUNT(distinct codigo_RTA) as Cantidad, codigo_RTA as 'codigo ruta' from vuelos group by vuelos.codigo_RTA";
            ad.IniciarTabla(ClausulaSQL, "Todos", ref dsVuelos, ref grdInformeVuelos);
        }
        private void RutasTransitadasMes()
        {
            string ClausulaSQL = "select COUNT(distinct codigo_RTA) as Cantidad, codigo_RTA as 'codigo ruta' from vuelos WHERE MONTH(fecha_salida_VLO) > MONTH(GETDATE()) - 1 and fecha_salida_VLO < GETDATE() group by vuelos.codigo_RTA";
            ad.IniciarTabla(ClausulaSQL, "Todos", ref dsVuelos, ref grdInformeVuelos);
        }

       
    }
}
