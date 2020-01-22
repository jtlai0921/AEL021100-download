using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProj8_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics MyGraphics = e.Graphics;
            Pen MyPen = new Pen(Color.Black, 1);
            for (int i = 1; i <= 10; i++)
            {
                MyGraphics.DrawEllipse(MyPen, 10, 10, 80, 80);
                MyGraphics.TranslateTransform(10, 0);
            }
            MyGraphics.ResetTransform();
            MyGraphics.TranslateTransform(300, 100);
            for (int i = 1; i <= 36; i++)
            {
                MyGraphics.DrawRectangle(MyPen, 10, 10, 50, 50);
                MyGraphics.RotateTransform(10);
            }
        }
    }
}
