using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimViec.DAO
{
    public class accountDAO
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-E7OLK4E\SQLEXPRESS;Initial Catalog=QL_TimViec;Integrated Security=True");

        private static accountDAO instance;

        public static accountDAO Instance
        {
            get { if (instance == null) instance = new accountDAO(); return accountDAO.instance; }
            private set { accountDAO.instance = value; }
        }



        private accountDAO() { }

        public DataTable excuteQuery(string query,Object[] parameter = null)
        {
            DataTable data = new DataTable();
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item,parameter[i]);
                            i++;
                        }
                    }
                }


                SqlDataAdapter dtdapter = new SqlDataAdapter(cmd);
                dtdapter.Fill(data);
                con.Close();
            }
            return data;
            }

        //hàm lấy type
        public string gettype(string username, string pass)
        {
            string type = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM account WHERE username ='" + username + "' and password='" + pass + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        type = dr["type"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                con.Close();
            }
            return type;
        }

        public DataTable timnguoidung(string username)
        {
            string query = "select * from KhachHang where dbo.fuConvertToUnsign1(tenkh) like dbo.fuConvertToUnsign1(N'%" + username + "%')";
            return excuteQuery(query);
        }

    }
}
