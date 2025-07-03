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
    public partial class Load_Create : Form
    {
        public Load_Create()
        {
            InitializeComponent();
        }


        List<ComboBox> comboBoxList;
        List<TextBox> textBoxList;

        private void tableLoad()
        {
            String sql = "SELECT l_id AS 'Load ID', j_id_fk AS 'Job ID', good.good_name AS 'Good Name', load.quantity AS 'Goods Quantity'  FROM load INNER JOIN good ON load.good_id_fk = good.good_id";

            CommonFunctions.DataTableLoadFun(sql, loadDataTable);
        }
        private void Load_Create_Load(object sender, EventArgs e)
        {
            // Declaring List of TextBox and List of ComboBox
            textBoxList = new List<TextBox>(){
                quantityBox
            };

            comboBoxList = new List<ComboBox>(){
                jobBox, goodBox
            };

            CommonFunctions.DataComboBox("SELECT * FROM job", jobBox, "j_id", "j_id");
            CommonFunctions.DataComboBox("SELECT * FROM good", goodBox, "good_name", "good_id");
            tableLoad();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Validating If all the textboxes are available
            if (CommonFunctions.validate(textBoxList) && CommonFunctions.validate(comboBoxList) && CommonFunctions.checkComoboBoxData(comboBoxList))
            {
                CommonFunctions.insertFun(" INSERT INTO load (quantity, j_id_fk, good_id_fk) VALUES ('"+quantityBox.Text+ "','" + jobBox.SelectedValue.ToString() + "','"+goodBox.SelectedValue.ToString()+"') ");

                tableLoad();

                CommonFunctions.resetAllTextBoxes(textBoxList);
                CommonFunctions.resetAllTextBoxes(comboBoxList);
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
    }
}
