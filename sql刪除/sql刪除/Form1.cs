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

namespace sql刪除
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using(SqlConnection con = cn1.cn)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText =
                    $"Delete From Account Where AccountID = (N'38')";
                //$"Delete From Account Where Name = (N'juje')";
                //$"Delete * From Account 或 $"Delete From Account
                //刪除某資料表中所有的資料
                cmd.ExecuteNonQuery();
            }
        }
    }
}
