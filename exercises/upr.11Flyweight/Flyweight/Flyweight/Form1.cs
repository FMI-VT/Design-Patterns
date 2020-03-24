using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Flyweight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Height = 600;
            this.Width = 600;
            this.Text = "Picture Groups";
            Client client = new Client();
            client.LoadGroups();
            this.Paint += new PaintEventHandler(client.DisplayGroups);
        }
    }
}
