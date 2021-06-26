using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace danhbadienthoai
{
    public partial class Trang_chủ : Form
    {
        public Trang_chủ()
        {
            InitializeComponent();
        }



        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quảnLýDanhBạToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
            this.Hide();
            
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            doimatkhau d = new doimatkhau();
            d.ShowDialog();
        }

        private void chươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thốngKêSốĐiệnThoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formreport f = new formreport();
            f.ShowDialog();
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chucsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chucvu cv = new chucvu();
            cv.ShowDialog();
            this.Hide();
        }
    }
}
