using System;
using System.IO;

namespace Reader
{
	public class Model
	{
		private FileSystemWatcher watcher;

		public delegate void MessageDelegate(string text);
		public event MessageDelegate onReaded;

		public Model ()
		{
			watcher = new FileSystemWatcher ();

			watcher.Path = Library.Settings.Instance.FilePath;
			watcher.NotifyFilter = NotifyFilters.LastWrite;
			watcher.Filter = Library.Settings.Instance.Basename;
			watcher.Changed += new FileSystemEventHandler(onChanged);
		}

        public bool Listening
        {
            get { return watcher.EnableRaisingEvents; }
            set { watcher.EnableRaisingEvents = value; }
        }

		private void onChanged(object source, FileSystemEventArgs e)
		{
			string word = "";
            string[] lines = System.IO.File.ReadAllLines(Library.Settings.Instance.File);

            foreach (string line in lines)
            {
                if (line.IndexOf(Library.Utils.CreateTitle(Library.ApplicationType.WriterApp,
                    Library.Settings.Instance)) >= 0)
				    word += line + "\r\n";
            }

			onReaded (word);

			Console.WriteLine (word);
		}
	}
}
