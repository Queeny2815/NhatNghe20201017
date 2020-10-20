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

namespace DesktopApp3
{
    public partial class Form2 : Form
    {

        string strCon = "Data Source=pc19;Initial Catalog=QLHD;Integrated Security=True";
        private string chuoiketnoi;

        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Dodulieu();
        }
        public void Dodulieu()
        {
            try
            {


                SqlConnection conn = new SqlConnection(strCon);
                SqlDataAdapter da = new SqlDataAdapter("select * from thanhpho", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);


            }
            catch (Exception EX)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenthanhpho = textBox1.Text;
            string sql = "insert into thanhpho(tenthanhpho) values ( ' " + tenthanhpho + " ' )";
            try
            {
                SqlConnection ketnoi = new SqlConnection(chuoiketnoi);
                ketnoi.Open();
                SqlCommand cmd = new SqlCommand(sql, ketnoi);
                cmd.ExecuteNonQuery();
                ketnoi.Close();
                Dodulieu();

            }
              catch(Exception ex)
            {

            }
        }
    }
}
