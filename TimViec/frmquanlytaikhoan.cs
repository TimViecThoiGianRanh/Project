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
using TimViec.DAO;

namespace TimViec
{
    public partial class frmquanlytaikhoan : Form
    {
        dangkyBLL dklq = new dangkyBLL();
        LinQ.khachhangBLL khlq = new LinQ.khachhangBLL();
        TuyenDungBLL tdlq = new TuyenDungBLL();
        LinQ.quantriBLL qtlq = new LinQ.quantriBLL();
        accountBLL aclq = new accountBLL();
        BindingSource bindingAC = new BindingSource();
        AccountBLL ac = new AccountBLL();
        tuyendungBLL tdbll = new tuyendungBLL();
        BLL.khachhangBLL khbll = new BLL.khachhangBLL();
        BLL.quantriBLL qtbll = new BLL.quantriBLL();
        public frmquanlytaikhoan()
        {
            InitializeComponent();
            gvtaikhoan.DataSource = bindingAC;
            loadaccount();
            adbingdingaccount();
        }

        public string taikhoancanhan()
        {
            return txttaikhoan.Text;
        }

        void loadaccount()
        {

            if (dangnhapquanly.type == "0")
            {
                bindingAC.DataSource = ac.danhsachnguoisudung();
            }
            if (dangnhapquanly.type == "9")
            {
                bindingAC.DataSource = ac.danhsachmod();
            }
        }

        void adbingdingaccount()
        {
            txttaikhoan.DataBindings.Add(new Binding("Text", gvtaikhoan.DataSource, "username", true, DataSourceUpdateMode.Never));
            txtmk.DataBindings.Add(new Binding("Text", gvtaikhoan.DataSource, "password", true, DataSourceUpdateMode.Never));
        }

        private void chktaikhoankhonghd_CheckedChanged(object sender, EventArgs e)
        {
            if (dangnhapquanly.type == "0")
            {
                if (chktaikhoankhonghd.Checked == true)
                {
                    bindingAC.DataSource = ac.danhsachkhd();
                }
                else
                    bindingAC.DataSource = ac.danhsachnguoisudung();
            }
            if (dangnhapquanly.type == "9")
            {
                if (chktaikhoankhonghd.Checked == true)
                {
                    bindingAC.DataSource = ac.danhsachmodhd();
                }
                else
                    bindingAC.DataSource = ac.danhsachmod();
            }
        }

        private void chktaikhoanhd_CheckedChanged(object sender, EventArgs e)
        {
            if (dangnhapquanly.type == "0")
            {
                if (chktaikhoanhd.Checked == true)
                {
                    bindingAC.DataSource = ac.danhsachhd();
                }
                else
                    bindingAC.DataSource = ac.danhsachnguoisudung();
            }
            if (dangnhapquanly.type == "9")
            {
                if (chktaikhoanhd.Checked == true)
                {
                    bindingAC.DataSource = ac.danhsachmodkhd();
                }
                else
                    bindingAC.DataSource = ac.danhsachmod();
            }
            
        }

        private void lammoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadaccount();
            chktaikhoanhd.Checked = false;
            chktaikhoankhonghd.Checked = false;
            btnThem.Enabled = true;
            luu.Enabled = true;
            sua.Enabled = true;
            xoa.Enabled = true;
            txttaikhoan.Enabled = false;
            txtmk.Enabled = false;
        }

        private void tim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string username = txtusername.EditValue.ToString();
            bindingAC.DataSource = ac.timkhachhang(username);
        }
        bool isthem;
        private void them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txttaikhoan.Enabled = true;
            txtmk.Enabled = true;
            txttaikhoan.ResetText();
            txtmk.ResetText();
            sua.Enabled = false;
            xoa.Enabled = false;
            isthem = true;
        }

        private void sua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtmk.Enabled = true;
            btnThem.Enabled = false;
            xoa.Enabled = false;
            isthem = false;
        }

        private void luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dangnhapquanly.type == "9")
            {
                if (isthem == true)
                {
                    account tk = new account();
                    tk.username = txttaikhoan.Text;
                    tk.password = txtmk.Text;
                    tk.type = 0;
                    tk.tinhtrang = 1;
                    int kq = aclq.themAC(tk);
                    if (kq == 2)
                        MessageBox.Show("Đã tồn tài tài khoản");
                    else if (kq == 0)
                        MessageBox.Show("Sai thông tin");
                    else
                    {
                        MessageBox.Show("Thêm thành công");
                        themthongtin them = new themthongtin();
                        them.Show();
                    }
                    loadaccount();
                }
                else
                {
                    account tk1 = new account();
                    tk1.username = txttaikhoan.Text;
                    tk1.password = txtmk.Text;
                    tk1.type = tk1.type;
                    tk1.tinhtrang = 1;
                    int kq = aclq.suaAC(tk1);
                    if (kq == 2)
                        MessageBox.Show("Chưa có tài khoản này, tạo tài khoản mới");
                    else if (kq == 0)
                        MessageBox.Show("Sai thông tin");
                    else
                    {
                        MessageBox.Show("thành công");
                        loadaccount();
                    }

                }
            }
            else
            {
                if (isthem == true)
                {
                    MessageBox.Show("Bạn không được phép thêm tài khoản");
                }
                else
                {
                    account tk1 = new account();
                    tk1.username = txttaikhoan.Text;
                    tk1.password = txtmk.Text;
                    tk1.type = tk1.type;
                    tk1.tinhtrang = 1;
                    int kq = aclq.suaAC(tk1);
                    if (kq == 2)
                        MessageBox.Show("Chưa có tài khoản này, tạo tài khoản mới");
                    else if (kq == 0)
                        MessageBox.Show("Sai thông tin");
                    else
                    {
                        MessageBox.Show("thành công");
                        loadaccount();
                    }
                }
            }

            btnThem.Enabled = true;
            sua.Enabled = true;
            xoa.Enabled = true;
            txttaikhoan.Enabled = false;
            txtmk.Enabled = false;
        }

        private void xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa !!!", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                account tk = new account();
                tk.username = txttaikhoan.Text;
                DataTable kh = khbll.laymakh(tk.username);
                DataTable td = tdbll.laymatd(tk.username);
                DataTable mod = qtbll.laymamod(tk.username);
                int type = int.Parse(gvtaikhoan.SelectedCells[0].OwningRow.Cells["type"].Value.ToString());
                //nếu là người tìm việc
                if (type == 1)
                {
                    string makh = Convert.ToString(kh.Rows[0]["makh"].ToString());
                    try
                    {
                        if (makh != null)
                        {
                            if (khlq.xoakh(makh) == 1)
                            {
                                int kq = aclq.XoaAC(tk.username);
                                if (kq == 1)
                                    MessageBox.Show("xóa thành công");
                                else
                                    MessageBox.Show("Lỗi xử lý");
                            }
                            else
                            {
                                MessageBox.Show("Còn hợp đồng vẫn chưa xử lý");
                            }
                        }
                        else
                        {
                            int kq = aclq.XoaAC(tk.username);
                            if (kq == 1)
                                MessageBox.Show("xóa thành công");
                            else
                                MessageBox.Show("Còn hợp đồng vẫn chưa xử lý");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Còn hợp đồng vẫn chưa xử lý");
                    }
                }
                //nếu là nhà tuyển dụng
                if (type == 2)
                {
                    string manhatd = Convert.ToString(td.Rows[0]["manhatd"].ToString());
                    try
                    {
                        if (manhatd != null)
                        {
                            if (tdlq.xoamtd(manhatd) == 1)
                            {
                                int kq = aclq.XoaAC(tk.username);
                                if (kq == 1)
                                    MessageBox.Show("xóa thành công");
                                else
                                    MessageBox.Show("Lỗi xử lý");
                            }
                            else
                            {
                                MessageBox.Show("Còn hợp đồng vẫn chưa xử lý");
                            }
                        }
                        else
                        {
                            int kq = aclq.XoaAC(tk.username);
                            if (kq == 1)
                                MessageBox.Show("xóa thành công");
                            else
                                MessageBox.Show("Còn hợp đồng vẫn chưa xử lý");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Còn hợp đồng vẫn chưa xử lý");
                    }
                }
                //nếu là mod
                if (type == 0)
                {

                    if (Convert.ToString(mod.Rows[0]["maqt"].ToString()) != null)
                    {
                        if (qtlq.xoamod(Convert.ToString(mod.Rows[0]["maqt"].ToString())) == 1)
                        {
                            int kq = aclq.XoaAC(tk.username);
                            if (kq == 1)
                                MessageBox.Show("xóa thành công");
                            else
                                MessageBox.Show("Lỗi xử lý");
                        }
                        else
                        {
                            MessageBox.Show("Còn hợp đồng vẫn chưa xử lý");
                        }
                    }
                    else
                    {
                        int kq = aclq.XoaAC(tk.username);
                        if (kq == 1)
                            MessageBox.Show("xóa thành công");
                        else
                            MessageBox.Show("Còn hợp đồng vẫn chưa xử lý");
                    }
                    }
                   
                }

            loadaccount();
     }

        private void frmquanlytaikhoan_Load(object sender, EventArgs e)
        {
            txttaikhoan.Enabled = false;
            txtmk.Enabled = false;
        }
        }

    }

