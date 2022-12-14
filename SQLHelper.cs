using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Страховая_компания__2021_
{
    public class SQLHelper
    {
        SqlConnection cn;

        public SQLHelper(string connectionString)
        {
            cn = new SqlConnection(connectionString);
        }

        public bool IsConnection
        {
            get
            {
                if (cn.State == System.Data.ConnectionState.Closed)
                {
                    cn.Open();
                }
                return true;
            }
        }
    }
}
