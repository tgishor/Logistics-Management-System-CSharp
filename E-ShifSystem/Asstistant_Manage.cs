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
    public partial class Asstistant_Manage : Form
    {
        public Asstistant_Manage()
        {
            InitializeComponent();
        }

        private string select_assistantID;

        List<ComboBox> comboBoxList;
        List<TextBox> textBoxList;

        private void tableLoad()
        {
            String sql = "SELECT assistant.ass_id AS 'Assistant ID', assistant.ass_name AS 'Assistant Name', assistant.ass_nic AS 'Assistant NIC', assistant.ass_phoneNo AS 'Assistant Phone', gender.gender_name AS 'Assistant Gender' FROM assistant INNER JOIN gender ON assistant.gender_id_fk = gender.gender_id";

            CommonFunctions.DataTableLoadFun(sql, assistantDataTable);
        }

        

        private void Asstistant_Manage_Load(object sender, EventArgs e)
        {
            CommonFunctions.DataComboBox("SELECT * FROM gender", genderBox, "gender_name", "gender_id");

            tableLoad();

            genderBox.SelectedItem = null;

            lblSelectedAssistantID.Text = "None";


            // Declaring List of TextBox and List of ComboBox
            textBoxList = new List<TextBox>(){
                assNameBox, assNicBox, assPhoneBox
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
                CommonFunctions.insertFun("INSERT INTO assistant (ass_name, ass_nic, ass_phoneNo, gender_id_fk) VALUES ('"+ assNameBox.Text +"', '"+ assNicBox.Text +"', '"+ assPhoneBox.Text +"', '"+genderBox.SelectedValue.ToString() +"' ) ");
                tableLoad();

            }
            else
            {
                MessageBox.Show("Please fill all the required boxes");
            }
        }

        private void assistantDataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                select_assistantID = assistantDataTable.Rows[index].Cells["Assistant ID"].Value.ToString();
                string assName = assistantDataTable.Rows[index].Cells["Assistant Name"].Value.ToString();
                string assNIC = assistantDataTable.Rows[index].Cells["Assistant NIC"].Value.ToString();
                string assPhone = assistantDataTable.Rows[index].Cells["Assistant Phone"].Value.ToString();
                string assGender = assistantDataTable.Rows[index].Cells["Assistant Gender"].Value.ToString();

                lblSelectedAssistantID.Text = select_assistantID;
                assNameBox.Text = assName;
                assPhoneBox.Text = assPhone;
                assNicBox.Text = assNIC;
                genderBox.Text = assGender;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Opopss Error!!!! \nProbably you had selected the invalid data row \nError Description:" + ex.Message);
            }
        }

        private void lblSelectedAssistantID_Click(object sender, EventArgs e)
        {
            CommonFunctions.resetAllTextBoxes(textBoxList);
            lblSelectedAssistantID.Text = "None";
            select_assistantID = null;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (select_assistantID == null)
            {
                MessageBox.Show("No Assistant ID Selected");
            }
            else
            {
                // Validating If all the textboxes are available
                if (CommonFunctions.validate(textBoxList) && CommonFunctions.validate(comboBoxList) && CommonFunctions.checkComoboBoxData(comboBoxList))
                {
                    CommonFunctions.updateFun("UPDATE assistant SET ass_name = '" + assNameBox.Text + "', ass_nic = '" + assNicBox.Text + "', ass_phoneNo = '" + assPhoneBox.Text + "' , gender_id_fk = '" + genderBox.SelectedValue.ToString() + "'  WHERE ass_id = '" + select_assistantID + "'");

                    tableLoad();

                }
                else
                {
                    MessageBox.Show("Please fill all the required boxes");
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (select_assistantID == null)
            {
                MessageBox.Show("No Assistant ID Selected");
            }
            else
            {
                CommonFunctions.deleteFun("DELETE FROM assistant WHERE ass_id= '" + select_assistantID + "'");
                tableLoad();
            }
        }
    }
}
