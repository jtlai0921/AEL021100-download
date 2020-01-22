using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProj7_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //將LinkVisited屬性設定為true，令超連結變成已瀏覽的超連結色彩
            linkLabel1.LinkVisited = true;

            //呼叫Process.Start() 方法以預設的瀏覽器開啟指定的網址
            System.Diagnostics.Process.Start("https://tw.yahoo.com/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkVisited = true;
            Form f = new Form();              //建立另一個表單
            f.Show();                    	  //呼叫 Show() 方法顯示表單            
        }
    }
}
