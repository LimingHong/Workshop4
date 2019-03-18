using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsClassLib
{
    class ProductsDB : TravelExpertsDB
    {
        

            //method for creating an empty list wich will display data
            public static List<Products> GetPackages()
            {
                List<Products> products = new List<Products>();
                try
                {
                   Products Pro; // for reading

                    string selectQuery = "SELECT ProductId,  ProdName " +
                                         "FROM Products " +
                                         "ORDER BY ProductId";
                    using (SqlConnection con = GetConnection())
                    {
                        //use "con" anywhere in this block
                        using (SqlCommand cmd = new SqlCommand(selectQuery, con))
                        {

                            //any exception will be thrown to the place where this method was called
                            con.Open(); // open connection

                            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection); // closes connection when done reading

                            while (dr.Read())// while there is data in data reader
                            {
                                Pro = new Products();
                                Pro.ProductId = Convert.ToInt32(dr["ProductId"]);
                            if (dr["PkgStartDate"] != DBNull.Value)
                            { Pro.ProdName = Convert.ToString(dr["ProdName"]); }
                            else
                            {
                                Pro.ProdName = null;
                            }
                                


                               
                                products.Add(Pro);
                            }
                        }

                    }
                }

                catch (Exception e)
                {
                    throw e;
                }
                return products;




            
        }
    }
}
