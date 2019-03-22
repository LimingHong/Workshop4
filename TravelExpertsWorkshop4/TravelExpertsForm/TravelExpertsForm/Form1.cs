using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        // filtering ProSup for data gridview
        private void FilterPacProSup(ComboBox inputCB)
        {
            
            if (!String.IsNullOrEmpty(inputCB.Text))
            {
                int value = Convert.ToInt32(inputCB.SelectedValue);
                productsBindingSource.DataSource = AllProducts;
                suppliersBindingSource.DataSource = AllSuppliers;

                var filteredProSup = from pps in PacProSupLinkages
                    where value == pps.PackageId
                    select pps;
                
                //MessageBox.Show(filteredProSup.Count().ToString());

                PacProSupBindingSource.DataSource = filteredProSup;
                ProSupDataGridview.DataSource = PacProSupBindingSource;
                this.ProSupDataGridview.Columns["PackageId"].Visible = false;
                this.ProSupDataGridview.Columns["ProdName"].Visible  = false;
                this.ProSupDataGridview.Columns["SupName"].Visible   = false;

                
            }


        }

        private void DisplayPacInfo(ComboBox inputCB)
        {
            if (!String.IsNullOrEmpty(inputCB.Text))
            {
                int value = Convert.ToInt32(inputCB.SelectedValue);

                Packages filterPackage = AllPackages.First(p => p.PackageId == value);


                pkgNameTextBox.Text = filterPackage.PkgName;
                pkgDescRichTextBox.Text = filterPackage.PkgDesc;
                pkgStartDateDateTimePicker.Value = (DateTime)filterPackage.PkgStartDate;
                pkgEndDateDateTimePicker.Value = (DateTime)filterPackage.PkgEndDate;
                pkgAgencyCommissionTextBox.Text = filterPackage.PkgBasePrice.ToString("c2");
                pkgBasePriceTextBox.Text = filterPackage.PkgBasePrice.ToString("c2");
            }
        }


        private void BindPackages()
        {
            packagesBindingSource.DataSource = AllPackages;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainTabControl.SelectTab(PackageTab);
            BindPackages();
            DisplayPacInfo(packageIdComboBox);
            FilterPacProSup(packageIdComboBox);
        }

        private void packageIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayPacInfo(packageIdComboBox);
            FilterPacProSup(packageIdComboBox);
            
        }

        private void ProSupDataGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EnableEditProSup_Click(object sender, EventArgs e)
        {
            EnableEditProSup.Visible = false;
            ProSupDataGridview.Enabled = true;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void AddEditConfig(string inputAction)
        {
            bool displayStatus = true;
            switch (inputAction){
                case "Adding":
                    ActionLabelPac.Text = "Adding";
                    AddPacIDTB.Visible = displayStatus;
                    packageIdComboBox.Visible = !displayStatus;
                    pkgNameTextBox.Text =
                        pkgDescRichTextBox.Text =
                            pkgAgencyCommissionTextBox.Text =
                                pkgBasePriceTextBox.Text = "";
                    break;

                case "Editing":
                    ActionLabelPac.Text = "Editing";
                    pkgAgencyCommissionTextBox.Text = decimal.Parse(pkgAgencyCommissionTextBox.Text, NumberStyles.Any).ToString("f2");
                    pkgBasePriceTextBox.Text = decimal.Parse(pkgBasePriceTextBox.Text, NumberStyles.Any).ToString("f2");
                    break;

                case "Cancel":
                    ActionLabelPac.Text = "Viewing";
                    displayStatus = false;
                    DisplayPacInfo(packageIdComboBox);
                    FilterPacProSup(packageIdComboBox);
                    AddPacIDTB.Visible = displayStatus;
                    packageIdComboBox.Visible = !displayStatus;
                    break;
            }

            pkgStartDateDateTimePicker.Enabled =
                pkgEndDateDateTimePicker.Enabled = 
                    SavePacBtn.Visible = CancelPacBtn.Visible = displayStatus;

            EditPacBtn.Visible = PacAddBtn.Visible = 
            pkgNameTextBox.ReadOnly =
                pkgDescRichTextBox.ReadOnly =
                    pkgAgencyCommissionTextBox.ReadOnly =
                        pkgBasePriceTextBox.ReadOnly = !displayStatus;
        }

        private void PacAddBtn_Click(object sender, EventArgs e)
        {
            AddEditConfig("Adding");
        }

        private void EditPacBtn_Click(object sender, EventArgs e)
        {
            AddEditConfig("Editing");
        }

        private void CancelPacBtn_Click(object sender, EventArgs e)
        {
            AddEditConfig("Cancel");
        }
    }
}
