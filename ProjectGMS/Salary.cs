using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGMS
{
    class Salary
    {

        int Eid;
        int allowance;
        int deduction;
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

        public int Allowance
        {
            set
            {
                allowance = value;
            }
            get
            {
                return allowance;
            }
        }
        public int Deductions
        {
            set
            {
                deduction= value;
            }
            get
            {
                return deduction;
            }
        }
        public void Create()
        {
            DbConnection d = new DbConnection();
            string query = $@"insert into Salary
                (allowance,deductions,Employee_ID)
                values({Allowance},{Deductions},{Empid})";
            d.ExecuteQuery(query, true);
        }
        public DataTable Read()
        {
            DbConnection d = new DbConnection();
            string query = "select * from Salary";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;

        }
        public DataTable Read(int Payid)
        {
            //select where
            DbConnection d = new DbConnection();
            string query = $"select * from Salary where Employee_ID={Empid}";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;

        }
        public void Update()
        {
            DbConnection d = new DbConnection();
            string query = $@"update Salary  set 
                allowance={Allowance},deductions={Deductions} where Employee_ID={Empid}";
            d.ExecuteQuery(query, true);

        }
        public DataTable Delete()
        {
            DbConnection d = new DbConnection();
            string query = $"delete from Salary where Employee_ID={Empid}";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;
        }

    }
}
