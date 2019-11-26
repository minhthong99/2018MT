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
using System.Configuration;
namespace BaiQuanLyBanHang
{
    public partial class TaiKhoan : Form
    {
        public TaiKhoan()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QuanLy"].ConnectionString.ToString();//khai báo đối tượng
            con = new SqlConnection(conString);//tạo đói tượng
            con.Open();//mo ket noi
            HienThi();
        }
        public void HienThi()
        {
            string sqlSELECT = "select *from tbl_Login";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();//tạo đối tượng bảng
            dt.Load(dr);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtUsername.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPassword.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string sqlINSERT = "insert dbo.tbl_Login(id,username , userpassword) " +
            "values(@id, @username, @userpassword)";
            SqlCommand cmd = new SqlCommand(sqlINSERT, con);

            cmd.Parameters.AddWithValue("id", txtID.Text);
            cmd.Parameters.AddWithValue("username", txtUsername.Text);
            cmd.Parameters.AddWithValue("userpassword", txtPassword.Text);
          
            cmd.ExecuteNonQuery();
            HienThi();
            MessageBox.Show("Thành công");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "delete from dbo.tbl_Login where id = @id";
            SqlCommand cmd = new SqlCommand(sqlDELETE, con);
            cmd.Parameters.AddWithValue("id", txtID.Text);
            cmd.Parameters.AddWithValue("username", txtUsername.Text);
            cmd.Parameters.AddWithValue("userpassword", txtPassword.Text);

            cmd.ExecuteNonQuery();
            HienThi();
            MessageBox.Show("Thành công");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sqlEdit = "update dbo.tbl_Login set" +
       "  username = @username, userpassword = @userpassword where id=@id";
            SqlCommand cmd = new SqlCommand(sqlEdit, con);
            cmd.Parameters.AddWithValue("id", txtID.Text);
            cmd.Parameters.AddWithValue("username", txtUsername.Text);
            cmd.Parameters.AddWithValue("userpassword", txtPassword.Text);

            cmd.ExecuteNonQuery();
            HienThi();
            MessageBox.Show("Thành công");
        }

        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Menucs menu = new Menucs();
            menu.Show();
            menu.FormClosed += new FormClosedEventHandler(menu_FormClosed);
            this.Hide();
        }
        private void menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
