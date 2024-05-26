using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGMS
{
    class Product
    {
        int Pid;
        String Pname;
        int Pprice;
        int Pqty;
        int Catid;
        
        public int Proid
        {
            set
            {
                Pid = value;
            }
            get
            {
                return Pid;
            }
        }

        public string ProName
        {
            set
            {
                Pname = value;
            }
            get
            {
                return Pname;
            }
        }
        public int ProPrice
        {
            set
            {
                Pprice = value;
            }
            get
            {
                return Pprice;
            }
        }
        public int ProQTY
        {
            set
            {

                Pqty = value;
            }
            get
            {
                return Pqty;
            }
        }
        public int CateId
        {
            set
            {
                Catid = value;
            }
            get
            {
                return Catid;
            }
        }
        public void Create()
        {
            DbConnection d = new DbConnection();
            string query = $@"insert into Products
                (Product_ID,Name,Price,Quantity,Category_ID)
                values({Proid},'{ProName}',{ProPrice},{ProQTY},{CateId})";
            d.ExecuteQuery(query, true);
        }
        public DataTable Read()
        {
            DbConnection d = new DbConnection();
            string query = "select * from Products";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;

        }
        public DataTable Read(int Proid)
        {
            //select where
            DbConnection d = new DbConnection();
            string query = $"select * from Products where Product_ID={Proid}";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;

        }
        public void Update()
        {
            DbConnection d = new DbConnection();
            string query = $@"update Products  set 
       Category_ID= {CateId}, Name='{ProName}',Price={ProPrice}, Quantity={ProQTY} where Product_ID={Proid}";
            d.ExecuteQuery(query, true);

        }
        public DataTable Delete()
        {
            DbConnection d = new DbConnection();
            string query = $"delete from Products where Category_ID={CateId}";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;
        }

    }
}