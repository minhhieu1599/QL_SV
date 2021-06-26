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


    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
      
        }
        SqlConnection con1;
       // SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-T3NIM1T\SQLEXPRESS;Initial Catalog=danhba;Integrated Security=True");
       // private void hienthidulieu()
       // {
            
        //    string sql1 = " select * form thongtincanhan";
       //     SqlCommand cmd1 = new SqlCommand(sql1,con1);
        //    cmd1.CommandType = CommandType.Text;
       //     SqlDataAdapter dt = new SqlDataAdapter(cmd1);
        //    DataTable da = new DataTable();
        //    dt.Fill(da);
        //    datagrview.DataSource = da;
       // }

      //  private void Form2_Load(object sender, EventArgs e)
      //  {
       //     con1 = new SqlConnection(@"Data Source = DESKTOP-T3NIM1T\SQLEXPRESS; Initial Catalog = danhba; Integrated Security = True");
       //     con1.Open();
       //     hienthidulieu();
       // }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            con1 = new SqlConnection(@"Data Source = DESKTOP-T3NIM1T\SQLEXPRESS; Initial Catalog = danhba; Integrated Security = True");
            con1.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            danhbaEntities db = new danhbaEntities();
            datagrview.DataSource = db.getalldanhba();
        }

        private void data_click(object sender, DataGridViewCellEventArgs e)
        {
            if (datagrview.CurrentRow.Cells[0].Value != null)
            {
                txtID.Text = datagrview.CurrentRow.Cells[0].Value.ToString();
            }
            if (datagrview.CurrentRow.Cells[1].Value != null)
            {
                txtSdt.Text = datagrview.CurrentRow.Cells[1].Value.ToString();
            }
            if (datagrview.CurrentRow.Cells[2].Value != null)
            {
                txtHoten.Text = datagrview.CurrentRow.Cells[2].Value.ToString();
            }
            if (datagrview.CurrentRow.Cells[3].Value != null)
            {
                txtTinh.Text = datagrview.CurrentRow.Cells[3].Value.ToString();
            }
            if (datagrview.CurrentRow.Cells[4].Value != null)
            {
                txtHuyen.Text = datagrview.CurrentRow.Cells[4].Value.ToString();
            }
            if (datagrview.CurrentRow.Cells[5].Value != null)
            {
                txtXa.Text = datagrview.CurrentRow.Cells[5].Value.ToString();
            }
            if (datagrview.CurrentRow.Cells[6].Value != null)
            {
                txtcm.Text = datagrview.CurrentRow.Cells[6].Value.ToString();
            }

            else
            {
                txtSdt.Text = " ";

            }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            danhbaEntities db = new danhbaEntities();
            db.danhba_update_thongtincanhan(int.Parse(txtID.Text.ToString()),
                int.Parse(txtSdt.Text.ToString()),
                txtHoten.Text,
                txtTinh.Text,
                txtHuyen.Text,
                txtXa.Text,
                bool.Parse(txtcm.Text.ToString())
                );

            datagrview.DataSource = db.getalldanhba();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            danhbaEntities db = new danhbaEntities();
            db.SP_Xoahongtincanhan(int.Parse(txtID.Text.ToString()));

            datagrview.DataSource = db.getalldanhba();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {

            danhbaEntities db = new danhbaEntities();
            if (txtcm.Text.ToString() == "Nam")
                db.SP_InsertThongtincanhan_1(int.Parse(txtID.Text.ToString()),
                    int.Parse(txtSdt.Text.ToString()),
                    txtHoten.Text.ToString(),
                    txtTinh.Text.ToString(),
                    txtHuyen.Text.ToString(),
                    txtXa.Text.ToString(),
                        true);
                else
                    db.SP_InsertThongtincanhan_1(int.Parse(txtID.Text.ToString()),
                   int.Parse(txtSdt.Text.ToString()),
                   txtHoten.Text.ToString(),
                   txtTinh.Text.ToString(),
                   txtHuyen.Text.ToString(),
                   txtXa.Text.ToString(),
                   false);
                datagrview.DataSource = db.getalldanhba();

            clear();
        }
            void clear ()
        {
            txtID.Clear();
            txtSdt.Clear();
            txtHoten.Clear();
            txtTinh.Clear();
            txtHuyen.Clear();
            txtXa.Clear();
            //txtcm.Clear();

            txtID.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
            danhbaEntities db = new danhbaEntities();
            datagrview.DataSource = db.getalldanhba();

        }
  
        private void btntkhoten_Click(object sender, EventArgs e)
        {
         //   danhbaEntities db = new danhbaEntities();
       //    datagrview.DataSource= db.seaechthongtincanhan_nn(txttkhoten.Text);

            
        }

        private void btntksdt_Click(object sender, EventArgs e)
        {
            danhbaEntities db = new danhbaEntities();
            datagrview.DataSource = db.db_Searchthongtincanhan_SDT(int.Parse(txttksdt.Text.ToString()));
            

        }

        private void datagrview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //   while ( biennhap == DialogResult.ok && x != "");

        //      kn += "hoten like '%' ";

        // db.cn_timkiem_thongtincanhan()

        //  datagrview.DataSource = db.getalldanhba();

    }
}
