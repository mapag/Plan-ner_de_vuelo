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
    public partial class listarTripulantes : Form
    {
        DataSet dsVuelos;
        public listarTripulantes()
        {
            InitializeComponent();
        }

        private void listarTripulantes_Load(object sender, EventArgs e)
        {
            AccesoDatos ad = new AccesoDatos();
            dsVuelos = new DataSet();
            string ClausulaSQL = "select a.legajo_tcp  from tripulantes a ";
            ad.IniciarTabla(ClausulaSQL, "Todos", ref dsVuelos, ref grdTripulantes);
        }
    }
}
