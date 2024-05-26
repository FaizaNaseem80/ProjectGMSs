using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGMS
{
    class Promotion
    {
        int id;
        int Pid;
        int discount;
        string Sdate;
        string Edate;
        public int PrId
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
        public int Prdiscount
        {
            set
            {
                discount = value;
            }
            get
            {
                return discount;
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

        public String PrEdate
        {
            set
            {
                Edate = value;

            }
            get
            {
                return Edate;
            }

        }
        public string PrSdate
        {
            set
            {
                Sdate = value;
            }
            get
            {
                return Sdate;
            }
        }
        public void Create()
        {
            DbConnection d = new DbConnection();
            string query = $@"insert into Promotions
                (Product_ID,Promo_ID,Discount,Start_Date,End_Date)
                values({Proid},{PrId},{Prdiscount},'{PrSdate}','{PrEdate}')";
            d.ExecuteQuery(query, true);
        }
        public DataTable Read()
        {
            DbConnection d = new DbConnection();
            string query = $@"SELECT P.Product_ID,P.Name as ProductName,
    P.Price as ProductPrice,
    P.Category_ID,
    P.Quantity AS ProductQuantity,
    pr.Promo_ID,
    pr.Discount as PromotionDiscount,
	pr.Start_Date as PromotionStartDate,
	pr.End_Date as PromotionEndDate,
	pr.Product_ID
FROM
    Products P
JOIN
    Promotions pr ON P.Product_ID = pr.Product_ID; ";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;

        }
        public DataTable Read(int PrId)
        {
            //select where
            DbConnection d = new DbConnection();
            string query = $"select * from Category where Promo_ID={PrId}";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;

        }
        public void Update()
        {
            DbConnection d = new DbConnection();
            string query = $@"update Promotions set
                Product_ID={Proid},Discount={Prdiscount},Start_Date='{PrSdate}',End_Date='{PrEdate}' where Promo_ID={PrId}";
            d.ExecuteQuery(query, true);

        }
        public DataTable Delete()
        {
            DbConnection d = new DbConnection();
            string query = $"delete from Promotions where Product_Id={Proid}";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;
        }
    }
}