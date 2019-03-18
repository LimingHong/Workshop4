﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsClassLib
{
    public class ProSupDB : TravelExpertsDB
    {
        public static List<ProSup> GetProSups()
        {
            List<ProSup> proSup = new List<ProSup>();
            try
            {
                ProSup proS; // for reading

                string selectQuery = "SELECT ProductSupplierId,  ProductId, SupplierId " +
                                     "FROM Products_Suppliers " +
                                     "ORDER BY ProductSupplierId";
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
                            proS = new ProSup();
                            proS.ProductSupplierId = Convert.ToInt32(dr["ProductSupplierId"]);
                            proS.ProductId = Convert.ToInt32(dr["ProductId"]);
                            proS.SupplierId = Convert.ToInt32(dr["SupplierId"]);




                            proSup.Add(proS);
                        }
                    }

                }
            }

            catch (Exception e)
            {
                throw e;
            }
            return proSup;




        }
    }

}
