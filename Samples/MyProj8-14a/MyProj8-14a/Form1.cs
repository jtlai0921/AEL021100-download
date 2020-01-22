using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace MyProj8_14a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics MyGraphics = e.Graphics;          						//建立Graphics物件
            SolidBrush MyBrush1 = new SolidBrush(Color.Red);                //定義筆刷
            HatchBrush MyBrush2 = new HatchBrush(HatchStyle.Plaid, Color.Yellow, Color.Blue);
            TextureBrush MyBrush3 = new TextureBrush(new Bitmap(@"D:\bg2.bmp"));
            LinearGradientBrush MyBrush4 = new LinearGradientBrush(ClientRectangle, Color.Red, Color.Yellow, LinearGradientMode.Vertical);
            Point[] MyPoint1 = { new Point(250, 100), new Point(230, 120), new Point(200, 90) };
            Point[] MyPoint2 = { new Point(250, 10), new Point(230, 20), new Point(200, 50), new Point(250, 30) };
            MyGraphics.FillEllipse(MyBrush3, 10, 10, 50, 30);        	    //填滿橢圓
            MyGraphics.FillRectangle(MyBrush2, 10, 70, 50, 80);       	    //繪製矩形
            MyGraphics.FillPolygon(MyBrush1, MyPoint1);           	        //繪製多邊形
            MyGraphics.FillPie(MyBrush4, 300, 50, 100, 100, 45, 180);       //繪製派形        
        }
    }
}
