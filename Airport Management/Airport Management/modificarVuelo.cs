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
    public partial class modificarVuelo : Form
    {
        AccesoDatos ad = new AccesoDatos();
        DataSet ds;
        GestionVuelos gv;
        public modificarVuelo()
        {
            InitializeComponent();
        }

        private void activarcampos(bool estado)
        {
            cmb_Ruta.Enabled = estado;
            timer_Fecha.Enabled = estado;
            btnModificar.Enabled = estado;
        }

        private void modificarVuelo_Load(object sender, EventArgs e)
        {
            ad.AgregaraComboBox("select codigo_RTA from rutas", ref cmb_Ruta);
            timer_Fecha.Format = DateTimePickerFormat.Custom;
            timer_Fecha.CustomFormat = "dd'/'MM'/'yy 'a las ' HH:mm:ss 'Horas' ";
            //activarcampos(false);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            GestionVuelos gv = new  GestionVuelos();
            if (txt_Codigo.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar código de vuelo");
            }
            else if (!gv.VueloExiste(txt_Codigo.Text))
            {
                MessageBox.Show("El vuelvo ingresado no existe");
                txt_Codigo.Text = "";
            }
            string prov = timer_Fecha.Value.ToString();
            string[] fecha = prov.Split();
            if (fecha[2] == "a.m.") fecha[2] = "am";
            else fecha[2] = "pm";

            string consultaSQL = "update vuelos set codigo_RTA = '" + cmb_Ruta.Text + "', fecha_salida_VLO = '" + fecha[0] + " " + fecha[1] + " " + fecha[2] + "' where codigo_VLO = '" + txt_Codigo.Text + "'";
            ad.EjecutarConsulta(consultaSQL);
            MessageBox.Show("Vuelo modificado con éxito");
            cmb_Ruta.Text = "";
            txt_Codigo.Text = "";
        }

        private void txt_Codigo_TextChanged(object sender, EventArgs e)
        {
            gv = new GestionVuelos();
            ds = new DataSet();
            if (gv.VueloExiste(txt_Codigo.Text))
            {
                ad.cargaTabla("vuelo", "select * from vuelos where codigo_VLO = '" + txt_Codigo.Text + "'", ref ds);
                timer_Fecha.Text = ds.Tables["vuelo"].Rows[0]["fecha_salida_VLO"].ToString();
                cmb_Ruta.Text = ds.Tables["vuelo"].Rows[0]["codigo_RTA"].ToString();
                activarcampos(true);
            }
            //else activarcampos(false);
        }
    }
}
