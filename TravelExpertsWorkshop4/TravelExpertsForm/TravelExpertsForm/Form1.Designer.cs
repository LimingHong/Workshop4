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
            System.Windows.Forms.Label lblnewid;
            System.Windows.Forms.Label label1;
            this.packagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PacProSupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.ProductTab = new System.Windows.Forms.TabPage();
            this.txtNewProductName = new System.Windows.Forms.TextBox();
            this.txtNewProductID = new System.Windows.Forms.TextBox();
            this.btnProEdit = new System.Windows.Forms.Button();
            this.btnProAdd = new System.Windows.Forms.Button();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNameTextBox = new System.Windows.Forms.TextBox();
            this.productIdComboBox = new System.Windows.Forms.ComboBox();
            this.PackageTab = new System.Windows.Forms.TabPage();
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
            lblnewid = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacProSupBindingSource)).BeginInit();
            this.MainTabControl.SuspendLayout();
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
            productIdLabel.Location = new System.Drawing.Point(48, 90);
            productIdLabel.Name = "productIdLabel";
            productIdLabel.Size = new System.Drawing.Size(86, 20);
            productIdLabel.TabIndex = 2;
            productIdLabel.Text = "Product Id:";
            // 
            // supNameLabel
            // 
            supNameLabel.AutoSize = true;
            supNameLabel.Location = new System.Drawing.Point(220, 113);
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
            // lblnewid
            // 
            lblnewid.AutoSize = true;
            lblnewid.Location = new System.Drawing.Point(48, 209);
            lblnewid.Name = "lblnewid";
            lblnewid.Size = new System.Drawing.Size(121, 20);
            lblnewid.TabIndex = 44;
            lblnewid.Text = "New Product Id:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(48, 261);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(149, 20);
            label1.TabIndex = 45;
            label1.Text = "New Product Name:";
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
            this.ProductTab.Controls.Add(label1);
            this.ProductTab.Controls.Add(lblnewid);
            this.ProductTab.Controls.Add(this.txtNewProductName);
            this.ProductTab.Controls.Add(this.txtNewProductID);
            this.ProductTab.Controls.Add(this.btnProEdit);
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
            this.ProductTab.Size = new System.Drawing.Size(1417, 824);
            this.ProductTab.TabIndex = 1;
            this.ProductTab.Text = "Products";
            this.ProductTab.UseVisualStyleBackColor = true;
            // 
            // txtNewProductName
            // 
            this.txtNewProductName.Location = new System.Drawing.Point(224, 258);
            this.txtNewProductName.Name = "txtNewProductName";
            this.txtNewProductName.Size = new System.Drawing.Size(100, 26);
            this.txtNewProductName.TabIndex = 43;
            // 
            // txtNewProductID
            // 
            this.txtNewProductID.Location = new System.Drawing.Point(224, 206);
            this.txtNewProductID.Name = "txtNewProductID";
            this.txtNewProductID.Size = new System.Drawing.Size(100, 26);
            this.txtNewProductID.TabIndex = 42;
            // 
            // btnProEdit
            // 
            this.btnProEdit.Location = new System.Drawing.Point(248, 451);
            this.btnProEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProEdit.Name = "btnProEdit";
            this.btnProEdit.Size = new System.Drawing.Size(112, 35);
            this.btnProEdit.TabIndex = 41;
            this.btnProEdit.Text = "Change";
            this.btnProEdit.UseVisualStyleBackColor = true;
            this.btnProEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnProAdd
            // 
            this.btnProAdd.Location = new System.Drawing.Point(100, 451);
            this.btnProAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProAdd.Name = "btnProAdd";
            this.btnProAdd.Size = new System.Drawing.Size(112, 35);
            this.btnProAdd.TabIndex = 40;
            this.btnProAdd.Text = "Add";
            this.btnProAdd.UseVisualStyleBackColor = true;
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
            this.productsDataGridView.Location = new System.Drawing.Point(468, 71);
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
            this.prodNameTextBox.Location = new System.Drawing.Point(203, 131);
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
            this.productIdComboBox.Location = new System.Drawing.Point(203, 87);
            this.productIdComboBox.Name = "productIdComboBox";
            this.productIdComboBox.Size = new System.Drawing.Size(121, 28);
            this.productIdComboBox.TabIndex = 3;
            this.productIdComboBox.ValueMember = "ProductId";
            this.productIdComboBox.SelectedIndexChanged += new System.EventHandler(this.productIdComboBox_SelectedIndexChanged_1);
            // 
            // PackageTab
            // 
            this.PackageTab.Location = new System.Drawing.Point(4, 29);
            this.PackageTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PackageTab.Name = "PackageTab";
            this.PackageTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PackageTab.Size = new System.Drawing.Size(1417, 824);
            this.PackageTab.TabIndex = 0;
            this.PackageTab.Text = "Packages";
            this.PackageTab.UseVisualStyleBackColor = true;
            this.PackageTab.Click += new System.EventHandler(this.tabPage1_Click);
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
            this.SuppliersTab.Size = new System.Drawing.Size(1417, 824);
            this.SuppliersTab.TabIndex = 2;
            this.SuppliersTab.Text = "Suppliers";
            this.SuppliersTab.UseVisualStyleBackColor = true;
            // 
            // supNameTextBox
            // 
            this.supNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "SupName", true));
            this.supNameTextBox.Location = new System.Drawing.Point(314, 107);
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
            this.suppliersDataGridView.Location = new System.Drawing.Point(637, 83);
            this.suppliersDataGridView.Name = "suppliersDataGridView";
            this.suppliersDataGridView.RowTemplate.Height = 28;
            this.suppliersDataGridView.Size = new System.Drawing.Size(448, 713);
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
            this.ClientSize = new System.Drawing.Size(1425, 857);
            this.Controls.Add(this.MainTabControl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacProSupBindingSource)).EndInit();
            this.MainTabControl.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnProEdit;
        private System.Windows.Forms.Button btnProAdd;
        private System.Windows.Forms.TextBox txtNewProductName;
        private System.Windows.Forms.TextBox txtNewProductID;
    }
}

