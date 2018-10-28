using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimViec
{
    public partial class frmmain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        
        BindingSource bindingBD = new BindingSource();

        baidangBLL bd = new baidangBLL();
        public frmmain()
        {
            InitializeComponent();
           

        }

        private Form kiemtraTonTai(Type fType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                {
                    return f;
                }
            }
            return null;
        }
   

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            dangnhapquanly ql = new dangnhapquanly();
            ql.Show();
        }

        private void btnqltk_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraTonTai(typeof(frmquanlytaikhoan));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmquanlytaikhoan f = new frmquanlytaikhoan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnqlbd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraTonTai(typeof(frmbaidang));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmbaidang f = new frmbaidang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnqlcv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraTonTai(typeof(frmquanlycv));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmquanlycv f = new frmquanlycv();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnThongTin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Thongtin tt = new Thongtin();
            tt.Show();
        }

        private void btnhopdong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraTonTai(typeof(frmDangKy));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmDangKy f = new frmDangKy();
                f.MdiParent = this;
                f.Show();
            }
        }

        


    }
}
