using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProj8_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            MessageBox.Show("您選取的日期為" + dateTimePicker1.Value.ToShortDateString());
        }
    }
}
