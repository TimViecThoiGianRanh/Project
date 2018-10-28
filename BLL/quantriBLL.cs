using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class quantriBLL
    {
        quantriDAL qt = new quantriDAL();
        public quantriBLL()
        {
        }

        public DataTable thongtinkhachhang(string username)
        {
            return qt.thongtinmod(username);
        }

        public DataTable laymamod(string usrename)
        {
            return qt.laymamod(usrename);
        }

    }
}
