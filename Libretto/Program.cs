using Libretto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libretto
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        ///

        [STAThread]
        static void Main()
        {
            initDatabase();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }

        private static void initDatabase()
        {
           
        }
    }
}
