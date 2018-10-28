using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class accountBLL
    {
        tvDataContext tv = new tvDataContext();

        public accountBLL()
        {
        }

        bool ktkc(string username)
        {
            account ac = tv.accounts.Where(t => t.username == username).FirstOrDefault();
            if (ac != null)
                return true;
            else
                return false;
        }

        bool ktkhoa(string username)
        {
            account ac = tv.accounts.Where(t => t.username == username).SingleOrDefault();
            if (ac != null)
                return true;
            else
                return false;
        }

        public int themAC(account ac)
        {
            try
            {
                if (ktkc(ac.username) == true)
                    return 2;
                tv.accounts.InsertOnSubmit(ac);
                tv.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }


        public int suaAC(account ac)
        {
            try
            {
                if (ktkhoa(ac.username) == true)
                {
                    tv.SubmitChanges();
                    return 1;
                }
                return 2;
            }
            catch
            {
                return 0;
            }
        }

        account maxoa(string username)
        {
            account ac = tv.accounts.Where(t => t.username == username).FirstOrDefault();
            if (ac != null)
                return ac;
            else
                return null;
        }

        public int XoaAC(string username)
        {
            if (maxoa(username) != null)
                {
                    account ac = tv.accounts.Where(t => t.username == username).SingleOrDefault();
                    tv.accounts.DeleteOnSubmit(ac);
                    tv.SubmitChanges();
                    return 1;
                }

                else
                    return 0;
            }

    }
}
