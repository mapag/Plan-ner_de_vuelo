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

        private void eliminarAeropuertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarVentanaAnterior();
            eliminarAeropuerto eliminarAeropuerto = new eliminarAeropuerto();
            abrirVentana(eliminarAeropuerto);
        }

        private void generarBackUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccesoDatos ad = new AccesoDatos();
            ad.generarBkp();
            MessageBox.Show("Se ha generado el BackUp");
        }

        private void recuperarBackUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarVentanaAnterior();
            recuperarBD recuperarBD = new recuperarBD();
            abrirVentana(recuperarBD);
        }

        private void generarPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccesoDatos ad = new AccesoDatos();
            DataSet ds = new DataSet();
            bool aumentardia = false;
            ad.generarBkp();
            string consultaSQL1 = "select vuelos.codigo_VLO as codigo, rutas.ATOpartida_RTA as partida, rutas.ATOarrivo_RTA as arrivo, rutas.ETA_RTA as tiempo, vuelos.fecha_salida_VLO as fecha from vuelos inner join rutas on vuelos.codigo_RTA = rutas.codigo_RTA where vuelos.sincronizado_VLO = 0 order by vuelos.fecha_salida_VLO ASC";
            ad.cargaTabla("vuelos", consultaSQL1, ref ds);
            foreach (DataRow vuelo in ds.Tables["vuelos"].Rows)
            {
                string prov = vuelo["fecha"].ToString();
                string[] fecha = prov.Split();
                if (fecha[2] == "a.m.") fecha[2] = "am";
                else fecha[2] = "pm";

                string arrivo = fecha[1][0].ToString() + fecha[1][1].ToString();
                int hora = int.Parse(arrivo);
                hora += int.Parse(vuelo["tiempo"].ToString());
                if (fecha[2] == "am")
                {
                    if (hora > 24)
                    {
                        hora -= 24;
                        aumentardia = true;
                    }
                    if (hora > 12)
                    {
                        hora -= 12;
                        fecha[2] = "pm";
                    }
                }
                else
                {
                    if (hora > 24)
                    {
                        hora -= 24;
                        aumentardia = true;
                    }
                    if (hora > 12)
                    {
                        hora -= 12;
                        fecha[2] = "am";
                        aumentardia = true;
                    }
                }
                if (hora < 10) fecha[1] = "0" + hora.ToString() + ":" + fecha[1][3].ToString() + fecha[1][4].ToString() + ":" + fecha[1][6].ToString() + fecha[1][7].ToString();
                else fecha[1] = hora.ToString() + ":" + fecha[1][3].ToString() + fecha[1][4].ToString() + ":" + fecha[1][6].ToString() + fecha[1][7].ToString();
                if (aumentardia)
                {
                    int anio = int.Parse(fecha[0][8].ToString() + fecha[0][9].ToString());
                    int mes = int.Parse(fecha[0][3].ToString() + fecha[0][4].ToString());
                    int dia = int.Parse(fecha[0][8].ToString() + fecha[0][9].ToString());
                    if(mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10){
                        if (dia == 31)
                        {
                            dia = 1;
                            mes += 1;
                        }
                    }
                    else if (mes == 12)
                    {
                        if (dia == 31)
                        {
                            dia = 1;
                            mes = 1;
                            anio += 1;
                        }
                    }
                    else if( mes ==  2)
                    {
                        if (dia == 28)
                        {
                            dia = 1;
                            mes += 1;
                        }
                    }
                    else
                    {
                        if (dia == 30)
                        {
                            dia = 1;
                            mes += 1;
                        }
                    }
                    fecha[0] = dia.ToString() + "/" + mes.ToString() + "/20" + anio.ToString();
                }

                string consultaSQL2 = "select aviones.codigo_AV as codigo from aviones where aviones.ultimo_ATO_programado_AV = '" + vuelo["partida"].ToString() + "' and aviones.ultima_fecha_programada_AV < '" + fecha[0] + " " + fecha[1] + " " + fecha[2] + "' and aviones.baja_AV = 1 order by aviones.posicion_AV ASC";

                if (ad.ContarRegistros(consultaSQL2) > 0)
                {
                    ad.cargaTabla("aviones", consultaSQL2, ref ds);
                    ad.EjecutarConsulta("insert into VLO_por_AV select '" + vuelo["codigo"].ToString() + "', '" + ds.Tables["aviones"].Rows[0]["codigo"].ToString() + "'");
                    ad.EjecutarConsulta("update aviones set ultimo_ATO_programado_AV = '" + vuelo["arrivo"].ToString() + "' , ultima_fecha_programada_AV = '" + fecha[0] + " " + fecha[1] + " " + fecha[2] + "' where codigo_AV = '" + ds.Tables["aviones"].Rows[0][0].ToString() + "'" );
                    ad.EjecutarConsulta("update vuelos set sincronizado_VLO = 1 where codigo_VLO = '" + vuelo["codigo"].ToString() + "'");
                    ds.Tables["aviones"].Clear();
                }
                else
                {
                    MessageBox.Show("No hay aviones disponibles para el vuelo " + vuelo["codigo"].ToString() + "se recomienda planificar un vuelo de ida hacia el aeropuerto " + vuelo["partida"].ToString() + " que llegue antes del la fecha de partida.");
                }
            }
            MessageBox.Show("Se ha generado el plan satisfactoriamente.");
        }

        private void mostrarPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarVentanaAnterior();
            listarVuelosPorAvion listarVuelosPorAvion = new listarVuelosPorAvion();
            abrirVentana(listarVuelosPorAvion);
        }
    }
}
