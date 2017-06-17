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

            CargarComboTexto(ref cmbTipo);
        }
        private void CargarComboTexto(ref ComboBox NombreCombo)
        {
            NombreCombo.Items.Add("Comienza con:");
            NombreCombo.Items.Add("Termina en:");
            NombreCombo.Items.Add("Contiene:");
            NombreCombo.Items.Add("Es igual a:");
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
                case "Es Igual a:":
                    d1 = " ='";
                    d2 = "'";
                    break;
            } // SWITCH
            Clausula =
                Clausula + NombreCampo + d1 + Valor + d2;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

        }
  /*      private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string ClausulaSQLProductos = "";
            if (comboBox1.Text != "" && textBox1.Text != "")
                ConstruirClausulaSQL("IdProducto",
                                     comboBox1.Text,
                                     textBox1.Text,
                                     ref ClausulaSQLProductos);
            if (comboBox2.Text != "" && textBox2.Text != "")
                ConstruirClausulaSQL("NombreProducto",
                                     comboBox2.Text,
                                     textBox2.Text,
                                     ref ClausulaSQLProductos);
            if (comboBox3.Text != "" && textBox3.Text != "")
                ConstruirClausulaSQL("IdCategoría",
                                     comboBox3.Text,
                                     textBox3.Text,
                                     ref ClausulaSQLProductos);
            if (comboBox4.Text != "" && textBox4.Text != "")
                ConstruirClausulaSQL("IdProveedor",
                                     comboBox4.Text,
                                     textBox4.Text,
                                     ref ClausulaSQLProductos);

            dsNeptuno.Tables.Clear();
            GestionProductos gp = new GestionProductos();
            gp.ObtenerTodosLosProductosClausula("Select * from productos " + ClausulaSQLProductos, "Productos", ref dsNeptuno);
            Grilla.DataSource = dsNeptuno.Tables["Productos"];
        }*/
    }
}
