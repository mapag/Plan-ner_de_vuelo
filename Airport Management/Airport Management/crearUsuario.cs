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
    public partial class crearUsuario : Form
    {
        public crearUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    pictureBox1.Image = Image.FromFile(imagen);
                }
            }
            catch
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void crearUsuario_Load(object sender, EventArgs e)
        {
            txtUsuario.Select();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkContra.Checked)
                txtContra.UseSystemPasswordChar = false;
            else
                txtContra.UseSystemPasswordChar = true;
        }
    }
}
