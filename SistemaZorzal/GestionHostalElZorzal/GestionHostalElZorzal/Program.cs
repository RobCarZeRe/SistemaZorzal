using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionHostalElZorzal.Presentacion;

namespace GestionHostalElZorzal
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
            //Application.Run(new FrmRegistroHabCliente());
            //Application.Run(new FrmHabitaciones());
            //Application.Run(new FrmLogin());
            Application.Run(new FrmVentaProducto());

        }
    }
}
