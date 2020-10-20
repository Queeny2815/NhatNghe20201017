using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace DesktopApp3
{
    public partial class Form1 : Form
    {
        string strCon = "Data Source=pc19;Initial Catalog=QLHD;Integrated Security=True";
        private string chuoiketnoi;
        private string ketnoi;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs E)
        {
            try
            {

                SqlConnection conn = new SqlConnection(strCon);
                SqlDataAdapter da = new SqlDataAdapter("select * from thanhpho", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "TenThanhPho";
                comboBox1.ValueMember = "MaThanhPho";

            }
            catch (Exception EX)
            {

            }



        }




        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks!");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                string mathanhpho = comboBox1.SelectedValue.ToString();
                SqlConnection ketnoi = new SqlConnection(chuoiketnoi);
                string sql = "select * from khachhang where mathanhpho=" + mathanhpho;
                SqlDataAdapter da = new SqlDataAdapter(sql, ketnoi);
                SqlConnection conn = new SqlConnection(strCon);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;


            }
            catch (Exception ex)
            {

            }

        }
    }
}
