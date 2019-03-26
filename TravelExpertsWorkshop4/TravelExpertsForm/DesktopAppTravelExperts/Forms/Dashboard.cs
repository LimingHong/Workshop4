using System;
using System.Drawing;
using System.Windows.Forms;

namespace DesktopAppTravelExperts.Forms
{
    public partial class Dashboard : Form
    {
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


        // for time display very update of 1 second
        private void timerTime_Tick(object sender, EventArgs e)
        {
            uxTimeDisplay.Text = DateTime.Now.ToLongTimeString();
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
            uxTimeDisplay.Text = DateTime.Now.ToLongTimeString();


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
                    break;

                case "product":
                    uxBtnIndicatorPro.Visible = ProductSection = true;
                    break;

                case "supplier":
                    uxBtnIndicatorSup.Visible = SupplierSection = true;
                    break;

                case "customer":
                    uxBtnIndicatorCus.Visible = CustomerSection = true;
                    break;

                case "sale":
                    uxBtnIndicatorSal.Visible = SalesSection = true;
                    break;

                case "setting":
                    uxBtnIndicatorSet.Visible = SettingSection = true;
                    break;
            }

        }

        private void button8_Click(object sender, System.EventArgs e)
        {
            panel2.Visible = !panel2.Visible;
        }

        private void uxClosingBtn_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void Dashboard_Load(object sender, System.EventArgs e)
        {

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

    }
}
