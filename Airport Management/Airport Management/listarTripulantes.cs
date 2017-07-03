using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Airport_Management.Clases;

namespace Airport_Management
{
    public partial class listarTripulantes : Form
    {
        AccesoDatos ad = new AccesoDatos();
        DataSet dsRutas = new DataSet();
        ConstructorCodSQL cons = new ConstructorCodSQL();
        public listarTripulantes()
        {
            InitializeComponent();
        }

        private void listarTripulantes_Load(object sender, EventArgs e)
        {
            string ClausulaSQL = "SELECT a.legajo_tcp AS Legajo, a.apellido_TCP AS Apellido, a.nombre_TCP AS Nombre, tipo_TCP AS Cargo, baja_TCP as Estado from tripulantes a ";
            ad.IniciarTabla(ClausulaSQL, "Todos", ref dsRutas, ref grdTripulantes);

            CargarComboNumerico(ref cmbLegajo);
            CargarComboTexto(ref cmbApellido);
            CargarComboTexto(ref cmbNombre);
            CargarComboTexto(ref cmbCargo);
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
            string ClausulaSQL = "SELECT a.legajo_TCP AS Legajo, a.apellido_TCP AS Apellido, a.nombre_TCP AS Nombre, tipo_TCP AS Cargo, baja_TCP as Estado from tripulantes a WHERE a.legajo_TCP like '%'";

            if (cmbLegajo.Text != "" && txtLegajo.Text != "")
                cons.ConstructorConsultaTextual("tripulantes", "a.legajo_TCP", cmbLegajo.Text, txtLegajo.Text, ref ClausulaSQL);

            if (cmbApellido.Text != "" && txtApellido.Text != "")
                cons.ConstructorConsultaTextual("tripulantes", "a.apellido_TCP", cmbApellido.Text, txtApellido.Text, ref ClausulaSQL);

            if (cmbNombre.Text != "" && txtNombre.Text != "")
                cons.ConstructorConsultaTextual("tripulantes", "a.nombre_TCP", cmbNombre.Text, txtNombre.Text, ref ClausulaSQL);

            if (cmbCargo.Text != "" && txtCargo.Text != "")
                cons.ConstructorConsultaNumerica("tripulantes", "a.cargo_TCP", cmbCargo.Text, txtCargo.Text, ref ClausulaSQL);


            ad.IniciarTabla(ClausulaSQL, "filtro", ref dsRutas, ref grdTripulantes);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string ClausulaSQL = "SELECT a.legajo_tcp AS Legajo, a.apellido_TCP AS Apellido, a.nombre_TCP AS Nombre, tipo_TCP AS Cargo, baja_TCP as Estado from tripulantes a ";
            ad.IniciarTabla(ClausulaSQL, "Todos", ref dsRutas, ref grdTripulantes);

            cmbLegajo.Text = "";
            cmbApellido.Text = "";
            cmbNombre.Text = "";
            cmbCargo.Text = "";

            txtLegajo.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtLegajo.Text = "";
        }

        private void txtLegajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 47 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
