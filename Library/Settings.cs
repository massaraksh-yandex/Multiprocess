using System;
using System.IO;

namespace Library
{
    public enum State
    {
        NotStarted,
        Waiting,
        Working
    }

    public enum ApplicationType
    {
        ReaderApp,
        WriterApp,
        ControllApp
    }

    public static class Defines
    {
        public const uint START_PROCESSES = 123456;
        public const uint STOP_PROCESSES = 123457;
        public const uint EXIT_PROGRAMM = 123458;
    }

	public class Settings
	{
        private static Random random = new Random();

        private string file_;
        private int operationTime_;
        private int timerInterval_;
        private string waitEventName_;
		private int processId_;
        private string title_;

        public int ProcessId
        {
            get { return processId_; }
        }

        public string File
        {
            get { return file_; }
        }

        public int OperationTime
        {
            get { return operationTime_; }
        }

        public int TimerInterval
        {
            get { return timerInterval_; }
        }
        public string WaitEventName
        {
            get { return waitEventName_; }
        }
        public string Title
        {
            get { return title_; }
        }

		public string FilePath
		{
			get{ return new FileInfo(File).DirectoryName; }
		}

		public string Basename
		{
			get{ return new FileInfo(File).Name; }
		}

		private Settings()
		{
			string desktop = Environment.GetFolderPath (Environment.SpecialFolder.Desktop);
			file_ = System.IO.Path.Combine (desktop, "test");
			operationTime_ = 1000;
			timerInterval_ = 900;
            waitEventName_ = "TIME_WAIT_EVENT";
            processId_ = 1;
		}

		protected virtual void setValue(string key, string value)
		{
			switch (key) {
			case "file":file_ = value; break;
			case "operation-time":operationTime_ = int.Parse(value); break;
			case "timer-interval":timerInterval_ = int.Parse(value); break;
            case "wait-event-name": waitEventName_ = value; break;
            case "process-id": processId_ = int.Parse(value); break;

			default:throw new Exception(key + ":" + value); 
			}
		}

		static private bool verify(string str)
		{
			return str.Length > 2 &&
				str [0] == '-' &&
				str [1] == '-' &&
				str.IndexOf ('=') > 0;
		}

		public static void Create(string[] args, ApplicationType app)
		{
			Settings s = new Settings ();

			foreach (string str in args) {
				if (!verify (str))
					throw new Exception (str);

				string keyValue = str.Substring (2);
				string[] arr = keyValue.Split (new string[]{ "=" }, StringSplitOptions.RemoveEmptyEntries);
				if (arr.Length != 2)
					throw new Exception (keyValue);

				s.setValue (arr [0], arr [1]);
			}

            s.title_ = Utils.CreateTitle(app, s);
			instance_ = s;
		}

		private static Settings instance_ = null;

		public static Settings Instance
		{
			get { return instance_; }
		}
	}
}

