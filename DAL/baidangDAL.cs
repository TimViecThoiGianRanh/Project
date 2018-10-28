using DAL.tvTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class baidangDAL
    {
        baidangTableAdapter bd = new baidangTableAdapter();
        public baidangDAL()
        {
        }

        public DataTable danhsachbaidang()
        {

            return bd.GetData();
        }


        public DataTable timbaidang(string mabd)
        {

            if (bd.timbaidang(mabd) != null)
                return bd.timbaidang(mabd);
            else
                return null;
        }

    }
}
