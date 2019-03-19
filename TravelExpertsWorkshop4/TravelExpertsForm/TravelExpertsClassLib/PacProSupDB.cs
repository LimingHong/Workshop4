using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpertsClassLib
{
    public class PacProSupDB: TravelExpertsDB
    {
        public static List<PacProSup> GetPacProSup()
        {
            List<PacProSup> newPacProSup = new List<PacProSup>(); // empty list object
            try
            {
                PacProSup currentPacProSup; // for reading

                string selectJoinQuery = "select p.PackageId ,PkgName,pt.ProductId, ProdName,ss.SupplierId, ss.SupName " +
                                         "from Packages_Products_Suppliers pps " +
                                         "inner join  Packages p " +
                                         "on p.PackageId = pps.PackageId " +
                                         "inner join Products_Suppliers pp " +
                                         "on pps.ProductSupplierId = pp.ProductSupplierId " +
                                         "inner join Products pt " +
                                         "on pt.ProductId = pp.ProductId " +
                                         "inner join Suppliers ss " +
                                         "on ss.SupplierId = pp.SupplierId";

                // block code style
                using (SqlConnection con = GetConnection())
                {
                    // use con anywhere in this block
                    using (SqlCommand cmd = new SqlCommand(selectJoinQuery, con))
                    {
                        // use cmd anywhere in this block
                        // any exception will be thrown to the place wher this method was called
                        con.Open();

                        // this will auto close connection when done
                        SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                        while (dr.Read())  // while there is still data in the datareader
                        {
                            /*PackageId
                              ProductSupplierId*/
                            currentPacProSup = new PacProSup();
                            currentPacProSup.PackageId = Convert.ToInt32(dr["PackageId"]);
                            currentPacProSup.ProductId = Convert.ToInt32(dr["ProductId"]);
                            currentPacProSup.ProdName = dr["ProdName"] as string;
                            currentPacProSup.SupplierId = Convert.ToInt64(dr["SupplierId"]);
                            currentPacProSup.SupName = dr["SupName"] as string;
                            
                            newPacProSup.Add(currentPacProSup);
                        }
                    }
                } //  the object gets recycled


            }
            catch (Exception)
            {
                MessageBox.Show("Connection Error. Failed to retrieve PacProSup information");
            }

            return newPacProSup;
        }
    }
}
