using System;
using System.Windows.Forms;
using DomestikAirline.DataBase;

namespace DomestikAirline
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            BDInitializer bd = new BDInitializer();

            bd.CrearBaseDatos();
            bd.CrearTablas();

            FrmLogin login = new FrmLogin();

            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FrmMenu());
            }
        }
    }
}