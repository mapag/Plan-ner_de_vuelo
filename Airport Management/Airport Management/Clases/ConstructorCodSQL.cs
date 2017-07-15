using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport_Management
{
    class ConstructorCodSQL
    {

        public ConstructorCodSQL() { }

        public void ConstructorConsultaNumerica(string tabla, string NombreCampo, string Operador, string Valor, ref string Consulta)/// SE PUEDE AGREGAR EL CONSEPTO string tabla PARA MODIFICAR LA TABLA DE BUSQUEDA SI ES NECESARIO
        {
            string d = "";
            if (Consulta == "")
                Consulta = "Select * from "+tabla+" WHERE "; ///MODIFICAR PARA CAMBIAR LOS CAMPOS Y LA TABLA DE BUSQUEDA
            else
                Consulta = Consulta + " AND ";
            switch (Operador)
            {
                case "Igual a:":
                    d = " = ";
                    break;
                case "Mayor a:":
                    d = " > ";
                    break;
                case "Menor a:":
                    d = " < ";
                    break;
                case "Menor o igual a":
                    d = " <= ";
                    break;
                case "Mayor o igual a":
                    d = " >= ";
                    break;
            }
            Consulta = Consulta + NombreCampo + d + Valor;
        }

        public void CargarComboTexto(ref ComboBox NombreCombo)
        {
            NombreCombo.Items.Add("Comienza con");
            NombreCombo.Items.Add("Termina en");
            NombreCombo.Items.Add("Contiene");
            NombreCombo.Items.Add("Es igual a");
        }

        public void ConstructorConsultaTextual(string tabla, string NombreCampo, string Operador, string Valor, ref string Consulta) /// SE PUEDE AGREGAR EL CONSEPTO string tabla PARA MODIFICAR LA TABLA DE BUSQUEDA SI ES NECESARIO
            {
            string d = "";
            if (Consulta == "")
                Consulta = "Select * from "+ tabla + " WHERE ";   ///MODIFICAR PARA CAMBIAR LOS CAMPOS Y LA TABLA DE BUSQUEDA
            else
                Consulta = Consulta + " AND ";
            switch (Operador)
            {
                case "Es igual a":
                    d = " = '" + Valor + "'";
                    break;
                case "Comienza con":
                    d = " like '" + Valor + "%'";
                    break;
                case "Termina en":
                    d = " like '%" + Valor + "'";
                    break;
                case "Contiene":
                    d = " like '%" + Valor + "%'";
                    break;
                case "No contiene":
                    d = " not like '%" + Valor + "%'";
                    break;
                case "No comienza con":
                    d = " not like '" + Valor + "%'";
                    break;
                case "No termina en":
                    d = " not like '%" + Valor + "'";
                    break;
            }
            Consulta = Consulta + NombreCampo + d;
        }

        public void CargarComboTiempo(ref ComboBox NombreCombo)
        {
            NombreCombo.Items.Add("Antes de");
            NombreCombo.Items.Add("Después de");
        }

        public void ConstructorConsultaTemporal(string tabla, string NombreCampo, string Operador, string Valor, ref string Consulta) /// SE PUEDE AGREGAR EL CONSEPTO string tabla PARA MODIFICAR LA TABLA DE BUSQUEDA SI ES NECESARIO
        {
            string d = "";
            if (Consulta == "")
                Consulta = "Select * from " + tabla + " WHERE ";   ///MODIFICAR PARA CAMBIAR LOS CAMPOS Y LA TABLA DE BUSQUEDA
            else
                Consulta = Consulta + " AND ";
            switch (Operador)
            {
                case "Antes de":
                    d = " < '" + Valor + "'";
                    break;
                case "Después de":
                    d = " > '" + Valor + "'";
                    break;
            }
            Consulta = Consulta + NombreCampo + d;
        }

    }
}
