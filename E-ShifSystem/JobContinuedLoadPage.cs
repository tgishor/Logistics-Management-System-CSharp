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
    public partial class JobContinuedLoadPage : Form
    {

        private int selected_jobID;
        private String selected_loadID;

        List<ComboBox> comboBoxList;
        List<TextBox> textBoxList;

        public JobContinuedLoadPage(int jobID)
        {
            InitializeComponent();
            selected_jobID = jobID; 

        }

        private void tableLoad()
        {
            String sql = "SELECT load.l_id AS 'Load ID', good.good_name 'Good Name', load.quantity 'Goods Quantity' FROM load INNER JOIN good ON load.good_id_fk = good.good_id WHERE load.j_id_fk = '"+ selected_jobID + "'";

            CommonFunctions.DataTableLoadFun(sql, loadDataTable);
        }

        private void JobContinuedLoadPage_Load(object sender, EventArgs e)
        {

            if (selected_jobID < 1 || selected_jobID == null)
            {
                this.Hide();
                new Job_Manage().Show();
            }

            lblSelectedJobID.Text = selected_jobID.ToString();

            CommonFunctions.DataComboBox("SELECT * FROM good", goodBox, "good_name", "good_id");

            tableLoad();

            comboBoxList = new List<ComboBox>(){
                goodBox
            };

            textBoxList = new List<TextBox>(){
                quantityBox
            };
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (CommonFunctions.validate(comboBoxList) && CommonFunctions.checkComoboBoxData(comboBoxList))
            {
                CommonFunctions.insertFun("INSERT INTO load (quantity, j_id_fk, good_id_fk) VALUES ('"+quantityBox.Text+"', '"+ selected_jobID + "', '"+goodBox.SelectedValue.ToString()+ "');");

                tableLoad();

                CommonFunctions.resetAllTextBoxes(textBoxList);
                CommonFunctions.resetAllTextBoxes(comboBoxList);
            }
            else
            {
                MessageBox.Show("Please fill all the required boxes");
            }
        }

        private void proceedBtn_Click(object sender, EventArgs e)
        {
            MainPanel.OpenChildForm(new Payment_Create(selected_jobID));
        }

        private void holdBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment On Hold");
            MainPanel.OpenChildForm(new Job_Manage());
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (selected_loadID == null)
            {
                MessageBox.Show("No Load ID Selected");
            }
            else
            {
                CommonFunctions.deleteFun("DELETE FROM load WHERE l_id= '" + selected_loadID + "'");
                tableLoad();
            }
        }

        private void loadDataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                selected_loadID = loadDataTable.Rows[index].Cells["Load ID"].Value.ToString();

                lblSelectedLoadID.Text = selected_loadID;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Opopss Error!!!! \nProbably you had selected the invalid data row \nError Description:" + ex.Message);
            }
        }
    }
}
