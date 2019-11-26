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
namespace BaiQuanLyBanHang
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
     
        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4NNB39U\SQLEXPRESS;Initial Catalog=BanHang;Integrated Security=True");
            String query = "Select * from tbl_Login where username ='" + textBox1.Text + "'and userpassword ='" + textBox2.Text + "'";
 
 
            SqlDataAdapter sda = new SqlDataAdapter(query,con);//show du lieu ra
            DataTable dt = new DataTable();//mot vung show du lieu
            sda.Fill(dt);//data adapter vao datatable
        
          
            if (dt.Rows.Count==1)
            {
                
                Menucs main = new Menucs();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kiem tra lai tai khoan hoac mat khau");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
