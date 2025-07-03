using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_ShifSystem
{
    public partial class resetPassword : Form
    {
        public resetPassword()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        private void resetPassword_Load(object sender, EventArgs e)
        {

        }

        private void resetPassword_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resetPasswordBtn_Click(object sender, EventArgs e)
        {
            string[] getUserType = usernameBox.Text.Split('-');

            string userType = getUserType[0];

            // Do customer login
            if (userType == "CUS")
            {
                DataTable customerTable = CommonFunctions.tableFun("SELECT * FROM customer WHERE c_username = '" + usernameBox.Text + "' ");

                int count = customerTable.Rows.Count;

                if (count == 1)
                {
                    // Creating a password for customer
                    string customerPassword = CommonFunctions.CreateRandomPassword(8);

                    CommonFunctions.updateFunNoMsgBox("UPDATE customer SET c_password = '" + customerPassword + "' WHERE c_username = '" + usernameBox.Text + "' ");

                    sentMail(getHtml(usernameBox.Text, customerPassword), customerTable.Rows[0]["c_email"].ToString());

                    MessageBox.Show("New Username and Password has been Sent to your Registered Email");
                }
                else
                {
                    MessageBox.Show("This usernmae is not been found");
                }
            }
            else if (userType == "ADM")
            {
                DataTable adminTable = CommonFunctions.tableFun("SELECT * FROM admin WHERE adm_usernmae = '" + usernameBox.Text + "' ");

                int count = adminTable.Rows.Count;

                if (count == 1)
                {
                    // Creating a password for customer
                    string adminPassword = CommonFunctions.CreateRandomPassword(8);

                    CommonFunctions.updateFunNoMsgBox("UPDATE admin SET adm_password = '" + adminPassword + "' WHERE adm_username = '" + usernameBox.Text + "' ");

                    sentMail(getHtml(usernameBox.Text, adminPassword), adminTable.Rows[0]["c_email"].ToString());

                    MessageBox.Show("New Username and Password has been Sent to your Registered Email");
                }
                else
                {
                    MessageBox.Show("This usernmae is not been found");
                }
            }
            else
            {
                MessageBox.Show("Invalid Username, Pease Check the usernmae nad Please try again");
            }
        }

        public static string getHtml(String _cusUsername, String password)
        {
            try
            {
                string messageBody = "<h2> Your Password for E-Shift SYstem has been Resetted </h2><br><br>";
                messageBody += "<h4> Below are your new username and password \n Your Username: <strong>" + _cusUsername + "</strong> <br>  Your Password: <strong> " + password + " </strong>  </h4>";
                return messageBody; // return HTML Table as string from this function  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static void sentMail(string htmlString, string emailAddress)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("gish_degreeproj@grandstarhall.com", "E-Shift Admin");
                message.To.Add(new MailAddress(emailAddress));
                message.Subject = "E-Shift System Username and Password has been resetted ";
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = htmlString;
                smtp.Port = 587;
                smtp.Host = "mail.grandstarhall.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("gish_degreeproj@grandstarhall.com", "esoftdegreee1234");
                smtp.Send(message);
            }
            catch (SmtpException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
