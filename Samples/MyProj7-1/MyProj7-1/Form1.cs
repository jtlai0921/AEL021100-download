using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProj7_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = true;
            richTextBox1.BulletIndent = 10;
        }

        private void richTextBox2_Enter(object sender, EventArgs e)
        {
            richTextBox2.SelectionHangingIndent = 15;
        }
    }
}
