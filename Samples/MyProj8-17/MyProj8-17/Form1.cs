using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProj8_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics MyGraphics = e.Graphics;
            SolidBrush MyBrush = new SolidBrush(Color.Black);
            Font MyFont = new Font("新細明體", 12);
            MyGraphics.DrawString(textBox1.Text, MyFont, MyBrush, 10, 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult Result = printDialog1.ShowDialog();
            if (Result == DialogResult.OK)
                printDocument1.Print();
        }
    }
}
