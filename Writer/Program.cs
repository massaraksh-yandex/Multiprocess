using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Writer
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
                Library.Settings.Create(args, Library.ApplicationType.WriterApp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при разборе аргументов командной строки");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WindowWriter());
        }
    }
}
