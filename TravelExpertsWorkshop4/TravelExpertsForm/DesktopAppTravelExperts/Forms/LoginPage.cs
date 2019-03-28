using System;
using System.Drawing;
using System.Windows.Forms;

namespace DesktopAppTravelExperts
{
    public partial class LoginPage : Form
    {
        // boolean parameters for form modes recognition
        private int FormMode = 0; // 0 = login, 1 = Sign-up , 2 = forgot password


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;


        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            this.Focus();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(LoginPage_KeyDown);
        }

        private void uxClosingBtn_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void uxLoginControlBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void LoginPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.W)
            {
                Close();
            }

        }



        private void uxUsernameTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                uxBtnSubmit.PerformClick();
            }
        }

        private void uxBtnSubmit_Click(object sender, EventArgs e)
        {
            string test = "";
            switch (FormMode)
            {
                case 0:
                    test = "Login";
                    break;
                case 1:
                    test = "Sign Up";
                    break;
                case 2:
                    test = "Forgot Password";
                    break;

            }
            MessageBox.Show("Clicked while in " + test + " mode");
        }

        private void uxPasswordTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                uxBtnSubmit.PerformClick();
            }
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = Color.OrangeRed;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.White;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.LawnGreen;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FormMode = 1; // indicate signing up
            panel1.Visible = false; // get rid of label panel
            label1.Text = "First Name:";
            label4.Text = "Last Name:";
            uxBtnSubmit.Text = "Sign Up";
            uxEmailLabel.Visible = uxEmailTB.Visible = true;
            uxCancelLabel.Visible = true;


        }

        // forgotpassword is clicked
        private void label5_Click(object sender, EventArgs e)
        {
            FormMode = 2; // indicate that this is forgotpassword mode
            panel1.Visible = false; // get rid of label panel
            label1.Text = "First Name:";
            label4.Text = "Last Name:";
            uxBtnSubmit.Text = "Find Password";
            uxEmailLabel.Visible = uxEmailTB.Visible = true;
            uxCancelLabel.Visible = true;
        }

        private void uxCancelLabel_Click(object sender, EventArgs e)
        {
            FormMode = 0; // indicate signing up
            panel1.Visible = true; // get rid of label panel
            label1.Text = "Username:";
            label4.Text = "Password:";
            uxBtnSubmit.Text = "Login";
            uxEmailLabel.Visible = uxEmailTB.Visible = false;
            uxCancelLabel.Visible = false;
        }
    }
}
