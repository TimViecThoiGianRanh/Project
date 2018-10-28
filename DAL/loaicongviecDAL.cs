using DAL.tvTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class loaicongviecDAL
    {
        loaicongviecTableAdapter loai = new loaicongviecTableAdapter();
        public loaicongviecDAL()
        {
        }

        public DataTable loadloaicv()
        {
            return loai.GetData();
        }

    }
}
