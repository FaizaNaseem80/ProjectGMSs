using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ProjectGMS
{
    class Expense
    {
        int id;
        string description;
        int amount;
        string date;
        public int Exid
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
        public string Exdes
        {
            set
            {
                description = value;
            }
            get
            {
                return description;
            }
        }
        public int Examount

        {
            set
            {
                amount = value;

            }
            get
            {
                return amount;
            }

        }
        public string Exdate
        {
            set
            {
                date = value;
            }
            get
            {
                return date;
            }
        }
        public void Create()
        {
            DbConnection d = new DbConnection();
            string query = $@"insert into Expenses
                (Expense_ID,Description,Amount,Date)
                values({Exid},'{Exdes}',{Examount},'{Exdate}')";
            d.ExecuteQuery(query, true);
        }
        public DataTable Read()
        {
            DbConnection d = new DbConnection();
            string query = "select * from Expenses";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;

        }
        public DataTable Read(int Exid)
        {
            //select where
            DbConnection d = new DbConnection();
            string query = $"select * from Expenses where Expense_ID={Exid}";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;

        }
        public void Update()
        {
            DbConnection d = new DbConnection();
            string query = $@"update Expenses set
                Description='{Exdes}',Amount={Examount},Date={Exdate} where Expense_ID={Exid}";
            d.ExecuteQuery(query, true);

        }
        public DataTable Delete()
        {
            DbConnection d = new DbConnection();
            string query = $"delete from Expenses where Expense_ID={Exid}";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;
        }

    }

}
