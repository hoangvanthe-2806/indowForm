using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace demo
{
    public class Connection
    {
        private static string stringConnection = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True";
        public static SqlConnection getConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
