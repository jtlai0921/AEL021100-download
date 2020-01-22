using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProj8_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Which_Picture = 1;									//這個變數用來記錄要顯示哪張圖片
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;                        //不顯示pictureBox1
            pictureBox2.Visible = false;                        //不顯示pictureBox2
            pictureBox3.Location = new Point(10, 10);  	        //設定pictureBox3的起始位置
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Which_Picture == 1)                             //若要顯示第一張圖片
            {
                pictureBox3.Image = pictureBox1.Image;
                Which_Picture = 2;
            }
            else                                                //若要顯示第二張圖片
            {
                pictureBox3.Image = pictureBox2.Image;
                Which_Picture = 1;
            }
            if (pictureBox3.Location.X < this.Width)            //若pictureBox3的X座標小於表單
                pictureBox3.Location = new Point(pictureBox3.Location.X + 20, 10);  //設定新位置
            else
                pictureBox3.Location = new Point(10, 10);       //設定由左重新跑起
        }
    }
}
