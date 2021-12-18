using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace gameing
{
    public class Database
    {
        public static SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAZZAD\source\repos\labfinalll\db\ht.mdf;Integrated Security=True;Connect Timeout=30");
    }
   
}
