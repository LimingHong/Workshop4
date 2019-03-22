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
            this.EditPacBtn = new System.Windows.Forms.Button();
            this.EnableEditProSup = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.ProductTab = new System.Windows.Forms.TabPage();
            this.PackageTab = new System.Windows.Forms.TabPage();
            this.AddPacIDTB = new System.Windows.Forms.TextBox();
            this.ActionLabelPac = new System.Windows.Forms.Label();
            this.CancelPacBtn = new System.Windows.Forms.Button();
            this.SavePacBtn = new System.Windows.Forms.Button();
            this.PacAddBtn = new System.Windows.Forms.Button();
            this.SuppliersTab = new System.Windows.Forms.TabPage();
            packageIdLabel = new System.Windows.Forms.Label();
            pkgAgencyCommissionLabel = new System.Windows.Forms.Label();
            pkgBasePriceLabel = new System.Windows.Forms.Label();
            pkgDescLabel = new System.Windows.Forms.Label();
            pkgEndDateLabel = new System.Windows.Forms.Label();
            pkgNameLabel = new System.Windows.Forms.Label();
            pkgStartDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProSupDataGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacProSupBindingSource)).BeginInit();
            this.MainTabControl.SuspendLayout();
            this.PackageTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // packageIdLabel
            // 
            packageIdLabel.AutoSize = true;
            packageIdLabel.Location = new System.Drawing.Point(72, 27);
            packageIdLabel.Name = "packageIdLabel";
            packageIdLabel.Size = new System.Drawing.Size(65, 13);
            packageIdLabel.TabIndex = 18;
            packageIdLabel.Text = "Package Id:";
            // 
            // pkgAgencyCommissionLabel
            // 
            pkgAgencyCommissionLabel.AutoSize = true;
            pkgAgencyCommissionLabel.Location = new System.Drawing.Point(20, 350);
            pkgAgencyCommissionLabel.Name = "pkgAgencyCommissionLabel";
            pkgAgencyCommissionLabel.Size = new System.Drawing.Size(126, 13);
            pkgAgencyCommissionLabel.TabIndex = 20;
            pkgAgencyCommissionLabel.Text = "Pkg Agency Commission:";
            // 
            // pkgBasePriceLabel
            // 
            pkgBasePriceLabel.AutoSize = true;
            pkgBasePriceLabel.Location = new System.Drawing.Point(63, 410);
            pkgBasePriceLabel.Name = "pkgBasePriceLabel";
            pkgBasePriceLabel.Size = new System.Drawing.Size(83, 13);
            pkgBasePriceLabel.TabIndex = 22;
            pkgBasePriceLabel.Text = "Pkg Base Price:";
            // 
            // pkgDescLabel
            // 
            pkgDescLabel.AutoSize = true;
            pkgDescLabel.Location = new System.Drawing.Point(75, 105);
            pkgDescLabel.Name = "pkgDescLabel";
            pkgDescLabel.Size = new System.Drawing.Size(57, 13);
            pkgDescLabel.TabIndex = 24;
            pkgDescLabel.Text = "Pkg Desc:";
            // 
            // pkgEndDateLabel
            // 
            pkgEndDateLabel.AutoSize = true;
            pkgEndDateLabel.Location = new System.Drawing.Point(52, 245);
            pkgEndDateLabel.Name = "pkgEndDateLabel";
            pkgEndDateLabel.Size = new System.Drawing.Size(77, 13);
            pkgEndDateLabel.TabIndex = 26;
            pkgEndDateLabel.Text = "Pkg End Date:";
            // 
            // pkgNameLabel
            // 
            pkgNameLabel.AutoSize = true;
            pkgNameLabel.Location = new System.Drawing.Point(72, 66);
            pkgNameLabel.Name = "pkgNameLabel";
            pkgNameLabel.Size = new System.Drawing.Size(60, 13);
            pkgNameLabel.TabIndex = 28;
            pkgNameLabel.Text = "Pkg Name:";
            // 
            // pkgStartDateLabel
            // 
            pkgStartDateLabel.AutoSize = true;
            pkgStartDateLabel.Location = new System.Drawing.Point(52, 292);
            pkgStartDateLabel.Name = "pkgStartDateLabel";
            pkgStartDateLabel.Size = new System.Drawing.Size(80, 13);
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
            this.packageIdComboBox.Location = new System.Drawing.Point(162, 19);
            this.packageIdComboBox.Name = "packageIdComboBox";
            this.packageIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.packageIdComboBox.TabIndex = 19;
            this.packageIdComboBox.ValueMember = "PackageId";
            this.packageIdComboBox.SelectedIndexChanged += new System.EventHandler(this.packageIdComboBox_SelectedIndexChanged);
            // 
            // pkgAgencyCommissionTextBox
            // 
            this.pkgAgencyCommissionTextBox.Location = new System.Drawing.Point(162, 347);
            this.pkgAgencyCommissionTextBox.Name = "pkgAgencyCommissionTextBox";
            this.pkgAgencyCommissionTextBox.ReadOnly = true;
            this.pkgAgencyCommissionTextBox.Size = new System.Drawing.Size(200, 20);
            this.pkgAgencyCommissionTextBox.TabIndex = 21;
            // 
            // pkgBasePriceTextBox
            // 
            this.pkgBasePriceTextBox.Location = new System.Drawing.Point(162, 407);
            this.pkgBasePriceTextBox.Name = "pkgBasePriceTextBox";
            this.pkgBasePriceTextBox.ReadOnly = true;
            this.pkgBasePriceTextBox.Size = new System.Drawing.Size(200, 20);
            this.pkgBasePriceTextBox.TabIndex = 23;
            // 
            // pkgDescRichTextBox
            // 
            this.pkgDescRichTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pkgDescRichTextBox.Location = new System.Drawing.Point(66, 121);
            this.pkgDescRichTextBox.Name = "pkgDescRichTextBox";
            this.pkgDescRichTextBox.ReadOnly = true;
            this.pkgDescRichTextBox.Size = new System.Drawing.Size(296, 96);
            this.pkgDescRichTextBox.TabIndex = 25;
            this.pkgDescRichTextBox.Text = "";
            // 
            // pkgEndDateDateTimePicker
            // 
            this.pkgEndDateDateTimePicker.Enabled = false;
            this.pkgEndDateDateTimePicker.Location = new System.Drawing.Point(162, 239);
            this.pkgEndDateDateTimePicker.Name = "pkgEndDateDateTimePicker";
            this.pkgEndDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.pkgEndDateDateTimePicker.TabIndex = 27;
            // 
            // pkgNameTextBox
            // 
            this.pkgNameTextBox.Location = new System.Drawing.Point(162, 63);
            this.pkgNameTextBox.Name = "pkgNameTextBox";
            this.pkgNameTextBox.ReadOnly = true;
            this.pkgNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.pkgNameTextBox.TabIndex = 29;
            // 
            // pkgStartDateDateTimePicker
            // 
            this.pkgStartDateDateTimePicker.Enabled = false;
            this.pkgStartDateDateTimePicker.Location = new System.Drawing.Point(162, 286);
            this.pkgStartDateDateTimePicker.Name = "pkgStartDateDateTimePicker";
            this.pkgStartDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
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
            this.ProSupDataGridview.Location = new System.Drawing.Point(454, 19);
            this.ProSupDataGridview.Name = "ProSupDataGridview";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProSupDataGridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ProSupDataGridview.Size = new System.Drawing.Size(485, 487);
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
            // EditPacBtn
            // 
            this.EditPacBtn.Location = new System.Drawing.Point(275, 483);
            this.EditPacBtn.Name = "EditPacBtn";
            this.EditPacBtn.Size = new System.Drawing.Size(75, 23);
            this.EditPacBtn.TabIndex = 34;
            this.EditPacBtn.Text = "Edit";
            this.EditPacBtn.UseVisualStyleBackColor = true;
            this.EditPacBtn.Click += new System.EventHandler(this.EditPacBtn_Click);
            // 
            // EnableEditProSup
            // 
            this.EnableEditProSup.Location = new System.Drawing.Point(640, 483);
            this.EnableEditProSup.Name = "EnableEditProSup";
            this.EnableEditProSup.Size = new System.Drawing.Size(126, 23);
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
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(950, 557);
            this.MainTabControl.TabIndex = 37;
            // 
            // ProductTab
            // 
            this.ProductTab.Location = new System.Drawing.Point(4, 22);
            this.ProductTab.Name = "ProductTab";
            this.ProductTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProductTab.Size = new System.Drawing.Size(942, 531);
            this.ProductTab.TabIndex = 1;
            this.ProductTab.Text = "Products";
            this.ProductTab.UseVisualStyleBackColor = true;
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
            this.PackageTab.Location = new System.Drawing.Point(4, 22);
            this.PackageTab.Name = "PackageTab";
            this.PackageTab.Padding = new System.Windows.Forms.Padding(3);
            this.PackageTab.Size = new System.Drawing.Size(942, 531);
            this.PackageTab.TabIndex = 0;
            this.PackageTab.Text = "Packages";
            this.PackageTab.UseVisualStyleBackColor = true;
            this.PackageTab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // AddPacIDTB
            // 
            this.AddPacIDTB.Location = new System.Drawing.Point(162, 27);
            this.AddPacIDTB.Name = "AddPacIDTB";
            this.AddPacIDTB.ReadOnly = true;
            this.AddPacIDTB.Size = new System.Drawing.Size(200, 20);
            this.AddPacIDTB.TabIndex = 41;
            this.AddPacIDTB.Visible = false;
            // 
            // ActionLabelPac
            // 
            this.ActionLabelPac.AutoSize = true;
            this.ActionLabelPac.ForeColor = System.Drawing.Color.SeaGreen;
            this.ActionLabelPac.Location = new System.Drawing.Point(8, 19);
            this.ActionLabelPac.Name = "ActionLabelPac";
            this.ActionLabelPac.Size = new System.Drawing.Size(44, 13);
            this.ActionLabelPac.TabIndex = 40;
            this.ActionLabelPac.Text = "Viewing";
            // 
            // CancelPacBtn
            // 
            this.CancelPacBtn.Location = new System.Drawing.Point(297, 470);
            this.CancelPacBtn.Name = "CancelPacBtn";
            this.CancelPacBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelPacBtn.TabIndex = 38;
            this.CancelPacBtn.Text = "Cancel";
            this.CancelPacBtn.UseVisualStyleBackColor = true;
            this.CancelPacBtn.Visible = false;
            this.CancelPacBtn.Click += new System.EventHandler(this.CancelPacBtn_Click);
            // 
            // SavePacBtn
            // 
            this.SavePacBtn.Location = new System.Drawing.Point(71, 470);
            this.SavePacBtn.Name = "SavePacBtn";
            this.SavePacBtn.Size = new System.Drawing.Size(75, 23);
            this.SavePacBtn.TabIndex = 37;
            this.SavePacBtn.Text = "Save";
            this.SavePacBtn.UseVisualStyleBackColor = true;
            this.SavePacBtn.Visible = false;
            // 
            // PacAddBtn
            // 
            this.PacAddBtn.Location = new System.Drawing.Point(89, 483);
            this.PacAddBtn.Name = "PacAddBtn";
            this.PacAddBtn.Size = new System.Drawing.Size(75, 23);
            this.PacAddBtn.TabIndex = 36;
            this.PacAddBtn.Text = "Add";
            this.PacAddBtn.UseVisualStyleBackColor = true;
            this.PacAddBtn.Click += new System.EventHandler(this.PacAddBtn_Click);
            // 
            // SuppliersTab
            // 
            this.SuppliersTab.Location = new System.Drawing.Point(4, 22);
            this.SuppliersTab.Name = "SuppliersTab";
            this.SuppliersTab.Padding = new System.Windows.Forms.Padding(3);
            this.SuppliersTab.Size = new System.Drawing.Size(942, 531);
            this.SuppliersTab.TabIndex = 2;
            this.SuppliersTab.Text = "Suppliers";
            this.SuppliersTab.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 557);
            this.Controls.Add(this.MainTabControl);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProSupDataGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacProSupBindingSource)).EndInit();
            this.MainTabControl.ResumeLayout(false);
            this.PackageTab.ResumeLayout(false);
            this.PackageTab.PerformLayout();
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
        private System.Windows.Forms.Button EditPacBtn;
        private System.Windows.Forms.Button EnableEditProSup;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage ProductTab;
        private System.Windows.Forms.TabPage PackageTab;
        private System.Windows.Forms.TabPage SuppliersTab;
        private System.Windows.Forms.Button PacAddBtn;
        private System.Windows.Forms.Button CancelPacBtn;
        private System.Windows.Forms.Button SavePacBtn;
        private System.Windows.Forms.Label ActionLabelPac;
        private System.Windows.Forms.TextBox AddPacIDTB;
    }
}

