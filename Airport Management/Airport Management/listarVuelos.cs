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
        public listarVuelos()
        {
            InitializeComponent();
        }

        private void listarVuelos_Load(object sender, EventArgs e)
        {
            dsVuelos = new DataSet();
            GestionVuelos gv = new GestionVuelos();
            gv.listarVuelos("Vuelos", ref dsVuelos);
            grdListarVuelos.DataSource = dsVuelos.Tables["Vuelos"];

            CargarComboTexto(ref cmbCodigo);
            CargarComboTexto(ref cmbRuta);
            CargarComboTexto(ref cmbFecha);
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
        }

        private void ConstruirClausulaSQL(string NombreCampo,
                                          string Operador,
                                          string Valor,
                                          ref string Clausula)
        {
            string d1 = "";  //Delimitador 1
            string d2 = ""; //Delimitador 2
            if (Clausula == "")
                Clausula = Clausula + " WHERE ";
            else
                Clausula = Clausula + " AND ";
            switch (Operador)
            {
                case "Igual a:":
                    d1 = " = ";
                    d2 = "";
                    break;
                case "Mayor a:":
                    d1 = " > ";
                    d2 = "";
                    break;
                case "Menor a:":
                    d1 = " < ";
                    d2 = "";
                    break;
                case "Comienza con:":
                    d1 = " LIKE '";
                    d2 = "%'";
                    break;
                case "Termina en:":
                    d1 = " LIKE '%";
                    d2 = "'";
                    break;
                case "Contiene:":
                    d1 = " LIKE '%";
                    d2 = "%'";
                    break;
                case "Es igual a:":
                    d1 = " ='";
                    d2 = "'";
                    break;
            } // SWITCH
            Clausula =
                Clausula + NombreCampo + d1 + Valor + d2;
        }
    }
}
