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
            System.Windows.Forms.Label packageIDLabel;
            System.Windows.Forms.Label pkgAgencyCommissionLabel;
            System.Windows.Forms.Label pkgBasePriceLabel;
            System.Windows.Forms.Label pkgDescriptionLabel;
            System.Windows.Forms.Label pkgEndDateLabel;
            System.Windows.Forms.Label pkgNameLabel;
            System.Windows.Forms.Label pkgStartDateLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.packageIDTextBox = new System.Windows.Forms.TextBox();
            this.pkgAgencyCommissionTextBox = new System.Windows.Forms.TextBox();
            this.pkgBasePriceTextBox = new System.Windows.Forms.TextBox();
            this.pkgDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.pkgEndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pkgNameTextBox = new System.Windows.Forms.TextBox();
            this.pkgStartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ProductsCB = new System.Windows.Forms.ComboBox();
            this.SuppliersCB = new System.Windows.Forms.ComboBox();
            this.ProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            packageIDLabel = new System.Windows.Forms.Label();
            pkgAgencyCommissionLabel = new System.Windows.Forms.Label();
            pkgBasePriceLabel = new System.Windows.Forms.Label();
            pkgDescriptionLabel = new System.Windows.Forms.Label();
            pkgEndDateLabel = new System.Windows.Forms.Label();
            pkgNameLabel = new System.Windows.Forms.Label();
            pkgStartDateLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // packageIDLabel
            // 
            packageIDLabel.AutoSize = true;
            packageIDLabel.Location = new System.Drawing.Point(28, 9);
            packageIDLabel.Name = "packageIDLabel";
            packageIDLabel.Size = new System.Drawing.Size(67, 13);
            packageIDLabel.TabIndex = 1;
            packageIDLabel.Text = "Package ID:";
            // 
            // pkgAgencyCommissionLabel
            // 
            pkgAgencyCommissionLabel.AutoSize = true;
            pkgAgencyCommissionLabel.Location = new System.Drawing.Point(28, 35);
            pkgAgencyCommissionLabel.Name = "pkgAgencyCommissionLabel";
            pkgAgencyCommissionLabel.Size = new System.Drawing.Size(126, 13);
            pkgAgencyCommissionLabel.TabIndex = 3;
            pkgAgencyCommissionLabel.Text = "Pkg Agency Commission:";
            // 
            // pkgBasePriceLabel
            // 
            pkgBasePriceLabel.AutoSize = true;
            pkgBasePriceLabel.Location = new System.Drawing.Point(28, 61);
            pkgBasePriceLabel.Name = "pkgBasePriceLabel";
            pkgBasePriceLabel.Size = new System.Drawing.Size(83, 13);
            pkgBasePriceLabel.TabIndex = 5;
            pkgBasePriceLabel.Text = "Pkg Base Price:";
            // 
            // pkgDescriptionLabel
            // 
            pkgDescriptionLabel.AutoSize = true;
            pkgDescriptionLabel.Location = new System.Drawing.Point(28, 87);
            pkgDescriptionLabel.Name = "pkgDescriptionLabel";
            pkgDescriptionLabel.Size = new System.Drawing.Size(85, 13);
            pkgDescriptionLabel.TabIndex = 7;
            pkgDescriptionLabel.Text = "Pkg Description:";
            // 
            // pkgEndDateLabel
            // 
            pkgEndDateLabel.AutoSize = true;
            pkgEndDateLabel.Location = new System.Drawing.Point(28, 114);
            pkgEndDateLabel.Name = "pkgEndDateLabel";
            pkgEndDateLabel.Size = new System.Drawing.Size(77, 13);
            pkgEndDateLabel.TabIndex = 9;
            pkgEndDateLabel.Text = "Pkg End Date:";
            // 
            // pkgNameLabel
            // 
            pkgNameLabel.AutoSize = true;
            pkgNameLabel.Location = new System.Drawing.Point(28, 139);
            pkgNameLabel.Name = "pkgNameLabel";
            pkgNameLabel.Size = new System.Drawing.Size(60, 13);
            pkgNameLabel.TabIndex = 11;
            pkgNameLabel.Text = "Pkg Name:";
            // 
            // pkgStartDateLabel
            // 
            pkgStartDateLabel.AutoSize = true;
            pkgStartDateLabel.Location = new System.Drawing.Point(28, 166);
            pkgStartDateLabel.Name = "pkgStartDateLabel";
            pkgStartDateLabel.Size = new System.Drawing.Size(80, 13);
            pkgStartDateLabel.TabIndex = 13;
            pkgStartDateLabel.Text = "Pkg Start Date:";
            // 
            // packageIDTextBox
            // 
            this.packageIDTextBox.Location = new System.Drawing.Point(165, 9);
            this.packageIDTextBox.Name = "packageIDTextBox";
            this.packageIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.packageIDTextBox.TabIndex = 2;
            // 
            // pkgAgencyCommissionTextBox
            // 
            this.pkgAgencyCommissionTextBox.Location = new System.Drawing.Point(165, 35);
            this.pkgAgencyCommissionTextBox.Name = "pkgAgencyCommissionTextBox";
            this.pkgAgencyCommissionTextBox.Size = new System.Drawing.Size(200, 20);
            this.pkgAgencyCommissionTextBox.TabIndex = 4;
            // 
            // pkgBasePriceTextBox
            // 
            this.pkgBasePriceTextBox.Location = new System.Drawing.Point(165, 61);
            this.pkgBasePriceTextBox.Name = "pkgBasePriceTextBox";
            this.pkgBasePriceTextBox.Size = new System.Drawing.Size(200, 20);
            this.pkgBasePriceTextBox.TabIndex = 6;
            // 
            // pkgDescriptionTextBox
            // 
            this.pkgDescriptionTextBox.Location = new System.Drawing.Point(165, 87);
            this.pkgDescriptionTextBox.Name = "pkgDescriptionTextBox";
            this.pkgDescriptionTextBox.Size = new System.Drawing.Size(200, 20);
            this.pkgDescriptionTextBox.TabIndex = 8;
            // 
            // pkgEndDateDateTimePicker
            // 
            this.pkgEndDateDateTimePicker.Location = new System.Drawing.Point(165, 113);
            this.pkgEndDateDateTimePicker.Name = "pkgEndDateDateTimePicker";
            this.pkgEndDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.pkgEndDateDateTimePicker.TabIndex = 10;
            // 
            // pkgNameTextBox
            // 
            this.pkgNameTextBox.Location = new System.Drawing.Point(165, 139);
            this.pkgNameTextBox.Name = "pkgNameTextBox";
            this.pkgNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.pkgNameTextBox.TabIndex = 12;
            // 
            // pkgStartDateDateTimePicker
            // 
            this.pkgStartDateDateTimePicker.Location = new System.Drawing.Point(165, 165);
            this.pkgStartDateDateTimePicker.Name = "pkgStartDateDateTimePicker";
            this.pkgStartDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.pkgStartDateDateTimePicker.TabIndex = 14;
            // 
            // ProductsCB
            // 
            this.ProductsCB.FormattingEnabled = true;
            this.ProductsCB.Location = new System.Drawing.Point(165, 214);
            this.ProductsCB.Name = "ProductsCB";
            this.ProductsCB.Size = new System.Drawing.Size(200, 21);
            this.ProductsCB.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(28, 214);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(122, 13);
            label1.TabIndex = 16;
            label1.Text = "Select Type of Product: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(28, 255);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(81, 13);
            label2.TabIndex = 18;
            label2.Text = "Select Supplier:";
            // 
            // SuppliersCB
            // 
            this.SuppliersCB.FormattingEnabled = true;
            this.SuppliersCB.Location = new System.Drawing.Point(165, 255);
            this.SuppliersCB.Name = "SuppliersCB";
            this.SuppliersCB.Size = new System.Drawing.Size(200, 21);
            this.SuppliersCB.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(label2);
            this.Controls.Add(this.SuppliersCB);
            this.Controls.Add(label1);
            this.Controls.Add(this.ProductsCB);
            this.Controls.Add(packageIDLabel);
            this.Controls.Add(this.packageIDTextBox);
            this.Controls.Add(pkgAgencyCommissionLabel);
            this.Controls.Add(this.pkgAgencyCommissionTextBox);
            this.Controls.Add(pkgBasePriceLabel);
            this.Controls.Add(this.pkgBasePriceTextBox);
            this.Controls.Add(pkgDescriptionLabel);
            this.Controls.Add(this.pkgDescriptionTextBox);
            this.Controls.Add(pkgEndDateLabel);
            this.Controls.Add(this.pkgEndDateDateTimePicker);
            this.Controls.Add(pkgNameLabel);
            this.Controls.Add(this.pkgNameTextBox);
            this.Controls.Add(pkgStartDateLabel);
            this.Controls.Add(this.pkgStartDateDateTimePicker);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox packageIDTextBox;
        private System.Windows.Forms.TextBox pkgAgencyCommissionTextBox;
        private System.Windows.Forms.TextBox pkgBasePriceTextBox;
        private System.Windows.Forms.TextBox pkgDescriptionTextBox;
        private System.Windows.Forms.DateTimePicker pkgEndDateDateTimePicker;
        private System.Windows.Forms.TextBox pkgNameTextBox;
        private System.Windows.Forms.DateTimePicker pkgStartDateDateTimePicker;
        private System.Windows.Forms.ComboBox ProductsCB;
        private System.Windows.Forms.ComboBox SuppliersCB;
        private System.Windows.Forms.BindingSource ProductsBindingSource;
    }
}

