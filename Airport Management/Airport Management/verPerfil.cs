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
    public partial class verPerfil : Form
    {
        DataSet dsUsuario = new DataSet();
        public verPerfil()
        {
            InitializeComponent();
        }

        private void verPerfil_Load(object sender, EventArgs e)
        {
            try
            {
                string lastname = null;
                string firstname = null;
                string age = null;

                GestionUsuarios gu = new GestionUsuarios();

                bool status = gu.GetUsersData(ref lastname, ref firstname, ref age);
                if (status)
                {
                    txtNombre.Text = firstname;
                    txtApellido.Text = lastname;
                    txtCorreo.Text = age;
                }
            }
            catch
            {

            }
        }



    }
}
