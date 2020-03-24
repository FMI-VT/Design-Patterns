using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace DecoratorPhoto
{
    // This simple BorderedPhoto decorator adds a colored border of fixed size
    class BorderedPhoto : Photo
    {
        Photo photo;
        Color color;
        public BorderedPhoto(Photo p, Color c)
        {
            photo = p;
            color = c;
        }
        public override void Drawer(Object source, PaintEventArgs e)
        {
            photo.Drawer(source, e);
            e.Graphics.DrawRectangle(new Pen(color, 10), 25, 15, 215, 225);
        }
    }
}
