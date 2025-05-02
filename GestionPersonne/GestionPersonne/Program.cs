using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPersonne
{
    static class Program
    {
        private static string configFilePath = Application.StartupPath + @"\config.ini";

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!File.Exists(configFilePath))
            {
                Application.Run(new ServerConfig());
            }
            else
            {
                Application.Run(new Modals.Auth());
            }
        }
    }
}
