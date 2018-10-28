using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class khachhangBLL
    {
        KhachHangDAL kh = new KhachHangDAL();
        public khachhangBLL()
        {
        }

        public DataTable thongtinkhachhang(string username)
        {
            return kh.loadthongtin(username);
        }

        public DataTable laymakh(string username)
        {
            return kh.laymakh(username);
        }

    }
}
