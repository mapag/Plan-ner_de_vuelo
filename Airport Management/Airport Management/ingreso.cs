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
        public bool validado = false;
        public ingreso()
        {
            InitializeComponent();
        }
        private void sistema()
        {
            validado = true;
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int cant = ad.ContarRegistros("select usuario from usuarios where usuario = '" + txtUsuario.Text + "' and contrasena = '" + txtContra.Text + "'");
            
            //if (cant == 1)
            //{
                sistema();
           // }
            //else
            //{
            //    MessageBox.Show("Usuario o contraseña inexistente");
            //}
        }
    }
}
