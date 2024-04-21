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
using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Markup;
using System.Windows.Media;
namespace Home.DuLieu
{
    internal class KetNoiCSDL
    {

        private static string sqlCon = "Data Source=LAPTOP-IGR3NG0G\\THANHAN;Initial Catalog=BanXeMay;Integrated Security=True;Encrypt=False";

        public SqlConnection con = new SqlConnection(sqlCon);

        string strconn = "Data Source=LAPTOP-IGR3NG0G\\THANHAN;Initial Catalog=BanXeMay;Integrated Security=True;Encrypt=False";

        SqlConnection conn = null;

        public void Connection()
        {
            conn = new SqlConnection(strconn);
            conn.Open();
        }

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
