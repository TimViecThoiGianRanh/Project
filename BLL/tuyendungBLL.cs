using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class tuyendungBLL
    {
         TuyenDungDAL td = new TuyenDungDAL();
         public tuyendungBLL()
         {
         }

         public DataTable thongtintuyendung(string username)
         {
             return td.loadtd(username);
         }
         public DataTable laymatd(string username)
         {
             return td.laymatd(username);
         }

    }
}
