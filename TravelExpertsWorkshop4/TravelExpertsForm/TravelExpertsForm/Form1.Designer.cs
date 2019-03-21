namespace TravelExpertsForm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label packageIdLabel;
            System.Windows.Forms.Label pkgAgencyCommissionLabel;
            System.Windows.Forms.Label pkgBasePriceLabel;
            System.Windows.Forms.Label pkgDescLabel;
            System.Windows.Forms.Label pkgEndDateLabel;
            System.Windows.Forms.Label pkgNameLabel;
            System.Windows.Forms.Label pkgStartDateLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label prodNameLabel;
            System.Windows.Forms.Label productIdLabel;
            System.Windows.Forms.Label supNameLabel;
            System.Windows.Forms.Label supplierIdLabel;
            this.packagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packageIdComboBox = new System.Windows.Forms.ComboBox();
            this.pkgAgencyCommissionTextBox = new System.Windows.Forms.TextBox();
            this.pkgBasePriceTextBox = new System.Windows.Forms.TextBox();
            this.pkgDescRichTextBox = new System.Windows.Forms.RichTextBox();
            this.pkgEndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pkgNameTextBox = new System.Windows.Forms.TextBox();
            this.pkgStartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProSupDataGridview = new System.Windows.Forms.DataGridView();
            this.ProdNameCB = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SupNameCB = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PacProSupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacEditBtn = new System.Windows.Forms.Button();
            this.EnableEditProSup = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.ProductTab = new System.Windows.Forms.TabPage();
            this.PackageTab = new System.Windows.Forms.TabPage();
            this.SuppliersTab = new System.Windows.Forms.TabPage();
            this.prodNameTextBox = new System.Windows.Forms.TextBox();
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.supNameTextBox = new System.Windows.Forms.TextBox();
            this.supplierIdTextBox = new System.Windows.Forms.TextBox();
            this.suppliersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            packageIdLabel = new System.Windows.Forms.Label();
            pkgAgencyCommissionLabel = new System.Windows.Forms.Label();
            pkgBasePriceLabel = new System.Windows.Forms.Label();
            pkgDescLabel = new System.Windows.Forms.Label();
            pkgEndDateLabel = new System.Windows.Forms.Label();
            pkgNameLabel = new System.Windows.Forms.Label();
            pkgStartDateLabel = new System.Windows.Forms.Label();
            prodNameLabel = new System.Windows.Forms.Label();
            productIdLabel = new System.Windows.Forms.Label();
            supNameLabel = new System.Windows.Forms.Label();
            supplierIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProSupDataGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacProSupBindingSource)).BeginInit();
            this.MainTabControl.SuspendLayout();
            this.ProductTab.SuspendLayout();
            this.PackageTab.SuspendLayout();
            this.SuppliersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // packageIdLabel
            // 
            packageIdLabel.AutoSize = true;
            packageIdLabel.Location = new System.Drawing.Point(108, 42);
            packageIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            packageIdLabel.Name = "packageIdLabel";
            packageIdLabel.Size = new System.Drawing.Size(93, 20);
            packageIdLabel.TabIndex = 18;
            packageIdLabel.Text = "Package Id:";
            // 
            // pkgAgencyCommissionLabel
            // 
            pkgAgencyCommissionLabel.AutoSize = true;
            pkgAgencyCommissionLabel.Location = new System.Drawing.Point(30, 538);
            pkgAgencyCommissionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgAgencyCommissionLabel.Name = "pkgAgencyCommissionLabel";
            pkgAgencyCommissionLabel.Size = new System.Drawing.Size(187, 20);
            pkgAgencyCommissionLabel.TabIndex = 20;
            pkgAgencyCommissionLabel.Text = "Pkg Agency Commission:";
            // 
            // pkgBasePriceLabel
            // 
            pkgBasePriceLabel.AutoSize = true;
            pkgBasePriceLabel.Location = new System.Drawing.Point(94, 631);
            pkgBasePriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgBasePriceLabel.Name = "pkgBasePriceLabel";
            pkgBasePriceLabel.Size = new System.Drawing.Size(120, 20);
            pkgBasePriceLabel.TabIndex = 22;
            pkgBasePriceLabel.Text = "Pkg Base Price:";
            // 
            // pkgDescLabel
            // 
            pkgDescLabel.AutoSize = true;
            pkgDescLabel.Location = new System.Drawing.Point(112, 162);
            pkgDescLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgDescLabel.Name = "pkgDescLabel";
            pkgDescLabel.Size = new System.Drawing.Size(81, 20);
            pkgDescLabel.TabIndex = 24;
            pkgDescLabel.Text = "Pkg Desc:";
            // 
            // pkgEndDateLabel
            // 
            pkgEndDateLabel.AutoSize = true;
            pkgEndDateLabel.Location = new System.Drawing.Point(78, 377);
            pkgEndDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgEndDateLabel.Name = "pkgEndDateLabel";
            pkgEndDateLabel.Size = new System.Drawing.Size(112, 20);
            pkgEndDateLabel.TabIndex = 26;
            pkgEndDateLabel.Text = "Pkg End Date:";
            // 
            // pkgNameLabel
            // 
            pkgNameLabel.AutoSize = true;
            pkgNameLabel.Location = new System.Drawing.Point(108, 102);
            pkgNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgNameLabel.Name = "pkgNameLabel";
            pkgNameLabel.Size = new System.Drawing.Size(86, 20);
            pkgNameLabel.TabIndex = 28;
            pkgNameLabel.Text = "Pkg Name:";
            // 
            // pkgStartDateLabel
            // 
            pkgStartDateLabel.AutoSize = true;
            pkgStartDateLabel.Location = new System.Drawing.Point(78, 449);
            pkgStartDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgStartDateLabel.Name = "pkgStartDateLabel";
            pkgStartDateLabel.Size = new System.Drawing.Size(118, 20);
            pkgStartDateLabel.TabIndex = 30;
            pkgStartDateLabel.Text = "Pkg Start Date:";
            // 
            // packagesBindingSource
            // 
            this.packagesBindingSource.DataSource = typeof(TravelExpertsClassLib.Packages);
            // 
            // packageIdComboBox
            // 
            this.packageIdComboBox.DataSource = this.packagesBindingSource;
            this.packageIdComboBox.DisplayMember = "PackageId";
            this.packageIdComboBox.FormattingEnabled = true;
            this.packageIdComboBox.Location = new System.Drawing.Point(243, 29);
            this.packageIdComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.packageIdComboBox.Name = "packageIdComboBox";
            this.packageIdComboBox.Size = new System.Drawing.Size(298, 28);
            this.packageIdComboBox.TabIndex = 19;
            this.packageIdComboBox.ValueMember = "PackageId";
            this.packageIdComboBox.SelectedIndexChanged += new System.EventHandler(this.packageIdComboBox_SelectedIndexChanged);
            // 
            // pkgAgencyCommissionTextBox
            // 
            this.pkgAgencyCommissionTextBox.Location = new System.Drawing.Point(243, 534);
            this.pkgAgencyCommissionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pkgAgencyCommissionTextBox.Name = "pkgAgencyCommissionTextBox";
            this.pkgAgencyCommissionTextBox.Size = new System.Drawing.Size(298, 26);
            this.pkgAgencyCommissionTextBox.TabIndex = 21;
            // 
            // pkgBasePriceTextBox
            // 
            this.pkgBasePriceTextBox.Location = new System.Drawing.Point(243, 626);
            this.pkgBasePriceTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pkgBasePriceTextBox.Name = "pkgBasePriceTextBox";
            this.pkgBasePriceTextBox.Size = new System.Drawing.Size(298, 26);
            this.pkgBasePriceTextBox.TabIndex = 23;
            // 
            // pkgDescRichTextBox
            // 
            this.pkgDescRichTextBox.Location = new System.Drawing.Point(99, 186);
            this.pkgDescRichTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pkgDescRichTextBox.Name = "pkgDescRichTextBox";
            this.pkgDescRichTextBox.Size = new System.Drawing.Size(442, 146);
            this.pkgDescRichTextBox.TabIndex = 25;
            this.pkgDescRichTextBox.Text = "";
            // 
            // pkgEndDateDateTimePicker
            // 
            this.pkgEndDateDateTimePicker.Location = new System.Drawing.Point(243, 368);
            this.pkgEndDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pkgEndDateDateTimePicker.Name = "pkgEndDateDateTimePicker";
            this.pkgEndDateDateTimePicker.Size = new System.Drawing.Size(298, 26);
            this.pkgEndDateDateTimePicker.TabIndex = 27;
            // 
            // pkgNameTextBox
            // 
            this.pkgNameTextBox.Location = new System.Drawing.Point(243, 97);
            this.pkgNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pkgNameTextBox.Name = "pkgNameTextBox";
            this.pkgNameTextBox.Size = new System.Drawing.Size(298, 26);
            this.pkgNameTextBox.TabIndex = 29;
            // 
            // pkgStartDateDateTimePicker
            // 
            this.pkgStartDateDateTimePicker.Location = new System.Drawing.Point(243, 440);
            this.pkgStartDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pkgStartDateDateTimePicker.Name = "pkgStartDateDateTimePicker";
            this.pkgStartDateDateTimePicker.Size = new System.Drawing.Size(298, 26);
            this.pkgStartDateDateTimePicker.TabIndex = 31;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(TravelExpertsClassLib.Products);
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataSource = typeof(TravelExpertsClassLib.Suppliers);
            // 
            // ProSupDataGridview
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProSupDataGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProSupDataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProSupDataGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdNameCB,
            this.SupNameCB});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProSupDataGridview.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProSupDataGridview.Enabled = false;
            this.ProSupDataGridview.Location = new System.Drawing.Point(681, 29);
            this.ProSupDataGridview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProSupDataGridview.Name = "ProSupDataGridview";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProSupDataGridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ProSupDataGridview.Size = new System.Drawing.Size(728, 749);
            this.ProSupDataGridview.TabIndex = 32;
            this.toolTip1.SetToolTip(this.ProSupDataGridview, "Click Edit to modify");
            this.ProSupDataGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProSupDataGridview_CellContentClick);
            // 
            // ProdNameCB
            // 
            this.ProdNameCB.DataPropertyName = "ProductId";
            this.ProdNameCB.DataSource = this.productsBindingSource;
            this.ProdNameCB.DisplayMember = "ProdName";
            this.ProdNameCB.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ProdNameCB.HeaderText = "Product Name";
            this.ProdNameCB.Name = "ProdNameCB";
            this.ProdNameCB.ValueMember = "ProductId";
            this.ProdNameCB.Width = 200;
            // 
            // SupNameCB
            // 
            this.SupNameCB.DataPropertyName = "SupplierId";
            this.SupNameCB.DataSource = this.suppliersBindingSource;
            this.SupNameCB.DisplayMember = "SupName";
            this.SupNameCB.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.SupNameCB.HeaderText = "Supplier Name";
            this.SupNameCB.Name = "SupNameCB";
            this.SupNameCB.ValueMember = "SupplierId";
            this.SupNameCB.Width = 200;
            // 
            // pacEditBtn
            // 
            this.pacEditBtn.Location = new System.Drawing.Point(228, 743);
            this.pacEditBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pacEditBtn.Name = "pacEditBtn";
            this.pacEditBtn.Size = new System.Drawing.Size(112, 35);
            this.pacEditBtn.TabIndex = 34;
            this.pacEditBtn.Text = "Edit";
            this.pacEditBtn.UseVisualStyleBackColor = true;
            // 
            // EnableEditProSup
            // 
            this.EnableEditProSup.Location = new System.Drawing.Point(960, 743);
            this.EnableEditProSup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EnableEditProSup.Name = "EnableEditProSup";
            this.EnableEditProSup.Size = new System.Drawing.Size(189, 35);
            this.EnableEditProSup.TabIndex = 35;
            this.EnableEditProSup.Text = "Enable Editing";
            this.EnableEditProSup.UseVisualStyleBackColor = true;
            this.EnableEditProSup.Click += new System.EventHandler(this.EnableEditProSup_Click);
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.ProductTab);
            this.MainTabControl.Controls.Add(this.PackageTab);
            this.MainTabControl.Controls.Add(this.SuppliersTab);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1425, 857);
            this.MainTabControl.TabIndex = 37;
            // 
            // ProductTab
            // 
            this.ProductTab.Controls.Add(this.productsDataGridView);
            this.ProductTab.Controls.Add(prodNameLabel);
            this.ProductTab.Controls.Add(this.prodNameTextBox);
            this.ProductTab.Controls.Add(productIdLabel);
            this.ProductTab.Controls.Add(this.productIdTextBox);
            this.ProductTab.Location = new System.Drawing.Point(4, 29);
            this.ProductTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductTab.Name = "ProductTab";
            this.ProductTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductTab.Size = new System.Drawing.Size(1417, 824);
            this.ProductTab.TabIndex = 1;
            this.ProductTab.Text = "Products";
            this.ProductTab.UseVisualStyleBackColor = true;
            // 
            // PackageTab
            // 
            this.PackageTab.Controls.Add(this.EnableEditProSup);
            this.PackageTab.Controls.Add(packageIdLabel);
            this.PackageTab.Controls.Add(this.ProSupDataGridview);
            this.PackageTab.Controls.Add(this.packageIdComboBox);
            this.PackageTab.Controls.Add(pkgNameLabel);
            this.PackageTab.Controls.Add(pkgDescLabel);
            this.PackageTab.Controls.Add(this.pkgNameTextBox);
            this.PackageTab.Controls.Add(pkgAgencyCommissionLabel);
            this.PackageTab.Controls.Add(this.pkgDescRichTextBox);
            this.PackageTab.Controls.Add(this.pacEditBtn);
            this.PackageTab.Controls.Add(pkgEndDateLabel);
            this.PackageTab.Controls.Add(this.pkgAgencyCommissionTextBox);
            this.PackageTab.Controls.Add(this.pkgEndDateDateTimePicker);
            this.PackageTab.Controls.Add(pkgBasePriceLabel);
            this.PackageTab.Controls.Add(this.pkgBasePriceTextBox);
            this.PackageTab.Controls.Add(this.pkgStartDateDateTimePicker);
            this.PackageTab.Controls.Add(pkgStartDateLabel);
            this.PackageTab.Location = new System.Drawing.Point(4, 29);
            this.PackageTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PackageTab.Name = "PackageTab";
            this.PackageTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PackageTab.Size = new System.Drawing.Size(1417, 824);
            this.PackageTab.TabIndex = 0;
            this.PackageTab.Text = "Packages";
            this.PackageTab.UseVisualStyleBackColor = true;
            // 
            // SuppliersTab
            // 
            this.SuppliersTab.Controls.Add(this.suppliersDataGridView);
            this.SuppliersTab.Controls.Add(supNameLabel);
            this.SuppliersTab.Controls.Add(this.supNameTextBox);
            this.SuppliersTab.Controls.Add(supplierIdLabel);
            this.SuppliersTab.Controls.Add(this.supplierIdTextBox);
            this.SuppliersTab.Location = new System.Drawing.Point(4, 29);
            this.SuppliersTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SuppliersTab.Name = "SuppliersTab";
            this.SuppliersTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SuppliersTab.Size = new System.Drawing.Size(1417, 824);
            this.SuppliersTab.TabIndex = 2;
            this.SuppliersTab.Text = "Suppliers";
            this.SuppliersTab.UseVisualStyleBackColor = true;
            // 
            // prodNameLabel
            // 
            prodNameLabel.AutoSize = true;
            prodNameLabel.Location = new System.Drawing.Point(46, 70);
            prodNameLabel.Name = "prodNameLabel";
            prodNameLabel.Size = new System.Drawing.Size(92, 20);
            prodNameLabel.TabIndex = 0;
            prodNameLabel.Text = "Prod Name:";
            // 
            // prodNameTextBox
            // 
            this.prodNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProdName", true));
            this.prodNameTextBox.Location = new System.Drawing.Point(144, 70);
            this.prodNameTextBox.Name = "prodNameTextBox";
            this.prodNameTextBox.Size = new System.Drawing.Size(100, 26);
            this.prodNameTextBox.TabIndex = 1;
            // 
            // productIdLabel
            // 
            productIdLabel.AutoSize = true;
            productIdLabel.Location = new System.Drawing.Point(46, 18);
            productIdLabel.Name = "productIdLabel";
            productIdLabel.Size = new System.Drawing.Size(86, 20);
            productIdLabel.TabIndex = 2;
            productIdLabel.Text = "Product Id:";
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductId", true));
            this.productIdTextBox.Location = new System.Drawing.Point(144, 15);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.Size = new System.Drawing.Size(100, 26);
            this.productIdTextBox.TabIndex = 3;
            // 
            // supNameLabel
            // 
            supNameLabel.AutoSize = true;
            supNameLabel.Location = new System.Drawing.Point(115, 79);
            supNameLabel.Name = "supNameLabel";
            supNameLabel.Size = new System.Drawing.Size(88, 20);
            supNameLabel.TabIndex = 0;
            supNameLabel.Text = "Sup Name:";
            // 
            // supNameTextBox
            // 
            this.supNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "SupName", true));
            this.supNameTextBox.Location = new System.Drawing.Point(210, 76);
            this.supNameTextBox.Name = "supNameTextBox";
            this.supNameTextBox.Size = new System.Drawing.Size(100, 26);
            this.supNameTextBox.TabIndex = 1;
            // 
            // supplierIdLabel
            // 
            supplierIdLabel.AutoSize = true;
            supplierIdLabel.Location = new System.Drawing.Point(115, 36);
            supplierIdLabel.Name = "supplierIdLabel";
            supplierIdLabel.Size = new System.Drawing.Size(89, 20);
            supplierIdLabel.TabIndex = 2;
            supplierIdLabel.Text = "Supplier Id:";
            // 
            // supplierIdTextBox
            // 
            this.supplierIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "SupplierId", true));
            this.supplierIdTextBox.Location = new System.Drawing.Point(210, 36);
            this.supplierIdTextBox.Name = "supplierIdTextBox";
            this.supplierIdTextBox.Size = new System.Drawing.Size(100, 26);
            this.supplierIdTextBox.TabIndex = 3;
            // 
            // suppliersDataGridView
            // 
            this.suppliersDataGridView.AutoGenerateColumns = false;
            this.suppliersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.suppliersDataGridView.DataSource = this.suppliersBindingSource;
            this.suppliersDataGridView.Location = new System.Drawing.Point(626, 8);
            this.suppliersDataGridView.Name = "suppliersDataGridView";
            this.suppliersDataGridView.RowTemplate.Height = 28;
            this.suppliersDataGridView.Size = new System.Drawing.Size(251, 499);
            this.suppliersDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SupplierId";
            this.dataGridViewTextBoxColumn1.HeaderText = "SupplierId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SupName";
            this.dataGridViewTextBoxColumn2.HeaderText = "SupName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AutoGenerateColumns = false;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.productsDataGridView.DataSource = this.productsBindingSource;
            this.productsDataGridView.Location = new System.Drawing.Point(410, 8);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.RowTemplate.Height = 28;
            this.productsDataGridView.Size = new System.Drawing.Size(248, 485);
            this.productsDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ProductId";
            this.dataGridViewTextBoxColumn3.HeaderText = "ProductId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ProdName";
            this.dataGridViewTextBoxColumn4.HeaderText = "ProdName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 857);
            this.Controls.Add(this.MainTabControl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProSupDataGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacProSupBindingSource)).EndInit();
            this.MainTabControl.ResumeLayout(false);
            this.ProductTab.ResumeLayout(false);
            this.ProductTab.PerformLayout();
            this.PackageTab.ResumeLayout(false);
            this.PackageTab.PerformLayout();
            this.SuppliersTab.ResumeLayout(false);
            this.SuppliersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource packagesBindingSource;
        private System.Windows.Forms.ComboBox packageIdComboBox;
        private System.Windows.Forms.TextBox pkgAgencyCommissionTextBox;
        private System.Windows.Forms.TextBox pkgBasePriceTextBox;
        private System.Windows.Forms.RichTextBox pkgDescRichTextBox;
        private System.Windows.Forms.DateTimePicker pkgEndDateDateTimePicker;
        private System.Windows.Forms.TextBox pkgNameTextBox;
        private System.Windows.Forms.DateTimePicker pkgStartDateDateTimePicker;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private System.Windows.Forms.DataGridView ProSupDataGridview;
        private System.Windows.Forms.BindingSource PacProSupBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProdNameCB;
        private System.Windows.Forms.DataGridViewComboBoxColumn SupNameCB;
        private System.Windows.Forms.Button pacEditBtn;
        private System.Windows.Forms.Button EnableEditProSup;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage ProductTab;
        private System.Windows.Forms.TabPage PackageTab;
        private System.Windows.Forms.TabPage SuppliersTab;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox prodNameTextBox;
        private System.Windows.Forms.TextBox productIdTextBox;
        private System.Windows.Forms.DataGridView suppliersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox supNameTextBox;
        private System.Windows.Forms.TextBox supplierIdTextBox;
    }
}

