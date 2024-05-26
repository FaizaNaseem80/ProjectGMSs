using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;

namespace ProjectGMS
{
    class Orders
    {
        int Oid;
        int cid;
        string date;
        int amount;
        public int Orderid
        {
            set
            {
                Oid = value;
            }
            get
            {
                return Oid;
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
        public string OrderDate
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
        public int TotalAmount
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
        public void Create()
        {
            DbConnection d = new DbConnection();
            string query = $@"insert into Orders
                (Order_ID,Customer_ID,Total_Amount,Order_Date)
                values({Orderid},{Cusid},{TotalAmount},'{OrderDate}')";
            d.ExecuteQuery(query, true);
        }
        public DataTable Read()
        {
            DbConnection d = new DbConnection();
            string query = $@"select o.Order_ID,o.Order_Date,o.Total_Amount as Order_Total, C.Customer_ID,C.CussName as Customer_Name, C.Contact as Customer_Contact, C.Address as Customer_Address from Orders o join Customers C on o.Customer_ID = C.Customer_ID;";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;

        }
        public DataTable Read(int Payid)
        {
            //select where
            DbConnection d = new DbConnection();
            string query = $"select * from Orders where Order_ID={Orderid}";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;

        }
        public void Update()
        {
            DbConnection d = new DbConnection();
            string query = $@"update Orders  set 
                Order_Date='{OrderDate}',Customer_ID={Cusid},Total_Amount={TotalAmount} where Order_ID={Orderid}";
            d.ExecuteQuery(query, true);

        }
        public DataTable Delete()
        {
            DbConnection d = new DbConnection();
            string query = $"delete from Orders where Order_ID={Orderid}";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;
        }

    }
}
