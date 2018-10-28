using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimViec
{
    public partial class Thongtin : Form
    {
        quantriBLL qt = new quantriBLL();
        public Thongtin()
        {
            InitializeComponent();
            loadthongtin();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void loadthongtin()
        {
            dangnhapquanly dn = new dangnhapquanly();
            if (dangnhapquanly.type == "9")
            {
                Ten.Text = "Phạm Thạch Sơn Tùng";
                DiaChi.Text = "Phòng trọ";
                Sdt.Text = "0363064268";
            }
            else
            {
                DataTable mod = qt.thongtinkhachhang(dn.taikhoandangnhap());

                string tenmod = Convert.ToString(mod.Rows[0]["tenqt"].ToString());
                string diachi = Convert.ToString(mod.Rows[0]["diachi"].ToString());
                string sodt = Convert.ToString(mod.Rows[0]["Sdt"].ToString());
                Ten.Text = tenmod;
                DiaChi.Text = diachi;
                Sdt.Text = sodt;
            }
            
        }
        
    }
}
