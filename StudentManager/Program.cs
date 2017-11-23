using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


using System.Diagnostics;
using Models;

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

            FrmUserLogin frmLogin = new FrmUserLogin();

            DialogResult result = frmLogin.ShowDialog();

            if(result== DialogResult.OK)
            {
                Application.Run(new FrmMain());
            }
            else
            {
                Application.Exit();
            }

          

        }

        public static SysAdmin currentAdmin=null;

    }
}
