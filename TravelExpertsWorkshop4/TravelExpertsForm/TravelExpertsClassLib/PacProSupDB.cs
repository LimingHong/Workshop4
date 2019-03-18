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
    class PacProSupDB: TravelExpertsDB
    {
        public List<PacProSup> GetPacProSup()
        {
            List<PacProSup> newPacProSup = new List<PacProSup>(); // empty list object
            try
            {
                PacProSup currentPacProSup; // for reading

                string selectJoinQuery = "select * from PacProSup;";

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
                            currentPacProSup = new PacProSup();
                            currentPacProSup.PackageId = Convert.ToInt32(dr["PackageId"]);
                            currentPacProSup.ProductSupplierId = Convert.ToInt64(dr["ProductSupplierId"]);


                            newPacProSup.Add(currentPacProSup);
                        }
                    }
                } //  the object gets recycled


            }
            catch (Exception)
            {
                MessageBox.Show("Connection Error Try Again");
            }

            return newPacProSup;
        }
    }
}
