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
            ingreso n = new ingreso();
            
            
            Application.Run(n);
            if (n.validado != 0)
            {
                Form1 a = new Form1();
                Application.Run(a);
                if (a.validado)
                    //Main();
                    Application.Restart();
            }
        }
    }
}
