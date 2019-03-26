namespace DesktopAppTravelExperts.Forms
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.uxUserRoleLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.uxTimeDisplay = new System.Windows.Forms.Label();
            this.uxUserNameLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uxDateDisplay = new System.Windows.Forms.Label();
            this.uxBtnScreenSize = new System.Windows.Forms.Button();
            this.uxClosingBtn = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.uxBtnIndicatorPac = new System.Windows.Forms.Panel();
            this.uxBtnSettings = new System.Windows.Forms.Button();
            this.uxBtnSales = new System.Windows.Forms.Button();
            this.uxBtnCustomer = new System.Windows.Forms.Button();
            this.uxBtnSupplier = new System.Windows.Forms.Button();
            this.uxBtnProduct = new System.Windows.Forms.Button();
            this.uxBtnPackages = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.uxBtnIndicatorSet = new System.Windows.Forms.Panel();
            this.uxBtnIndicatorSal = new System.Windows.Forms.Panel();
            this.uxBtnIndicatorCus = new System.Windows.Forms.Panel();
            this.uxBtnIndicatorPro = new System.Windows.Forms.Panel();
            this.uxBtnIndicatorSup = new System.Windows.Forms.Panel();
            this.uxUserProfilePic = new DesktopAppTravelExperts.CircularPicturebox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxUserProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // uxUserRoleLabel
            // 
            this.uxUserRoleLabel.AutoSize = true;
            this.uxUserRoleLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxUserRoleLabel.ForeColor = System.Drawing.Color.White;
            this.uxUserRoleLabel.Location = new System.Drawing.Point(261, 48);
            this.uxUserRoleLabel.Name = "uxUserRoleLabel";
            this.uxUserRoleLabel.Size = new System.Drawing.Size(63, 16);
            this.uxUserRoleLabel.TabIndex = 0;
            this.uxUserRoleLabel.Text = "UserRole";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(209, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Role :";
            // 
            // uxTimeDisplay
            // 
            this.uxTimeDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxTimeDisplay.AutoSize = true;
            this.uxTimeDisplay.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTimeDisplay.ForeColor = System.Drawing.Color.White;
            this.uxTimeDisplay.Location = new System.Drawing.Point(621, 49);
            this.uxTimeDisplay.Name = "uxTimeDisplay";
            this.uxTimeDisplay.Size = new System.Drawing.Size(72, 16);
            this.uxTimeDisplay.TabIndex = 0;
            this.uxTimeDisplay.Text = "HH:MM:SS";
            // 
            // uxUserNameLabel
            // 
            this.uxUserNameLabel.AutoSize = true;
            this.uxUserNameLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxUserNameLabel.ForeColor = System.Drawing.Color.White;
            this.uxUserNameLabel.Location = new System.Drawing.Point(174, 25);
            this.uxUserNameLabel.Name = "uxUserNameLabel";
            this.uxUserNameLabel.Size = new System.Drawing.Size(138, 23);
            this.uxUserNameLabel.TabIndex = 0;
            this.uxUserNameLabel.Text = "First Lastname";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.uxUserProfilePic);
            this.panel2.Controls.Add(this.uxDateDisplay);
            this.panel2.Controls.Add(this.uxBtnScreenSize);
            this.panel2.Controls.Add(this.uxClosingBtn);
            this.panel2.Controls.Add(this.uxUserRoleLabel);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.uxTimeDisplay);
            this.panel2.Controls.Add(this.uxUserNameLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(215, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(985, 92);
            this.panel2.TabIndex = 4;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // uxDateDisplay
            // 
            this.uxDateDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxDateDisplay.AutoSize = true;
            this.uxDateDisplay.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDateDisplay.ForeColor = System.Drawing.Color.White;
            this.uxDateDisplay.Location = new System.Drawing.Point(598, 31);
            this.uxDateDisplay.Name = "uxDateDisplay";
            this.uxDateDisplay.Size = new System.Drawing.Size(171, 16);
            this.uxDateDisplay.TabIndex = 9;
            this.uxDateDisplay.Text = "Thursday, March 30, 2019";
            this.uxDateDisplay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // uxBtnScreenSize
            // 
            this.uxBtnScreenSize.BackColor = System.Drawing.Color.Black;
            this.uxBtnScreenSize.Dock = System.Windows.Forms.DockStyle.Right;
            this.uxBtnScreenSize.FlatAppearance.BorderSize = 0;
            this.uxBtnScreenSize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.uxBtnScreenSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxBtnScreenSize.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBtnScreenSize.ForeColor = System.Drawing.Color.White;
            this.uxBtnScreenSize.Image = ((System.Drawing.Image)(resources.GetObject("uxBtnScreenSize.Image")));
            this.uxBtnScreenSize.Location = new System.Drawing.Point(837, 0);
            this.uxBtnScreenSize.Name = "uxBtnScreenSize";
            this.uxBtnScreenSize.Size = new System.Drawing.Size(74, 92);
            this.uxBtnScreenSize.TabIndex = 7;
            this.uxBtnScreenSize.UseVisualStyleBackColor = false;
            this.uxBtnScreenSize.Click += new System.EventHandler(this.uxBtnScreenSize_Click);
            // 
            // uxClosingBtn
            // 
            this.uxClosingBtn.BackColor = System.Drawing.Color.Black;
            this.uxClosingBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.uxClosingBtn.FlatAppearance.BorderSize = 0;
            this.uxClosingBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.uxClosingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxClosingBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxClosingBtn.ForeColor = System.Drawing.Color.White;
            this.uxClosingBtn.Image = ((System.Drawing.Image)(resources.GetObject("uxClosingBtn.Image")));
            this.uxClosingBtn.Location = new System.Drawing.Point(911, 0);
            this.uxClosingBtn.Name = "uxClosingBtn";
            this.uxClosingBtn.Size = new System.Drawing.Size(74, 92);
            this.uxClosingBtn.TabIndex = 5;
            this.uxClosingBtn.UseVisualStyleBackColor = false;
            this.uxClosingBtn.Click += new System.EventHandler(this.uxClosingBtn_Click);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(173, 8);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(38, 29);
            this.button8.TabIndex = 2;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // uxBtnIndicatorPac
            // 
            this.uxBtnIndicatorPac.BackColor = System.Drawing.Color.White;
            this.uxBtnIndicatorPac.Location = new System.Drawing.Point(1, 142);
            this.uxBtnIndicatorPac.Name = "uxBtnIndicatorPac";
            this.uxBtnIndicatorPac.Size = new System.Drawing.Size(7, 60);
            this.uxBtnIndicatorPac.TabIndex = 1;
            // 
            // uxBtnSettings
            // 
            this.uxBtnSettings.FlatAppearance.BorderSize = 0;
            this.uxBtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxBtnSettings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBtnSettings.ForeColor = System.Drawing.Color.White;
            this.uxBtnSettings.Image = ((System.Drawing.Image)(resources.GetObject("uxBtnSettings.Image")));
            this.uxBtnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uxBtnSettings.Location = new System.Drawing.Point(12, 648);
            this.uxBtnSettings.Name = "uxBtnSettings";
            this.uxBtnSettings.Size = new System.Drawing.Size(203, 60);
            this.uxBtnSettings.TabIndex = 2;
            this.uxBtnSettings.Text = "     Settings";
            this.uxBtnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.uxBtnSettings.UseVisualStyleBackColor = true;
            this.uxBtnSettings.Click += new System.EventHandler(this.uxBtnSettings_Click);
            this.uxBtnSettings.MouseEnter += new System.EventHandler(this.uxBtnSettings_MouseEnter);
            this.uxBtnSettings.MouseLeave += new System.EventHandler(this.uxBtnSettings_MouseLeave);
            // 
            // uxBtnSales
            // 
            this.uxBtnSales.FlatAppearance.BorderSize = 0;
            this.uxBtnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxBtnSales.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBtnSales.ForeColor = System.Drawing.Color.White;
            this.uxBtnSales.Image = ((System.Drawing.Image)(resources.GetObject("uxBtnSales.Image")));
            this.uxBtnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uxBtnSales.Location = new System.Drawing.Point(12, 406);
            this.uxBtnSales.Name = "uxBtnSales";
            this.uxBtnSales.Size = new System.Drawing.Size(203, 60);
            this.uxBtnSales.TabIndex = 2;
            this.uxBtnSales.Text = "     View Sales";
            this.uxBtnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.uxBtnSales.UseVisualStyleBackColor = true;
            this.uxBtnSales.Click += new System.EventHandler(this.uxBtnSales_Click);
            this.uxBtnSales.MouseEnter += new System.EventHandler(this.uxBtnSales_MouseEnter);
            this.uxBtnSales.MouseLeave += new System.EventHandler(this.uxBtnSales_MouseLeave);
            // 
            // uxBtnCustomer
            // 
            this.uxBtnCustomer.FlatAppearance.BorderSize = 0;
            this.uxBtnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxBtnCustomer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBtnCustomer.ForeColor = System.Drawing.Color.White;
            this.uxBtnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("uxBtnCustomer.Image")));
            this.uxBtnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uxBtnCustomer.Location = new System.Drawing.Point(12, 340);
            this.uxBtnCustomer.Name = "uxBtnCustomer";
            this.uxBtnCustomer.Size = new System.Drawing.Size(203, 60);
            this.uxBtnCustomer.TabIndex = 2;
            this.uxBtnCustomer.Text = "     Customers";
            this.uxBtnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.uxBtnCustomer.UseVisualStyleBackColor = true;
            this.uxBtnCustomer.Click += new System.EventHandler(this.uxBtnCustomer_Click);
            this.uxBtnCustomer.MouseEnter += new System.EventHandler(this.uxBtnCustomer_MouseEnter);
            this.uxBtnCustomer.MouseLeave += new System.EventHandler(this.uxBtnCustomer_MouseLeave);
            // 
            // uxBtnSupplier
            // 
            this.uxBtnSupplier.FlatAppearance.BorderSize = 0;
            this.uxBtnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxBtnSupplier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBtnSupplier.ForeColor = System.Drawing.Color.White;
            this.uxBtnSupplier.Image = ((System.Drawing.Image)(resources.GetObject("uxBtnSupplier.Image")));
            this.uxBtnSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uxBtnSupplier.Location = new System.Drawing.Point(12, 274);
            this.uxBtnSupplier.Name = "uxBtnSupplier";
            this.uxBtnSupplier.Size = new System.Drawing.Size(203, 60);
            this.uxBtnSupplier.TabIndex = 2;
            this.uxBtnSupplier.Text = "     Suppliers";
            this.uxBtnSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.uxBtnSupplier.UseVisualStyleBackColor = true;
            this.uxBtnSupplier.Click += new System.EventHandler(this.uxBtnSupplier_Click);
            this.uxBtnSupplier.MouseEnter += new System.EventHandler(this.uxBtnSupplier_MouseEnter);
            this.uxBtnSupplier.MouseLeave += new System.EventHandler(this.uxBtnSupplier_MouseLeave);
            // 
            // uxBtnProduct
            // 
            this.uxBtnProduct.FlatAppearance.BorderSize = 0;
            this.uxBtnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxBtnProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBtnProduct.ForeColor = System.Drawing.Color.White;
            this.uxBtnProduct.Image = ((System.Drawing.Image)(resources.GetObject("uxBtnProduct.Image")));
            this.uxBtnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uxBtnProduct.Location = new System.Drawing.Point(12, 208);
            this.uxBtnProduct.Name = "uxBtnProduct";
            this.uxBtnProduct.Size = new System.Drawing.Size(203, 60);
            this.uxBtnProduct.TabIndex = 2;
            this.uxBtnProduct.Text = "     Products";
            this.uxBtnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.uxBtnProduct.UseVisualStyleBackColor = true;
            this.uxBtnProduct.Click += new System.EventHandler(this.uxBtnProduct_Click);
            this.uxBtnProduct.MouseEnter += new System.EventHandler(this.uxBtnProduct_MouseEnter);
            this.uxBtnProduct.MouseLeave += new System.EventHandler(this.uxBtnProduct_MouseLeave);
            // 
            // uxBtnPackages
            // 
            this.uxBtnPackages.FlatAppearance.BorderSize = 0;
            this.uxBtnPackages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxBtnPackages.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBtnPackages.ForeColor = System.Drawing.Color.White;
            this.uxBtnPackages.Image = ((System.Drawing.Image)(resources.GetObject("uxBtnPackages.Image")));
            this.uxBtnPackages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uxBtnPackages.Location = new System.Drawing.Point(12, 142);
            this.uxBtnPackages.Name = "uxBtnPackages";
            this.uxBtnPackages.Size = new System.Drawing.Size(203, 60);
            this.uxBtnPackages.TabIndex = 2;
            this.uxBtnPackages.Text = "     Packages";
            this.uxBtnPackages.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.uxBtnPackages.UseVisualStyleBackColor = true;
            this.uxBtnPackages.Click += new System.EventHandler(this.uxBtnPackages_Click);
            this.uxBtnPackages.MouseEnter += new System.EventHandler(this.uxBtnPackages_MouseEnter);
            this.uxBtnPackages.MouseLeave += new System.EventHandler(this.uxBtnPackages_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 140);
            this.panel3.TabIndex = 0;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Black;
            this.panelLeft.Controls.Add(this.uxBtnIndicatorSet);
            this.panelLeft.Controls.Add(this.uxBtnIndicatorSal);
            this.panelLeft.Controls.Add(this.uxBtnIndicatorCus);
            this.panelLeft.Controls.Add(this.uxBtnIndicatorPro);
            this.panelLeft.Controls.Add(this.uxBtnIndicatorSup);
            this.panelLeft.Controls.Add(this.uxBtnIndicatorPac);
            this.panelLeft.Controls.Add(this.uxBtnSettings);
            this.panelLeft.Controls.Add(this.uxBtnSales);
            this.panelLeft.Controls.Add(this.uxBtnCustomer);
            this.panelLeft.Controls.Add(this.uxBtnSupplier);
            this.panelLeft.Controls.Add(this.uxBtnProduct);
            this.panelLeft.Controls.Add(this.uxBtnPackages);
            this.panelLeft.Controls.Add(this.panel3);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(215, 720);
            this.panelLeft.TabIndex = 3;
            this.panelLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLeft_MouseDown);
            // 
            // uxBtnIndicatorSet
            // 
            this.uxBtnIndicatorSet.BackColor = System.Drawing.Color.White;
            this.uxBtnIndicatorSet.Location = new System.Drawing.Point(1, 648);
            this.uxBtnIndicatorSet.Name = "uxBtnIndicatorSet";
            this.uxBtnIndicatorSet.Size = new System.Drawing.Size(7, 60);
            this.uxBtnIndicatorSet.TabIndex = 6;
            // 
            // uxBtnIndicatorSal
            // 
            this.uxBtnIndicatorSal.BackColor = System.Drawing.Color.White;
            this.uxBtnIndicatorSal.Location = new System.Drawing.Point(1, 406);
            this.uxBtnIndicatorSal.Name = "uxBtnIndicatorSal";
            this.uxBtnIndicatorSal.Size = new System.Drawing.Size(7, 60);
            this.uxBtnIndicatorSal.TabIndex = 5;
            // 
            // uxBtnIndicatorCus
            // 
            this.uxBtnIndicatorCus.BackColor = System.Drawing.Color.White;
            this.uxBtnIndicatorCus.Location = new System.Drawing.Point(1, 340);
            this.uxBtnIndicatorCus.Name = "uxBtnIndicatorCus";
            this.uxBtnIndicatorCus.Size = new System.Drawing.Size(7, 60);
            this.uxBtnIndicatorCus.TabIndex = 4;
            // 
            // uxBtnIndicatorPro
            // 
            this.uxBtnIndicatorPro.BackColor = System.Drawing.Color.White;
            this.uxBtnIndicatorPro.Location = new System.Drawing.Point(1, 208);
            this.uxBtnIndicatorPro.Name = "uxBtnIndicatorPro";
            this.uxBtnIndicatorPro.Size = new System.Drawing.Size(7, 60);
            this.uxBtnIndicatorPro.TabIndex = 2;
            // 
            // uxBtnIndicatorSup
            // 
            this.uxBtnIndicatorSup.BackColor = System.Drawing.Color.White;
            this.uxBtnIndicatorSup.Location = new System.Drawing.Point(1, 274);
            this.uxBtnIndicatorSup.Name = "uxBtnIndicatorSup";
            this.uxBtnIndicatorSup.Size = new System.Drawing.Size(7, 60);
            this.uxBtnIndicatorSup.TabIndex = 3;
            // 
            // uxUserProfilePic
            // 
            this.uxUserProfilePic.BackColor = System.Drawing.Color.DarkGray;
            this.uxUserProfilePic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uxUserProfilePic.BackgroundImage")));
            this.uxUserProfilePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uxUserProfilePic.Location = new System.Drawing.Point(71, 8);
            this.uxUserProfilePic.Name = "uxUserProfilePic";
            this.uxUserProfilePic.Size = new System.Drawing.Size(80, 80);
            this.uxUserProfilePic.TabIndex = 10;
            this.uxUserProfilePic.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dashboard_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Dashboard_KeyUp);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uxUserProfilePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Label uxUserRoleLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label uxTimeDisplay;
        private System.Windows.Forms.Label uxUserNameLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel uxBtnIndicatorPac;
        private System.Windows.Forms.Button uxBtnSettings;
        private System.Windows.Forms.Button uxBtnSales;
        private System.Windows.Forms.Button uxBtnCustomer;
        private System.Windows.Forms.Button uxBtnSupplier;
        private System.Windows.Forms.Button uxBtnProduct;
        private System.Windows.Forms.Button uxBtnPackages;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button uxClosingBtn;
        private System.Windows.Forms.Panel uxBtnIndicatorSal;
        private System.Windows.Forms.Panel uxBtnIndicatorCus;
        private System.Windows.Forms.Panel uxBtnIndicatorPro;
        private System.Windows.Forms.Panel uxBtnIndicatorSup;
        private System.Windows.Forms.Panel uxBtnIndicatorSet;
        private System.Windows.Forms.Button uxBtnScreenSize;
        private System.Windows.Forms.Label uxDateDisplay;
        private CircularPicturebox uxUserProfilePic;
    }
}