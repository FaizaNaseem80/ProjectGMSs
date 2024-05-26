using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ProjectGMS
{
    class Employee
    {
       
        int Eid;
        string name;
        string type;
        string email;
        string password;
        int contact;
        string address;
        
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
        public  string EmpType
        {
            set
            {
                type = value;
            }
            get
            {
                return type;
            }
        }
        public string Empname
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public int Empcontact
        {
            set
            {
                contact = value;

            }
            get
            {
                return contact;
            }

        }
        public string Empaddress
        {
            set
            {
                address = value;
            }
            get
            {
                return address;
            }
        }
        public string EmpEmail
        {
            set
            {
                email = value;
            }
            get
            {
                return email;
            }

        }
        public string EmpPassword
        {
            set
            {
                password= value;
            }
            get
            {
                return password;
            }
        }
        public void Create()
        {
            DbConnection d = new DbConnection();
            string query = $@"insert into Employees
                (Employee_ID,Name,Type,Contact,Address,Email,Password)
                values({Empid},'{Empname}','{EmpType}',{Empcontact},'{Empaddress}','{EmpEmail}','{EmpPassword}')";
            d.ExecuteQuery(query, true);
        }
        public DataTable Read()
        {
            DbConnection d = new DbConnection();
            string query = "select * from Employees";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;

        }
        public DataTable Read(int id)
        {
            //select where
            DbConnection d = new DbConnection();
            string query = $"select * from Employees where Employee_ID={Empid}";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;

        }
        public void Update()
        {
            DbConnection d = new DbConnection();
            string query = $@"update Employees set
                Name='{Empname}',Position='{EmpType}',Contact={Empcontact},Address='{Empaddress}','{EmpEmail}','{EmpPassword} where Employee_ID={Empid}";
            d.ExecuteQuery(query, true);

        }
        public DataTable Delete()
        {
            DbConnection d = new DbConnection();
            string query = $"delete from Employee where  Employee_Id={Empid}";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;
        }

    }
}

