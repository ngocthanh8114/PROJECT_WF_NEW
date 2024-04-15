using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Home.DuLieu
{
    
    internal class KetNoiCSDL
    {
        
        private static string sqlCon = "Data Source=LAPTOP-IGR3NG0G\\SQLEXPRESS;Initial Catalog=BanXeMay;Integrated Security=True;Encrypt=False";
        public SqlConnection con = new SqlConnection(sqlCon);


        //---------------------------------NgocThanh-------------------------------------
        string strconn = "Data Source=LAPTOP-IGR3NG0G\\SQLEXPRESS;Initial Catalog=BanXeMay;Integrated Security=True;Encrypt=False";
        SqlDataAdapter da = null;
        SqlConnection conn = null;
        SqlCommand cmd = null;
        DataSet ds = null;

        public void Connection()
        {
            conn = new SqlConnection(strconn);
            conn.Open();
        }
        //---------------------------------NgocThanh-------------------------------------


        public void myConnect()
        {
            if (con.State == ConnectionState.Closed) con.Open();
        }
        public void myClose()
        {
            con.Close();
        }
    }
}
