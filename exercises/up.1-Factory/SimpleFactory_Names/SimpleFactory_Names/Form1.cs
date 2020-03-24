using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleFactory_Names
{
    public partial class Form1 : Form
    {
        NameFactory nameFact;
        public Form1()
        {
            InitializeComponent();
            nameFact = new NameFactory();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            Names test = nameFact.getName(txbName.Text);
            txbFirst.Text = test.getFrname();
            txbLast.Text = test.getLname();
        }
    }
}
