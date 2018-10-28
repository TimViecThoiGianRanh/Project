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
    public partial class frmquanlycv : Form
    {
        congviecBLL cv = new congviecBLL();
        loaicongviecBLL loai = new loaicongviecBLL();
        BindingSource bindingCV = new BindingSource();
        CongViecBLL congviec = new CongViecBLL();
        public frmquanlycv()
        {
            InitializeComponent();
            dgcongviec.DataSource = bindingCV;
            loadcv();
            loadcbb();
            adbingdingcongviec();
        }

        void loadcv()
        {
            bindingCV.DataSource = cv.danhsachcongviec();
        }

        void loadcbb()
        {

            
            cmbloaicv.DisplayMember = "tenloai";
            cmbloaicv.ValueMember = "maloai";
            cmbloaicv.DataSource = loai.loadloaicv();
            //DataRow Dr = loai.loadloaicv().NewRow();
            //Dr["tenloai"] = "tất cả";
            //Dr["maloai"] = "";
            //loai.loadloaicv().Rows.Add(Dr);
  
        }

        void adbingdingcongviec()
        {

            txtmacv.DataBindings.Add(new Binding("Text",dgcongviec.DataSource, "macv", true, DataSourceUpdateMode.Never));
            txttencv.DataBindings.Add(new Binding("Text", dgcongviec.DataSource, "tencv", true, DataSourceUpdateMode.Never));
            cmbloaicv.DataBindings.Add(new Binding("Text", dgcongviec.DataSource, "tenloai", true, DataSourceUpdateMode.Never));
            
        }

        private void lammoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cmbloaicv.SelectedItem = false;
            loadcv();
            txtmacv.Enabled = false;
            txttencv.Enabled = false;
            btnThem.Enabled = true;
            sua.Enabled = true;
            xoa.Enabled = true;
        }



        private void cmbloaicv_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbloaicv.Text == "Công việc toàn thời gian")
                bindingCV.DataSource = cv.danhsachcongviecttg();
            if (cmbloaicv.Text == "Công việc bán thời gian")
                bindingCV.DataSource = cv.danhsachcongviecbtg();
        }

        private void frmquanlycv_Load(object sender, EventArgs e)
        {
            sua.Enabled = false;
            xoa.Enabled = false;
            luu.Enabled = false;
            txtmacv.Enabled = false;
            txttencv.Enabled = false;
            cmbloaicv.SelectedItem = false;
        }

        bool isthem;

        private void them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isthem = true;
            sua.Enabled = false;
            xoa.Enabled = false;
            luu.Enabled = true;
            txttencv.Enabled = true;
        }

        private void sua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isthem = false;
            btnThem.Enabled = false;
            xoa.Enabled = false;
            luu.Enabled = true;
            txttencv.Enabled = true;
        }

        private void luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isthem == true)
            {
                try
                {
                    string macv = "";
                    string tencv = txttencv.Text;
                    string loaicv = cmbloaicv.SelectedValue.ToString();
                    congviec cv = new congviec();
                    cv.macv = macv;
                    cv.tencv = tencv;
                    cv.maloai = loaicv;
                    int kq = congviec.ThemCV(cv);
                    if (kq == 2)
                        MessageBox.Show("Đã có công việc này");
                    else if (kq == 0)
                        MessageBox.Show("Sai thông tin");
                    else
                        MessageBox.Show("Thêm thành công");
                    loadcv();
                }
                catch
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else
            {
                try
                {
                    string tencv = txttencv.Text;
                    string loaicv = cmbloaicv.SelectedValue.ToString();
                    congviec cv = new congviec();
                    int kq = congviec.suaCV(txtmacv.Text);
                    if (kq == 2)
                        MessageBox.Show("Công việc chưa có, bạn nên tạo mới");
                    else if (kq == 0)
                        MessageBox.Show("Sai thông tin");
                    else
                        MessageBox.Show("Thành công");
                    loadcv();

                }
                catch
                {
                    MessageBox.Show("Không sữa được");
                }
            }
            txttencv.Enabled = false;
        }

        private void xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa !!!", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string macv = txtmacv.Text;
                int kq = congviec.XoaAC(macv);
                if (kq == 1)
                    MessageBox.Show("Xóa thành công");
                else
                    MessageBox.Show("Công việc đang được nhiều người đăng tin");
                loadcv();
            }
        }

        private void dgcongviec_SelectionChanged(object sender, EventArgs e)
        {
            xoa.Enabled = true;
            sua.Enabled = true;
        }


       

    }
}
