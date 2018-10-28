using DAL.tvTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class quantriDAL
    {
        quantriTableAdapter qt = new quantriTableAdapter();
        public quantriDAL()
        {
        }

        public DataTable thongtinmod(string usrename)
        {
            return qt.thongtinmod(usrename);
        }


        public DataTable laymamod(string usrename)
        {
            return qt.laymamod(usrename);
        }
    }
}
