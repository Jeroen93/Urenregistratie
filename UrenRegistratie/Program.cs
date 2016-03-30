using System;
#if !DEBUG
using System.Diagnostics;
#endif
using System.Windows.Forms;
using UrenRegistratie.Forms;

namespace UrenRegistratie
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
#if !DEBUG
            if (Debugger.IsAttached)
                MessageBox.Show(@"In Releasemode!");
#endif
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
