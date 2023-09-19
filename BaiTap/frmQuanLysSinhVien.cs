using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            string StudentName = txtFind.Text.ToLower();



            foreach (DataGridViewRow row in dgvData.Rows)
            {
                DataGridViewCell cell = row.Cells[2];
                if (cell.Value != null)
                {
                    string StuNameRow = cell.Value.ToString().ToLower();
                    row.Visible = StuNameRow.Contains(StudentName);

                }
            }
        }
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmAdd frmAdd = new frmAdd(this);
            frmAdd.Show();

            
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmAdd frmAdd = new frmAdd(this);
            frmAdd.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            frmAdd frmAdd = new frmAdd(this);
            frmAdd.Show();
        }

    }
}
