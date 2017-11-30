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
    public partial class agregarAeropuerto : Form
    {
        GestionAeropuertos ga = new GestionAeropuertos();

        public agregarAeropuerto()
        {
            InitializeComponent();
        }

        private void agregarAeropuerto_Load(object sender, EventArgs e)
        {

        }

        private int activarbotonagregar()
        {
            bool estado = true;
            int num = 0;
            if (txt_Codigo.Text.Equals("") || txt_Codigo.Text.Length != 3 || 'A' > txt_Codigo.Text[0] || txt_Codigo.Text[0] > 'Z'
                                                                          || 'A' > txt_Codigo.Text[1] || txt_Codigo.Text[1] > 'Z'
                                                                          || 'A' > txt_Codigo.Text[2] || txt_Codigo.Text[2] > 'Z')
            {
                estado = false;
                num = 8;
            }
            if (ga.CodigoExiste(txt_Codigo.Text))
            {
                estado = false;
                MessageBox.Show("El código ya existe, verifique que el aeropuerto no este ya creado");
            }
            if (txt_Nombre.Text.Equals("")) estado = false;
            if (txt_Pais.Text.Equals("")) estado = false;
            if (txt_provincia.Text.Equals("")) estado = false;
            btn_agregar.Enabled = estado;
            return num;
        }

        private void txt_Codigo_Leave(object sender, EventArgs e)
        {
            //if (activarbotonagregar() == 8) MessageBox.Show("El codigo son 3 letras mayúsculas");
        }

        private void txt_Nombre_Leave(object sender, EventArgs e)
        {
            //activarbotonagregar();
        }

        private void txt_Pais_Leave(object sender, EventArgs e)
        {
            //activarbotonagregar();
        }

        private void txt_provincia_Leave(object sender, EventArgs e)
        {
            //activarbotonagregar();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_provincia.Text == "" || txt_Codigo.Text == "" || txt_Nombre.Text == "" || txt_Pais.Text == "")
                {

                    MessageBox.Show("Debe completar todos los campos");
                }
                else
                {
                    int num = 0;
                    if (txt_Codigo.Text.Equals("") || txt_Codigo.Text.Length != 3 || 'A' > txt_Codigo.Text[0] || txt_Codigo.Text[0] > 'Z'
                                                                                  || 'A' > txt_Codigo.Text[1] || txt_Codigo.Text[1] > 'Z'
                                                                                  || 'A' > txt_Codigo.Text[2] || txt_Codigo.Text[2] > 'Z')
                    {
                        num++;
                        MessageBox.Show("El codigo son 3 letras mayúsculas");
                    }
                    if (ga.CodigoExiste(txt_Codigo.Text))
                    {
                        num++;
                        MessageBox.Show("El código ya existe, verifique que el aeropuerto no este ya creado");
                    }

                    if (num == 0)
                    {
                        ga.agregarAeropuerto(txt_Codigo.Text, txt_Nombre.Text, txt_Pais.Text, txt_provincia.Text);
                        MessageBox.Show("Aeropuerto agregado correctamente.");
                    }
                }
            }
            catch (SyntaxErrorException re)
            {
                MessageBox.Show(re.ToString());
            }

            //LIMPIA LOS CAMPOS
            txt_Codigo.Text = "";
            txt_provincia.Text = "";
            txt_Pais.Text = "";
            txt_Nombre.Text = "";
        }

    }
}
