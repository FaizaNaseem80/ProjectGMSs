using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGMS
{
    class Payments
    {
        int id;
        string method;
        public int Payid
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }
        public string PayMethod
        {
            set
            {
               method = value;
            }
            get
            {
                return method;
            }
        }
        public void Create()
        {
            DbConnection d = new DbConnection();
            string query = $@"insert into Payment_Methods
                (Payment_ID,Method)
                values({Payid},'{PayMethod}')";
            d.ExecuteQuery(query, true);
        }
        public DataTable Read()
        {
            DbConnection d = new DbConnection();
            string query = "select * from Payment_Methods";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;

        }
        public DataTable Read(int Payid)
        {
            //select where
            DbConnection d = new DbConnection();
            string query = $"select * from Payment_Methods where Payment_ID={Payid}";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;

        }
        public void Update()
        {
            DbConnection d = new DbConnection();
            string query = $@"update Payment_Methods set 
                Method='{PayMethod}' where Payment_ID={Payid}";
            d.ExecuteQuery(query, true);

        }
        public DataTable Delete()
        {
            DbConnection d = new DbConnection();
            string query = $"delete from Payment_Methods where Payment_ID={Payid}";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;
        }

    }
}
