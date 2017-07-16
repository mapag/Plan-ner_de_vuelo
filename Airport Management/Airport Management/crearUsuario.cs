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
    public partial class crearUsuario : Form
    {
        GestionUsuarios gu = new GestionUsuarios();
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
            btnGuardar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (gu.usuarioExiste(txtUsuario.Text)) MessageBox.Show("El usuario ingresado ya existe");

            else
            {
                gu.crearUsuario(txtUsuario.Text, txtContra.Text, txtNombre.Text, txtApellido.Text, txtCorreo.Text, txtTelefono.Text);

                MessageBox.Show("Usuario ingresado con éxito");
                
                txtUsuario.Text = "";
                txtContra.Text = "";
                txtApellido.Text = "";
                txtNombre.Text = "";
                txtCorreo.Text = "";
                txtTelefono.Text = "";

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkContra.Checked)
                txtContra.UseSystemPasswordChar = false;
            else
                txtContra.UseSystemPasswordChar = true;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Length == 0 || txtContra.Text.Length == 0 || txtNombre.Text.Length == 0 || txtApellido.Text.Length == 0)
            {
                btnGuardar.Enabled = false;
            }
            else btnGuardar.Enabled = true;
        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Length == 0 || txtContra.Text.Length == 0 || txtNombre.Text.Length == 0 || txtApellido.Text.Length == 0)
            {
                btnGuardar.Enabled = false;
            }
            else btnGuardar.Enabled = true;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Length == 0 || txtContra.Text.Length == 0 || txtNombre.Text.Length == 0 || txtApellido.Text.Length == 0)
            {
                btnGuardar.Enabled = false;
            }
            else btnGuardar.Enabled = true;
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Length == 0 || txtContra.Text.Length == 0 || txtNombre.Text.Length == 0 || txtApellido.Text.Length == 0)
            {
                btnGuardar.Enabled = false;
            }
            else btnGuardar.Enabled = true;
        }
    }
}
