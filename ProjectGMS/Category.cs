using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace ProjectGMS
{
    class Category
    {

        int Catid;
        string Name;
        string Description;
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

        public string CateName
        {
            set
            {
                Name= value;
            }
            get
            {
                return Name;
            }
        }
        public string CateDes
        {
            set
            {
                Description = value;
            }
            get
            {
                return Description;
            }
        }
        public void Create()
        {
            DbConnection d = new DbConnection();
            string query = $@"insert into Category
                (Category_ID,Name,Description)
                values({CateId},'{CateName}','{CateDes}')";
            d.ExecuteQuery(query, true);
        }
        public DataTable Read()
        {
            DbConnection d = new DbConnection();
            string query = "select * from Category";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;

        }
        public DataTable Read(int CateId)
        {
            //select where
            DbConnection d = new DbConnection();
            string query = $"select * from Category where Category_ID={CateId}";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;

        }
        public void Update()
        {
            DbConnection d = new DbConnection();
            string query = $@"update Category set 
                Name='{CateName}',Description='{CateDes}' where Category_ID={CateId}";
            d.ExecuteQuery(query, true);

        }
        public DataTable Delete()
        {
            DbConnection d = new DbConnection();
            string query = $"delete from Category where Category_ID={CateId}";
            DataTable dt = d.ExecuteQuery(query, false);
            return dt;
        }

    }
}

