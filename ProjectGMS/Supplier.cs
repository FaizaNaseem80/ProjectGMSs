using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGMS
{
    class Supplier
    {
        int id;
        string name;
        int contact;
        string address;
        public int Supid
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
        public string Supname
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
        public int Supcontact
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
        public string Supaddress
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
            string query = $@"insert into Suppliers
                (Supplier_ID,Name,Contact,Address)
                values({Supid},'{Supname}',{Supcontact},'{Supaddress}')";
            d.ExecuteQuery(query, true);
        }
        public DataTable Read()
        {
            DbConnection d = new DbConnection();
            string query = "select * from Suppliers";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;

        }
        public DataTable Read(int Supid)
        {
            //select where
            DbConnection d = new DbConnection();
            string query = $"select * from Suppliers where Supplier_ID={Supid}";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;

        }
        public void Update()
        {
            DbConnection d = new DbConnection();
            string query = $@"update Suppliers set
                Name='{Supname}',Contact={Supcontact},Address='{Supaddress}' where Supplier_ID={Supid}";
            d.ExecuteQuery(query, true);

        }
        public DataTable Delete()
        {
            DbConnection d = new DbConnection();
            string query = $"delete from Suppliers where Supplier_ID={Supid}";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;
        }

    }
}
