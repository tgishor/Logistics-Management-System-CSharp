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
    public partial class TransportUnit_Create : Form
    {
        public TransportUnit_Create()
        {
            InitializeComponent();
        }

        List<ComboBox> comboBoxList;
        List<TextBox> textBoxList;

        private void tableLoad()
        {
            String sql = "SELECT transportUnit.tu_id AS 'Transport Unit ID', transportUnit.tu_desc AS ' Unit Description', driver.dri_name AS 'Driver Name', driver.dri_phoneNo AS 'Driver Phone', assistant.ass_name AS 'Assistant Name', assistant.ass_phoneNo AS 'Assistant Phone', container.con_id AS 'Container Name', lorry.lorry_name AS 'Lorry Name', lorry.lorry_number AS 'Lorry Number' FROM transportUnit INNER JOIN driver ON transportUnit.dri_id_fk = driver.dri_id INNER JOIN assistant ON transportUnit.ass_id_fk = assistant.ass_id INNER JOIN container ON transportUnit.con_id_fk = container.con_id INNER JOIN lorry ON transportUnit.lorry_id_fk = lorry.lorry_id ";

            CommonFunctions.DataTableLoadFun(sql, transportUnitDataTable);
        }


        

        private void TransportUnit_Create_Load(object sender, EventArgs e)
        {
            CommonFunctions.DataComboBox("SELECT * FROM lorry", lorryBox, "lorry_name", "lorry_id");
            CommonFunctions.DataComboBox("SELECT * FROM container", containerBox, "con_name", "con_id");
            CommonFunctions.DataComboBox("SELECT * FROM driver", driverBox, "dri_name", "dri_id");
            CommonFunctions.DataComboBox("SELECT * FROM assistant", assistantBox, "ass_name", "ass_id");
            tableLoad();

            lorryBox.SelectedItem = null;
            containerBox.SelectedItem = null;
            driverBox.SelectedItem = null;
            assistantBox.SelectedItem = null;


            // Declaring List of TextBox and List of ComboBox
            textBoxList = new List<TextBox>(){
                descBox
            };

            comboBoxList = new List<ComboBox>(){
                lorryBox, containerBox, driverBox, assistantBox
            };
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Validating If all the textboxes are available
            if (CommonFunctions.validate(textBoxList) && CommonFunctions.validate(comboBoxList) && CommonFunctions.checkComoboBoxData(comboBoxList))
            {
                CommonFunctions.insertFun("INSERT INTO transportUnit (tu_desc, dri_id_fk, ass_id_fk, con_id_fk, lorry_id_fk) VALUES ('"+descBox.Text+"', '"+driverBox.SelectedValue.ToString()+ "','" + assistantBox.SelectedValue.ToString() + "','" + containerBox.SelectedValue.ToString() + "', '" + lorryBox.SelectedValue.ToString() + "') ");

                tableLoad();

            }
            else
            {
                MessageBox.Show("Please fill all the required boxes");
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            CommonFunctions.resetAllTextBoxes(textBoxList);
            CommonFunctions.resetAllTextBoxes(comboBoxList);

        }

        private void searchFun()
        {
            String sql = "SELECT transportUnit.tu_id AS 'Transport Unit ID', transportUnit.tu_desc AS ' Unit Description', driver.dri_name AS 'Driver Name', driver.dri_phoneNo AS 'Driver Phone', assistant.ass_name AS 'Assistant Name', assistant.ass_phoneNo AS 'Assistant Phone', container.con_id AS 'Container Name', lorry.lorry_name AS 'Lorry Name', lorry.lorry_number AS 'Lorry Number' FROM transportUnit INNER JOIN driver ON transportUnit.dri_id_fk = driver.dri_id INNER JOIN assistant ON transportUnit.ass_id_fk = assistant.ass_id INNER JOIN container ON transportUnit.con_id_fk = container.con_id INNER JOIN lorry ON transportUnit.lorry_id_fk = lorry.lorry_id WHERE transportUnit.tu_id = '" + searchBar.Text + "'";

            CommonFunctions.DataTableLoadFun(sql, transportUnitDataTable);
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            searchFun();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchFun();
        }
    }
}
