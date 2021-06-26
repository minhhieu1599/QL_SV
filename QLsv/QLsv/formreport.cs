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
    public partial class formreport : Form
    {
        public formreport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.getalldanhba();
            db.demsoluong();
            MessageBox.Show("");
            if(dataGridView1.CurrentRow.Cells[0].Value != null)
            {
                db.demsoluong();
            }

        }
        danhbaEntities db = new danhbaEntities();
        private void formreport_Load(object sender, EventArgs e)
        {
            
            db.demsoluong();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DataSource = db.getalldanhba();
            db.demsoluong();
        }
    }
}
