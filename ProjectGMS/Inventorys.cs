using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGMS
{
    class Inventorys
    {
        public List <Product> Products
        {
            get;
            set;
        }
        public Inventorys()
        {
            Products = new List<Product>();
        }
        public void AddProduct(Product Products)
        {
            Products.Add(Product);
        }
        public void UpdateQuantity(int p )
        int Pid;
        int exqty;
        int newqty;
        int reorder;
        string expdate;
        int Catid;
        int Batchid;
        int id;
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
        public int ExQTY
        {
            set
            {
                exqty = value;
            }
            get
            {
                return exqty;
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
        public int NewQTY
        {
            set
            {
                newqty = value;
            }
            get
            {
                return newqty;
            }
        }
        public int BatchId
        {
            set
            {
                Batchid = value;
            }
            get
            {
                return Batchid;
            }
        }
        public string ExpiryDate
        {
            set
            {
                expdate = value;
            }
            get
            {
                return expdate;
            }
        }
        public int ReorderLevel
        {
            set
            {
                reorder = value;
            }
            get
            {
                return reorder;
            }
        }
        public void Create()
        {
            DbConnection d = new DbConnection();
            string query = $@"insert into Inventory
                (Product_ID,Supplier_ID,ExistingQuantity,Reorderlevel,Batchid,Category_ID,NewQuantity)
                values({Proid},{Supid},{ExQTY},{ReorderLevel},{BatchId},{CateId},{NewQTY})";
            d.ExecuteQuery(query, true);
        }
        public DataTable Read()
        {
            DbConnection d = new DbConnection();
            string query = $@"SELECT 
    P.Product_ID,
    P.Name AS ProductName,
    P.Price AS ProductPrice,
    P.Category_ID,
    P.Quantity AS ProductQuantity,
    S.Supplier_ID,
    S.Name AS SupplierName,
    S.Contact AS SupplierContact,
    S.Address AS SupplierAddress,
    I.ExistingQuantity,
    I.NewQuantity,
    I.ReorderLevel,
    I.BatchID as StockBatchId,
    I.Quantity as StockTotalQty
FROM 
    Products P
JOIN 
    Inventory I ON P.Product_ID = I.Product_ID
JOIN 
    Suppliers S ON I.Supplier_ID = S.Supplier_ID
-- If there is a Categories table and you want to include Category details, you can join it as well
JOIN 
    Category C ON P.Category_ID = C.Category_ID;
";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;

        }
        public DataTable Read(int Proid)
        {
            //select where
            DbConnection d = new DbConnection();
            string query = $"select * from Inventory where Product_ID={Proid} ";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;

        }
        public void Update()
        {
            DbConnection d = new DbConnection();
            string query = $@"update Inventory set 
                Supplier_ID={Supid},ExistingQuantity={ExQTY},NewQuantity={NewQTY},Batchid={BatchId},Reorderlevel={ReorderLevel},Category_ID={CateId} where Product_ID={Proid}";
            d.ExecuteQuery(query, true);

        }
        public DataTable Delete()
        {
            DbConnection d = new DbConnection();
            string query = $"delete from Inventory where Product_ID={Proid}";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;
        }
        public void UpdateQuantity(string connectionString, int Proid, int ExQTY, int NewQTY)
        {
            string updateQuery = $@"UPDATE Inventory 
SET Quantity = {NewQTY}+{ExQTY},NewQuantity={NewQTY} where Product_ID={Proid}";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                updateCommand.Parameters.AddWithValue("@ExQTY", ExQTY);
                updateCommand.Parameters.AddWithValue("@NewQTY", NewQTY);
                updateCommand.Parameters.AddWithValue("@ProductID", Proid);

                int rowsAffected = updateCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Quantity updated successfully.");
                }
                else
                {
                    Console.WriteLine("No rows affected. Product ID may not exist.");
                }
            }
        }


    }
}
        