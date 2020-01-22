using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProj8_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //呼叫此方法顯示瀏覽資料夾對話方塊
            folderBrowserDialog1.ShowDialog();
            //以對話方塊顯示選取的資料夾路徑
            MessageBox.Show(folderBrowserDialog1.SelectedPath);
        }
    }
}
