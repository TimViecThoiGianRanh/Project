using LinQ;
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
    public partial class themthongtin : Form
    {
        quantriBLL qtbll = new quantriBLL();
        public themthongtin()
        {
            InitializeComponent();
        }

        private void btnhuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string tenqt = Ten.Text;
            string diachi = DiaChi.Text;
            string sdt = Sdt.Text;
            quantri qt = new quantri();
            qt.tenqt = tenqt;
            qt.diachi = diachi;
            qt.sdt = sdt;
            qt.maqt = "";
            int kq = qtbll.themmod(qt);
            if (kq == 1)
            {
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
            else
                MessageBox.Show("Nhập lại");
            
        }
    }
}
