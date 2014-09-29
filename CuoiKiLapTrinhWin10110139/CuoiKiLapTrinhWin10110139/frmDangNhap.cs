using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;


namespace CuoiKiLapTrinhWin10110139
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form1();
           
            frm.ShowDialog();

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if ((this.txtuser.Text == "admin") && (this.txtpass.Text == "admin"))
            {
                this.Hide();
                Form frm = new Form1();
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Không đúng tên người dùng/pass", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                this.txtuser.Focus();
            }
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtuser.Text == "admin" && txtpass.Text == "admin")
                {
                    this.Hide();
                    Form frm = new Form1();
                    frm.ShowDialog();
                }
            }
        }

    }
}
