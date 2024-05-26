using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGMS
{
    class User_Authentication
    {
        public DataTable Login(string email, string password, string type)
        {
            DbConnection d = new DbConnection();
            string query = $@"auth";
            DataTable dt = d.procedureExecuteQuery(query, false, email, password, type);
            return dt;
            //T and T password='bilalhgf' OR 'a'='a'

        }
    }
}
