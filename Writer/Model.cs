using System;
using System.IO;
using System.Threading;

namespace Writer
{
	public class Model
	{
        private System.Timers.Timer timer;
        private bool needToContinue;
        private System.Threading.EventWaitHandle waiter;

		public delegate void StatusDelegate();

		public event StatusDelegate writingStarted;
		public event StatusDelegate writingFinished;

		public Model ()
		{
			timer = new System.Timers.Timer (Library.Settings.Instance.TimerInterval);
            timer.Elapsed += new System.Timers.ElapsedEventHandler(onTimer);
            needToContinue = true;
            waiter = new EventWaitHandle(true, System.Threading.EventResetMode.AutoReset,
                                                          Library.Settings.Instance.WaitEventName);
		}

        public void SetFree()
        {
            waiter.Set();
        }

        public void StartTimer()
        {
            timer.Start();
            needToContinue = true;
        }

        public void StopTimer()
        {
            timer.Stop();
            needToContinue = false;
        }

        void onTimer(object source, System.Timers.ElapsedEventArgs e)
		{
			timer.Stop ();
			writingStarted ();

			WriteWord ();

			writingFinished ();
            if (needToContinue) timer.Start();
		}

		public void WriteWord()
		{
			waiter.WaitOne ();
			Thread.Sleep (Library.Settings.Instance.OperationTime);
			using (StreamWriter sr = new StreamWriter(Library.Settings.Instance.File, true)) {
				string word = Library.Settings.Instance.Title + ": " + DateTime.Now;
				sr.WriteLine (word);
			}
			waiter.Set ();
		}
	}
}

