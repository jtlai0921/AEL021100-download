using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProj3_1c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Total = 0;
            for (int i = System.Convert.ToInt32(textBox1.Text);
            i <= System.Convert.ToInt32(textBox2.Text); i++)
                Total = Total + i;          //這行敘述也可以改寫為Total += i;
            MessageBox.Show(textBox1.Text + "累加到" + textBox2.Text + "的總和為" + Total.ToString());
        }
    }
}
