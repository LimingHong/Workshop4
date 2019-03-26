namespace DesktopAppTravelExperts
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.uxLoginControlBar = new System.Windows.Forms.Panel();
            this.uxClosingBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.uxBtnSubmit = new System.Windows.Forms.Button();
            this.uxPasswordTb = new System.Windows.Forms.TextBox();
            this.uxUsernameTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.uxLoginControlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // uxLoginControlBar
            // 
            this.uxLoginControlBar.BackColor = System.Drawing.Color.Black;
            this.uxLoginControlBar.Controls.Add(this.uxClosingBtn);
            this.uxLoginControlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.uxLoginControlBar.Location = new System.Drawing.Point(0, 0);
            this.uxLoginControlBar.Name = "uxLoginControlBar";
            this.uxLoginControlBar.Size = new System.Drawing.Size(635, 82);
            this.uxLoginControlBar.TabIndex = 8;
            this.uxLoginControlBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.uxLoginControlBar_MouseDown);
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
            this.uxClosingBtn.Location = new System.Drawing.Point(574, 0);
            this.uxClosingBtn.Name = "uxClosingBtn";
            this.uxClosingBtn.Size = new System.Drawing.Size(61, 82);
            this.uxClosingBtn.TabIndex = 4;
            this.uxClosingBtn.UseVisualStyleBackColor = false;
            this.uxClosingBtn.Click += new System.EventHandler(this.uxClosingBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(379, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Sign Up ?";
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // uxBtnSubmit
            // 
            this.uxBtnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uxBtnSubmit.BackColor = System.Drawing.Color.White;
            this.uxBtnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uxBtnSubmit.FlatAppearance.BorderSize = 0;
            this.uxBtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxBtnSubmit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBtnSubmit.ForeColor = System.Drawing.Color.Black;
            this.uxBtnSubmit.Location = new System.Drawing.Point(173, 561);
            this.uxBtnSubmit.Name = "uxBtnSubmit";
            this.uxBtnSubmit.Size = new System.Drawing.Size(274, 39);
            this.uxBtnSubmit.TabIndex = 15;
            this.uxBtnSubmit.Text = "Login";
            this.uxBtnSubmit.UseVisualStyleBackColor = false;
            this.uxBtnSubmit.Click += new System.EventHandler(this.uxBtnSubmit_Click);
            // 
            // uxPasswordTb
            // 
            this.uxPasswordTb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uxPasswordTb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPasswordTb.Location = new System.Drawing.Point(94, 421);
            this.uxPasswordTb.Name = "uxPasswordTb";
            this.uxPasswordTb.Size = new System.Drawing.Size(447, 31);
            this.uxPasswordTb.TabIndex = 13;
            this.uxPasswordTb.UseSystemPasswordChar = true;
            this.uxPasswordTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uxPasswordTb_KeyDown);
            // 
            // uxUsernameTb
            // 
            this.uxUsernameTb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uxUsernameTb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxUsernameTb.Location = new System.Drawing.Point(94, 338);
            this.uxUsernameTb.Name = "uxUsernameTb";
            this.uxUsernameTb.Size = new System.Drawing.Size(447, 31);
            this.uxUsernameTb.TabIndex = 14;
            this.uxUsernameTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uxUsernameTb_KeyDown);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(90, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(159, 502);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Forgot Password?";
            this.label5.MouseEnter += new System.EventHandler(this.label5_MouseEnter);
            this.label5.MouseLeave += new System.EventHandler(this.label5_MouseLeave);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(6, 676);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(356, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Copyrights © 2019. All rights Reserved By Travel Experts.";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(90, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "User Name:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(173, 102);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(306, 177);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(635, 696);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.uxLoginControlBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxBtnSubmit);
            this.Controls.Add(this.uxPasswordTb);
            this.Controls.Add(this.uxUsernameTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginPage_KeyDown);
            this.uxLoginControlBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel uxLoginControlBar;
        private System.Windows.Forms.Button uxClosingBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uxBtnSubmit;
        private System.Windows.Forms.TextBox uxPasswordTb;
        private System.Windows.Forms.TextBox uxUsernameTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}