using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGMS
{
    class Customer
    {
        int id;
        int cid;
        string name;
        int contact;
        string address;
        public int ProId
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
        public int Cusid
        {
            set
            {
                cid = value;
            }
            get
            {
                return cid;
            }
        }
        public string Cusname
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
        public int Cuscontact
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
        public string Cusaddress
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
        public void Create()
        {
            DbConnection d = new DbConnection();
            string query = $@"insert into Customers
                (Customer_id,CussName,Contact,Address)
                values({Cusid},'{Cusname}',{Cuscontact},'{Cusaddress}')";
            d.ExecuteQuery(query, true);
        }
        public DataTable Read()
        {
            DbConnection d = new DbConnection();
            string query = "select * from Customers";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;

        }
        public  DataTable Read(int Cusid)
        {
            //select where
            DbConnection d = new DbConnection();
            string query = $"select * from Customers where Customer_id={Cusid}";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;

        }
        public void Update()
        {
            DbConnection d = new DbConnection();
            string query = $@"update Customers set
                Cussname='{Cusname}',Contact={Cuscontact},Address='{Cusaddress}' where Customer_Id={Cusid}";
            d.ExecuteQuery(query, true);

        }
        public DataTable Delete()
        {
            DbConnection d = new DbConnection();
            string query = $"delete from Customers where Customer_Id={Cusid}";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;
        }

    }
}
