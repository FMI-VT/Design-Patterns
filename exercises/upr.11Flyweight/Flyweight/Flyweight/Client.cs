using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Flyweight
{
    class Client
    {
        // Shared state - the images
        static FlyweightFactory album = new FlyweightFactory();
        // Unshared state - the groups
        static Dictionary<string, List<string>> allGroups = new Dictionary<string, List<string>>();
        public void LoadGroups()
        {
            var myGroups = new[] {
                new {Name = "Sleep",  Members = new [] {"cat3.jpg", "cat7.jpg", "cat9.jpg"}},
                new {Name = "Wayward",   Members = new [] {"cat2.jpg","cat4.jpg"}},
                new {Name = "Social pics",    Members = new [] {"cat11.jpg", "cat8.jpg", "cat.jpg","cat6.jpg"}},
                new {Name = "Hunger", Members = new [] {"cat10.jpg", "cat5.jpg"}} 
            };
            // Load the Flyweights, saving on shared intrinsic state
            foreach (var g in myGroups)
            { // implicit typing
                allGroups.Add(g.Name, new List<string>());
                foreach (string filename in g.Members)
                {
                    allGroups[g.Name].Add(filename);
                    album[filename].Load(filename);
                }
            }
        }
        public void DisplayGroups(Object source, PaintEventArgs e)
        {
            // Display the Flyweights, passing the unshared state
            int row=0;
            foreach (string g in allGroups.Keys)
            {
                int col=0;
                
                e.Graphics.DrawString(g, new Font("Arial", 16), new SolidBrush(Color.Black), new PointF(0, row * 130 + 10));
                foreach (string filename in allGroups[g])
                {
                    album[filename].Display(e, row, col);
                    col++;
                }
                row++;
            }
        }
    }
}
