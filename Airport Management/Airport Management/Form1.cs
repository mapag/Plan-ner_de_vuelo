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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarAviónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                this.MdiChildren[i].Close();
            }
            
            agregarAvion agreAvion = new agregarAvion();
            agreAvion.MdiParent = this;
            agreAvion.Show();
        }

        private void modificarAviónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                this.MdiChildren[i].Close();
            }

            modificarAvion2 modAvion = new modificarAvion2();
            modAvion.MdiParent = this;
            modAvion.Show();
        }

        private void eliminarAviónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                this.MdiChildren[i].Close();
            }

            eliminarAvion elimAvion = new eliminarAvion();
            elimAvion.MdiParent = this;
            elimAvion.Show();
        }

        private void agregarVueloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                this.MdiChildren[i].Close();
            }

            agregarVuelo agregVuelo = new agregarVuelo();
            agregVuelo.MdiParent = this;
            agregVuelo.Show();
        }

        private void modificarVueloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                this.MdiChildren[i].Close();
            }

            modificarVuelo modVuelo = new modificarVuelo();
            modVuelo.MdiParent = this;
            modVuelo.Show();
        }

        private void eliminarVueloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                this.MdiChildren[i].Close();
            }

            eliminarVuelo elimVuelo = new eliminarVuelo();
            elimVuelo.MdiParent = this;
            elimVuelo.Show();
        }
    }
}
