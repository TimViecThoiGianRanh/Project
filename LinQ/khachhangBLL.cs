using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class khachhangBLL
    {
        tvDataContext tv = new tvDataContext();
        dangkyBLL dk = new dangkyBLL();
        public khachhangBLL()
        {
        }


        public int xoakh(string makh)
        {
            if (makh != null)
            {
                KhachHang delete = tv.KhachHangs.Where(t => t.makh.Equals(makh)).SingleOrDefault();
                tv.KhachHangs.DeleteOnSubmit(delete);
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
