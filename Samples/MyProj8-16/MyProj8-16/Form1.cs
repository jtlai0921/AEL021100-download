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

namespace MyProj8_16
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
            LinearGradientBrush MyBrush = new LinearGradientBrush(ClientRectangle,
              Color.Red, Color.Yellow, LinearGradientMode.Horizontal);
            Font MyFont = new Font("標楷體", 20, FontStyle.Italic);
            MyGraphics.DrawString("Visual C# 程式設計", MyFont, MyBrush, 10, 10);
        }
    }
}
