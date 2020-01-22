using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProj3_1e
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Result1 = "", Result2 = "";
            for (int i = 1; i <= 9; i++)                                        //第一個迴圈的開始
            {
                Result1 = "";
                for (int j = 1; j <= 9; j++)                                    //第二個迴圈的開始
                {
                    Result1 = Result1 + i + "*" + j + "=" + i * j + '\t';       //'\t' 表示 [Tab] 鍵
                }                                                               //第二個迴圈的結尾
                Result2 = Result2 + Result1 + '\n';                             //'\n' 表示 [Enter] 鍵
            }                                                                   //第一個迴圈的結尾
            MessageBox.Show(Result2);
        }
    }
}
