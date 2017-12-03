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
        public InformeAeropuertos()
        {
            InitializeComponent();
        }

        private void InformeAeropuertos_Load(object sender, EventArgs e)
        {
            cmbFIltro.Items.Add("Aeropuertos más utilizados");
            cmbFIltro.Items.Add("Aeropuertos por paises");
            cmbFIltro.Items.Add("Aeropuertos por mes");
        }

        private void btnMostrarInforme_Click(object sender, EventArgs e)
        {
            
        }
    }
}
