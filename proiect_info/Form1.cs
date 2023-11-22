using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_info
{
    public partial class Form1 : Form
    {
        int x, y, z;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = 1;
            if (x*y*z==1)
                button4.Visible = true; 
            Pagina1 p1 = new Pagina1();
            p1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Test p4 = new Test();
            p4.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            y = 1;
            if (x * y * z == 1)
                button4.Visible = true;
            Pagina2 p2 = new Pagina2();
            p2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            z = 1;
            if (x * y * z == 1)
                button4.Visible = true;
            Pagina3 p3 = new Pagina3();
            p3.ShowDialog();
        }
    }
}
