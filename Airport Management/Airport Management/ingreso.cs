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
    public partial class ingreso : Form
    {
        AccesoDatos ad = new AccesoDatos();
        public int validado = 0;
        public ingreso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cant = ad.ContarRegistros("select id_USU from usuarios where usuario_USU = '" + txtUsuario.Text + "' and contrasena_USU = '" + txtContra.Text + "'");

            if (cant == 1)
            {
                validado = 123;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña inexistente");
            }
        }
    }
}
