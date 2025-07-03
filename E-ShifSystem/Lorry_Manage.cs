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
    public partial class Lorry_Manage : Form
    {
        public Lorry_Manage()
        {
            InitializeComponent();
        }

        private string select_lorryID;

        List<ComboBox> comboBoxList;
        List<TextBox> textBoxList;


        private void tableLoad()
        {
            String sql = "SELECT lorry.lorry_id AS 'Lorry ID', lorry.lorry_name AS 'Lorry Name' , lorry.lorry_number AS 'Lorry Number', lorryType.lorryType_name AS 'Lorry Type' FROM lorry INNER JOIN lorryType ON lorry.lorryType_id_fk = lorryType.lorryType_id";

            CommonFunctions.DataTableLoadFun(sql, lorryDataTable);
        }

        private void Lorry_Manage_Load(object sender, EventArgs e)
        {
            CommonFunctions.DataComboBox("SELECT * FROM lorryType", lorryTypeBox, "lorryType_name", "lorryType_id");

            tableLoad();

            lorryTypeBox.SelectedItem = null;

            lblSelectedLorryID.Text = "None";


            // Declaring List of TextBox and List of ComboBox
            textBoxList = new List<TextBox>(){
               lorryNameBox,lorryNumBox
            };

            comboBoxList = new List<ComboBox>(){
                lorryTypeBox
            };

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Validating If all the textboxes are available
            if (CommonFunctions.validate(textBoxList) && CommonFunctions.validate(comboBoxList) && CommonFunctions.checkComoboBoxData(comboBoxList))
            {
                CommonFunctions.insertFun("INSERT INTO lorry (lorry_name, lorry_number, lorryType_id_fk) VALUES ('"+lorryNameBox.Text+"', '"+lorryNumBox.Text+"', '"+lorryTypeBox.SelectedValue.ToString()+"') ");

                tableLoad();

                CommonFunctions.resetAllTextBoxes(textBoxList);
            }
            else
            {
                MessageBox.Show("Please fill all the required boxes");
            }
        }

        private void lorryDataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                select_lorryID = lorryDataTable.Rows[index].Cells["Lorry ID"].Value.ToString();
                string l_name = lorryDataTable.Rows[index].Cells["Lorry Name"].Value.ToString();
                string l_number = lorryDataTable.Rows[index].Cells["Lorry Number"].Value.ToString();
                string l_type = lorryDataTable.Rows[index].Cells["Lorry Type"].Value.ToString();

                lblSelectedLorryID.Text = select_lorryID;
                lorryNameBox.Text = l_name;
                lorryNumBox.Text = l_number;
                lorryTypeBox.Text = l_type;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Opopss Error!!!! \nProbably you had selected the invalid data row \nError Description:" + ex.Message);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (select_lorryID == null)
            {
                MessageBox.Show("No Lorry ID Selected");
            }
            else
            {
                // Validating If all the textboxes are available
                if (CommonFunctions.validate(textBoxList) && CommonFunctions.validate(comboBoxList) && CommonFunctions.checkComoboBoxData(comboBoxList))
                {
                    CommonFunctions.updateFun("UPDATE lorry SET lorry_name='"+lorryNameBox.Text+"', lorry_number='"+lorryNumBox.Text+"', lorryType_id_fk='"+lorryTypeBox.SelectedValue.ToString()+"' WHERE lorry_id = '" + select_lorryID + "'");

                    tableLoad();

                    CommonFunctions.resetAllTextBoxes(textBoxList);

                }
                else
                {
                    MessageBox.Show("Please fill all the required boxes");
                }


            }
        }

        private void lblSelectedLorryID_Click(object sender, EventArgs e)
        {
            CommonFunctions.resetAllTextBoxes(textBoxList);
            lblSelectedLorryID.Text = "None";
            select_lorryID = null;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (select_lorryID == null)
            {
                MessageBox.Show("No Lorry ID Selected");
            }
            else
            {
                CommonFunctions.deleteFun("DELETE FROM lorry WHERE lorry_id= '" + select_lorryID + "'");

                tableLoad();

                CommonFunctions.resetAllTextBoxes(textBoxList);
            }
        }
    }
}
