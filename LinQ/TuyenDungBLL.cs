using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class TuyenDungBLL
    {
        tvDataContext tv = new tvDataContext();
        public TuyenDungBLL()
        {
        }

        public List<tuyendung> Loadcv()
        {
            return tv.tuyendungs.Select(t => t).ToList<tuyendung>();
        }


        public int xoamtd(string matd)
        {
            if (matd != null)
            {
                tuyendung delete = tv.tuyendungs.Where(t => t.username.Equals(matd)).SingleOrDefault();
                tv.tuyendungs.DeleteOnSubmit(delete);
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
