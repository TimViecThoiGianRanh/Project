using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class loaicongviecBLL
    {
        loaicongviecDAL loai = new loaicongviecDAL();
        public loaicongviecBLL()
        {
        }

        public DataTable loadloaicv()
        {
            return loai.loadloaicv();
        }
    }
}
