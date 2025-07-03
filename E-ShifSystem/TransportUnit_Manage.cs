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
    public partial class TransportUnit_Manage : Form
    {
        public TransportUnit_Manage()
        {
            InitializeComponent();
        }

        private String select_transUnitID;
        private String currentStatus;

        private void tableLoad()
        {
            String sql = @"SELECT transportUnit.tu_id AS 'Transport Unit ID', transportUnit.tu_desc AS 'Unit Description', tu_status.tu_statusName AS 'Trans Unit Status', driver.dri_name AS 'Driver Name', driver.dri_phoneNo AS 'Driver Phone', assistant.ass_name AS 'Assistant Name', assistant.ass_phoneNo AS 'Assistant Phone', container.con_id AS 'Container Name', lorry.lorry_name AS 'Lorry Name', lorry.lorry_number AS 'Lorry Number' FROM transportUnit INNER JOIN driver ON transportUnit.dri_id_fk = driver.dri_id INNER JOIN assistant ON transportUnit.ass_id_fk = assistant.ass_id INNER JOIN container ON transportUnit.con_id_fk = container.con_id INNER JOIN lorry ON transportUnit.lorry_id_fk = lorry.lorry_id INNER JOIN tu_status ON transportUnit.tu_status_fk = tu_status.tu_status_id ";

            CommonFunctions.DataTableLoadFun(sql, transportUnitDataTable);
        }

        private void TransportUnit_Manage_Load(object sender, EventArgs e)
        {
            tableLoad();

            lblSelectedTransID.Text = "None";

            controlGroupBox.Hide();
        }

        private void transportUnitDataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                select_transUnitID = transportUnitDataTable.Rows[index].Cells["Transport Unit ID"].Value.ToString();
                currentStatus = transportUnitDataTable.Rows[index].Cells["Trans Unit Status"].Value.ToString();

                lblSelectedTransID.Text = select_transUnitID;
                if (currentStatus == "Available")
                {
                    tuStatusBtn.Checked = true;
                    controlGroupBox.Show();
                }
                else if (currentStatus == "Not Available")
                {
                    tuStatusBtn.Checked = false;
                    controlGroupBox.Show();
                }

                /*controlGroupBox.Hide();*/


            }
            catch (Exception ex)
            {
                MessageBox.Show("Opopss Error!!!! \nProbably you had selected the invalid data row \nError Description:" + ex.Message);
            }
        }

        private void searchFun()
        {
            if (searchBar.Text != "")
            {
                String sql = "SELECT transportUnit.tu_id AS 'Transport Unit ID', transportUnit.tu_desc AS ' Unit Description', driver.dri_name AS 'Driver Name', driver.dri_phoneNo AS 'Driver Phone', assistant.ass_name AS 'Assistant Name', assistant.ass_phoneNo AS 'Assistant Phone', container.con_id AS 'Container Name', lorry.lorry_name AS 'Lorry Name', lorry.lorry_number AS 'Lorry Number' FROM transportUnit INNER JOIN driver ON transportUnit.dri_id_fk = driver.dri_id INNER JOIN assistant ON transportUnit.ass_id_fk = assistant.ass_id INNER JOIN container ON transportUnit.con_id_fk = container.con_id INNER JOIN lorry ON transportUnit.lorry_id_fk = lorry.lorry_id WHERE transportUnit.tu_id = '" + searchBar.Text + "'";

                CommonFunctions.DataTableLoadFun(sql, transportUnitDataTable);
            }
            else
            {
                tableLoad();
            }
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            searchFun();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchFun();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (select_transUnitID == null)
            {
                MessageBox.Show("No Assistant ID Selected");
            }
            else
            {
                CommonFunctions.deleteFun("DELETE FROM transportUnit WHERE tu_id= '" + select_transUnitID + "'");
                tableLoad();
            }
        }

        private void lblSelectedTransID_Click(object sender, EventArgs e)
        {
            lblSelectedTransID.Text = "None";
            select_transUnitID = null;
        }

        private void changeStatus_Click(object sender, EventArgs e)
        {

        }

        private void tuStatusBtn_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void tuStatusBtn_Click(object sender, EventArgs e)
        {
            if (tuStatusBtn.Checked == true)
            {
                // Update the Status to Available
                CommonFunctions.updateFunWithoutMsgBox("UPDATE transportUnit SET tu_status_fk = 1 WHERE tu_id = '" + select_transUnitID + "'");
                tableLoad();
            }

            if (tuStatusBtn.Checked == false)
            {
                // Update the Status to Not Available
                CommonFunctions.updateFunWithoutMsgBox("UPDATE transportUnit SET tu_status_fk = 2 WHERE tu_id = '" + select_transUnitID + "'");
                tableLoad();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
