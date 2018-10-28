using DAL.tvTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Account
    {
        accountTableAdapter ac = new accountTableAdapter();
        public Account()
        {
        }

        public DataTable danhsachtaikhoan()
        {
            return ac.GetData();
        }

        public DataTable danhsachkhd()
        {
            return ac.taikhoankhonghoatdong();
        }

        public DataTable danhsachhd()
        {
            return ac.taikhoanhoatdong();
        }

        public DataTable danhsachnguoisudung()
        {
            return ac.danhsachnguoisudung();
        }

        public DataTable danhsachmod()
        {
            return ac.danhsachmod();
        }

        public DataTable danhsachmodhd()
        {
            return ac.danhsachmodhd();
        }

        public DataTable danhsachmodkhd()
        {
            return ac.danhsachmodkhd();
        }

        public DataTable timkhachhang(string username)
        {
            return ac.timkhachhang(username);
        }

    }
}
