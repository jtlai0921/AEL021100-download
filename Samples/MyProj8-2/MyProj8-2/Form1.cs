﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProj8_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show("您選取的日期範圍為 " +
              monthCalendar1.SelectionStart.ToShortDateString() +
              " ~ " + monthCalendar1.SelectionEnd.ToShortDateString());
        }
    }
}
