using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyProj11_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection1.Open();      //開啟資料連接
                                        //建立SqlDataReader物件
            SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();
            //透過ComboBox控制項顯示查詢結果中的學生姓名
            while (sqlDataReader1.Read())
            {
                comboBox1.Items.Add(sqlDataReader1.GetString(1));
            }
            sqlDataReader1.Close();     //關閉SqlDataReader物件
            sqlConnection1.Close();		//關閉資料連接
        }
    }
}
