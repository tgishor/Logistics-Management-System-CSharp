using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_ShifSystem
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void userBox_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void login_Load(object sender, EventArgs e)
        {
            
        }

        private void userBox_Enter(object sender, EventArgs e)
        {
            /*userBox.Text = "";
            userBox.ForeColor = Color.LightSkyBlue;*/
        }

        private void userBox_Leave(object sender, EventArgs e)
        {
            /*userBox.Text = "Username";
            userBox.ForeColor = Color.FromArgb(254, 254, 255);*/
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private string userType;


        private void loginBtn_Click(object sender, EventArgs e)
        {
            

            if (userBox.Text != "" && passBox.Text != "")
            {
                string[] getUserType = userBox.Text.Split('-');

                userType = getUserType[0];

                // Do customer login
                if (userType == "CUS")
                {
                    if (CommonFunctions.userLoginCheck("SELECT * FROM customer WHERE c_username = '" + userBox.Text + "' AND c_password = '" + passBox.Text + "'", new Customer_Dashboard()))
                    {

                        // Creating Datatable to get the username,name and id of the users
                        DataTable userDetails = CommonFunctions.tableFun("SELECT * FROM customer WHERE c_username = '" + userBox.Text + "' AND c_password = '" + passBox.Text + "'");

                        // Setting the username,name and the id of the user commonly accessible 
                        CommonFunctions.logedUserInfo = new loginDetails(userDetails.Rows[0]["c_id"].ToString(), userDetails.Rows[0]["c_name"].ToString(), userDetails.Rows[0]["c_username"].ToString());

                        this.Hide();
                        new Customer_Dashboard().Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username or Password ", "Incorrect Credentials", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                }
                else if (userType == "ADM")
                {

                    String passFinal = CommonFunctions.EncryptString("b14ca5898a4e4133bbce2ea2315a1916", passBox.Text);
                    /*String DecryptionString = CommonFunctions.DecryptString("b14ca5898a4e4133bbce2ea2315a1916", passBox.Text);

                    MessageBox.Show(DecryptionString);*/

                    if (CommonFunctions.userLoginCheck("SELECT * FROM admin WHERE adm_username = '" + userBox.Text + "' AND adm_password = '" + passFinal + "'", new MainPanel()))
                    {
                        // Creating Datatable to get the username,name and id of the admin
                        DataTable userDetails = CommonFunctions.tableFun("SELECT * FROM admin WHERE adm_username = '" + userBox.Text + "' AND adm_password = '" + passFinal + "'");

                        // Setting the username,name and the id of the admin commonly accessible 
                        CommonFunctions.logedUserInfo = new loginDetails(userDetails.Rows[0]["adm_id"].ToString(), userDetails.Rows[0]["adm_name"].ToString(), userDetails.Rows[0]["adm_username"].ToString());

                        this.Hide();
                        new MainPanel().Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username or Password ", "Incorrect Credentials", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password ", "Incorrect Credentials", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid Data ", "Invalid Data", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }


        }

        private void forgetPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            new resetPassword().Show();
        }
    }
}
