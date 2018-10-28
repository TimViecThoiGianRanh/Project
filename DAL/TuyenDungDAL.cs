using DAL.tvTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TuyenDungDAL
    {
        public TuyenDungDAL()
        {
        }

        tuyendungTableAdapter td = new tuyendungTableAdapter();

        public DataTable loadtd(string username)
        {
            return td.thongtintuyendung(username);
        }

        public DataTable laymatd(string username)
        {
            return td.laymatd(username);
        }

    }
}
