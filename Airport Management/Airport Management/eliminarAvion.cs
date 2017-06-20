using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport_Management
{
    public partial class eliminarAvion : Form
    {
        public eliminarAvion()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 0 || txtCodigo.Text.Length != 7) MessageBox.Show("Debe ingresar un código válido");

        }
    }
}
