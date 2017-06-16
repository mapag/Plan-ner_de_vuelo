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
    public partial class listarAviones : Form
    {
        public listarAviones()
        {
            InitializeComponent();
        }

        private void listarAviones_Load(object sender, EventArgs e)
        {

            DataSet dsAviones = new DataSet();
            GestionAviones ga = new GestionAviones();
            ga.listarAviones("Productos", ref dsAviones);
            grdListarAviones.DataSource = dsAviones.Tables["Productos"];

        }
    }
}
