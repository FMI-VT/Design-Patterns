using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace DecoratorPhoto
{
    // The original Photo class
    public class Photo : Form
    {
        Image image;
        public Photo()
        {
            image = new Bitmap("juice.jpg");
            /*
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                //open.InitialDirectory = "D:";
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    image = new Bitmap(open.FileName);
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
             */
            this.Text = "Orange Juice";
            this.Paint += new PaintEventHandler(Drawer);
        }
        public virtual void Drawer(Object source, PaintEventArgs e)
        {
            e.Graphics.DrawImage(image, 20, 20); // 30,20
        }
    }
}
