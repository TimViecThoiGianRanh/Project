using DAL.tvTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhachHangDAL
    {

        KhachHangTableAdapter kh = new KhachHangTableAdapter();
        public KhachHangDAL()
        {
        }

        public DataTable loadkh()
        {
            return kh.GetData();
        }


        public DataTable loadthongtin(string username)
        {
            return kh.thongtinnguoidung(username);
        }

        public DataTable laymakh(string username)
        {
            return kh.laymakhachhang(username);
        }

    }
}
