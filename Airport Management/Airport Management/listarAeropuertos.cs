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
    public partial class listarAeropuertos : Form
    {
        DataSet dsAeropuertos = new DataSet();
        ConstructorCodSQL cons = new ConstructorCodSQL();
        AccesoDatos ad = new AccesoDatos();
        public listarAeropuertos()
        {
            InitializeComponent();
        }

        private void listarAeropuertos_Load(object sender, EventArgs e)
        {
            CargarComboTexto(ref cmbCodigo);
            CargarComboTexto(ref cmbNombre);
            CargarComboTexto(ref cmbProvincia);
            CargarComboTexto(ref cmbPais);
            
            string ClausulaSQL = "SELECT a.codigo_ATO AS 'Codigo de aeropuerto', a.nombre_ATO AS Nombre, a.provincia_ATO AS Provincia, a.pais_ATO AS Pais  from aeropuertos AS a where codigo_ATO like '%'";
            ad.IniciarTabla(ClausulaSQL, "Todos", ref dsAeropuertos, ref grdListarAeropuertos);
          
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
            string ClausulaSQL = "SELECT a.codigo_ATO AS 'Codigo de aeropuerto', a.nombre_ATO AS Nombre, a.provincia_ATO AS Provincia, a.pais_ATO AS Pais  from aeropuertos AS a where codigo_ATO like '%'";
            ad.IniciarTabla(ClausulaSQL, "Todos", ref dsAeropuertos, ref grdListarAeropuertos);

            cmbCodigo.Text = "";
            cmbNombre.Text = "";
            cmbProvincia.Text = "";
            cmbPais.Text = "";

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtProvincia.Text = "";
            txtPais.Text = "";
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string ClausulaSQL = "SELECT a.codigo_ATO AS 'Codigo de aeropuerto', a.nombre_ATO AS Nombre, a.provincia_ATO AS Provincia, a.pais_ATO AS Pais  from aeropuertos AS a where codigo_ATO like '%'";

            if (cmbCodigo.Text != "" && txtCodigo.Text != "")
                cons.ConstructorConsultaTextual("aeropuertos", "a.codigo_ATO", cmbCodigo.Text, txtCodigo.Text, ref ClausulaSQL);

            if (cmbNombre.Text != "" && txtNombre.Text != "")
                cons.ConstructorConsultaTextual("aeropuertos", "a.nombre_ATO", cmbNombre.Text, txtNombre.Text, ref ClausulaSQL);

            if (cmbProvincia.Text != "" && txtProvincia.Text != "")
                cons.ConstructorConsultaTextual("aeropuertos", "a.provincia_ATO", cmbProvincia.Text, txtProvincia.Text, ref ClausulaSQL);

            if (cmbPais.Text != "" && txtPais.Text != "")
                cons.ConstructorConsultaTextual("aeropuertos", "a.pais_ATO", cmbPais.Text, txtPais.Text, ref ClausulaSQL);

            ad.IniciarTabla(ClausulaSQL, "filtro", ref dsAeropuertos, ref grdListarAeropuertos);
        }
    }
}
