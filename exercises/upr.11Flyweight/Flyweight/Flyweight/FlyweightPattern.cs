using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Flyweight
{
    // Flyweight Pattern 
    public interface IFlyweight
    {
        void Load(string filename);
        void Display(PaintEventArgs e, int row, int col);
    }
    public struct Flyweight : IFlyweight
    {
        // Intrinsic state
        Image pThumbnail;
        public void Load(string filename)
        {
            pThumbnail = new Bitmap("images/" + filename).
            GetThumbnailImage(100, 100, null, new IntPtr());// Here is important, that the picture must to be redicible to 100 X 100. Of example 532 X 532 pixels !!!
        }
        public void Display(PaintEventArgs e, int row, int col)
        {
            e.Graphics.DrawImage(pThumbnail, col * 100 + 10, row * 130 + 40,
            pThumbnail.Width, pThumbnail.Height);
        }
    }
    public class FlyweightFactory
    {
        // Keeps an indexed list of IFlyweight objects in existence
        Dictionary<string, IFlyweight> flyweights = new Dictionary<string, IFlyweight>();
        public FlyweightFactory()
        {
            flyweights.Clear();
        }
        public IFlyweight this[string index]
        {
            get
            {
                if (!flyweights.ContainsKey(index))
                    flyweights[index] = new Flyweight();
                return flyweights[index];
            }
        }
    }

}
