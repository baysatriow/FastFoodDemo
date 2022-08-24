using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1. 
using System.Data.SqlClient;
namespace FastFoodDemo
{
    internal class koneksi
    {
        public SqlConnection GetConn()
        {
            //2.
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=GOLDENZ\\SQLEXPRESS;Initial Catalog=tableservice;Integrated Security=True";
            return conn;
        }
    }
}