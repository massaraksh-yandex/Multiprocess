using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reader
{
    public partial class WindowReader : Form
    {
        Model model;
        Library.State state;

        public WindowReader()
        {
            InitializeComponent();
            model = new Model();
            model.onReaded += new Model.MessageDelegate(onFileReaded);
            state = Library.State.NotStarted;
            Text = Library.Settings.Instance.Title;
        }

        protected override void WndProc(ref Message message)
        {
            if (message.Msg == Library.Defines.START_PROCESSES)
            {
                state = Library.State.Working;
                model.Listening = true;
            }
            else if (message.Msg == Library.Defines.STOP_PROCESSES)
            {
                state = Library.State.Waiting;
                model.Listening = false;
            }
            else if (message.Msg == Library.Defines.EXIT_PROGRAMM)
            {
                Close();
            }
            else
            {
                base.WndProc(ref message);
            }
            statusLine.Text = setStatus();
        }

        private void onFileReaded(string text)
        {
            fileView.Text = text;
            fileView.SelectionStart = fileView.Text.Length;
            fileView.ScrollToCaret();
        }

        private string setStatus()
        {
            string str = "";
            switch (state)
            {
                case Library.State.NotStarted: str = "симуляция ещё не начата"; break;
                case Library.State.Waiting: str = "приостановленно"; break;
                case Library.State.Working: str = "ожидание изменений в файле"; break;
            }
            return "Статус: " + str;
        }

    }
}
