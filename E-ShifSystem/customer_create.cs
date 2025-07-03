using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Mail;



namespace E_ShifSystem
{
    public partial class customer_create : Form
    {
        public customer_create()
        {
            InitializeComponent();
        }

        List<ComboBox> comboBoxList;
        List<TextBox> textBoxList;

        private string customerPassword;
        private String cusUsername = "CUS-";
        private void customer_create_Load(object sender, EventArgs e)
        {
            // Declaring List of TextBox and List of ComboBox
            textBoxList = new List<TextBox>(){
                nameBox, nicBox, phoneBox, addBox, cusEmailBox
            };

            comboBoxList = new List<ComboBox>(){
                cityBox
            };

            CommonFunctions.DataComboBox("SELECT * FROM city", cityBox, "city_name", "city_id");

            tableLoad();

            cityBox.SelectedItem = null;
        }


        private void tableLoad()
        {
            String sql = "SELECT customer.c_id AS 'Customer ID', customer.c_name AS 'Customer Name', customer.c_nic AS 'Customer NIC', customer.c_address AS 'Customer Address', customer.c_phoneNo AS 'Customer Phone No', customer.c_email AS 'Customer Email', city.city_name AS 'Customer District' FROM customer INNER JOIN city ON customer.city_id_fk = city.city_id";

            CommonFunctions.DataTableLoadFun(sql, cusDataTable);
        }


        private Boolean checkComoboBoxData()
        {
            if (cityBox.SelectedValue == null)
            {
                // Text Box Colour Change 
                cityBox.BackColor = Color.Red;
                return false;
            }
            else
            {
                // change back colour text box colour 
                cityBox.BackColor = Color.White;
                return true;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Validating If all the textboxes & Combo Box are not Empty
            // And a checkComboBox() is used to check whether the data in the combo box is form the combo box member
            if (CommonFunctions.validate(textBoxList) && CommonFunctions.validate(comboBoxList) && checkComoboBoxData())
            {
                int lastCusInsertedID = CommonFunctions.insertAndReturnID("INSERT INTO customer (c_name, c_nic, c_address, c_phoneNo, c_email, city_id_fk ) VALUES ('" + nameBox.Text + "', '" + nicBox.Text + "', '" + addBox.Text + "', '" + phoneBox.Text + "','"+ cusEmailBox.Text +"' ,'" + cityBox.SelectedValue.ToString() + "' ); SELECT SCOPE_IDENTITY() AS lastCusInsertedID; ");

                // Creating a username for customer 
                cusUsername += lastCusInsertedID.ToString();

                // Creating a password for customer
                customerPassword = CommonFunctions.CreateRandomPassword(8);

                CommonFunctions.updateFunNoMsgBox("UPDATE customer SET c_username = '"+ cusUsername + "', c_password = '"+ customerPassword + "' WHERE c_id = '"+ lastCusInsertedID + "' ");

                tableLoad();    // After Query Executing Successfully, To reload the Data Grid View

                string mailTemplate = getHtml(cusUsername, customerPassword);

                sentMail(mailTemplate, cusEmailBox.Text);

                MessageBox.Show("Customer Data Inserted Successfully");

            }
            else
            {
                MessageBox.Show("Please fill all the required boxes"); // Message Passed if Anything Goes Wrong in the Validaiton
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {

            foreach (TextBox myBox in textBoxList)
            {
                myBox.ResetText();
                myBox.BackColor = Color.White;
            }


            foreach (ComboBox myComboBox in comboBoxList)
            {
                myComboBox.ResetText();
                myComboBox.BackColor = Color.White;
            }

        }

        private void phoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '+') && ((sender as TextBox).Text.IndexOf('+') > -1))
            {
                e.Handled = true;
            }
        }


        private void searchFun()
        {
            if (searchBox.Text != "")
            {
                String sql = "SELECT customer.c_id AS 'Customer ID', customer.c_name AS 'Customer Name', customer.c_nic AS 'Customer NIC', customer.c_address AS 'Customer Address', customer.c_phoneNo AS 'Customer Phone No', city.city_name AS 'Customer District' FROM customer INNER JOIN city ON customer.city_id_fk = city.city_id WHERE customer.c_name LIKE '%" + searchBox.Text + "%'";

                CommonFunctions.DataTableLoadFun(sql, cusDataTable);
            }
            else
            {
                tableLoad();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchFun();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            searchFun();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void payDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public static string getHtml(String _cusUsername, String password)
        {
            
            try
            {

                string messageBody = "<h2>   Your username & password for Login into the E-Shift System is mentioned below: </h2><br><br>";
                messageBody += "<h4> Your Username: <strong>" + _cusUsername + "</strong> <br>  Your Password: <strong> " + password + " </strong>  </h4>";
                return messageBody; // return HTML Table as string from this function  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static void sentMail(string htmlString,string emailAddress)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("gish_degreeproj@grandstarhall.com","E-Shift Admin");
                message.To.Add(new MailAddress(emailAddress));
                message.Subject = "E-Shift Customer System Username and Password";
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = htmlString;
                smtp.Port = 587;
                smtp.Host = "mail.grandstarhall.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("gish_degreeproj@grandstarhall.com", "esoftdegreee1234");
                smtp.Send(message);
            }
            catch (SmtpException ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
