using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class quantriBLL
    {
        public quantriBLL()
        {
        }

        tvDataContext tv = new tvDataContext();

        bool ktkc(string maqt)
        {
            quantri cv = tv.quantris.Where(t => t.maqt == maqt).FirstOrDefault();
            if (cv != null)
                return true;
            else
                return false;
        }

        public int themmod(quantri qt)
        {
           try
           {
               if(ktkc(qt.maqt)==false)
               tv.quantris.InsertOnSubmit(qt);
               tv.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int xoamod(string maqt)
        {
            if (maqt != null)
            {
                quantri delete = tv.quantris.Where(t => t.maqt.Equals(maqt)).SingleOrDefault();
                tv.quantris.DeleteOnSubmit(delete);
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
