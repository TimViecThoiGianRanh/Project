using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AccountBLL
    {
        Account ac = new Account();
        public AccountBLL()
        {
        }

        public DataTable danhsach()
        {
            return ac.danhsachtaikhoan();
        }

        public DataTable danhsachkhd()
        {
            return ac.danhsachkhd();
        }

        public DataTable danhsachhd()
        {
            return ac.danhsachhd();
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
