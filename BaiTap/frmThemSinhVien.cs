using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BaiTap
{
    public partial class frmAdd : Form
    {
        frmMain fmain;
     
        public frmAdd(frmMain formMain)
        {
            InitializeComponent();
            this.fmain = formMain;
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int temp = 1;
            errorProvider1.SetError(txtId, "");
            errorProvider2.SetError(txtName, "");
            errorProvider3.SetError(txtAverageScore, "");
            if(txtId.Text ==""|| txtName.Text == "" || txtAverageScore.Text == "" )
            {
                MessageBox.Show("Chua nhap day du thong tin, yeu cau nhap lai!");
                return;
            }

            if (double.Parse(txtAverageScore.Text)  > 10 || double.Parse(txtAverageScore.Text) < 0)
            {
                MessageBox.Show("DTB trong khoang 0-10");
                return;

            }
            else
            {
                MessageBox.Show("Nhap thong tin thanh cong");
            

            }

            DataGridView dataGridView = fmain.dgvData;
           
            dataGridView.Rows.Add(temp,txtId.Text, txtName.Text, cmbFaculty.Text, txtAverageScore.Text);
            temp++;
       
        }
       
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
