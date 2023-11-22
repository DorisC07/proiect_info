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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int p = 0;
            if (radioButton13.Checked)
                p++;
            if (radioButton17.Checked)
                p++;
            if (radioButton19.Checked)
                p++;
            if (radioButton24.Checked)
                p++;
            if (p < 3)
                MessageBox.Show("Mai încearcă o dată");
            else
                MessageBox.Show("Felicitări");
        }
    }
}
