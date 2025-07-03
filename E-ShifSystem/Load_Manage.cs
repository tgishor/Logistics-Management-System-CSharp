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
    public partial class Load_Manage : Form
    {
        public Load_Manage()
        {
            InitializeComponent();
        }

        private String select_loadID;

        private void tableLoad()
        {
            String sql = "SELECT l_id AS 'Load ID', j_id_fk AS 'Job ID', good.good_name AS 'Good Name', load.quantity AS 'Goods Quantity'  FROM load INNER JOIN good ON load.good_id_fk = good.good_id";

            CommonFunctions.DataTableLoadFun(sql, loadDataTable);
        }

        private void Load_Manage_Load(object sender, EventArgs e)
        {
            tableLoad();

            lblSelectedLoad.Text = "None";
        }

        private void loadDataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                select_loadID = loadDataTable.Rows[index].Cells["Load ID"].Value.ToString();

                lblSelectedLoad.Text = select_loadID;
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
                String sql = "SELECT l_id AS 'Load ID', j_id_fk AS 'Job ID', good.good_name AS 'Good Name', load.quantity AS 'Goods Quantity'  FROM load INNER JOIN good ON load.good_id_fk = good.good_id WHERE load.load_id = '" + searchBar.Text + "'";

                CommonFunctions.DataTableLoadFun(sql, loadDataTable);
            }
            else
            {
                tableLoad();
            }
        }

        private void lblSelectedLoad_Click(object sender, EventArgs e)
        {
            lblSelectedLoad.Text = "None";
            select_loadID = null;
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (select_loadID == null)
            {
                MessageBox.Show("No Load ID Selected");
            }
            else
            {
                CommonFunctions.deleteFun("DELETE FROM load WHERE l_id= '" + select_loadID + "'");
                tableLoad();
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            MainPanel.OpenChildForm(new Load_Create());
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            MainPanel.OpenChildForm(new Load_Create());
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
