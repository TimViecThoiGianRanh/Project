using DAL.tvTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DangKyDAL
    {
        dangkyTableAdapter dk = new dangkyTableAdapter();
        public DangKyDAL()
        {
        }

        public DataTable danhsachhopdong()
        {
            return dk.danhsachhopdong();
        }

        public DataTable danhsachdangkyhopdong(string mabd)
        {
            return dk.danhsachbaidangdk(mabd);
        }

    }
}
