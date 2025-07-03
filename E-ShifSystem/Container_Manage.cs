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
    public partial class Container_Manage : Form
    {
        public Container_Manage()
        {
            InitializeComponent();
        }

        private string select_containerID;

        private void tableLoad()
        {
            String sql = "SELECT con_id AS 'Container ID', con_name AS 'Container Name' FROM container";

            CommonFunctions.DataTableLoadFun(sql, containerDataTable);


        }

        private void Container_Manage_Load(object sender, EventArgs e)
        {
            tableLoad();

            lblSelectedContainerID.Text = "None";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Validating If all the textboxes are available
            if (CommonFunctions.validate(new List<TextBox>(){
                containerNameBox
            }))
            {
                CommonFunctions.insertFun("INSERT INTO container (con_name ) VALUES ('" + containerNameBox.Text + "' ) ");
                tableLoad();
            }
            else
            {
                MessageBox.Show("Please fill all the required boxes");
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (select_containerID == null)
            {
                MessageBox.Show("No Container ID Selected");
            }
            else
            {
                CommonFunctions.updateFun("UPDATE container SET con_name = '" + containerNameBox.Text + "' WHERE con_id = '" + select_containerID + "'");
                tableLoad();
            }
        }

        private void containerDataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                select_containerID = containerDataTable.Rows[index].Cells["Container ID"].Value.ToString();
                string container_name = containerDataTable.Rows[index].Cells["Container Name"].Value.ToString();

                lblSelectedContainerID.Text = select_containerID;
                containerNameBox.Text = container_name;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Opopss Error!!!! \nProbably you had selected the invalid data row \nError Description:"+ex.Message);
            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (select_containerID == null)
            {
                MessageBox.Show("No Container ID Selected");
            }
            else
            {
                CommonFunctions.deleteFun("DELETE FROM container WHERE con_id= '" + select_containerID + "'");
                tableLoad();
            }
        }

        private void lblSelectedContainerID_Click(object sender, EventArgs e)
        {
            containerNameBox.ResetText();
            lblSelectedContainerID.Text = "None";
            select_containerID = null;
        }
    }
}
