using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProj7_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Prefer = "您喜愛的早餐有 ";
            if (checkBox1.Checked) Prefer += "三明治 ";
            if (checkBox2.Checked) Prefer += "潛水艇 ";
            if (checkBox3.Checked) Prefer += "燒餅 ";
            if (checkBox4.Checked) Prefer += "飯糰 ";
            if (checkBox5.Checked) Prefer += "蘿蔔糕 ";
            MessageBox.Show(Prefer, "早餐問卷調查");
        }
    }
}
