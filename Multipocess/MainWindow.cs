using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MultipocessRape
{
    public partial class MainWindow : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SendMessage(IntPtr hwnd, uint Msg, IntPtr wParam, IntPtr lParam);

        private bool runningPrograms;
        
        public MainWindow()
        {
            runningPrograms = false;
            InitializeComponent();
            fileNameText.Text = Library.Settings.Instance.File;
            Text = Library.Settings.Instance.Title;

            fileNameText.Text = Library.Settings.Instance.File;
            timerNumeric.Value = Library.Settings.Instance.TimerInterval;
            operationNumeric.Value = Library.Settings.Instance.OperationTime;
            timeEventName.Text = Library.Settings.Instance.WaitEventName;

            setEnabledByStart(false);
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Файл для наблюдения";
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                fileNameText.Text = dialog.FileName;
            }
        }

        private void terminateButton_Click(object sender, EventArgs e)
        {
            sendMessages("Reader", Library.Defines.EXIT_PROGRAMM);
            sendMessages("Writer", Library.Defines.EXIT_PROGRAMM);
            runningPrograms = false;
            setEnabledByStart(false);
            setActionButtonName();
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            uint message = runningPrograms ? Library.Defines.STOP_PROCESSES : Library.Defines.START_PROCESSES;
            runningPrograms = !runningPrograms;
            setActionButtonName();

            sendMessages("Reader", message);
            sendMessages("Writer", message);
        }

        private void sendMessages(string program, uint code)
        {
            Process[] processes = Process.GetProcessesByName(program);
            foreach (Process p in processes)
            {
                SendMessage(p.MainWindowHandle, code, IntPtr.Zero, IntPtr.Zero);
            }
        }

        private string createSettingsString(int processId)
        {
            return Library.Utils.SettingsString(fileNameText.Text, operationNumeric.Value,
                                                   timerNumeric.Value, timeEventName.Text, processId);
        }

        private void setActionButtonName()
        {
            actionButton.Text = runningPrograms ? "Остановить симуляцию" : "Запустить симуляцию";
            startToolStripMenuItem.Text = runningPrograms ? "Остановить симуляцию" : "Запустить симуляцию";
        }

        private void setEnabledByStart(bool started)
        {
            groupBox1.Enabled = !started;
            groupBox2.Enabled = !started;
            groupBox3.Enabled = started;

            симуляцияToolStripMenuItem.Enabled = started;
            выбратьФайлДляСлеженияToolStripMenuItem.Enabled = !started;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            actionButton.Text = "Запустить симуляцию";
            int number = (int)numWriters.Value;

            for (int i = 0; i < number; i++)
            {
                Process process = new Process();
                process.StartInfo.FileName = readingExe();
                process.StartInfo.Arguments = createSettingsString(i);
                process.Start();
            }

            for (int i = 0; i < number; i++)
            {
                Process process = new Process();
                process.StartInfo.FileName = writingExe();
                process.StartInfo.Arguments = createSettingsString(i);
                process.Start();
            }

            setEnabledByStart(true);
        }

        private string writingExe()
        {
            return System.IO.Path.Combine(Application.StartupPath, "Writer.exe");
        }

        private string readingExe()
        {
            return System.IO.Path.Combine(Application.StartupPath, "Reader.exe");
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            terminateButton_Click(null, null);
        }

        private void выбратьФайлДляСлеженияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileButton_Click(sender, e);
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actionButton_Click(sender, e);
        }

        private void завершитьВсеПриложенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            terminateButton_Click(sender, e);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            terminateButton_Click(null, null);
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void справкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "help.chm");
        }
    }
}
