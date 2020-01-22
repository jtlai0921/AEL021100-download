using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProj8_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics MyGraphics = e.Graphics;                               //建立Graphics物件
            Pen MyPen1 = new Pen(Color.Red, 1);                             //定義畫筆
            Pen MyPen2 = new Pen(Color.Blue, 3);
            Pen MyPen3 = new Pen(Color.Green, 5);
            Point[] MyPoint1 = { new Point(250, 100), new Point(230, 120), new Point(200, 90) };
            Point[] MyPoint2 = { new Point(250, 10), new Point(230, 20), new Point(200, 50), new Point(250, 30) };
            MyGraphics.DrawEllipse(MyPen1, 10, 10, 50, 30);                 //繪製橢圓
            MyGraphics.DrawLine(MyPen2, 100, 100, 200, 200);                //繪製直線
            MyGraphics.DrawRectangle(MyPen3, 10, 70, 50, 80);               //繪製矩形
            MyGraphics.DrawPolygon(MyPen1, MyPoint1);                       //繪製多邊形
            MyGraphics.DrawCurve(MyPen2, MyPoint2);                         //繪製曲線
            MyGraphics.DrawPie(MyPen3, 300, 50, 100, 100, 45, 180);  	    //繪製派形
        }
    }
}
