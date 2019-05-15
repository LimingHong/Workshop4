using DesktopAppTravelExperts.Forms;
using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using TravelExpertsClassLib;

namespace DesktopAppTravelExperts
{
    public partial class LoginPage : Form
    {

        // boolean parameters for form modes recognition
        private int FormMode = 0; // 0 = login, 1 = Sign-up , 2 = forgot password
        protected Agents currentUser;

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

        private void CleanAllInputFields()
        {
            uxUsernameTb.Text = uxPasswordTb.Text = uxEmailTB.Text = "";
        }

        private void uxBtnSubmit_Click(object sender, EventArgs e)
        {
            string test = "";
            Agents inputUser = new Agents();

            switch (FormMode)
            {
                case 0:
                    test = "Login";
                    string inputUserName, inputPassword;
                    if (Validator.IsPresent(uxUsernameTb, "Username")
                        && Validator.IsPresent(uxPasswordTb, "Password")
                        && Validator.IsEmail(uxUsernameTb, "username")
                    )
                    {
                        inputUserName = uxUsernameTb.Text.Trim();
                        inputPassword = uxPasswordTb.Text.Trim();

                        if (LoginInfosDB.FindAgentExistingAcc(inputUserName, inputPassword, out inputUser))
                        {
                            currentUser = new Agents
                            {
                                AgentId = inputUser.AgentId,
                                AgtFirstName = inputUser.AgtFirstName,
                                AgtLastName = inputUser.AgtLastName,
                                AgtEmail = inputUser.AgtEmail,
                                AgtPosition = inputUser.AgtPosition,
                                AgtBusPhone = inputUser.AgtBusPhone,
                                AgtMiddleInitial = inputUser.AgtMiddleInitial,
                                AgencyId = inputUser.AgencyId,
                            };
                            MessageBox.Show("Login Successful!" +
                                            "\n " + currentUser.AgentId +
                                            "\n" + currentUser.AgtFirstName + " " + currentUser.AgtLastName);
                            this.Hide();
                            Dashboard newDashboard = new Dashboard();
                            newDashboard.currentAgent = currentUser;
                            newDashboard.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Login Fail !");
                        }
                    }

                    break;
                case 1:

                    test = "Sign Up";

                    if (Validator.IsPresent(uxUsernameTb, "First name")
                        && Validator.IsPresent(uxPasswordTb, "Last name")
                        && Validator.IsPresent(uxEmailTB, "Email")
                        && Validator.IsEmail(uxEmailTB, "Email")
                    )
                    {
                        CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
                        TextInfo textInfo = cultureInfo.TextInfo;

                        inputUser.AgtFirstName = textInfo.ToTitleCase(uxUsernameTb.Text.Trim().ToLower());
                        inputUser.AgtLastName = textInfo.ToTitleCase(uxPasswordTb.Text.Trim());
                        inputUser.AgtEmail = uxEmailTB.Text.Trim();

                        if (LoginInfosDB.CreateAccount(inputUser))
                        {
                            MessageBox.Show("Signup Successful!");
                            MessageBox.Show(
                                "Temporary Sign-in Option: \n --- Username: \nYour Email\n --- Password: \nYour first and last name  with each name's first letter capitalized and without spacing", "Account Info");
                            CleanAllInputFields();
                            SwitchMode(0);
                            FormMode = 0;

                        }
                        else
                        {
                            MessageBox.Show("The information you have provided indicates that you are not a member of our team. Access is only granted for Travel Experts Agents.", "Status:");
                            CleanAllInputFields();
                        }
                    }

                    break;
                case 2:
                    test = "Forgot Password";
                    MessageBox.Show("Funcionality Still Underconstruction!", "Status:");


                    break;

            }
            //MessageBox.Show("Clicked while in " + test + " mode");
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


        // forgotpassword is clicked
        private void SwitchMode(int inputIndicator)
        {
            bool turnOn = true;
            string FirstLabel = "";
            string SeconLabel = "";
            string StringButton = "";
            CleanAllInputFields();
            switch (inputIndicator)
            {
                case 0:
                    turnOn = false; // get rid of label panel
                    FirstLabel = "Username:";
                    SeconLabel = "Password:";
                    StringButton = "Login";
                    break;

                case 1:
                case 2:
                    FirstLabel = "First Name:";
                    SeconLabel = "Last Name:";

                    if (inputIndicator == 2)
                    {
                        StringButton = "Find Password";
                    }
                    else
                    {
                        StringButton = "Sign Up";
                    }

                    break;

            }

            panel1.Visible = !turnOn; // get rid of label panel
            label1.Text = FirstLabel;
            label4.Text = SeconLabel;
            uxBtnSubmit.Text = StringButton;
            uxEmailLabel.Visible = uxEmailTB.Visible = turnOn;
            uxCancelLabel.Visible = turnOn;
            uxPasswordTb.UseSystemPasswordChar = !turnOn;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            FormMode = 1; // indicate signing up
            SwitchMode(1);

        }

        private void label5_Click(object sender, EventArgs e)
        {
            FormMode = 2; // indicate that this is forgotpassword mode
            SwitchMode(2);
        }


        private void uxCancelLabel_Click(object sender, EventArgs e)
        {
            FormMode = 0; // indicate signing up
            SwitchMode(0);
        }

        private void uxUsernameTb_MouseEnter(object sender, EventArgs e)
        {

            if (FormMode == 0) uxUsernameEmailTooltipLabel.Visible = true;
        }

        private void uxUsernameTb_MouseLeave(object sender, EventArgs e)
        {

            uxUsernameEmailTooltipLabel.Visible = false;
        }
    }
}
