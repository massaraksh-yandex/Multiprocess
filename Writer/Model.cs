using System;
using System.IO;
using System.Threading;

namespace Writer
{
	public class Model
	{
        private static Random random = new Random();
        private static int randValue(int value, int percentage)
        {
            return value + random.Next(-value*percentage/100, value*percentage/100);
        }

        private System.Timers.Timer timer;
        private bool needToContinue;
        private System.Threading.EventWaitHandle waiter;
        

		public delegate void StatusDelegate();

		public event StatusDelegate writingStarted;
		public event StatusDelegate writingFinished;

		public Model ()
		{
			timer = new System.Timers.Timer (randValue(Library.Settings.Instance.TimerInterval, 15));
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
			WriteWord ();
            if (needToContinue) timer.Start();
		}

		public void WriteWord()
		{
			waiter.WaitOne ();
            writingStarted();
			Thread.Sleep (randValue(Library.Settings.Instance.OperationTime, 15));
			using (StreamWriter sr = new StreamWriter(Library.Settings.Instance.File, true)) {
				string word = Library.Settings.Instance.Title + ": " + DateTime.Now;
				sr.WriteLine (word);
			}
			waiter.Set ();
            writingFinished();
		}
	}
}

