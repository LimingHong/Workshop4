using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlDataReader = System.Data.SqlClient.SqlDataReader;

namespace TravelExpertsClassLib
{
    public class SuppliersDB:TravelExpertsDB
    {
        public static List<Suppliers> GetSuppliers()
        {
            List<Suppliers> newSuppliers = new List<Suppliers>(); // empty list object
            try
            {
                Suppliers currentSupllier; // for reading
                
                string selectJoinQuery = "select * from Suppliers";

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
                            currentSupllier = new Suppliers();
                            //SupplierId SupName
                            currentSupllier.SupplierId = Convert.ToInt64(dr["SupplierId"]);
                            currentSupllier.SupName = dr["SupName"] as string;
                            

                            newSuppliers.Add(currentSupllier);
                        }
                    }
                } //  the object gets recycled


            }
            catch (Exception )
            {
                MessageBox.Show("Connection Error. Failed to retrieve Suppliers information");
            }

            return newSuppliers;
        }
    }
}
