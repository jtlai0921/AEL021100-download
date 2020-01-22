using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProj8_19
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
            float X1 = -200;
            float Y1 = (float)1 / 200 * (X1 * X1);
            float X2 = 0;
            float Y2 = 0;
            MyGraphics.DrawLine(MyPen, 10, 210, 410, 210);  //繪製X軸，X座標平移210像素點
            MyGraphics.DrawLine(MyPen, 210, 10, 210, 410);  //繪製Y軸，Y座標平移210像素點
            for (int i = -199; i <= 200; i++)
            {
                X2 = i;
                Y2 = (float)1 / 200 * (X2 * X2);
                MyGraphics.DrawLine(MyPen, X1 + 210, -Y1 + 210, X2 + 210, -Y2 + 210);
                X1 = X2;
                Y1 = Y2;
            }
        }
    }
}
