using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ProjectGMS
{
    class Stores
    {
        int id;
        string name;
        int contact;
        string location;
        public int Sid
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
        public string Sname
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
        public int Scontact
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
        public string Slocation
        {
            set
            {
                location = value;
            }
            get
            {
                return location;
            }
        }
        public void Create()
        {
            DbConnection d = new DbConnection();
            string query = $@"insert into Store_Information
                (Store_ID,Name,Location,Contact)
                values({Sid},'{Sname}','{Slocation}',{Scontact})";
            d.ExecuteQuery(query, true);
        }
        public DataTable Read()
        {
            DbConnection d = new DbConnection();
            string query = "select * from Store_Information";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;

        }
        public DataTable Read(int id)
        {
            //select where
            DbConnection d = new DbConnection();
            string query = $"select * from Store_Information where Store_ID={Sid}";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;

        }
        public void Update()
        {
            DbConnection d = new DbConnection();
            string query = $@"update  Store_Information set
                Name='{Sname}',Contact={Scontact},Location='{Slocation}' where Store_ID={Sid}";
            d.ExecuteQuery(query, true);

        }
        public DataTable Delete()
        {
            DbConnection d = new DbConnection();
            string query = $"delete from Store_Information where Store_ID={Sid}";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;
        }

    }
}

