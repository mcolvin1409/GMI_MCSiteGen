using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MCNWSiteGen
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// 13-Aug-12, Mark C, WI28788: removed enabling visual styles to support
        ///     the list view control in Windows XP
        /// </summary>
        [STAThread]
        static void Main()
        {            
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}