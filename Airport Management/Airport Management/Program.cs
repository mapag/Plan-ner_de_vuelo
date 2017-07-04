using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport_Management
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            
            /* DESCOMENTAR ESTO PARA QUE ESTE EL INGRESO
             * ingreso n = new ingreso();
            Application.Run(n);
            if (n.validado)
            {*/
                Application.Run(new Form1());
            /*
            }*/
        }
    }
}
