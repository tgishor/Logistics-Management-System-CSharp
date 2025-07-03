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
    public partial class Customer_Update : Form
    {
        private string customer_id = null;
        public Customer_Update(string _cusID)
        {
            InitializeComponent();

            customer_id = _cusID; 
        }

        List<ComboBox> comboBoxList;
        List<TextBox> textBoxList;

        private void Customer_Update_Load(object sender, EventArgs e)
        {
            lblSelectedCustomer.Text = customer_id;

            CommonFunctions.DataComboBox("SELECT * FROM city", cityBox, "city_name", "city_id");

            DataTable cusTable = CommonFunctions.tableFun("SELECT * FROM customer WHERE c_id = '" + customer_id + "' ");

            foreach (DataRow row in cusTable.Rows)
            {
                cityBox.SelectedValue = row["city_id_fk"].ToString();
                nameBox.Text = row["c_name"].ToString();
                nicBox.Text = row["c_nic"].ToString();
                streetBox.Text = row["c_address"].ToString();
                phoneBox.Text = row["c_phoneNo"].ToString();
                emailBox.Text = row["c_email"].ToString();

            }

            // Declaring List of TextBox and List of ComboBox
            textBoxList = new List<TextBox>(){
                nameBox, nicBox, streetBox, phoneBox, emailBox
            };

            comboBoxList = new List<ComboBox>(){
                cityBox
            };
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (customer_id == null)
            {
                MessageBox.Show("No Customer ID Selected");
            }
            else
            {
                // Validating If all the textboxes are available
                if (CommonFunctions.validate(textBoxList) && CommonFunctions.validate(comboBoxList) && CommonFunctions.checkComoboBoxData(comboBoxList))
                {
                    CommonFunctions.updateFun("UPDATE customer SET c_name = '"+nameBox.Text+"', c_nic = '"+nicBox.Text+"', c_address = '"+streetBox.Text+"', c_phoneNo = '"+phoneBox.Text+"', city_id_fk = '"+cityBox.SelectedValue.ToString()+"', c_email = '"+emailBox.Text+"'	 WHERE c_id = '" + customer_id + "' ");

                }
                else
                {
                    MessageBox.Show("Please fill all the required boxes");
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPanel.OpenChildForm(new Customer_Manage());
        }
    }
}
