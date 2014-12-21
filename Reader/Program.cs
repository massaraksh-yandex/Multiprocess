using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Reader
{
	static class Programm
	{
        [STAThread]
		public static void Main (string[] args)
		{
            try
            {
                Library.Settings.Create(args, Library.ApplicationType.ReaderApp);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при разборе аргументов командной строки");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WindowReader());
		}
	}
}
