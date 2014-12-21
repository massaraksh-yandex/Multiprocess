using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Writer
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

}
