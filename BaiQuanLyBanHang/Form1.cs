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
    public partial class fHome : Form
    {
        
        public fHome()
        {
            InitializeComponent();
            
        }

        /*  private void LoadDuLieu()
           {
               string connectionSTR = @"Data Source=DESKTOP-4NNB39U\SQLEXPRESS;Initial Catalog=SanPham;Integrated Security=True";
               SqlConnection con = new SqlConnection(connectionSTR);

               string query = "Select * from dbo.Hang";
               con.Open();
               SqlCommand cmd = new SqlCommand(query, con);
               DataTable data = new DataTable();
               SqlDataAdapter adapter = new SqlDataAdapter(cmd);
               adapter.Fill(data);
               con.Close();
               dataGridView1.DataSource = data;


           }*/

        SqlConnection con;
        private void fHome_Load(object sender, EventArgs e)
        {
            
            string conString= ConfigurationManager.ConnectionStrings["QuanLy"].ConnectionString.ToString();//khai báo đối tượng
            con = new SqlConnection(conString);//tạo đói tượng
            con.Open();//mo ket noi
            HienThi();
        }


    




        public void HienThi()
        {
            string sqlSELECT = "select *from SanPham";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();//tạo đối tượng bảng
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMahang.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTenhang.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtGiaban.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtLoaihang.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtMaugiay.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string sqlINSERT = "insert dbo.SanPham(Magiay, Tengiay, Gia, Loaigiay,Maugiay) " +
              "values(@Magiay, @Tengiay, @Gia, @Loaigiay,@Maugiay)";
            SqlCommand cmd = new SqlCommand(sqlINSERT, con);

            cmd.Parameters.AddWithValue("Magiay", txtMahang.Text);
            cmd.Parameters.AddWithValue("Tengiay", txtTenhang.Text);
            cmd.Parameters.AddWithValue("Gia", txtGiaban.Text);
            cmd.Parameters.AddWithValue("Loaigiay", txtLoaihang.Text);
            cmd.Parameters.AddWithValue("Maugiay", txtMaugiay.Text);
            cmd.ExecuteNonQuery();
            HienThi();
            MessageBox.Show(" Thêm mới Thành công");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "delete from dbo.SanPham where magiay = @Magiay";
            SqlCommand cmd = new SqlCommand(sqlDELETE, con);


            cmd.Parameters.AddWithValue("Magiay", txtMahang.Text);
            cmd.Parameters.AddWithValue("Tengiay", txtTenhang.Text);
            cmd.Parameters.AddWithValue("Gia", txtGiaban.Text);
            cmd.Parameters.AddWithValue("Loaigiay", txtLoaihang.Text);
            cmd.Parameters.AddWithValue("Maugiay", txtMaugiay.Text);
            cmd.ExecuteNonQuery();
            HienThi();
            MessageBox.Show("Thành công");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sqlEdit = "update dbo.SanPham set" +
         " tengiay = @Tengiay, gia = @Gia, loaigiay = @Loaigiay,maugiay=@Maugiay where magiay = @Magiay";
            SqlCommand cmd = new SqlCommand(sqlEdit, con);


            cmd.Parameters.AddWithValue("Magiay", txtMahang.Text);
            cmd.Parameters.AddWithValue("Tengiay", txtTenhang.Text);
            cmd.Parameters.AddWithValue("Gia", txtGiaban.Text);
            cmd.Parameters.AddWithValue("Loaigiay", txtLoaihang.Text);
            cmd.Parameters.AddWithValue("Maugiay", txtMaugiay.Text);
            cmd.ExecuteNonQuery();
            HienThi();
            MessageBox.Show("Thành công");
        }

        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            txtMahang.Clear();
            txtTenhang.Clear();
            txtGiaban.Clear();
            txtLoaihang.Clear();
            txtMaugiay.Clear();
        }

        private void fHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
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
