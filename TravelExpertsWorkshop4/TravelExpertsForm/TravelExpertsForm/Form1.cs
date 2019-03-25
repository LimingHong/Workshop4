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

        // variable for ProSupID
        private int selectedProductSupplierId = -1;

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


        //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
        /* Section: Package
         * Author: Eric
         */
        //Codes:

        private void packageIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayPacInfo(packageIdComboBox);
            FilterPacProSup(packageIdComboBox);

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

                    AddPacIDTB.Text = (AllPackages.OrderByDescending(p => p.PackageId).FirstOrDefault().PackageId + 1).ToString();

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

                if (filteredProSup.Count() == 0)
                {
                    filteredProSup = new List<PacProSup>();
                }

                PacProSupBindingSource.DataSource = filteredProSup;
                ProSupDataGridview.DataSource = PacProSupBindingSource;
                this.ProSupDataGridview.Columns["PackageId"].Visible = false;
                this.ProSupDataGridview.Columns["ProductId"].Visible = false;
                this.ProSupDataGridview.Columns["SupplierId"].Visible = false;
                this.ProSupDataGridview.Columns["ProductSupplierId"].Visible = false;


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

        private void SavePacBtn_Click(object sender, EventArgs e)
        {
            string indicator = ""; // for testing purpose

            if (AddPacStatus)
            {

                //testing = "Saving item in add mode ";
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

                    indicator = "Adding Package Failed. ";

                    if (PackagesDB.AddPackage(newPac))
                    {
                        indicator = "Adding Package Successful !";
                        UpdateAllInfos();
                        BindPackages();
                        CancelPacBtn.PerformClick();
                    }

                }

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

        private void AddProSup_Click(object sender, EventArgs e)
        {
            ProductAddComboB.DataSource = AllProducts;
            ProductAddComboB.DisplayMember = "ProdName";
            ProductAddComboB.ValueMember = "ProductId";

            SupplierAddComboB.DataSource = AllSuppliers;
            SupplierAddComboB.DisplayMember = "SupName";
            SupplierAddComboB.ValueMember = "SupplierId";


            AddProSupPanel.Visible = AddProSupPanel.Enabled = true;
            AddProSup.Visible = false;
        }

        private void AddProSupCancel_Click(object sender, EventArgs e)
        {
            AddProSupPanel.Visible = AddProSupPanel.Enabled = false;
            AddProSup.Visible = true;
        }

        private void AddProSupConfirmBtn_Click(object sender, EventArgs e)
        {
            bool existed = false;
            string statusTest = "Failed";

            UpdateAllInfos();
            int inputPackageID = Convert.ToInt32(packageIdComboBox.SelectedValue);
            int inputProductID = Convert.ToInt32(ProductAddComboB.SelectedValue);
            long inputSupplierID = Convert.ToInt64(SupplierAddComboB.SelectedValue);

            foreach (PacProSup pps in PacProSupLinkages)
            {
                if (pps.PackageId == inputPackageID && pps.ProductId == inputProductID &&
                    pps.SupplierId == inputSupplierID) existed = true;
            }

            if (!existed)
            {

                PacProSup newPPS = new PacProSup();
                newPPS.PackageId = inputPackageID;
                newPPS.ProductId = inputProductID;
                newPPS.SupplierId = inputSupplierID;


                if (PacProSupDB.AddPacProSup(newPPS))
                {
                    statusTest = "Adding Successful !";
                    UpdateAllInfos();
                    BindPackages();
                    DisplayPacInfo(packageIdComboBox);
                    FilterPacProSup(packageIdComboBox);
                }
            }
            else
            {
                statusTest = "That is already Existed for the current package !";
            }


            MessageBox.Show(statusTest);
        }

        // editing packages 
        private void EditProSupCancelBtn_Click(object sender, EventArgs e)
        {

            EditProSupPanel.Visible = false;
            AddProSup.Visible = true;
            selectedProductSupplierId = -1;
        }

        private void EditProSupSaveBtn_Click(object sender, EventArgs e)
        {
            string operationStatus = "Failed to Update Product and Supplier . Try Again";
            bool existed = false;
            int inputProductID = Convert.ToInt32(EditProCB.SelectedValue);
            long inputSupplierID = Convert.ToInt64(EditSupCB.SelectedValue);

            foreach (ProSup pps in ProSupLinkages)
            {
                if (pps.ProductId == inputProductID &&
                    pps.SupplierId == inputSupplierID) existed = true;
            }

            if (!existed)
            {
                ProSup inputProSup = new ProSup();
                inputProSup.ProductSupplierId = selectedProductSupplierId;
                inputProSup.ProductId = inputProductID;
                inputProSup.SupplierId = inputSupplierID;
                if (ProSupDB.UpdateProSup(inputProSup))
                {
                    operationStatus = "Successfully updated product and supplier for the package !";
                    UpdateAllInfos();
                    BindPackages();
                    DisplayPacInfo(packageIdComboBox);
                    FilterPacProSup(packageIdComboBox);
                }

            }
            else
            {
                operationStatus = "This pair of product and supplier is already existed for this package.";
            }

            MessageBox.Show(operationStatus);
        }

        private void ProSupDataGridview_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EditProSupPanel.Visible = true;
            AddProSup.Visible = false;
            if (e.RowIndex != -1)
            {
                DataGridViewRow selectedRow = ProSupDataGridview.Rows[e.RowIndex];

                selectedProductSupplierId = Convert.ToInt32(selectedRow.Cells[5].Value);

                EditProCB.DataSource = AllProducts;
                EditProCB.DisplayMember = "ProdName";
                EditProCB.ValueMember = "ProductId";
                EditProCB.SelectedValue = selectedRow.Cells[1].Value;

                EditSupCB.DataSource = AllSuppliers;
                EditSupCB.DisplayMember = "SupName";
                EditSupCB.ValueMember = "SupplierId";
                EditSupCB.SelectedValue = selectedRow.Cells[3].Value;

                //MessageBox.Show(selectedRow.Cells[5].Value.ToString());
            }

        }
        //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$






        //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
        /* Section: Products
         * Author: Liming
         */
        //Codes:


        //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$












        //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
        /* Section: Suppliers
         * Author: Guido
         */
        //Codes:


        //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$




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



        private void tabPage1_Click(object sender, EventArgs e)
        {

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
            Pro.ProdName = Convert.ToString(New.ProdName);
            return Pro;
        }

        private Suppliers CreateObject(Suppliers New)
        {
            Suppliers Sup = new Suppliers();
            Sup.SupplierId = New.SupplierId;
            Sup.SupName = New.SupName;
            return Sup;
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
            newProduct.ProdName = Convert.ToString(prodNameTextBox.Text);
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
            try
            {
                if (Validator.IsPresentCombo(productIdComboBox, "ID"))
                {
                    Products findOldProduct = FindOldProduct(productIdComboBox);


                    if (findOldProduct != null)
                    {
                        Products newProduct = productUpdate(prodNameTextBox, CreateObject(findOldProduct));


                        bool Success = ProductsDB.UpdateProduct(findOldProduct, newProduct);

                        if (Success)
                            MessageBox.Show("Product is updated :)");
                        productsDataGridView.DataSource = AllProducts;
                    }
                    else
                    {
                        MessageBox.Show("Cant find Product ID");
                    }
                }
                else
                {
                    MessageBox.Show("The product id is invalid. ");
                }
            }
            //catch the other error and show the ex error message from db class
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnProAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validator.IsPresent(txtNewProductName, "New Product Name"))
                {




                    Products newProduct = productUpdate1(txtNewProductName);


                    newProduct.ProductId = ProductsDB.AddProduct(newProduct);


                    MessageBox.Show("Product is updated :)");
                    productsDataGridView.DataSource = AllProducts;


                }
            }
            //catch the other error and show the ex error message from db class
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
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


        //this event allows to display the info on the text box when you double click on the desired row from the gridview table,
        // making easier to select the supplier and then edit its information
        private void suppliersDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            supplierIdComboBox.Text = suppliersDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            supNameTextBox.Text = suppliersDataGridView.SelectedRows[0].Cells[1].Value.ToString();
        }


        private Suppliers supplierUpdate(TextBox supNameTextBox, Suppliers supplier)
        {
            Suppliers newSupplier = CreateObject(supplier);
            newSupplier.SupName = supNameTextBox.Text;
            return newSupplier;
        }
        private Suppliers supplierUpdate1(TextBox newID, TextBox newName)
        {
            Suppliers Sup = new Suppliers();

            Sup.SupplierId = Convert.ToInt32(newID);
            Sup.SupName = newName.Text;
            return Sup;
        }

        //Method For Adding a new Supplier to database and therefore to the grid view as well.
        private void btnAddSupp_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (Validator.IsPresent(supNameTextBox, "Supplier's Name"))
            //    {




            //        Suppliers newSupplier = supplierUpdate1(txtNewProductID, txtNewProductName);


            //        newSupplier.SupplierId = SuppliersDB.AddSupplier(newSupplier);


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


    }
}
