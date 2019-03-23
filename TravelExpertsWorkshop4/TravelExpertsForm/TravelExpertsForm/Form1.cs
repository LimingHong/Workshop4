using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TravelExpertsClassLib;

namespace TravelExpertsForm
{
    public partial class MainForm : Form
    {
        protected List<Packages> AllPackages;
        protected List<Products> AllProducts;
        protected List<Suppliers> AllSuppliers;
        protected List<ProSup> ProSupLinkages;
        protected List<PacProSup> PacProSupLinkages;

        /*
         * Boolean indicators for Packages page
         */
        private bool EditPacStatus = false;
        private bool AddPacStatus = false;

        public MainForm()
        {
            InitializeComponent();
            this.ClientSize = new Size(967, 591);

        }

        private void UpdateAllInfos()
        {
            AllPackages = PackagesDB.GetPackages();
            AllProducts = ProductsDB.GetProducts();
            AllSuppliers = SuppliersDB.GetSuppliers();
            ProSupLinkages = ProSupDB.GetProSups();
            PacProSupLinkages = PacProSupDB.GetPacProSup();
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
                this.ProSupDataGridview.Columns["ProdName"].Visible = false;
                this.ProSupDataGridview.Columns["SupName"].Visible = false;


            }


        }

        private void DisplayPacInfo(ComboBox inputCB)
        {
            if (!String.IsNullOrEmpty(inputCB.Text))
            {
                string formatNumerical = "";
                int value = Convert.ToInt32(inputCB.SelectedValue);

                Packages filterPackage = AllPackages.First(p => p.PackageId == value);


                pkgNameTextBox.Text = filterPackage.PkgName;
                pkgDescRichTextBox.Text = filterPackage.PkgDesc;
                pkgStartDateDateTimePicker.Value = (DateTime)filterPackage.PkgStartDate;
                pkgEndDateDateTimePicker.Value = (DateTime)filterPackage.PkgEndDate;

                if (EditPacStatus)
                {
                    formatNumerical = "f2";
                }
                else
                {
                    formatNumerical = "c2";
                }
                pkgAgencyCommissionTextBox.Text = filterPackage.PkgAgencyCommission.ToString(formatNumerical);
                pkgBasePriceTextBox.Text = filterPackage.PkgBasePrice.ToString(formatNumerical);

            }
        }


        private void BindPackages()
        {
            packagesBindingSource.DataSource = AllPackages;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateAllInfos();
            MainTabControl.SelectTab(PackageTab);
            BindPackages();
            DisplayPacInfo(packageIdComboBox);
            FilterPacProSup(packageIdComboBox);
            DisplayProInfo(productIdComboBox);
            DisplaySupInfo(supplierIdComboBox);
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
            switch (inputAction)
            {
                case "Adding":
                    AddPacStatus = true;
                    ActionLabelPac.Text = "Adding";
                    AddPacIDTB.Visible = displayStatus;
                    packageIdComboBox.Visible = packageIdComboBox.Enabled = !displayStatus;
                    pkgNameTextBox.Text =
                        pkgDescRichTextBox.Text =
                            pkgAgencyCommissionTextBox.Text =
                                pkgBasePriceTextBox.Text = "";
                    break;

                case "Editing":
                    EditPacStatus = true;
                    ActionLabelPac.Text = "Editing";
                    DisplayPacInfo(packageIdComboBox);
                    FilterPacProSup(packageIdComboBox);
                    break;

                case "Cancel":
                    AddPacStatus = EditPacStatus = displayStatus = false;
                    ActionLabelPac.Text = "Viewing";
                    DisplayPacInfo(packageIdComboBox);
                    FilterPacProSup(packageIdComboBox);
                    AddPacIDTB.Visible = displayStatus;
                    packageIdComboBox.Visible = packageIdComboBox.Enabled = !displayStatus;
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
            PacProSupBindingSource.DataSource = new List<PacProSup>();


        }

        private void EditPacBtn_Click(object sender, EventArgs e)
        {
            AddEditConfig("Editing");
        }

        private void CancelPacBtn_Click(object sender, EventArgs e)
        {
            AddEditConfig("Cancel");
        }


        private void DisplaySupInfo(ComboBox supplierIdComboBox)
        {
            suppliersBindingSource.DataSource = AllSuppliers;
            suppliersDataGridView.DataSource = AllSuppliers;
        }
        private void productIdComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DisplayProInfo(packageIdComboBox);
        }

        private void supplierIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySupInfo(supplierIdComboBox);
        }

        private void DisplayProInfo(ComboBox packageIdComboBox)
        {
            productsBindingSource.DataSource = AllProducts;
            productsDataGridView.DataSource = AllProducts;
        }
        private Products CreateObject(Products New)
        {
            Products Pro = new Products();
            Pro.ProductId = New.ProductId;
            Pro.ProdName = New.ProdName;
            return Pro;
        }
        private Products FindOldProduct(ComboBox inputBox)
        {
            Products OldProduct = new Products();
            foreach (Products item in AllProducts)
            {
                if (Convert.ToInt32(inputBox.SelectedValue) == item.ProductId)
                {
                    OldProduct = CreateObject(item);
                }
            }

            return OldProduct;

        }

        private Products productUpdate(TextBox prodNameTextBox, Products product)
        {
            Products newProduct = CreateObject(product);
            newProduct.ProdName = prodNameTextBox.Text;
            return newProduct;
        }
        private Products productUpdate1(TextBox newName)
        {
            Products Pro = new Products();

            //Pro.ProductId = Convert.ToInt32(txtNewProductID.Text);
            Pro.ProdName = txtNewProductName.Text;
            return Pro;
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (Validator.IsPresent(prodNameTextBox) && Validator.IsPresent(productIdComboBox))
            //    {
            //        Products findOldProduct = FindOldProduct(productIdComboBox);


            //        if (findOldProduct != null)
            //        {
            //            Products newProduct = productUpdate(prodNameTextBox, CreateObject(findOldProduct));


            //            bool Success = ProductsDB.UpdateProduct(findOldProduct, newProduct);

            //            if (Success)
            //                MessageBox.Show("Product is updated :)");
            //            productsDataGridView.DataSource = AllProducts;
            //        }
            //        else
            //        {
            //            MessageBox.Show("Cant find Product ID");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("The product id is invalid. ");
            //    }
            //}
            ////catch the other error and show the ex error message from db class
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, ex.GetType().ToString());
            //}
        }

        private void btnProAdd_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (Validator.IsPresent(prodNameTextBox) && Validator.IsPresent(productIdComboBox))
            //    {




            //        Products newProduct = productUpdate1(txtNewProductID, txtNewProductName);


            //        newProduct.ProductId = ProductsDB.AddProduct(newProduct);


            //        MessageBox.Show("Product is updated :)");
            //        productsDataGridView.DataSource = AllProducts;


            //    }
            //}
            ////catch the other error and show the ex error message from db class
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, ex.GetType().ToString());
            //}
        }

        private void SavePacBtn_Click(object sender, EventArgs e)
        {
            string indicator = ""; // for testing purpose

            if (AddPacStatus)
            {

                //testing = "Saving item in add mode ";

            }

            if (EditPacStatus)
            {
                /*
                 * pkgNameTextBox
                pkgDescRichTextBox
                pkgStartDateDateTimePicker
                pkgEndDateDateTimePicker           
                pkgAgencyCommissionTextBox
                pkgBasePriceTextBox
                 */

                //testing = "Saving item in edit mode ";
                if (
                    //check if present
                    Validator.IsPresent(pkgNameTextBox, "Package Name") &&
                    Validator.IsPresentRichTB(pkgDescRichTextBox, "Package Description") &&
                    Validator.IsPresentDateTimePicker(pkgStartDateDateTimePicker, "Package Start Date") &&
                    Validator.IsPresentDateTimePicker(pkgEndDateDateTimePicker, "Package End Date") &&
                    Validator.IsPresent(pkgAgencyCommissionTextBox, "Agency Commission") &&
                    Validator.IsPresent(pkgBasePriceTextBox, "Price") &&
                    //check valid values
                    Validator.IsDecimal(pkgAgencyCommissionTextBox, "Agency Commission") &&
                    Validator.IsDecimal(pkgBasePriceTextBox, "Price") &&
                    Validator.IsNonNegativeDecimal(pkgAgencyCommissionTextBox, "Agency Commission") &&
                    Validator.IsNonNegativeDecimal(pkgBasePriceTextBox, "Price")
                    )
                {


                    int value = Convert.ToInt32(packageIdComboBox.SelectedValue);

                    Packages newPac = new Packages();

                    newPac.PackageId = value;
                    newPac.PkgName = pkgNameTextBox.Text;
                    newPac.PkgStartDate = pkgStartDateDateTimePicker.Value;
                    newPac.PkgEndDate = pkgEndDateDateTimePicker.Value;
                    newPac.PkgDesc = pkgDescRichTextBox.Text;
                    newPac.PkgBasePrice = Convert.ToDecimal(pkgBasePriceTextBox.Text);
                    newPac.PkgAgencyCommission = Convert.ToDecimal(pkgAgencyCommissionTextBox.Text);

                    indicator = "Update Package Failed. ";

                    if (PackagesDB.UpdatePackage(newPac))
                    {
                        indicator = "Update Package Successful !";
                        UpdateAllInfos();
                    }

                }


            }

            MessageBox.Show(indicator);
        }
        private void AddNewProduct(object sender, EventArgs e)
        {
            btnProAdd.Visible = true;
            txtNewProductName.Visible = true;
            //txtNewProductID.Visible = true;
            prodNameTextBox.ReadOnly = true;
            productIdComboBox.Enabled = false;
            btuProAddback.Visible = true;
            //lblNewProductIDD.Visible = true;
            lblNewProName.Visible = true;
            btuProAddback.Visible = true;


        }

        private void backPro(object sender, EventArgs e)
        {
            btnProAdd.Visible = false;
            txtNewProductName.Visible = false;
            //txtNewProductID.Visible = false;
            prodNameTextBox.ReadOnly = false;
            btuProAddback.Visible = false;
            //lblNewProductIDD.Visible = false;
            lblNewProName.Visible = false;
            productIdComboBox.Enabled = true;
        }


    }
}
