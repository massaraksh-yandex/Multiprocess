using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Writer
{
    public partial class WindowWriter : Form
    {
        class Design
        {
            public Brush brush;
            public string Text;
            public Font TextFont;

            public Design(Color br, string text, Font f, int width, int height)
            {
                Text = text;
                Size textSize = TextRenderer.MeasureText(text, f);
                float presentFontSize = f.Size;
                Font newFont = new Font(f.FontFamily, presentFontSize, f.Style);
                while ((textSize.Width > width || textSize.Height > height) && presentFontSize - 0.2F > 0)
                {
                    presentFontSize -= 0.2F;
                    newFont = new Font(f.FontFamily, presentFontSize, f.Style);
                    textSize = TextRenderer.MeasureText(text, newFont);
                }
                TextFont = newFont;
                brush = new SolidBrush(br);
            }
        }

        Model model;
        Library.State state;
        Dictionary<Library.State, Design> designs;

        public WindowWriter()
        {
            model = new Model();
            model.writingStarted  += new Model.StatusDelegate(onWriting);
            model.writingFinished += new Model.StatusDelegate(onWritingFinished);
            InitializeComponent();
            Text = Library.Settings.Instance.Title;
            state = Library.State.NotStarted;

            designs = new Dictionary<Library.State, Design>();
            designs[Library.State.NotStarted] = new Design(Color.Gray, "Не начато",
                new Font("Arial", 40), Width, Height);
            designs[Library.State.Waiting] = new Design(Color.Green, "Ожидание очереди",
                new Font("Arial", 40), Width, Height);
            designs[Library.State.Working] = new Design(Color.Red, "Идёт запись",
                new Font("Arial", 40), Width, Height);

            paintAll();
        }

        protected override void WndProc(ref Message message)
        {
            if (message.Msg == Library.Defines.START_PROCESSES)
            {
                state = Library.State.Working;
                model.StartTimer();
            }
            else if (message.Msg == Library.Defines.STOP_PROCESSES)
            {
                state = Library.State.NotStarted;
                model.SetFree();
                model.StopTimer();
                paintAll();
                Refresh();
            }
            else if (message.Msg == Library.Defines.EXIT_PROGRAMM)
            {
                Close();
            }
            else
            {
                base.WndProc(ref message);
            }
        }

        private void onWriting()
        {
            state = Library.State.Working;
            paintAll();
            Refresh();
        }

        private void onWritingFinished()
        {
            if(state != Library.State.NotStarted)
                state = Library.State.Waiting;
            paintAll();
            Refresh();
        }

        private void paintAll()
        {
            Graphics gc = CreateGraphics();

            Design d = designs[state];
            gc.FillRectangle(d.brush, 0, 0, Width, Height);

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            Brush pen = new SolidBrush(Color.Black);
            gc.DrawString(d.Text, d.TextFont, pen, new RectangleF(-5, 0, Width, Height-10), sf);
        }

        private void Window_Paint(object sender, PaintEventArgs e)
        {
            paintAll();
        }

        private void WindowWriter_FormClosed(object sender, FormClosedEventArgs e)
        {
            model.SetFree();
        }
    }
}
