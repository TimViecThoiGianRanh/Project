using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class chitietbdBLL
    {
        tvDataContext tv = new tvDataContext();
        public chitietbdBLL()
        {
        }

        public List<chitietbd> Loadbd()
        {
            return tv.chitietbds.Select(t => t).ToList<chitietbd>();
        }

        public int xoachitiet(string mabd)
        {
            try
            {
                chitietbd delete = tv.chitietbds.Where(t => t.mabd.Equals(mabd)).SingleOrDefault();
                tv.chitietbds.DeleteOnSubmit(delete);
                tv.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

    }
}
