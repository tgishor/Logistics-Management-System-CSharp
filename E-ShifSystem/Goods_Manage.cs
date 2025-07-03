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
    public partial class Goods_Manage : Form
    {
        public Goods_Manage()
        {
            InitializeComponent();
        }

        private string select_goodID;

        List<ComboBox> comboBoxList;
        List<TextBox> textBoxList;

        private void tableLoad()
        {
            String sql = "SELECT good.good_id AS 'Good ID', good.good_name AS 'Good Name', good.good_initailAmount AS 'Good Initial Amount', goodType.goodType AS 'Good Type'  FROM good INNER JOIN goodType ON good.goodType_id_fk = goodType.goodType_id;";

            CommonFunctions.DataTableLoadFun(sql, goodDataTable);
        }

        private void Goods_Manage_Load(object sender, EventArgs e)
        {
            CommonFunctions.DataComboBox("SELECT * FROM goodType", goodTypeBox, "goodType", "goodType_id");

            tableLoad();

            goodTypeBox.SelectedItem = null;

            lblSelectedGoodID.Text = "None";


            // Declaring List of TextBox and List of ComboBox
            textBoxList = new List<TextBox>(){
                goodNameBox, initalAmountBox
            };

            comboBoxList = new List<ComboBox>(){
                goodTypeBox
            };
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Validating If all the textboxes are available
            if (CommonFunctions.validate(textBoxList) && CommonFunctions.validate(comboBoxList) && CommonFunctions.checkComoboBoxData(comboBoxList))
            {
                CommonFunctions.insertFun("INSERT INTO good (good_name, good_initailAmount, goodType_id_fk) VALUES ('" + goodNameBox.Text+"', '"+initalAmountBox.Text+"', '"+goodTypeBox.SelectedValue.ToString()+"')");

                tableLoad();

                CommonFunctions.resetAllTextBoxes(textBoxList);
                CommonFunctions.resetAllTextBoxes(comboBoxList);

            }
            else
            {
                MessageBox.Show("Please fill all the required boxes");
            }

            
        }

        private void goodDataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                select_goodID = goodDataTable.Rows[index].Cells["Good ID"].Value.ToString();
                string good_name = goodDataTable.Rows[index].Cells["Good Name"].Value.ToString();
                string good_amount = goodDataTable.Rows[index].Cells["Good Initial Amount"].Value.ToString();
                string good_type = goodDataTable.Rows[index].Cells["Good Type"].Value.ToString();

                lblSelectedGoodID.Text = select_goodID;
                goodNameBox.Text = good_name;
                initalAmountBox.Text = good_amount;
                goodTypeBox.Text = good_type;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Opopss Error!!!! \nProbably you had selected the invalid data row \nError Description:" + ex.Message);
            }
        }

        private void lblSelectedGoodID_Click(object sender, EventArgs e)
        {
            CommonFunctions.resetAllTextBoxes(textBoxList);
            CommonFunctions.resetAllTextBoxes(comboBoxList);
            lblSelectedGoodID.Text = "None";
            select_goodID = null;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (select_goodID == null)
            {
                MessageBox.Show("No Good ID Selected");
            }
            else
            {
                // Validating If all the textboxes are available
                if (CommonFunctions.validate(textBoxList) && CommonFunctions.validate(comboBoxList) && CommonFunctions.checkComoboBoxData(comboBoxList))
                {
                    CommonFunctions.updateFun("UPDATE good SET good_name = '"+goodNameBox.Text+ "', good_initailAmount = '" + initalAmountBox.Text+ "', goodType_id_fk = '" + goodTypeBox.SelectedValue.ToString() + "'  WHERE good_id = '" + select_goodID+"'");

                    tableLoad();

                    CommonFunctions.resetAllTextBoxes(textBoxList);
                    CommonFunctions.resetAllTextBoxes(comboBoxList);

                }
                else
                {
                    MessageBox.Show("Please fill all the required boxes");
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (select_goodID == null)
            {
                MessageBox.Show("No Good ID Selected");
            }
            else
            {
                CommonFunctions.deleteFun("DELETE FROM good WHERE good_id= '"+ select_goodID +"'");

                tableLoad();

                CommonFunctions.resetAllTextBoxes(textBoxList);
                CommonFunctions.resetAllTextBoxes(comboBoxList);
            }
        }
    }
}
