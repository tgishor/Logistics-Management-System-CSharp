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
    public partial class ExsitCustomerJob_Create : Form
    {
        public ExsitCustomerJob_Create()
        {
            InitializeComponent();
        }


        List<ComboBox> comboBoxList;
        List<TextBox> textBoxList;

        private void ExsitCustomerJob_Create_Load(object sender, EventArgs e)
        {
            // Setting up the format for dateTimePicker "pickDateTime"
            pickupDateTime.Format = DateTimePickerFormat.Custom;
            pickupDateTime.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            DateTime PresentDateTime = DateTime.Now;
            pickupDateTime.MinDate = PresentDateTime;

            //Define All ComboBox

            CommonFunctions.DataComboBox("SELECT * FROM jobStatus", jobStatusBox, "jStatus", "jStatus_id");
            CommonFunctions.DataComboBox("SELECT * FROM transportUnit", transportUnitBox, "tu_desc", "tu_id");
            CommonFunctions.DataComboBox("SELECT * FROM customer", cusBox, "c_name", "c_id");

            lblRecentlyAddedJob.Text = CommonFunctions.getLastInsertedIDinColumn("job").ToString();

            // Declaring List of TextBox and List of ComboBox
            textBoxList = new List<TextBox>(){
               pickAddress,dropAddress,totalPayableBox
            };

            comboBoxList = new List<ComboBox>(){
                cusBox,jobStatusBox,transportUnitBox
            };

            lblRecentlyAddedJob.Text = CommonFunctions.getLastInsertedIDinColumn("job").ToString();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void continueWithLoadBtn_Click(object sender, EventArgs e)
        {
            if (CommonFunctions.validate(textBoxList) && CommonFunctions.validate(comboBoxList) && CommonFunctions.checkComoboBoxData(comboBoxList))
            {

                DateTime now = DateTime.Now; // To get the current date and time

                // Inserting Job Details and Geting the Inserted Job ID in Return 
                int lastJobInsertedID = CommonFunctions.insertAndReturnID("INSERT INTO job (j_regDateTime, j_pickLocation, j_pickDateTime, j_dropLocation, j_payable , c_id_fk, tu_id_fk,jobStatus_id_fk) VALUES ('" + now.ToString() + "','" + pickAddress.Text + "', '" + pickupDateTime.Value + "','" + dropAddress.Text + "','" + totalPayableBox.Text + "' ,'" + cusBox.SelectedValue.ToString() + "','" + transportUnitBox.SelectedValue.ToString() + "','" + jobStatusBox.SelectedValue.ToString() + "'); SELECT SCOPE_IDENTITY() AS lastJobInsertedID;");

                // Job ID is been sent with the constructor to Load Form
                MainPanel.OpenChildForm(new JobContinuedLoadPage(lastJobInsertedID));

            }
            else
            {
                MessageBox.Show("Please fill all the required boxes");
            }
        }

        private void addJobOnlyBtn_Click(object sender, EventArgs e)
        {
            if (CommonFunctions.validate(textBoxList) && CommonFunctions.validate(comboBoxList) && CommonFunctions.checkComoboBoxData(comboBoxList))
            {

                DateTime now = DateTime.Now; // To get the current date and time

                // Inserting Job Details and Geting the Inserted Job ID in Return 
                int lastJobInsertedID = CommonFunctions.insertAndReturnID("INSERT INTO job (j_regDateTime, j_pickLocation, j_pickDateTime, j_dropLocation, j_payable , c_id_fk, tu_id_fk,jobStatus_id_fk) VALUES ('" + now.ToString() + "','" + pickAddress.Text + "', '" + pickupDateTime.Value + "','" + dropAddress.Text + "','" + totalPayableBox.Text + "' ,'" + cusBox.SelectedValue.ToString() + "','" + transportUnitBox.SelectedValue.ToString() + "','" + jobStatusBox.SelectedValue.ToString() + "'); SELECT SCOPE_IDENTITY() AS lastJobInsertedID;");
                CommonFunctions.resetAllTextBoxes(textBoxList);
                CommonFunctions.resetAllTextBoxes(comboBoxList);

            }
            else
            {
                MessageBox.Show("Please fill all the required boxes");
            }

        }

        private void manageJobBtn_Click(object sender, EventArgs e)
        {
            MainPanel.OpenChildForm(new Job_Manage());
        }

        private void transportUnitBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (transportUnitBox.SelectedValue != null)
            {
                grpBoxSelectedTu.Show();

                DataTable transDetails = CommonFunctions.tableFun("SELECT transportUnit.tu_id AS 'Transport Unit ID', transportUnit.tu_desc AS 'Unit Description', tu_status.tu_statusName AS 'Trans Unit Status', driver.dri_name AS 'Driver Name', driver.dri_phoneNo AS 'Driver Phone', assistant.ass_name AS 'Assistant Name', assistant.ass_phoneNo AS 'Assistant Phone', container.con_name AS 'Container Name', lorry.lorry_name AS 'Lorry Name', lorry.lorry_number AS 'Lorry Number' FROM transportUnit INNER JOIN driver ON transportUnit.dri_id_fk = driver.dri_id INNER JOIN assistant ON transportUnit.ass_id_fk = assistant.ass_id INNER JOIN container ON transportUnit.con_id_fk = container.con_id INNER JOIN lorry ON transportUnit.lorry_id_fk = lorry.lorry_id INNER JOIN tu_status ON transportUnit.tu_status_fk = tu_status.tu_status_id WHERE transportUnit.tu_id = '" + transportUnitBox.SelectedValue.ToString() + "' ");

                lblContainerName.Text = transDetails.Rows[0]["Container Name"].ToString();

                lblLorryName.Text = transDetails.Rows[0]["Lorry Name"].ToString();

                lblStatus.Text = transDetails.Rows[0]["Trans Unit Status"].ToString();
            }
            else
            {
                grpBoxSelectedTu.Hide();
            }
        }
    }
}
