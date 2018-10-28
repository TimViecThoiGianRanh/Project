using DAL.tvTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class congviecDAL
    {
         congviecTableAdapter cv = new congviecTableAdapter();
         public congviecDAL()
        {
        }

        public DataTable danhsachcongviec()
        {

            return cv.danhsachcongviec();
        }

        public DataTable danhsachcongviecttg()
        {

            return cv.congviectoantg();
        }

        public DataTable danhsachcongviecbtg()
        {

            return cv.congviecbantg();
        }


    }
}
