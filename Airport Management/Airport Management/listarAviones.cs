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
        DataSet dsAviones;
        public listarAviones()
        {
            InitializeComponent();
        }

        private void listarAviones_Load(object sender, EventArgs e)
        {

            dsAviones = new DataSet();
            GestionAviones ga = new GestionAviones();
            ga.listarAviones("Aviones", ref dsAviones);
            grdListarAviones.DataSource = dsAviones.Tables["Aviones"];

            CargarComboTexto(ref cmbCodigo);
            CargarComboTexto(ref cmbFabricante);
            CargarComboTexto(ref cmbModelo);
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

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string ClausulaSQL = "";
            if (cmbCodigo.Text != "" && txtCodigo.Text != "")
                ConstruirClausulaSQL("codigo_AV",
                                     cmbCodigo.Text,
                                     txtCodigo.Text,
                                     ref ClausulaSQL);
            if (cmbFabricante.Text != "" && txtFabricante.Text != "")
                ConstruirClausulaSQL("fabricante_TA",
                                     cmbFabricante.Text,
                                     txtFabricante.Text,
                                     ref ClausulaSQL);
            if (cmbModelo.Text != "" && txtModelo.Text != "")
                ConstruirClausulaSQL("modelo_TA",
                                     cmbModelo.Text,
                                     txtModelo.Text,
                                     ref ClausulaSQL);

            MessageBox.Show(ClausulaSQL);

            dsAviones.Tables.Clear();
            GestionAviones gp = new GestionAviones();
            gp.listarAvionesClausula("select a.codigo_AV as Codigo, b.fabricante_TA as 'Fabricante', b.modelo_TA as Modelo, b.descripcion_TA as Descripción from Aviones a inner join tipos_de_aviones b on b.codigo_TA = a.tipo_AV" + ClausulaSQL, "Aviones", ref dsAviones);
            grdListarAviones.DataSource = dsAviones.Tables["Aviones"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // DataSet dsActualizar;
            DataSet dsEliminar;
            //DataSet dsAgregar;
            GestionAviones gp = new GestionAviones();
            /*
            if (dsAviones.HasChanges(DataRowState.Modified))
            {
                dsActualizar = new DataSet();
                dsActualizar = dsAviones.GetChanges(DataRowState.Modified);
                gp.modificarAvion("Aviones", dsActualizar);
            }
            if (dsAviones.HasChanges(DataRowState.Added))
            {
                dsAgregar = new DataSet();
                dsAgregar = dsAviones.GetChanges(DataRowState.Added);
                gp.insertarAvion("Aviones", dsAgregar);
            }*/
            if (dsAviones.HasChanges(DataRowState.Deleted))
            {
                dsEliminar = new DataSet();
                dsEliminar = dsAviones.GetChanges(DataRowState.Deleted);
                gp.eliminarAvion("Aviones", dsEliminar);
            }
            MessageBox.Show("Cambios efectuados en la base de datos.");
        }

    }
}
