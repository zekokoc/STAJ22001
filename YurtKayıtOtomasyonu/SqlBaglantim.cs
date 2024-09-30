using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace YurtKayıtOtomasyonu
{
    public class SqlBaglantim
    {
        public SqlConnection bağlanti()
        {
            SqlConnection bağlan = new SqlConnection(@"Data Source=DESKTOP-0OEVPEH\SQLEXPRESS;Initial Catalog=YurtOtomasyon;Integrated Security=True;");
            bağlan.Open();
            return bağlan;
        }

    }
}
