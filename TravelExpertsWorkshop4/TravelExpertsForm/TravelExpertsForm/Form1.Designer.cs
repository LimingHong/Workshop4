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
            System.Windows.Forms.Label prodNameLabel;
            System.Windows.Forms.Label productIdLabel;
            System.Windows.Forms.Label supNameLabel;
            System.Windows.Forms.Label supplierIdLabel;
            System.Windows.Forms.Label packageIdLabel;
            System.Windows.Forms.Label pkgNameLabel;
            System.Windows.Forms.Label pkgDescLabel;
            System.Windows.Forms.Label pkgAgencyCommissionLabel;
            System.Windows.Forms.Label pkgEndDateLabel;
            System.Windows.Forms.Label pkgBasePriceLabel;
            System.Windows.Forms.Label pkgStartDateLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.packagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PacProSupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ProSupDataGridview = new System.Windows.Forms.DataGridView();
            this.ProdNameCB = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SupNameCB = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.PackageTab = new System.Windows.Forms.TabPage();
            this.AddPacIDTB = new System.Windows.Forms.TextBox();
            this.ActionLabelPac = new System.Windows.Forms.Label();
            this.CancelPacBtn = new System.Windows.Forms.Button();
            this.SavePacBtn = new System.Windows.Forms.Button();
            this.PacAddBtn = new System.Windows.Forms.Button();
            this.EnableEditProSup = new System.Windows.Forms.Button();
            this.packageIdComboBox = new System.Windows.Forms.ComboBox();
            this.pkgNameTextBox = new System.Windows.Forms.TextBox();
            this.pkgDescRichTextBox = new System.Windows.Forms.RichTextBox();
            this.EditPacBtn = new System.Windows.Forms.Button();
            this.pkgAgencyCommissionTextBox = new System.Windows.Forms.TextBox();
            this.pkgEndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pkgBasePriceTextBox = new System.Windows.Forms.TextBox();
            this.pkgStartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ProductTab = new System.Windows.Forms.TabPage();
            this.lblNewProName = new System.Windows.Forms.Label();
            this.btuProAddback = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNewProductName = new System.Windows.Forms.TextBox();
            this.btnProductChange = new System.Windows.Forms.Button();
            this.btnProAdd = new System.Windows.Forms.Button();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNameTextBox = new System.Windows.Forms.TextBox();
            this.productIdComboBox = new System.Windows.Forms.ComboBox();
            this.SuppliersTab = new System.Windows.Forms.TabPage();
            this.supNameTextBox = new System.Windows.Forms.TextBox();
            this.supplierIdComboBox = new System.Windows.Forms.ComboBox();
            this.suppliersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            prodNameLabel = new System.Windows.Forms.Label();
            productIdLabel = new System.Windows.Forms.Label();
            supNameLabel = new System.Windows.Forms.Label();
            supplierIdLabel = new System.Windows.Forms.Label();
            packageIdLabel = new System.Windows.Forms.Label();
            pkgNameLabel = new System.Windows.Forms.Label();
            pkgDescLabel = new System.Windows.Forms.Label();
            pkgAgencyCommissionLabel = new System.Windows.Forms.Label();
            pkgEndDateLabel = new System.Windows.Forms.Label();
            pkgBasePriceLabel = new System.Windows.Forms.Label();
            pkgStartDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacProSupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProSupDataGridview)).BeginInit();
            this.MainTabControl.SuspendLayout();
            this.PackageTab.SuspendLayout();
            this.ProductTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.SuppliersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // prodNameLabel
            // 
            prodNameLabel.AutoSize = true;
            prodNameLabel.Location = new System.Drawing.Point(48, 131);
            prodNameLabel.Name = "prodNameLabel";
            prodNameLabel.Size = new System.Drawing.Size(114, 20);
            prodNameLabel.TabIndex = 0;
            prodNameLabel.Text = "Product Name:";
            // 
            // productIdLabel
            // 
            productIdLabel.AutoSize = true;
            productIdLabel.Location = new System.Drawing.Point(48, 89);
            productIdLabel.Name = "productIdLabel";
            productIdLabel.Size = new System.Drawing.Size(86, 20);
            productIdLabel.TabIndex = 2;
            productIdLabel.Text = "Product Id:";
            // 
            // supNameLabel
            // 
            supNameLabel.AutoSize = true;
            supNameLabel.Location = new System.Drawing.Point(220, 112);
            supNameLabel.Name = "supNameLabel";
            supNameLabel.Size = new System.Drawing.Size(88, 20);
            supNameLabel.TabIndex = 1;
            supNameLabel.Text = "Sup Name:";
            // 
            // supplierIdLabel
            // 
            supplierIdLabel.AutoSize = true;
            supplierIdLabel.Location = new System.Drawing.Point(220, 148);
            supplierIdLabel.Name = "supplierIdLabel";
            supplierIdLabel.Size = new System.Drawing.Size(89, 20);
            supplierIdLabel.TabIndex = 3;
            supplierIdLabel.Text = "Supplier Id:";
            // 
            // packageIdLabel
            // 
            packageIdLabel.AutoSize = true;
            packageIdLabel.Location = new System.Drawing.Point(111, 37);
            packageIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            packageIdLabel.Name = "packageIdLabel";
            packageIdLabel.Size = new System.Drawing.Size(93, 20);
            packageIdLabel.TabIndex = 42;
            packageIdLabel.Text = "Package Id:";
            // 
            // pkgNameLabel
            // 
            pkgNameLabel.AutoSize = true;
            pkgNameLabel.Location = new System.Drawing.Point(111, 97);
            pkgNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgNameLabel.Name = "pkgNameLabel";
            pkgNameLabel.Size = new System.Drawing.Size(86, 20);
            pkgNameLabel.TabIndex = 52;
            pkgNameLabel.Text = "Pkg Name:";
            // 
            // pkgDescLabel
            // 
            pkgDescLabel.AutoSize = true;
            pkgDescLabel.Location = new System.Drawing.Point(116, 157);
            pkgDescLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgDescLabel.Name = "pkgDescLabel";
            pkgDescLabel.Size = new System.Drawing.Size(81, 20);
            pkgDescLabel.TabIndex = 48;
            pkgDescLabel.Text = "Pkg Desc:";
            // 
            // pkgAgencyCommissionLabel
            // 
            pkgAgencyCommissionLabel.AutoSize = true;
            pkgAgencyCommissionLabel.Location = new System.Drawing.Point(33, 534);
            pkgAgencyCommissionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgAgencyCommissionLabel.Name = "pkgAgencyCommissionLabel";
            pkgAgencyCommissionLabel.Size = new System.Drawing.Size(187, 20);
            pkgAgencyCommissionLabel.TabIndex = 44;
            pkgAgencyCommissionLabel.Text = "Pkg Agency Commission:";
            // 
            // pkgEndDateLabel
            // 
            pkgEndDateLabel.AutoSize = true;
            pkgEndDateLabel.Location = new System.Drawing.Point(81, 372);
            pkgEndDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgEndDateLabel.Name = "pkgEndDateLabel";
            pkgEndDateLabel.Size = new System.Drawing.Size(112, 20);
            pkgEndDateLabel.TabIndex = 50;
            pkgEndDateLabel.Text = "Pkg End Date:";
            // 
            // pkgBasePriceLabel
            // 
            pkgBasePriceLabel.AutoSize = true;
            pkgBasePriceLabel.Location = new System.Drawing.Point(98, 626);
            pkgBasePriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgBasePriceLabel.Name = "pkgBasePriceLabel";
            pkgBasePriceLabel.Size = new System.Drawing.Size(120, 20);
            pkgBasePriceLabel.TabIndex = 46;
            pkgBasePriceLabel.Text = "Pkg Base Price:";
            // 
            // pkgStartDateLabel
            // 
            pkgStartDateLabel.AutoSize = true;
            pkgStartDateLabel.Location = new System.Drawing.Point(81, 445);
            pkgStartDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgStartDateLabel.Name = "pkgStartDateLabel";
            pkgStartDateLabel.Size = new System.Drawing.Size(118, 20);
            pkgStartDateLabel.TabIndex = 54;
            pkgStartDateLabel.Text = "Pkg Start Date:";
            // 
            // packagesBindingSource
            // 
            this.packagesBindingSource.DataSource = typeof(TravelExpertsClassLib.Packages);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProSupDataGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ProSupDataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProSupDataGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdNameCB,
            this.SupNameCB});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProSupDataGridview.DefaultCellStyle = dataGridViewCellStyle5;
            this.ProSupDataGridview.Enabled = false;
            this.ProSupDataGridview.Location = new System.Drawing.Point(684, 25);
            this.ProSupDataGridview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProSupDataGridview.Name = "ProSupDataGridview";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProSupDataGridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ProSupDataGridview.Size = new System.Drawing.Size(728, 749);
            this.ProSupDataGridview.TabIndex = 56;
            this.toolTip1.SetToolTip(this.ProSupDataGridview, "Click Edit to modify");
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
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.PackageTab);
            this.MainTabControl.Controls.Add(this.ProductTab);
            this.MainTabControl.Controls.Add(this.SuppliersTab);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1426, 849);
            this.MainTabControl.TabIndex = 37;
            // 
            // PackageTab
            // 
            this.PackageTab.Controls.Add(this.AddPacIDTB);
            this.PackageTab.Controls.Add(this.ActionLabelPac);
            this.PackageTab.Controls.Add(this.CancelPacBtn);
            this.PackageTab.Controls.Add(this.SavePacBtn);
            this.PackageTab.Controls.Add(this.PacAddBtn);
            this.PackageTab.Controls.Add(this.EnableEditProSup);
            this.PackageTab.Controls.Add(packageIdLabel);
            this.PackageTab.Controls.Add(this.ProSupDataGridview);
            this.PackageTab.Controls.Add(this.packageIdComboBox);
            this.PackageTab.Controls.Add(pkgNameLabel);
            this.PackageTab.Controls.Add(pkgDescLabel);
            this.PackageTab.Controls.Add(this.pkgNameTextBox);
            this.PackageTab.Controls.Add(pkgAgencyCommissionLabel);
            this.PackageTab.Controls.Add(this.pkgDescRichTextBox);
            this.PackageTab.Controls.Add(this.EditPacBtn);
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
            this.PackageTab.Size = new System.Drawing.Size(1418, 816);
            this.PackageTab.TabIndex = 0;
            this.PackageTab.Text = "1.Packages";
            this.PackageTab.UseVisualStyleBackColor = true;
            this.PackageTab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // AddPacIDTB
            // 
            this.AddPacIDTB.Location = new System.Drawing.Point(246, 37);
            this.AddPacIDTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddPacIDTB.Name = "AddPacIDTB";
            this.AddPacIDTB.ReadOnly = true;
            this.AddPacIDTB.Size = new System.Drawing.Size(298, 26);
            this.AddPacIDTB.TabIndex = 63;
            this.AddPacIDTB.Visible = false;
            // 
            // ActionLabelPac
            // 
            this.ActionLabelPac.AutoSize = true;
            this.ActionLabelPac.ForeColor = System.Drawing.Color.SeaGreen;
            this.ActionLabelPac.Location = new System.Drawing.Point(15, 25);
            this.ActionLabelPac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ActionLabelPac.Name = "ActionLabelPac";
            this.ActionLabelPac.Size = new System.Drawing.Size(64, 20);
            this.ActionLabelPac.TabIndex = 62;
            this.ActionLabelPac.Text = "Viewing";
            // 
            // CancelPacBtn
            // 
            this.CancelPacBtn.Location = new System.Drawing.Point(448, 718);
            this.CancelPacBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelPacBtn.Name = "CancelPacBtn";
            this.CancelPacBtn.Size = new System.Drawing.Size(112, 35);
            this.CancelPacBtn.TabIndex = 61;
            this.CancelPacBtn.Text = "Cancel";
            this.CancelPacBtn.UseVisualStyleBackColor = true;
            this.CancelPacBtn.Visible = false;
            this.CancelPacBtn.Click += new System.EventHandler(this.CancelPacBtn_Click);
            // 
            // SavePacBtn
            // 
            this.SavePacBtn.Location = new System.Drawing.Point(110, 718);
            this.SavePacBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SavePacBtn.Name = "SavePacBtn";
            this.SavePacBtn.Size = new System.Drawing.Size(112, 35);
            this.SavePacBtn.TabIndex = 60;
            this.SavePacBtn.Text = "Save";
            this.SavePacBtn.UseVisualStyleBackColor = true;
            this.SavePacBtn.Visible = false;
            this.SavePacBtn.Click += new System.EventHandler(this.SavePacBtn_Click);
            // 
            // PacAddBtn
            // 
            this.PacAddBtn.Location = new System.Drawing.Point(136, 738);
            this.PacAddBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PacAddBtn.Name = "PacAddBtn";
            this.PacAddBtn.Size = new System.Drawing.Size(112, 35);
            this.PacAddBtn.TabIndex = 59;
            this.PacAddBtn.Text = "Add";
            this.PacAddBtn.UseVisualStyleBackColor = true;
            this.PacAddBtn.Click += new System.EventHandler(this.PacAddBtn_Click);
            // 
            // EnableEditProSup
            // 
            this.EnableEditProSup.Location = new System.Drawing.Point(963, 738);
            this.EnableEditProSup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EnableEditProSup.Name = "EnableEditProSup";
            this.EnableEditProSup.Size = new System.Drawing.Size(189, 35);
            this.EnableEditProSup.TabIndex = 58;
            this.EnableEditProSup.Text = "Enable Editing";
            this.EnableEditProSup.UseVisualStyleBackColor = true;
            this.EnableEditProSup.Click += new System.EventHandler(this.EnableEditProSup_Click);
            // 
            // packageIdComboBox
            // 
            this.packageIdComboBox.DataSource = this.packagesBindingSource;
            this.packageIdComboBox.DisplayMember = "PackageId";
            this.packageIdComboBox.FormattingEnabled = true;
            this.packageIdComboBox.Location = new System.Drawing.Point(246, 25);
            this.packageIdComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.packageIdComboBox.Name = "packageIdComboBox";
            this.packageIdComboBox.Size = new System.Drawing.Size(298, 28);
            this.packageIdComboBox.TabIndex = 43;
            this.packageIdComboBox.ValueMember = "PackageId";
            this.packageIdComboBox.SelectedIndexChanged += new System.EventHandler(this.packageIdComboBox_SelectedIndexChanged);
            // 
            // pkgNameTextBox
            // 
            this.pkgNameTextBox.Location = new System.Drawing.Point(243, 94);
            this.pkgNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pkgNameTextBox.Name = "pkgNameTextBox";
            this.pkgNameTextBox.ReadOnly = true;
            this.pkgNameTextBox.Size = new System.Drawing.Size(298, 26);
            this.pkgNameTextBox.TabIndex = 53;
            // 
            // pkgDescRichTextBox
            // 
            this.pkgDescRichTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pkgDescRichTextBox.Location = new System.Drawing.Point(102, 182);
            this.pkgDescRichTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pkgDescRichTextBox.Name = "pkgDescRichTextBox";
            this.pkgDescRichTextBox.ReadOnly = true;
            this.pkgDescRichTextBox.Size = new System.Drawing.Size(442, 146);
            this.pkgDescRichTextBox.TabIndex = 49;
            this.pkgDescRichTextBox.Text = "";
            // 
            // EditPacBtn
            // 
            this.EditPacBtn.Location = new System.Drawing.Point(416, 738);
            this.EditPacBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditPacBtn.Name = "EditPacBtn";
            this.EditPacBtn.Size = new System.Drawing.Size(112, 35);
            this.EditPacBtn.TabIndex = 57;
            this.EditPacBtn.Text = "Edit";
            this.EditPacBtn.UseVisualStyleBackColor = true;
            this.EditPacBtn.Click += new System.EventHandler(this.EditPacBtn_Click);
            // 
            // pkgAgencyCommissionTextBox
            // 
            this.pkgAgencyCommissionTextBox.Location = new System.Drawing.Point(246, 529);
            this.pkgAgencyCommissionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pkgAgencyCommissionTextBox.Name = "pkgAgencyCommissionTextBox";
            this.pkgAgencyCommissionTextBox.ReadOnly = true;
            this.pkgAgencyCommissionTextBox.Size = new System.Drawing.Size(298, 26);
            this.pkgAgencyCommissionTextBox.TabIndex = 45;
            // 
            // pkgEndDateDateTimePicker
            // 
            this.pkgEndDateDateTimePicker.Enabled = false;
            this.pkgEndDateDateTimePicker.Location = new System.Drawing.Point(246, 363);
            this.pkgEndDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pkgEndDateDateTimePicker.Name = "pkgEndDateDateTimePicker";
            this.pkgEndDateDateTimePicker.Size = new System.Drawing.Size(298, 26);
            this.pkgEndDateDateTimePicker.TabIndex = 51;
            // 
            // pkgBasePriceTextBox
            // 
            this.pkgBasePriceTextBox.Location = new System.Drawing.Point(246, 622);
            this.pkgBasePriceTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pkgBasePriceTextBox.Name = "pkgBasePriceTextBox";
            this.pkgBasePriceTextBox.ReadOnly = true;
            this.pkgBasePriceTextBox.Size = new System.Drawing.Size(298, 26);
            this.pkgBasePriceTextBox.TabIndex = 47;
            // 
            // pkgStartDateDateTimePicker
            // 
            this.pkgStartDateDateTimePicker.Enabled = false;
            this.pkgStartDateDateTimePicker.Location = new System.Drawing.Point(246, 435);
            this.pkgStartDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pkgStartDateDateTimePicker.Name = "pkgStartDateDateTimePicker";
            this.pkgStartDateDateTimePicker.Size = new System.Drawing.Size(298, 26);
            this.pkgStartDateDateTimePicker.TabIndex = 55;
            // 
            // ProductTab
            // 
            this.ProductTab.Controls.Add(this.lblNewProName);
            this.ProductTab.Controls.Add(this.btuProAddback);
            this.ProductTab.Controls.Add(this.button1);
            this.ProductTab.Controls.Add(this.txtNewProductName);
            this.ProductTab.Controls.Add(this.btnProductChange);
            this.ProductTab.Controls.Add(this.btnProAdd);
            this.ProductTab.Controls.Add(this.productsDataGridView);
            this.ProductTab.Controls.Add(prodNameLabel);
            this.ProductTab.Controls.Add(this.prodNameTextBox);
            this.ProductTab.Controls.Add(productIdLabel);
            this.ProductTab.Controls.Add(this.productIdComboBox);
            this.ProductTab.Location = new System.Drawing.Point(4, 29);
            this.ProductTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductTab.Name = "ProductTab";
            this.ProductTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProductTab.Size = new System.Drawing.Size(1418, 816);
            this.ProductTab.TabIndex = 1;
            this.ProductTab.Text = "2.Products";
            this.ProductTab.UseVisualStyleBackColor = true;
            // 
            // lblNewProName
            // 
            this.lblNewProName.AutoSize = true;
            this.lblNewProName.Location = new System.Drawing.Point(52, 258);
            this.lblNewProName.Name = "lblNewProName";
            this.lblNewProName.Size = new System.Drawing.Size(149, 20);
            this.lblNewProName.TabIndex = 48;
            this.lblNewProName.Text = "New Product Name:";
            this.lblNewProName.Visible = false;
            // 
            // btuProAddback
            // 
            this.btuProAddback.Location = new System.Drawing.Point(479, 249);
            this.btuProAddback.Name = "btuProAddback";
            this.btuProAddback.Size = new System.Drawing.Size(112, 35);
            this.btuProAddback.TabIndex = 47;
            this.btuProAddback.Text = "Back";
            this.btuProAddback.UseVisualStyleBackColor = true;
            this.btuProAddback.Visible = false;
            this.btuProAddback.Click += new System.EventHandler(this.backPro);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 48);
            this.button1.TabIndex = 46;
            this.button1.Text = "Add a new Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddNewProduct);
            // 
            // txtNewProductName
            // 
            this.txtNewProductName.Location = new System.Drawing.Point(224, 258);
            this.txtNewProductName.Name = "txtNewProductName";
            this.txtNewProductName.Size = new System.Drawing.Size(100, 26);
            this.txtNewProductName.TabIndex = 43;
            this.txtNewProductName.Tag = "Product Name";
            this.txtNewProductName.Visible = false;
            // 
            // btnProductChange
            // 
            this.btnProductChange.Location = new System.Drawing.Point(349, 127);
            this.btnProductChange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProductChange.Name = "btnProductChange";
            this.btnProductChange.Size = new System.Drawing.Size(152, 46);
            this.btnProductChange.TabIndex = 41;
            this.btnProductChange.Text = "Change";
            this.btnProductChange.UseVisualStyleBackColor = true;
            this.btnProductChange.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnProAdd
            // 
            this.btnProAdd.Location = new System.Drawing.Point(345, 251);
            this.btnProAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProAdd.Name = "btnProAdd";
            this.btnProAdd.Size = new System.Drawing.Size(112, 35);
            this.btnProAdd.TabIndex = 40;
            this.btnProAdd.Text = "Add";
            this.btnProAdd.UseVisualStyleBackColor = true;
            this.btnProAdd.Visible = false;
            this.btnProAdd.Click += new System.EventHandler(this.btnProAdd_Click);
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AutoGenerateColumns = false;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.productsDataGridView.DataSource = this.productsBindingSource;
            this.productsDataGridView.Location = new System.Drawing.Point(670, 71);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.RowTemplate.Height = 28;
            this.productsDataGridView.Size = new System.Drawing.Size(423, 788);
            this.productsDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductId";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProductId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProdName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProdName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // prodNameTextBox
            // 
            this.prodNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProdName", true));
            this.prodNameTextBox.Location = new System.Drawing.Point(202, 131);
            this.prodNameTextBox.Name = "prodNameTextBox";
            this.prodNameTextBox.Size = new System.Drawing.Size(121, 26);
            this.prodNameTextBox.TabIndex = 1;
            // 
            // productIdComboBox
            // 
            this.productIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductId", true));
            this.productIdComboBox.DataSource = this.productsBindingSource;
            this.productIdComboBox.DisplayMember = "ProductId";
            this.productIdComboBox.FormattingEnabled = true;
            this.productIdComboBox.Location = new System.Drawing.Point(202, 88);
            this.productIdComboBox.Name = "productIdComboBox";
            this.productIdComboBox.Size = new System.Drawing.Size(121, 28);
            this.productIdComboBox.TabIndex = 3;
            this.productIdComboBox.ValueMember = "ProductId";
            this.productIdComboBox.SelectedIndexChanged += new System.EventHandler(this.productIdComboBox_SelectedIndexChanged_1);
            // 
            // SuppliersTab
            // 
            this.SuppliersTab.Controls.Add(supNameLabel);
            this.SuppliersTab.Controls.Add(this.supNameTextBox);
            this.SuppliersTab.Controls.Add(supplierIdLabel);
            this.SuppliersTab.Controls.Add(this.supplierIdComboBox);
            this.SuppliersTab.Controls.Add(this.suppliersDataGridView);
            this.SuppliersTab.Location = new System.Drawing.Point(4, 29);
            this.SuppliersTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SuppliersTab.Name = "SuppliersTab";
            this.SuppliersTab.Padding = new System.Windows.Forms.Padding(3);
            this.SuppliersTab.Size = new System.Drawing.Size(1418, 816);
            this.SuppliersTab.TabIndex = 2;
            this.SuppliersTab.Text = "3.Suppliers";
            this.SuppliersTab.UseVisualStyleBackColor = true;
            // 
            // supNameTextBox
            // 
            this.supNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "SupName", true));
            this.supNameTextBox.Location = new System.Drawing.Point(314, 108);
            this.supNameTextBox.Name = "supNameTextBox";
            this.supNameTextBox.Size = new System.Drawing.Size(121, 26);
            this.supNameTextBox.TabIndex = 2;
            // 
            // supplierIdComboBox
            // 
            this.supplierIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "SupplierId", true));
            this.supplierIdComboBox.DataSource = this.suppliersBindingSource;
            this.supplierIdComboBox.DisplayMember = "SupplierId";
            this.supplierIdComboBox.FormattingEnabled = true;
            this.supplierIdComboBox.Location = new System.Drawing.Point(315, 145);
            this.supplierIdComboBox.Name = "supplierIdComboBox";
            this.supplierIdComboBox.Size = new System.Drawing.Size(121, 28);
            this.supplierIdComboBox.TabIndex = 4;
            this.supplierIdComboBox.ValueMember = "SupplierId";
            this.supplierIdComboBox.SelectedIndexChanged += new System.EventHandler(this.supplierIdComboBox_SelectedIndexChanged);
            // 
            // suppliersDataGridView
            // 
            this.suppliersDataGridView.AutoGenerateColumns = false;
            this.suppliersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.suppliersDataGridView.DataSource = this.suppliersBindingSource;
            this.suppliersDataGridView.Location = new System.Drawing.Point(638, 83);
            this.suppliersDataGridView.Name = "suppliersDataGridView";
            this.suppliersDataGridView.RowTemplate.Height = 28;
            this.suppliersDataGridView.Size = new System.Drawing.Size(448, 712);
            this.suppliersDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SupplierId";
            this.dataGridViewTextBoxColumn3.HeaderText = "SupplierId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SupName";
            this.dataGridViewTextBoxColumn4.HeaderText = "SupName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 849);
            this.Controls.Add(this.MainTabControl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacProSupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProSupDataGridview)).EndInit();
            this.MainTabControl.ResumeLayout(false);
            this.PackageTab.ResumeLayout(false);
            this.PackageTab.PerformLayout();
            this.ProductTab.ResumeLayout(false);
            this.ProductTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.SuppliersTab.ResumeLayout(false);
            this.SuppliersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource packagesBindingSource;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private System.Windows.Forms.BindingSource PacProSupBindingSource;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage ProductTab;
        private System.Windows.Forms.TabPage PackageTab;
        private System.Windows.Forms.TabPage SuppliersTab;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox prodNameTextBox;
        private System.Windows.Forms.ComboBox productIdComboBox;
        private System.Windows.Forms.TextBox supNameTextBox;
        private System.Windows.Forms.ComboBox supplierIdComboBox;
        private System.Windows.Forms.DataGridView suppliersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnProductChange;
        private System.Windows.Forms.Button btnProAdd;
        private System.Windows.Forms.TextBox txtNewProductName;
        private System.Windows.Forms.TextBox AddPacIDTB;
        private System.Windows.Forms.Label ActionLabelPac;
        private System.Windows.Forms.Button CancelPacBtn;
        private System.Windows.Forms.Button SavePacBtn;
        private System.Windows.Forms.Button PacAddBtn;
        private System.Windows.Forms.Button EnableEditProSup;
        private System.Windows.Forms.DataGridView ProSupDataGridview;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProdNameCB;
        private System.Windows.Forms.DataGridViewComboBoxColumn SupNameCB;
        private System.Windows.Forms.ComboBox packageIdComboBox;
        private System.Windows.Forms.TextBox pkgNameTextBox;
        private System.Windows.Forms.RichTextBox pkgDescRichTextBox;
        private System.Windows.Forms.Button EditPacBtn;
        private System.Windows.Forms.TextBox pkgAgencyCommissionTextBox;
        private System.Windows.Forms.DateTimePicker pkgEndDateDateTimePicker;
        private System.Windows.Forms.TextBox pkgBasePriceTextBox;
        private System.Windows.Forms.DateTimePicker pkgStartDateDateTimePicker;
        private System.Windows.Forms.Button btuProAddback;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNewProName;
    }
}

