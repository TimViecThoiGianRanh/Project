using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class dangkyBLL
    {
        tvDataContext tv = new tvDataContext();
        public dangkyBLL()
        {
        }

        public List<dangky> Loadbd()
        {
            return tv.dangkies.Select(t => t).ToList<dangky>();
        }

        public int xoadangkybd(string mabd)
        {
            if (mabd != null)
            {
                dangky delete = tv.dangkies.Where(t => t.mabd.Equals(mabd)).SingleOrDefault();
                tv.dangkies.DeleteOnSubmit(delete);
                tv.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }

        }

        public int xoadangkykh(string makh)
        {
            if (makh != null)
            {
                dangky delete = tv.dangkies.Where(t => t.makh.Equals(makh)).SingleOrDefault();
                tv.dangkies.DeleteOnSubmit(delete);
                tv.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }

        }

    }
}
