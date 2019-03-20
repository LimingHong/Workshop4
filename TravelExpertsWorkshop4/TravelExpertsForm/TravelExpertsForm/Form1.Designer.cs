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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.EnableEditProSup = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.SuspendLayout();
            // 
            // packageIdLabel
            // 
            packageIdLabel.AutoSize = true;
            packageIdLabel.Location = new System.Drawing.Point(76, 25);
            packageIdLabel.Name = "packageIdLabel";
            packageIdLabel.Size = new System.Drawing.Size(65, 13);
            packageIdLabel.TabIndex = 18;
            packageIdLabel.Text = "Package Id:";
            // 
            // pkgAgencyCommissionLabel
            // 
            pkgAgencyCommissionLabel.AutoSize = true;
            pkgAgencyCommissionLabel.Location = new System.Drawing.Point(34, 334);
            pkgAgencyCommissionLabel.Name = "pkgAgencyCommissionLabel";
            pkgAgencyCommissionLabel.Size = new System.Drawing.Size(126, 13);
            pkgAgencyCommissionLabel.TabIndex = 20;
            pkgAgencyCommissionLabel.Text = "Pkg Agency Commission:";
            // 
            // pkgBasePriceLabel
            // 
            pkgBasePriceLabel.AutoSize = true;
            pkgBasePriceLabel.Location = new System.Drawing.Point(50, 402);
            pkgBasePriceLabel.Name = "pkgBasePriceLabel";
            pkgBasePriceLabel.Size = new System.Drawing.Size(83, 13);
            pkgBasePriceLabel.TabIndex = 22;
            pkgBasePriceLabel.Text = "Pkg Base Price:";
            // 
            // pkgDescLabel
            // 
            pkgDescLabel.AutoSize = true;
            pkgDescLabel.Location = new System.Drawing.Point(76, 122);
            pkgDescLabel.Name = "pkgDescLabel";
            pkgDescLabel.Size = new System.Drawing.Size(57, 13);
            pkgDescLabel.TabIndex = 24;
            pkgDescLabel.Text = "Pkg Desc:";
            // 
            // pkgEndDateLabel
            // 
            pkgEndDateLabel.AutoSize = true;
            pkgEndDateLabel.Location = new System.Drawing.Point(56, 240);
            pkgEndDateLabel.Name = "pkgEndDateLabel";
            pkgEndDateLabel.Size = new System.Drawing.Size(77, 13);
            pkgEndDateLabel.TabIndex = 26;
            pkgEndDateLabel.Text = "Pkg End Date:";
            // 
            // pkgNameLabel
            // 
            pkgNameLabel.AutoSize = true;
            pkgNameLabel.Location = new System.Drawing.Point(76, 67);
            pkgNameLabel.Name = "pkgNameLabel";
            pkgNameLabel.Size = new System.Drawing.Size(60, 13);
            pkgNameLabel.TabIndex = 28;
            pkgNameLabel.Text = "Pkg Name:";
            // 
            // pkgStartDateLabel
            // 
            pkgStartDateLabel.AutoSize = true;
            pkgStartDateLabel.Location = new System.Drawing.Point(56, 291);
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
            this.packageIdComboBox.Location = new System.Drawing.Point(166, 22);
            this.packageIdComboBox.Name = "packageIdComboBox";
            this.packageIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.packageIdComboBox.TabIndex = 19;
            this.packageIdComboBox.ValueMember = "PackageId";
            this.packageIdComboBox.SelectedIndexChanged += new System.EventHandler(this.packageIdComboBox_SelectedIndexChanged);
            // 
            // pkgAgencyCommissionTextBox
            // 
            this.pkgAgencyCommissionTextBox.Location = new System.Drawing.Point(166, 331);
            this.pkgAgencyCommissionTextBox.Name = "pkgAgencyCommissionTextBox";
            this.pkgAgencyCommissionTextBox.Size = new System.Drawing.Size(200, 20);
            this.pkgAgencyCommissionTextBox.TabIndex = 21;
            // 
            // pkgBasePriceTextBox
            // 
            this.pkgBasePriceTextBox.Location = new System.Drawing.Point(166, 399);
            this.pkgBasePriceTextBox.Name = "pkgBasePriceTextBox";
            this.pkgBasePriceTextBox.Size = new System.Drawing.Size(200, 20);
            this.pkgBasePriceTextBox.TabIndex = 23;
            // 
            // pkgDescRichTextBox
            // 
            this.pkgDescRichTextBox.Location = new System.Drawing.Point(166, 119);
            this.pkgDescRichTextBox.Name = "pkgDescRichTextBox";
            this.pkgDescRichTextBox.Size = new System.Drawing.Size(200, 96);
            this.pkgDescRichTextBox.TabIndex = 25;
            this.pkgDescRichTextBox.Text = "";
            // 
            // pkgEndDateDateTimePicker
            // 
            this.pkgEndDateDateTimePicker.Location = new System.Drawing.Point(166, 233);
            this.pkgEndDateDateTimePicker.Name = "pkgEndDateDateTimePicker";
            this.pkgEndDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.pkgEndDateDateTimePicker.TabIndex = 27;
            // 
            // pkgNameTextBox
            // 
            this.pkgNameTextBox.Location = new System.Drawing.Point(166, 64);
            this.pkgNameTextBox.Name = "pkgNameTextBox";
            this.pkgNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.pkgNameTextBox.TabIndex = 29;
            // 
            // pkgStartDateDateTimePicker
            // 
            this.pkgStartDateDateTimePicker.Location = new System.Drawing.Point(166, 284);
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
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProSupDataGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.ProSupDataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProSupDataGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdNameCB,
            this.SupNameCB});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProSupDataGridview.DefaultCellStyle = dataGridViewCellStyle20;
            this.ProSupDataGridview.Enabled = false;
            this.ProSupDataGridview.Location = new System.Drawing.Point(426, 0);
            this.ProSupDataGridview.Name = "ProSupDataGridview";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProSupDataGridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.ProSupDataGridview.Size = new System.Drawing.Size(485, 455);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 479);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // EnableEditProSup
            // 
            this.EnableEditProSup.Location = new System.Drawing.Point(609, 432);
            this.EnableEditProSup.Name = "EnableEditProSup";
            this.EnableEditProSup.Size = new System.Drawing.Size(126, 23);
            this.EnableEditProSup.TabIndex = 35;
            this.EnableEditProSup.Text = "Enable Editing";
            this.EnableEditProSup.UseVisualStyleBackColor = true;
            this.EnableEditProSup.Click += new System.EventHandler(this.EnableEditProSup_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(291, 479);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 36;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 524);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.EnableEditProSup);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProSupDataGridview);
            this.Controls.Add(packageIdLabel);
            this.Controls.Add(this.packageIdComboBox);
            this.Controls.Add(pkgAgencyCommissionLabel);
            this.Controls.Add(this.pkgAgencyCommissionTextBox);
            this.Controls.Add(pkgBasePriceLabel);
            this.Controls.Add(this.pkgBasePriceTextBox);
            this.Controls.Add(pkgDescLabel);
            this.Controls.Add(this.pkgDescRichTextBox);
            this.Controls.Add(pkgEndDateLabel);
            this.Controls.Add(this.pkgEndDateDateTimePicker);
            this.Controls.Add(pkgNameLabel);
            this.Controls.Add(this.pkgNameTextBox);
            this.Controls.Add(pkgStartDateLabel);
            this.Controls.Add(this.pkgStartDateDateTimePicker);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProSupDataGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacProSupBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button EnableEditProSup;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

