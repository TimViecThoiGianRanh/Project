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
    public partial class frmDangKy : Form
    {

        DangKyBLL dk = new DangKyBLL();
        BindingSource bindingDK = new BindingSource();
        public frmDangKy()
        {
            InitializeComponent();
            dgdk.DataSource = bindingDK;
            loaddk();
            adbingdingdangky();
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            txtmabd.Enabled = false;
            txttenkh.Enabled = false;
            txttennhdtd.Enabled = false;
        }

        void loaddk()
        {
            bindingDK.DataSource = dk.danhsachhopdong();
        }

        void adbingdingdangky()
        {
            txtmabd.DataBindings.Add(new Binding("Text",dgdk.DataSource, "mabd", true, DataSourceUpdateMode.Never));
           txttenkh.DataBindings.Add(new Binding("Text", dgdk.DataSource, "tenkh", true, DataSourceUpdateMode.Never));
           txttennhdtd.DataBindings.Add(new Binding("Text", dgdk.DataSource, "tennhatd", true, DataSourceUpdateMode.Never));
        }

        private void tim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string mabd = eidtmabd.EditValue.ToString();
            try
            {
                if (dk.danhsachdangkyhopdong(mabd) != null)
                    bindingDK.DataSource = dk.danhsachdangkyhopdong(mabd);
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
            loaddk();
        }

    }
}
