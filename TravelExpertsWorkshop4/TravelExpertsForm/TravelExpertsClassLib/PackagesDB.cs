using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsClassLib
{
    public class PackagesDB:TravelExpertsDB
    {
    
        //method for creating an empty list wich will display data
        public static List<Packages> GetPackages()
        {
            List<Packages> packages = new List<Packages>();
            try
            {
                Packages pkg; // for reading

                string selectQuery = "SELECT PackageID,  PkgName, PkgStartDate, PkgEndDate, " +
                                     "        PkgDescription, PkgBasePrice, PkgAgencyCommission " +
                                     "FROM Packages " +
                                     "ORDER BY PackageID";
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
                            pkg = new Packages();
                            pkg.PackageID = (int)dr["PackageID"];
                            pkg.PkgName = (string)dr["PkgName"];
                            pkg.PkgStartDate = (DateTime)dr["PkgStartDate"];
                            pkg.PkgEndDate = (DateTime)dr["PkgEndDate"];


                            // PkgStartDate with exception handling for null values
                            if (dr["PkgStartDate"] != DBNull.Value)
                            {
                                pkg.PkgStartDate = Convert.ToDateTime(dr["PkgStartDate"]);

                            }
                            else
                            {
                                pkg.PkgStartDate = null;
                            }

                            packages.Add(pkg);
                        }
                    }

                }
            }

            catch (Exception e)
            {
                throw e;
            }
            return packages;




        }
    }
}
