using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProj3_1b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (System.Convert.ToInt32(textBox1.Text))
            {
                //當使用者輸入1時
                case 1:
                    MessageBox.Show(textBox1.Text + "的英文為" + "ONE");
                    break;
                //當使用者輸入2時
                case 2:
                    MessageBox.Show(textBox1.Text + "的英文為" + "TWO");
                    break;
                //當使用者輸入3時
                case 3:
                    MessageBox.Show(textBox1.Text + "的英文為" + "THREE");
                    break;
                //當使用者輸入4時
                case 4:
                    MessageBox.Show(textBox1.Text + "的英文為" + "FOUR");
                    break;
                //當使用者輸入5時
                case 5:
                    MessageBox.Show(textBox1.Text + "的英文為" + "FIVE");
                    break;
                //當使用者輸入1-5以外的數字時
                default:
                    MessageBox.Show("您輸入的數字超過範圍！");
                    break;
            }
        }
    }
}
