using System;
using System.Windows.Forms;

namespace ProgramacionOrientadaAObjetos
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //La linea 17 indica cual es la forma de inicio
            Application.Run(new Form1());
        }
    }
}
