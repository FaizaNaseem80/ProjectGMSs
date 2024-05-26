using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGMS
{
    class Transaction
    {
        public Customer Customer
        {
            get;
            set;
        }
        public List<Product> Products
        {
            get;
            set;
        }
        public decimal TotalAmount
        {
            get;
            set;
        }
        int Tid;
        int Eid;
        int id;
        string Date;
        public int Transid
        {
            set
            {
                Tid = value;
            }
            get
            {
                return Tid;
            }
        }
        public int Empid
        {
            set
            {
                Eid = value;
            }
            get
            {
                return Eid;
            }
        }

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
        public string TransDate
        {
            set
            {
                 Date= value;
            }
            get
            {
                return Date;
            }
        }
        public void Create()
        {
            DbConnection d = new DbConnection();
            string query = $@"insert into Transactions
                (Transaction_ID,Employee_ID,Payment_ID,Transaction_Date)
                values({Transid},{Empid},{Payid},'{TransDate}')";
            d.ExecuteQuery(query, true);
        }
        public DataTable Read()
        {
            DbConnection d = new DbConnection();
            string query = "select * from Transactions";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;

        }
        public DataTable Read(int Payid)
        {
            //select where
            DbConnection d = new DbConnection();
            string query = $"select * from Transactions where Transaction_ID={Transid}";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;

        }
        public void Update()
        {
            DbConnection d = new DbConnection();
            string query = $@"update Transactions  set 
                Transaction_Date='{TransDate}',Payment_ID={Payid},Transaction_ID={Transid} where Employee_ID={Empid}";
            d.ExecuteQuery(query, true);

        }
        public DataTable Delete()
        {
            DbConnection d = new DbConnection();
            string query = $"delete from Transactions where Transaction_ID={Transid}";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;
        }

    }
}