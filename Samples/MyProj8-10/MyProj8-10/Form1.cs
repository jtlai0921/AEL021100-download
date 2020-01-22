using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProj8_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //呼叫此方法顯示對話方塊
            openFileDialog1.ShowDialog();
            //以預設的應用程式開啟檔案
            System.Diagnostics.Process.Start(openFileDialog1.FileName);
        }
    }
}
