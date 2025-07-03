using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_ShifSystem
{
    public partial class Admin_Manage : Form
    {
        public Admin_Manage()
        {
            InitializeComponent();
        }

        private string select_adminID;

        private string key = "b14ca5898a4e4133bbce2ea2315a1916";

        List<TextBox> textBoxList;

        private void tableLoad()
        {
            String sql = "SELECT adm_id AS 'Admin ID', adm_name AS 'Admin Name', adm_email AS 'Admin Email', adm_username AS 'Username', adm_password AS 'Password' FROM admin";

            CommonFunctions.DataTableLoadFun(sql, adminDataTable);
        }


        private void Admin_Manage_Load(object sender, EventArgs e)
        {

            tableLoad();

            lblSelectedAdminID.Text = "None";

            // Declaring List of TextBox and List of ComboBox
            textBoxList = new List<TextBox>(){
                adminName, adminEmail, adminPassword, adminUsername
            };

        }


        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Validating If all the textboxes are available
            if (CommonFunctions.validate(textBoxList)&& CommonFunctions.validatePassword(adminPassword)&& CommonFunctions.checkUsername("SELECT * FROM admin WHERE adm_username = '"+adminUsername.Text+"'"))
            {

                CommonFunctions.insertFun("INSERT INTO admin (adm_name, adm_email, adm_username, adm_password) VALUES ('" + adminName.Text + "', '" + adminEmail.Text + "', 'ADM-" + adminUsername.Text + "', '" + CommonFunctions.EncryptString(key, adminPassword.Text).ToString() + "') ");

                tableLoad();

                CommonFunctions.resetAllTextBoxes(textBoxList);

            }
            else
            {
                MessageBox.Show("Invalid Data, Please Try Again by FullFilling the Requirements", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void adminDataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                select_adminID = adminDataTable.Rows[index].Cells["Admin ID"].Value.ToString();
                string admin_name = adminDataTable.Rows[index].Cells["Admin Name"].Value.ToString();
                string admin_email = adminDataTable.Rows[index].Cells["Admin Email"].Value.ToString();
                string admin_username = adminDataTable.Rows[index].Cells["Username"].Value.ToString();

                lblSelectedAdminID.Text = select_adminID;
                adminName.Text = admin_name;
                adminEmail.Text = admin_email;
                adminUsername.Text = admin_username;
                adminPassword.Text = "If Wanted Create a New Password";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Opopss Error!!!! \nProbably you had selected the invalid data row \nError Description:" + ex.Message, "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (select_adminID == null)
            {
                MessageBox.Show("No Admin ID Selected");
            }
            else
            {
                // Validating If all the textboxes are available
                if (CommonFunctions.validate(textBoxList))
                {
                    
                    CommonFunctions.updateFun("UPDATE admin SET adm_name ='" +adminName.Text +"' , adm_email ='" +adminEmail.Text +"' , adm_username ='" + adminUsername.Text +"' , adm_password ='" + CommonFunctions.EncryptString(key, adminPassword.Text).ToString() + "' WHERE adm_id = '"+select_adminID+"'");

                    tableLoad();

                    CommonFunctions.resetAllTextBoxes(textBoxList);

                }
                else
                {
                    MessageBox.Show("Please fill all the required boxes", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void lblSelectedAdminID_Click(object sender, EventArgs e)
        {
            CommonFunctions.resetAllTextBoxes(textBoxList);
            lblSelectedAdminID.Text = "None";
            select_adminID = null;
        }

        private void adminPassword_Click(object sender, EventArgs e)
        {
            adminPassword.ResetText();  
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (select_adminID == null)
            {
                MessageBox.Show("No Admin ID Selected");
            }
            else
            {
                CommonFunctions.deleteFun("DELETE FROM admin WHERE adm_id = '" + select_adminID + "'");

                tableLoad();

                CommonFunctions.resetAllTextBoxes(textBoxList);
            }
        }
    }
}
