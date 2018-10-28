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
using Business_Tier;

namespace TimViec
{
    public partial class DangNhap : DevExpress.XtraEditors.XtraForm
    {
        DataTable tbDangnhap;
        B_DangNhap obj = new B_DangNhap();
        public static bool admin = false;
        public static string tendangnhap = "";
        public static bool dadangnhap = false;
        public DangNhap()
        {
            InitializeComponent();
        }

        private bool Kiemtra()
        {
            if (txtTendangnhap.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Tên đăng nhập");
                return false;
            }
            else if (txtMatkhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu");
                return false;
            }
            else
                return true;
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            bool a = false;
            if (Kiemtra())
            {
                tbDangnhap = obj.getThongtindangnhap();
                foreach (DataRow dr in tbDangnhap.Rows)
                {
                    if (txtTendangnhap.Text == dr["tentk"].ToString() && txtMatkhau.Text == dr["matkhau"].ToString())
                    {

                        MessageBox.Show("Chúc mừng bạn đăng nhập thành công");
                        dadangnhap = true;
                        if (txtTendangnhap.Text == "admin")
                        {
                            admin = true;
                        }
                        tendangnhap = txtTendangnhap.Text;
                        frmMain frm = new frmMain();
                        frm.ShowDialog();
                        txtMatkhau.Text = "";
                        txtTendangnhap.Text = "";
                        a = true;

                    }


                }
                if (!a)
                {
                    MessageBox.Show("Bạn nhập sai hoặc chưa đăng ký tài khoản");
                }
            }
        }

        private void linkDangky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy frm = new DangKy();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát không? ", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
                Close();
        }

    }
}