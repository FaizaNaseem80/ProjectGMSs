using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjectGMS
{
    class TransactionDetail
    {
        int id;
        int Tid;
        int Pid;
        int QTY;
        int Price;
        public int Detailid
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
        public int TQTY
        {
            set
            {
                QTY= value;
            }
            get
            {
                return QTY;
            }
        }
        public int TPrice
        {
            set
            {
                Price = value;
            }
            get
            {
                return Price;
            }
        }
        public void Create()
        {
            DbConnection d = new DbConnection();
            string query = $@"insert into Transaction_Details
                (Detail_ID,Transaction_ID,Product_ID,Quantity,Price)
                values({Detailid},{Transid},{Proid},{TQTY},{TPrice})";
            d.ExecuteQuery(query, true);
        }
        public DataTable Read()
        {
            DbConnection d = new DbConnection();
            string query = "select * from Transaction_Details";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;

        }
        public DataTable Read(int Detailid)
        {
            //select where
            DbConnection d = new DbConnection();
            string query = $"select * from Transaction_Details where Detail_ID={Detailid}";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;

        }
        public void Update()
        {
            DbConnection d = new DbConnection();
            string query = $@"update Transaction_Details set 
                Product_ID={Proid},Transaction_ID={Transid},Quantity={TQTY},Price={TPrice} where Detail_ID={Detailid}";
            d.ExecuteQuery(query, true);

        }
        public DataTable Delete()
        {
            DbConnection d = new DbConnection();
            string query = $"delete from Transaction_Details where Detail_ID={Detailid}";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;
        }

    }
}
