using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsClassLib
{
    public class TravelExpertsDB
    {
        //method to connect to "Northwind" database and get data from "Orders" table
        protected static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=TravelExperts;Integrated Security=True";
            return new SqlConnection(connectionString);
        }
    }
}
