using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airport_Management.Clases;

namespace Airport_Management
{
    public partial class recuperarBD : Form
    {
        AccesoDatos ad = new AccesoDatos();
        DataSet ds = new DataSet();
        public recuperarBD()
        {
            InitializeComponent();
        }

        private void recuperarBD_Load(object sender, EventArgs e)
        {
            ad.IniciarTabla("select fecha_bkp as fecha, direccion_bkp as direccion from backups", "bk", ref ds, ref grd_backups);
            grd_backups.AutoResizeColumns();
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            string consultaSQL = "USE master RESTORE DATABASE Airport_Manager FROM  DISK = '" + grd_backups.CurrentRow.Cells["direccion"].Value +"'";
            ad.rutaMaster();
            ad.EjecutarConsulta(consultaSQL);
            MessageBox.Show("Se ha recuperado la Base de datos");
            ad.rutaAirportManager();
            this.Close();
        }
    }
}
