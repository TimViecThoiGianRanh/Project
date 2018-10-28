using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
     public class baidangBLL
    {
         baidangDAL bdDAL = new baidangDAL();
         public baidangBLL()
         {
         }

         public DataTable danhsachbaidang()
         {
             return bdDAL.danhsachbaidang();
         }

         public DataTable timbaidang(string mabd)
         {

             if (bdDAL.timbaidang(mabd) != null)
                 return bdDAL.timbaidang(mabd);
             else
                 return null;
         }
    }
}
