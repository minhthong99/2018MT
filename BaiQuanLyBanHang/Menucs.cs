using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiQuanLyBanHang
{
    public partial class Menucs : Form
    {
        public Menucs()
        {
            InitializeComponent();
        }

        private void Menucs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fHome main = new fHome();
            main.Show();//show nay co nghia khi hien thi co the lam viec song song voi form khac showdialog chiem tren khung man hinh va khong the  ban cac form khac
            main.FormClosed += new FormClosedEventHandler(main_FormClosed);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();
            tk.Show();
            tk.FormClosed += new FormClosedEventHandler(tk_FormClosed);
            this.Hide();
        }
        private void tk_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
    }
}
