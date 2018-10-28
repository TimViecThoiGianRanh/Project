using BLL;
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
    public partial class frmbaidang : Form
    {
        baidangBLL bd = new baidangBLL();
        BaiDangBLL bdlq = new BaiDangBLL();
        chitietbdBLL ctbd = new chitietbdBLL();
        dangkyBLL dklq = new dangkyBLL();
        BindingSource bindingBD = new BindingSource();
        public frmbaidang()
        {
            InitializeComponent();
            dgbaidang.DataSource = bindingBD;
            loadbaidang();
            adbingdingbaidang();
        }
        void loadbaidang()
        {
            bindingBD.DataSource = bd.danhsachbaidang();
        }

        void adbingdingbaidang()
        {
            txtmabd.DataBindings.Add(new Binding("EditValue", dgbaidang.DataSource, "mabd", true, DataSourceUpdateMode.Never));
        }

        private void dgbaidang_SelectionChanged(object sender, EventArgs e)
        {
            xoa.Enabled = true;
        }

        private void xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            luu.Enabled = true;
            xoa.Enabled = false;
        }

        private void frmbaidang_Load(object sender, EventArgs e)
        {
            xoa.Enabled = false;
            luu.Enabled = false;
        }

        private void tim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string mabd = txtmabd.EditValue.ToString();
            try
            {
                if (bd.timbaidang(mabd) != null)
                    bindingBD.DataSource = bd.timbaidang(mabd);
                else
                    MessageBox.Show("Không tìm thấy");
            }
            catch
            {
                MessageBox.Show("không tìm thấy");
            }
        }

        private void lammoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadbaidang();
        }

        private void luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa !!!", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string mabd = txtmabd.EditValue.ToString();
                int kq = ctbd.xoachitiet(mabd);
                try
                {
                    int kq1 = dklq.xoadangkybd(mabd);
                    MessageBox.Show("Đã xóa những hợp đồng của bài đăng này", "Kiểm tra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch
                {
                    MessageBox.Show("Bài đăng này không có người đăng ký", "Kiểm tra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                int kq2 = bdlq.Xoabd(mabd);
                if (kq2 == 1)
                    MessageBox.Show("xóa thành công");
                else
                    MessageBox.Show("Xóa thất bại");
                loadbaidang();
            }
        }



    }
}
