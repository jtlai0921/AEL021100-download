using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProj3_1d
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Result = 1;                 //宣告用來存放計算結果的變數Result且初始值為1
            for (int i = 1; i <= System.Convert.ToInt32(textBox1.Text); i++)
                Result = Result * i;        //這行敘述也可以改寫為Result *= i;
            MessageBox.Show(textBox1.Text + "!的值為" + Result);
        }
    }
}
