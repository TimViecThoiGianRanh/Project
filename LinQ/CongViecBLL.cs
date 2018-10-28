using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class CongViecBLL
    {
        tvDataContext tv = new tvDataContext();
        public CongViecBLL()
        {
        }

        public List<congviec> Loadcv()
        {
            return tv.congviecs.Select(t => t).ToList<congviec>();
        }

        //Kiểm tra khóa chính
        bool ktkc(string macv)
        {
            congviec cv = tv.congviecs.Where(t => t.macv == macv).FirstOrDefault();
            if (cv != null)
                return true;
            else
                return false;
        }
        public int ThemCV(congviec cv)
        {
            try
            {
                if (ktkc(cv.macv) == true)
                    return 2;
                tv.congviecs.InsertOnSubmit(cv);
                tv.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int suaCV(string macv)
        {
            try
            {
                congviec cv = tv.congviecs.Where(t => t.macv == macv).SingleOrDefault();
                tv.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        congviec maxoa(string macv)
        {
            congviec ac = tv.congviecs.Where(t => t.macv == macv).FirstOrDefault();
            if (ac != null)
                return ac;
            else
                return null;
        }

        public int XoaAC(string macv)
        {
            if (maxoa(macv) != null)
            {
                congviec ac = tv.congviecs.Where(t => t.macv == macv).FirstOrDefault();
                tv.congviecs.DeleteOnSubmit(ac);
                tv.SubmitChanges();
                return 1;
            }

            else
                return 0;
        }

    }
}
