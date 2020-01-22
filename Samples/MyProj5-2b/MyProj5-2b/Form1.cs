using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProj5_2b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double R = System.Convert.ToDouble(textBox1.Text);
            MessageBox.Show("圓面積為" + CircleArea(R).ToString());
        }

        private double CircleArea(double Radius)
        {
            return Radius * Radius * 3.1416;
        }
    }
}
