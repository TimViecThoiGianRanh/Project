using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DangKyBLL
    {
        DangKyDAL dk = new DangKyDAL();
        public DangKyBLL()
        {
        }

        public DataTable danhsachhopdong()
        {
            return dk.danhsachhopdong();
        }

        public DataTable danhsachdangkyhopdong(string mabd)
        {
            return dk.danhsachdangkyhopdong(mabd);
        }

    }
}
