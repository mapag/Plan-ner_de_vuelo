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
        DataSet dsAviones = new DataSet();
        ConstructorCodSQL cons = new ConstructorCodSQL();
        AccesoDatos ad = new AccesoDatos();

        public listarAviones()
        {
            InitializeComponent();
        }

        private void listarAviones_Load(object sender, EventArgs e)
        {
            string ClausulaSQL = "select a.codigo_AV as Codigo, b.fabricante_TA as 'Fabricante', b.modelo_TA as Modelo, b.descripcion_TA as Descripción from Aviones a inner join tipos_de_aviones b on b.codigo_TA = a.tipo_AV where a.codigo_AV like '%'";
            ad.IniciarTabla(ClausulaSQL, "Todos", ref dsAviones, ref grdListarAviones);

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
            NombreCombo.Items.Add("Mayor o igual a");
            NombreCombo.Items.Add("Menor o igual a");
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            

            string ClausulaSQL = "select a.codigo_AV as Codigo, b.fabricante_TA as 'Fabricante', b.modelo_TA as Modelo, b.descripcion_TA as Descripción from Aviones a inner join tipos_de_aviones b on b.codigo_TA = a.tipo_AV where a.codigo_AV like '%'";

            if (cmbCodigo.Text != "" && txtCodigo.Text != "")
                cons.ConstructorConsultaTextual("aviones", "a.codigo_AV", cmbCodigo.Text, txtCodigo.Text, ref ClausulaSQL);

            if (cmbFabricante.Text != "" && txtFabricante.Text != "")
                cons.ConstructorConsultaTextual("aviones", "b.fabricante_TA", cmbFabricante.Text, txtFabricante.Text, ref ClausulaSQL);

            if (cmbModelo.Text != "" && txtModelo.Text != "")
                cons.ConstructorConsultaTextual("aviones", "b.modelo_TA", cmbModelo.Text, txtModelo.Text, ref ClausulaSQL);
                
            ad.IniciarTabla(ClausulaSQL, "filtro", ref dsAviones, ref grdListarAviones);

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

        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
