using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TimViec.DAO;

namespace TimViec
{
    public partial class dangnhapquanly : DevExpress.XtraEditors.XtraForm
    {
        public dangnhapquanly()
        {
            InitializeComponent();
        }
        private void dangnhapquanly_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        public static string type = "";
        public string taikhoandangnhap()
        {
            return txtTaiKhoan.Text;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            type = accountDAO.Instance.gettype(txtTaiKhoan.Text, txtpassWord.Text);
            if (type != "")
            {
                frmmain fmain = new frmmain();
                fmain.Show();
            }
            else
            {
                MessageBox.Show("Tài khoảng và mật khẩu không đúng !");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       



    }
}