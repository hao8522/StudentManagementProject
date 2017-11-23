using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


using System.Diagnostics;


namespace StudentManager
{
    static class Program
    {
        /// <summary>
        /// main program
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new FrmMain());

        }

    }
}
