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


namespace danhbadienthoai
{
    public partial class Form1 : Form
    {
 

        public Form1()
        {
            InitializeComponent();

        }


        public Form1(string TAIKHOAN, string MATKHAU, string tennguoidung, string quyen)
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
         
        {
              SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-T3NIM1T\SQLEXPRESS;Initial Catalog=danhba;Integrated Security=True");
            try
            {
                con.Open();
                string TK = txtusername.Text;
                string MK = txtpassword.Text;
                string sql = " select *form dangnhap where TAIKHOAN= '" + TK + "' and MAKHAU='" + MK + "' ";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dt = cmd.ExecuteReader();

            }
            catch(Exception ex)
            {
              //  MessageBox.Show(" lỗi kết nối");
            }
            if(txtusername.Text=="admin" && txtpassword.Text=="123")
                if (txtusername.Text == "khanh" && txtpassword.Text == "Khanh")
                {
                    MessageBox.Show("Đăng nhập thành công");
                    this.Hide();
                    //  Form2 f = new Form2();
                    Trang_chủ t = new Trang_chủ();
                t.ShowDialog();
                t.Show();
                this.Close();
            }
            else
            {
               MessageBox.Show(" Đăng nhập thất bại");
                    Trang_chủ t = new Trang_chủ();
                    t.ShowDialog();
                    t.Show();
                    this.Close();
                }



        }

        private void btnext_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
