using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProj5_2a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double C = System.Convert.ToDouble(textBox1.Text);
            Convert2F(C);
        }

        private void Convert2F(double DegreeC)
        {
            double DegreeF = DegreeC * 1.8 + 32;
            MessageBox.Show("攝氏" + DegreeC + "度可以轉換成華氏" + DegreeF + "度");
        }
    }
}
