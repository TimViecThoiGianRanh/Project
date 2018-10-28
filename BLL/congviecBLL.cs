using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class congviecBLL
    {
        congviecDAL cv = new congviecDAL();
        public congviecBLL()
        {
        }

        public DataTable danhsachcongviec()
        {
            return cv.danhsachcongviec();
        }

        public DataTable danhsachcongviecttg()
        {

            return cv.danhsachcongviecttg();
        }

        public DataTable danhsachcongviecbtg()
        {

            return cv.danhsachcongviecbtg();
        }

    }
}
