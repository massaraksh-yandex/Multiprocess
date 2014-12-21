using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MultipocessRape
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                Library.Settings.Create(args, Library.ApplicationType.ControllApp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при разборе аргументов командной строки");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
