using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class BaiDangBLL
    {
        tvDataContext tv = new tvDataContext();
        public BaiDangBLL()
        {
        }

        public List<baidang> Loadbd()
        {
            return tv.baidangs.Select(t => t).ToList<baidang>();
        }

        baidang maxoa(string mabd)
        {
            baidang ac = tv.baidangs.Where(t => t.mabd == mabd).FirstOrDefault();
            if (ac != null)
                return ac;
            else
                return null;
        }

        public int Xoabd(string mabd)
        {
            if (maxoa(mabd) != null)
            {
                baidang ac = tv.baidangs.Where(t => t.mabd == mabd).FirstOrDefault();
                tv.baidangs.DeleteOnSubmit(ac);
                tv.SubmitChanges();
                return 1;
            }

            else
                return 0;
        }

    }
}
