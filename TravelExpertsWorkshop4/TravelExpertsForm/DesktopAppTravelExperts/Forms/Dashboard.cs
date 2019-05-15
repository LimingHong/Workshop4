using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using TravelExpertsClassLib;

namespace DesktopAppTravelExperts.Forms
{
    public partial class Dashboard : Form
    {
        public Agents currentAgent = null;

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
        private bool GridViewProSupEdit = false;
        private DateTime CurrentDateTime = DateTime.Now;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private bool PackageSection = false;
        private bool ProductSection = false;
        private bool SupplierSection = false;
        private bool CustomerSection = false;
        private bool SalesSection = false;
        private bool SettingSection = false;

        private bool ScreenFull = false;

        // section switching
        private string[] SectionStageTab = { "package", "product", "supplier", "customer", "sale", "setting" };
        private int SectionStageTabIndex = 0;

        private void DisplayTime()
        {
            var inTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Mountain Standard Time");
            DateTime inTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, inTimeZone);

            uxTimeDisplay.Text = inTime.ToLongTimeString();
        }

        // for time display very update of 1 second
        private void timerTime_Tick(object sender, EventArgs e)
        {
            DisplayTime();
        }

        /// <summary>
        /// Update All List of Infos
        /// </summary>
        private void UpdateAllInfos()
        {
            AllPackages = PackagesDB.GetPackages();
            AllProducts = ProductsDB.GetProducts();
            AllSuppliers = SuppliersDB.GetSuppliers();
            ProSupLinkages = ProSupDB.GetProSups();
            PacProSupLinkages = PacProSupDB.GetPacProSup();
        }

        public Dashboard()
        {
            InitializeComponent();

            // setting all btnIndicator to invinsible
            uxBtnIndicatorCus.Visible =
                uxBtnIndicatorPac.Visible =
                    uxBtnIndicatorPro.Visible =
                        uxBtnIndicatorSup.Visible =
                            uxBtnIndicatorSal.Visible =
                                uxBtnIndicatorSet.Visible = false;

            // display time
            uxDateDisplay.Text = DateTime.Now.ToLongDateString();
            DisplayTime();
            uxUserProfilePic.BackgroundImageLayout = ImageLayout.Stretch;


            // style tabcontrol
            MainTabControl.Appearance = TabAppearance.FlatButtons;
            MainTabControl.ItemSize = new Size(0, 1);
            MainTabControl.SizeMode = TabSizeMode.Fixed;
            MainTabControl.BackColor = Color.Transparent;

        }


        private void Dashboard_Load(object sender, System.EventArgs e)
        {
            this.Focus();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Dashboard_KeyDown);

            PageSectionIndicate(SectionStageTab[SectionStageTabIndex]);

            UpdateAllInfos();
            BindPackages();
            DisplayPacInfo(packageIdComboBox);
            FilterPacProSup(packageIdComboBox);
            //DisplayProInfo(productIdComboBox);
            //DisplaySupInfo(supplierIdComboBox);

            // set error messages to empty strings
            StartDateErrorLabel.Text = EndDateErrorLabel.Text = "";
            ValidateTime(pkgStartDateDateTimePicker, pkgEndDateDateTimePicker);

            // setting for agent display
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;

            uxUserNameLabel.Text = textInfo.ToTitleCase(currentAgent.AgtFirstName.ToString() + " " + currentAgent.AgtLastName.ToString());
            uxUserRoleLabel.Text = textInfo.ToTitleCase(currentAgent.AgtPosition.ToString());

            //just for display purposes
            if (currentAgent.AgentId < 9)
            {
                var imageName = "Agent" + currentAgent.AgentId;
                uxUserProfilePic.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(imageName);
            }


        }


        /// <summary>
        /// enter one of these package, product, supplier, customer, sale, setting
        /// </summary>
        /// <param name="inputIndicate"> </param>
        private void PageSectionIndicate(string inputIndicate)
        {
            // set everything to false then regulate
            PackageSection =
                ProductSection =
                    SupplierSection =
                        CustomerSection =
                            SalesSection =
                                SettingSection = false;
            // setting all btnIndicator to invinsible
            uxBtnIndicatorCus.Visible =
                uxBtnIndicatorPac.Visible =
                    uxBtnIndicatorPro.Visible =
                        uxBtnIndicatorSup.Visible =
                            uxBtnIndicatorSal.Visible =
                                uxBtnIndicatorSet.Visible = false;
            switch (inputIndicate.ToLower())
            {
                case "package":
                    uxBtnIndicatorPac.Visible = PackageSection = true;
                    MainTabControl.SelectTab(PackageTab);
                    break;

                case "product":
                    uxBtnIndicatorPro.Visible = ProductSection = true;
                    MainTabControl.SelectTab(ProductTab);
                    break;

                case "supplier":
                    uxBtnIndicatorSup.Visible = SupplierSection = true;
                    MainTabControl.SelectTab(SuppliersTab);
                    break;

                case "customer":
                    uxBtnIndicatorCus.Visible = CustomerSection = true;
                    MainTabControl.SelectTab(CustomersTab);
                    break;

                case "sale":
                    uxBtnIndicatorSal.Visible = SalesSection = true;
                    MainTabControl.SelectTab(SalesTab);
                    break;

                case "setting":
                    uxBtnIndicatorSet.Visible = SettingSection = true;
                    MainTabControl.SelectTab(SettingsTab);
                    break;
            }

        }

        private void button8_Click(object sender, System.EventArgs e)
        {
            panel2.Visible = !panel2.Visible;
        }

        private void uxClosingBtn_Click(object sender, System.EventArgs e)
        {
            this.Close();
            Environment.Exit(1);
        }


        private void uxBtnPackages_Click(object sender, System.EventArgs e)
        {
            PageSectionIndicate("package");
        }

        private void uxBtnProduct_Click(object sender, System.EventArgs e)
        {
            PageSectionIndicate("product");
        }

        private void uxBtnSupplier_Click(object sender, System.EventArgs e)
        {
            PageSectionIndicate("supplier");
        }

        private void uxBtnCustomer_Click(object sender, System.EventArgs e)
        {
            PageSectionIndicate("customer");
        }

        private void uxBtnSales_Click(object sender, System.EventArgs e)
        {
            PageSectionIndicate("sale");
        }

        private void uxBtnSettings_Click(object sender, System.EventArgs e)
        {
            PageSectionIndicate("setting");
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panelLeft_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        private void uxBtnScreenSize_Click(object sender, EventArgs e)
        {
            ScreenFull = !ScreenFull;
            if (ScreenFull)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                this.TopMost = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }


        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void uxBtnPackages_MouseEnter(object sender, EventArgs e)
        {
            uxBtnPackages.BackColor = Color.DimGray;
        }

        private void uxBtnPackages_MouseLeave(object sender, EventArgs e)
        {
            uxBtnPackages.BackColor = Color.Black;
        }

        private void uxBtnProduct_MouseEnter(object sender, EventArgs e)
        {
            uxBtnProduct.BackColor = Color.DimGray;
        }

        private void uxBtnProduct_MouseLeave(object sender, EventArgs e)
        {
            uxBtnProduct.BackColor = Color.Black;
        }

        private void uxBtnSupplier_MouseEnter(object sender, EventArgs e)
        {
            uxBtnSupplier.BackColor = Color.DimGray;
        }

        private void uxBtnSupplier_MouseLeave(object sender, EventArgs e)
        {
            uxBtnSupplier.BackColor = Color.Black;
        }

        private void uxBtnCustomer_MouseEnter(object sender, EventArgs e)
        {
            uxBtnCustomer.BackColor = Color.DimGray;
        }

        private void uxBtnCustomer_MouseLeave(object sender, EventArgs e)
        {
            uxBtnCustomer.BackColor = Color.Black;
        }

        private void uxBtnSales_MouseEnter(object sender, EventArgs e)
        {
            uxBtnSales.BackColor = Color.DimGray;
        }

        private void uxBtnSales_MouseLeave(object sender, EventArgs e)
        {
            uxBtnSales.BackColor = Color.Black;
        }

        private void uxBtnSettings_MouseEnter(object sender, EventArgs e)
        {
            uxBtnSettings.BackColor = Color.DimGray;
        }

        private void uxBtnSettings_MouseLeave(object sender, EventArgs e)
        {
            uxBtnSettings.BackColor = Color.Black;
        }

        private void Dashboard_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control && e.KeyCode == Keys.W)
            {
                Close();
            }

        }

        private void Dashboard_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Tab)
            {
                SectionStageTabIndex += 1;

                if (SectionStageTabIndex > SectionStageTab.Length - 1)
                {
                    SectionStageTabIndex = 0;
                }

                PageSectionIndicate(SectionStageTab[SectionStageTabIndex]);
                Console.WriteLine(SectionStageTab[SectionStageTabIndex] + SectionStageTabIndex.ToString());
            }
        }

        //*******************************************************************************************
        // Packages


        private int ValidatePrice(TextBox BasePriceInput, TextBox CommissionInput)
        {
            int indicator = 1;
            decimal BasePrice = 0;
            decimal AgentCommission = 0;

            BasePriceInput.BackColor = Color.Red;
            CommissionInput.BackColor = Color.Red;
            BasePriceInput.BackColor = Color.WhiteSmoke;
            CommissionInput.ForeColor = Color.WhiteSmoke;

            if (Decimal.TryParse(BasePriceInput.Text, out BasePrice) &&
                Decimal.TryParse(CommissionInput.Text, out AgentCommission))
            {
                if (BasePrice > AgentCommission)
                {
                    indicator = 0;
                    BasePriceInput.BackColor = Color.White;
                    CommissionInput.BackColor = Color.White;
                    BasePriceInput.ForeColor = Color.Black;
                    CommissionInput.ForeColor = Color.Black;
                }
                else
                {
                    MessageBox.Show("Agency's commission should not be larger than package Base Price.", "Status");
                }
            }
            else
            {
                MessageBox.Show("Error During Conversion Process. \nPlease Try Again.", "Status");
            }

            return indicator;
        }

        private int ValidateTime(DateTimePicker StartInputDateTimePicker, DateTimePicker EndInputDateTimePicker)
        {
            /*
             *  Less than zero : If t1 is earlier than t2.
                Zero : If t1 is the same as t2.

                Greater than zero : If t1 is later than t2.
             */
            int indicator = 0;

            int End_Now = DateTime.Compare(EndInputDateTimePicker.Value, CurrentDateTime);
            int End_Start = DateTime.Compare(StartInputDateTimePicker.Value, EndInputDateTimePicker.Value); // End date has to be after Start

            if (End_Start < 0) // end date is later than start 
            {
                if (End_Now <= 0) // end date is sooner than Now which the package is out of date
                {
                    StartDateErrorLabel.Text = EndDateErrorLabel.Text =
                        "These dates have been expired.\nPlease fix this error.";
                    indicator = 2;
                }
                else
                {
                    StartDateErrorLabel.Text = EndDateErrorLabel.Text = "";
                }
            }
            else // if the end date is equal to or sooner than start date 
            {
                StartDateErrorLabel.Text = EndDateErrorLabel.Text =
                    "Start date Should not be \n later than or equal to the End date.";
                indicator = 1;
            }

            return indicator;
        }


        private void packageIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayPacInfo(packageIdComboBox);
            FilterPacProSup(packageIdComboBox);
            CancelPacBtn.Text = "Cancel";
            ValidateTime(pkgStartDateDateTimePicker, pkgEndDateDateTimePicker);
        }



        private void AddEditConfig(string inputAction)
        {
            bool displayStatus = true;
            switch (inputAction)
            {
                case "Adding":
                    AddPacStatus = true;
                    ActionLabelPac.Text = "Adding Package";
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
                    ActionLabelPac.Text = "Editing Package";
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
            AddProSup.Visible = ProSupDataGridview.Enabled = false;
            AddEditConfig("Adding");
            PacProSupBindingSource.DataSource = new List<PacProSup>();

        }

        private void EditPacBtn_Click(object sender, EventArgs e)
        {
            CancelPacBtn.Text = "Cancel";
            AddEditConfig("Editing");
        }

        private void CancelPacBtn_Click(object sender, EventArgs e)
        {
            AddEditConfig("Cancel");
            AddProSup.Visible = ProSupDataGridview.Enabled = true;
            CancelPacBtn.Text = "Cancel";
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
            string indicator = "Operation Failed. ";
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

                    indicator = "Adding Package Failed. "; // for testing purpose
                    int value = Convert.ToInt32(packageIdComboBox.SelectedValue);

                    Packages newPac = new Packages();

                    newPac.PackageId = value;
                    newPac.PkgName = pkgNameTextBox.Text;
                    newPac.PkgStartDate = pkgStartDateDateTimePicker.Value;
                    newPac.PkgEndDate = pkgEndDateDateTimePicker.Value;
                    newPac.PkgDesc = pkgDescRichTextBox.Text;
                    newPac.PkgBasePrice = Convert.ToDecimal(pkgBasePriceTextBox.Text);
                    newPac.PkgAgencyCommission = Convert.ToDecimal(pkgAgencyCommissionTextBox.Text);

                    if (ValidateTime(pkgStartDateDateTimePicker, pkgEndDateDateTimePicker) == 0 && ValidatePrice(pkgBasePriceTextBox, pkgAgencyCommissionTextBox) == 0)
                    {

                        if (PackagesDB.AddPackage(newPac))
                        {
                            indicator = "Adding Package Successful !";
                            UpdateAllInfos();
                            BindPackages();
                            CancelPacBtn.PerformClick();
                        }
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
                    if (ValidateTime(pkgStartDateDateTimePicker, pkgEndDateDateTimePicker) == 0 && ValidatePrice(pkgBasePriceTextBox, pkgAgencyCommissionTextBox) == 0)
                    {
                        if (PackagesDB.UpdatePackage(newPac))
                        {
                            indicator = "Update Package Successful !";
                            UpdateAllInfos();
                            CancelPacBtn.Text = "Close";
                        }
                    }

                }


            }

            MessageBox.Show(indicator, "Status");
        }

        private void AddProSup_Click(object sender, EventArgs e)
        {
            AddProSupCancel.Text = "Cancel";
            ProductAddComboB.DataSource = AllProducts;
            ProductAddComboB.DisplayMember = "ProdName";
            ProductAddComboB.ValueMember = "ProductId";

            SupplierAddComboB.DataSource = AllSuppliers;
            SupplierAddComboB.DisplayMember = "SupName";
            SupplierAddComboB.ValueMember = "SupplierId";


            AddProSupPanel.Visible = AddProSupPanel.Enabled = true;
            AddProSup.Visible = false;
            ProSupDataGridview.Enabled = false;
        }

        private void AddProSupCancel_Click(object sender, EventArgs e)
        {
            AddProSupPanel.Visible = AddProSupPanel.Enabled = false;
            AddProSup.Visible = true;
            ProSupDataGridview.Enabled = true;
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
                    AddProSupCancel.Text = "Close";
                }
            }
            else
            {
                statusTest = "That is already Existed for the current package !";
            }


            MessageBox.Show(statusTest, "Status");

        }

        // editing packages 
        private void EditProSupCancelBtn_Click(object sender, EventArgs e)
        {

            EditProSupPanel.Visible = GridViewProSupEdit = false;
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
                    EditProSupCancelBtn.Text = "Close";
                }

            }
            else
            {
                operationStatus = "This pair of product and supplier is already existed for this package.";
            }

            MessageBox.Show(operationStatus, "Status");
            GridViewProSupEdit = false;
        }

        private void ProSupDataGridview_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EditProSupCancelBtn.Text = "Cancel";
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
                GridViewProSupEdit = true;
                //MessageBox.Show(selectedRow.Cells[5].Value.ToString());
            }

        }

        private void ProSupDataGridview_SelectionChanged(object sender, EventArgs e)
        {
            if (GridViewProSupEdit)
            {
                DataGridView selectedRow = (DataGridView)sender;

                //User selected WHOLE ROW (by clicking in the margin)
                if (selectedRow.SelectedRows.Count > 0 || selectedRow.SelectedCells.Count > 0)
                {

                    selectedProductSupplierId = Convert.ToInt32(selectedRow.Rows[selectedRow.SelectedCells[0].RowIndex].Cells[5].Value);

                    EditProCB.DataSource = AllProducts;
                    EditProCB.DisplayMember = "ProdName";
                    EditProCB.ValueMember = "ProductId";
                    EditProCB.SelectedValue = selectedRow.Rows[selectedRow.SelectedCells[0].RowIndex].Cells[1].Value;

                    EditSupCB.DataSource = AllSuppliers;
                    EditSupCB.DisplayMember = "SupName";
                    EditSupCB.ValueMember = "SupplierId";
                    EditSupCB.SelectedValue = selectedRow.Rows[selectedRow.SelectedCells[0].RowIndex].Cells[3].Value;

                }
            }


        }


        // Packages section ends
        //*******************************************************************************************



        //*******************************************************************************************
        //Suppliers Starts
        private Suppliers CreateObject(Suppliers New)
        {
            Suppliers Sup = new Suppliers();
            Sup.SupplierId = New.SupplierId;
            Sup.SupName = New.SupName;
            return Sup;
        }

        //this event allows to display the info on the text box when you double click on the desired row from the gridview table,
        // making easier to select the supplier and then edit its information
        private void suppliersDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            supplierIdComboBox.Text = suppliersDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            supNameTextBox.Text = suppliersDataGridView.SelectedRows[0].Cells[1].Value.ToString();
        }



        //Method For Adding a new Supplier to database and therefore to the grid view as well.
        private void btnAddSupp_Click(object sender, EventArgs e)
        {
            grpNewSupp.Visible = true; //displays textbox for adding a new supplier

            supNameTextBox.Enabled = false;
            btnUpdateSupplier.Visible = false;
        }

        private void btnEditSupp_Click(object sender, EventArgs e)
        {
            supNameTextBox.Enabled = true; //allows to modify input on the text box
            btnUpdateSupplier.Visible = true; //button for update editted supplier name
            grpNewSupp.Visible = false;
        }

        private void btnSaveSupp_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validator.IsPresent(txtNewSupp, "New Supplier Name"))
                {

                    Suppliers newSupplier = new Suppliers();

                    newSupplier.SupName = txtNewSupp.Text;

                    newSupplier.SupplierId = AllSuppliers.Max(s => s.SupplierId) + 1;

                    if (SuppliersDB.AddSupplier(newSupplier))
                    {
                        MessageBox.Show("Supplier has been updated :)");
                        UpdateAllInfos();
                        suppliersDataGridView.DataSource = AllSuppliers;
                    }

                }
            }
            //catch the other error and show the ex error message from db class
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validator.IsPresent(supNameTextBox, "Supplier New Name"))
                {

                    Suppliers updateSupplier = new Suppliers();
                    updateSupplier.SupplierId = Convert.ToInt64(supplierIdComboBox.SelectedValue);
                    updateSupplier.SupName = supNameTextBox.Text.ToUpper().Trim();

                    if (SuppliersDB.UpdateSupplier(updateSupplier))
                    {
                        MessageBox.Show("Supplier has been updated :)");
                        UpdateAllInfos();
                        suppliersDataGridView.DataSource = AllSuppliers;
                    }
                }
            }
            //catch the other error and show the ex error message from db class
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        //Suppliers ends
        //*******************************************************************************************






        //*******************************************************************************************
        // products Author: Liming Hong

        private void productIdComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DisplayProInfo(packageIdComboBox);
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
                if (Validator.IsPresentCombo(productIdComboBox, "ID") && Validator.IsPresent(prodNameTextBox, "New Product Name") && Validator.IsCorrectLength(prodNameTextBox, "Name", 20) && Validator.IsNameValid(prodNameTextBox, "Name"))
                {
                    Products findOldProduct = FindOldProduct(productIdComboBox);


                    if (findOldProduct != null)
                    {
                        Products newProduct = productUpdate(prodNameTextBox, CreateObject(findOldProduct));


                        bool Success = ProductsDB.UpdateProduct(findOldProduct, newProduct);

                        if (Success)
                            MessageBox.Show("Product is updated :)");
                        UpdateAllInfos();
                        productsDataGridView.DataSource = AllProducts;
                    }
                    else
                    {
                        MessageBox.Show("Cant find Product ID");
                    }
                }
                else
                {
                    MessageBox.Show("Please re-enter. ");
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
                if (Validator.IsPresent(txtNewProductName, "New Product Name") && Validator.IsCorrectLength(txtNewProductName, "Name", 20) && Validator.IsNameValid(txtNewProductName, "Name"))
                {




                    Products newProduct = productUpdate1(txtNewProductName);


                    newProduct.ProductId = ProductsDB.AddProduct(newProduct);


                    MessageBox.Show("Product is updated :)");
                    UpdateAllInfos();
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




        // products ends
        //******************************************************************************************
    }
}
