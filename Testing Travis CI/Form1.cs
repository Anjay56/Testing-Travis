using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_Travis_CI
{
    public partial class Form1 : Form
    {
        int x = 3;
        int y = 4;

        public Form1()
        {
            InitializeComponent();
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }
    }
}
