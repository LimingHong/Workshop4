using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsClassLib;

namespace TravelExpertsForm
{
    public partial class MainForm : Form
    {
        protected List<Packages> AllPackages = PackagesDB.GetPackages();
        protected List<Products> AllProducts = ProductsDB.GetProducts();
        protected List<Suppliers> AllSuppliers = SuppliersDB.GetSuppliers();
        protected List<ProSup> ProSupLinkages = ProSupDB.GetProSups();
        protected List<PacProSup> PacProSupLinkages = PacProSupDB.GetPacProSup() ;
        public MainForm()
        {
            InitializeComponent();
        }
        /*
         * KEEP IN MIND THAT
         *          Pkg many:many Products
         *          Pkg many:many Suppliers
         *          vice versa
         */


        /* For LINQ in the future
         *
         * select p.PackageId ,pps.ProductSupplierId,PkgName,PkgStartDate,PkgEndDate,PkgDesc,PkgBasePrice,PkgAgencyCommission,ProductId,SupplierId from Packages_Products_Suppliers pps
	        inner join  Packages p
		    on p.PackageId = pps.PackageId
	        inner join Products_Suppliers pp
		    on pps.ProductSupplierId = pp.ProductSupplierId
         */

        /*
         *select p.PackageId ,PkgName,pt.ProductId, ProdName,ss.SupplierId, ss.SupName from Packages_Products_Suppliers pps
	            inner join  Packages p
	            	on p.PackageId = pps.PackageId
	            inner join Products_Suppliers pp
	            	on pps.ProductSupplierId = pp.ProductSupplierId
	            inner join Products pt
	            	 on pt.ProductId = pp.ProductId
	            inner join Suppliers ss
	            	on ss.SupplierId = pp.SupplierId
         *
         * Querying for better visualization 
         *
         *
         */
        private void BindPackages()
        {
            packagesBindingSource.DataSource = AllPackages;

            // formating currency display
            decimal BasePrice, AgentCommission;
            Decimal.TryParse(pkgBasePriceTextBox.Text, out BasePrice);
            Decimal.TryParse(pkgAgencyCommissionTextBox.Text, out AgentCommission);

            pkgBasePriceTextBox.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", BasePrice);
            pkgAgencyCommissionTextBox.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", AgentCommission);

        }

        private void BindSuppliersProductsCB()
        {
            ProductsBindingSource.DataSource = AllProducts;
            ProductsCB.DataSource = ProductsBindingSource;
            ProductsCB.DisplayMember = "ProdName";
            ProductsCB.ValueMember = "ProductId";

            SuppliersBindingSource.DataSource = AllSuppliers;
            SuppliersCB.DataSource = SuppliersBindingSource;
            SuppliersCB.DisplayMember = "SupName";
            SuppliersCB.ValueMember = "SupplierId";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindSuppliersProductsCB();
            BindPackages();
        }
    }
}
