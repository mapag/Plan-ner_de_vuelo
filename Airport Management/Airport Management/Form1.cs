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
    public partial class Form1 : Form
    {

        public bool validado = false;
        public Form1()
        {
            InitializeComponent();
        }

        public void borrarVentanaAnterior ()
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                this.MdiChildren[i].Close();
            }
        }

       public void abrirVentana (Form frm)
        {
            frm.MdiParent = this;
            frm.Show();
        }
        private void agregarAviónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            borrarVentanaAnterior();
            agregarAvion agreAvion = new agregarAvion();
            abrirVentana(agreAvion);
           
        }

        private void eliminarAviónToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            borrarVentanaAnterior();
            eliminarAvion elimAvion = new eliminarAvion();
            abrirVentana(elimAvion);
        }

        private void agregarVueloToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            borrarVentanaAnterior();
            agregarVuelo agregVuelo = new agregarVuelo();
            abrirVentana(agregVuelo);
        }

        private void modificarVueloToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            borrarVentanaAnterior();
            modificarVuelo modVuelo = new modificarVuelo();
            abrirVentana(modVuelo);
        }

        private void eliminarVueloToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            borrarVentanaAnterior();
            eliminarVuelo elimVuelo = new eliminarVuelo();
            abrirVentana(elimVuelo);
        }

        private void listarAvionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarVentanaAnterior();
            listarAviones listarAviones = new listarAviones();
            abrirVentana(listarAviones);
        }

        private void listarVueloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarVentanaAnterior();
            listarVuelos listarVuelos = new listarVuelos();
            abrirVentana(listarVuelos);
        }

        private void listarRutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarVentanaAnterior();
            listarRutas listarRutas = new listarRutas();
            abrirVentana(listarRutas);
        }

        private void listarTripulantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarVentanaAnterior();
            listarTripulantes listarTripulantes = new listarTripulantes();
            abrirVentana(listarTripulantes);
        }

        private void agregarRutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarVentanaAnterior();
            agregarRuta agregarRuta = new agregarRuta();
            abrirVentana(agregarRuta);
        }

        private void modificarRutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarVentanaAnterior();
            modificarRuta modificarRuta = new modificarRuta();
            abrirVentana(modificarRuta);
        }

        private void eliminarRutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarVentanaAnterior();
            eliminarRuta eliminarRuta = new eliminarRuta();
            abrirVentana(eliminarRuta);
        }

        private void vERPERFILToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarVentanaAnterior();
            verPerfil verPerfil = new verPerfil();
            abrirVentana(verPerfil);
        }

        private void cERRARSESIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ingreso A = new ingreso();
            validado = true;
            Application.Exit();
        }

        private void listarAeropuertosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarVentanaAnterior();
            listarAeropuertos listarAeropuertos = new listarAeropuertos();
            abrirVentana(listarAeropuertos);
        }

        private void agregarAeropuertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarVentanaAnterior();
            agregarAeropuerto agregarAeropuerto = new agregarAeropuerto();
            abrirVentana(agregarAeropuerto);
        }

        private void cREARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarVentanaAnterior();
            crearUsuario crearUsuario = new crearUsuario();
            abrirVentana(crearUsuario);
        }

        private void generarPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccesoDatos ad = new AccesoDatos();
            ad.generarBkp();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory("c:/BackUpAirport_Manager");
        }

        private void gENERARBACKUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccesoDatos ad = new AccesoDatos();
            if (ad.generarBkp()) MessageBox.Show("Se ha generado un BackUp nuevo");
            else MessageBox.Show("Error al generar BackUp");
        }

        private void rEUPERARBACKUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarVentanaAnterior();
            recuperarBD recuperarBD = new recuperarBD();
            abrirVentana(recuperarBD);
        }
    }
}
