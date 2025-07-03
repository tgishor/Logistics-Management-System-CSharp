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
    public partial class Driver_Manage : Form
    {
        public Driver_Manage()
        {
            InitializeComponent();
        }


        private string select_driverID;

        List<ComboBox> comboBoxList;
        List<TextBox> textBoxList;


        private void tableLoad()
        {
            String sql = "SELECT driver.dri_id AS 'Driver ID', driver.dri_name AS 'Driver Name', driver.dri_licenseNo AS 'Driver License No', driver.dri_phoneNo AS 'Driver Phone', driver.dri_nic AS 'Driver NIC' ,gender.gender_name AS 'Driver Gender' FROM driver INNER JOIN gender ON driver.gender_id_fk = gender.gender_id";

            CommonFunctions.DataTableLoadFun(sql, driverDataTable);
        }

        private void Driver_Manage_Load(object sender, EventArgs e)
        {
            CommonFunctions.DataComboBox("SELECT * FROM gender", genderBox, "gender_name", "gender_id");

            tableLoad();

            genderBox.SelectedItem = null;

            lblSelectedDriverID.Text = "None";


            // Declaring List of TextBox and List of ComboBox
            textBoxList = new List<TextBox>(){
                driNameBox, driLicenseNo, driNIC, driPhoneNo
            };

            comboBoxList = new List<ComboBox>(){
                genderBox
            };
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Validating If all the textboxes are available
            if (CommonFunctions.validate(textBoxList) && CommonFunctions.validate(comboBoxList) && CommonFunctions.checkComoboBoxData(comboBoxList))
            {
                CommonFunctions.insertFun("INSERT INTO driver (dri_name, dri_licenseNo, dri_phoneNo, dri_nic, gender_id_fk) VALUES ('" + driNameBox.Text + "', '" + driLicenseNo.Text + "', '" + driPhoneNo.Text + "', '" + driNIC.Text + "' ,'" + genderBox.SelectedValue.ToString() + "' ) ");

                tableLoad();

                CommonFunctions.resetAllTextBoxes(textBoxList);
            }
            else
            {
                MessageBox.Show("Please fill all the required boxes");
            }


        }

        private void driverDataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                select_driverID = driverDataTable.Rows[index].Cells["Driver ID"].Value.ToString();
                string Name = driverDataTable.Rows[index].Cells["Driver Name"].Value.ToString();
                string LicenseNo = driverDataTable.Rows[index].Cells["Driver License No"].Value.ToString();
                string Phone = driverDataTable.Rows[index].Cells["Driver Phone"].Value.ToString();
                string NIC = driverDataTable.Rows[index].Cells["Driver NIC"].Value.ToString();
                string Gender = driverDataTable.Rows[index].Cells["Driver Gender"].Value.ToString();

                lblSelectedDriverID.Text = select_driverID;
                driNameBox.Text = Name;
                driLicenseNo.Text = LicenseNo;
                driPhoneNo.Text = Phone;
                driNIC.Text = NIC;
                genderBox.Text = Gender;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Opopss Error!!!! \nProbably you had selected the invalid data row \nError Description:" + ex.Message);
            }
        }

        private void lblSelectedDriverID_Click(object sender, EventArgs e)
        {
            CommonFunctions.resetAllTextBoxes(textBoxList);
            lblSelectedDriverID.Text = "None";
            select_driverID = null;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (select_driverID == null)
            {
                MessageBox.Show("No Driver ID Selected");
            }
            else
            {
                // Validating If all the textboxes are available
                if (CommonFunctions.validate(textBoxList) && CommonFunctions.validate(comboBoxList) && CommonFunctions.checkComoboBoxData(comboBoxList))
                {
                    CommonFunctions.updateFun("UPDATE driver SET dri_name = '"+driNameBox.Text+"', dri_licenseNo = '"+driLicenseNo.Text+"', dri_phoneNo = '"+driPhoneNo.Text+"', dri_nic = '"+driNIC.Text+"' , gender_id_fk = '" + genderBox.SelectedValue.ToString() + "'  WHERE dri_id = '" + select_driverID + "'");

                    tableLoad();

                    CommonFunctions.resetAllTextBoxes(textBoxList);

                }
                else
                {
                    MessageBox.Show("Please fill all the required boxes");
                }
                
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (select_driverID == null)
            {
                MessageBox.Show("No Driver ID Selected");
            }
            else
            {
                CommonFunctions.deleteFun("DELETE FROM driver WHERE dri_id= '" + select_driverID + "'");

                tableLoad();

                CommonFunctions.resetAllTextBoxes(textBoxList);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
