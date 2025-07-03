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
    public partial class Customer_Manage : Form
    {
        public Customer_Manage()
        {
            InitializeComponent();
        }

        private string select_cusID;

        private void tableLoad()
        {
            String sql = "SELECT customer.c_id AS 'Customer ID', customer.c_name AS 'Customer Name', customer.c_nic AS 'Customer NIC', customer.c_address AS 'Customer Address', customer.c_phoneNo AS 'Customer Phone No', city.city_name AS 'Customer District' FROM customer INNER JOIN city ON customer.city_id_fk = city.city_id";

            CommonFunctions.DataTableLoadFun(sql, customerDataTable);
        }

        private void Customer_Manage_Load(object sender, EventArgs e)
        {
            tableLoad();  // This function is used to add the data to the data grid view
        }
        private void customerDataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                select_cusID = customerDataTable.Rows[index].Cells["Customer ID"].Value.ToString();

                customerIDLoad.Text = select_cusID;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Opopss Error!!!! \nProbably you had selected the invalid data row \nError Description:" + ex.Message);
            }
        }

        private void updateNavBtn_Click(object sender, EventArgs e)
        {
            if(select_cusID == null)
            {
                MessageBox.Show("No Customer ID Selected");
            }
            else
            {
                this.Hide();

                // Selected Customer ID sent with the construstor to the Customer_Update Form
                MainPanel.OpenChildForm(new Customer_Update(select_cusID)); 
            }
        }

        // Delet Button Function 
        private void deleteBtn_Click(object sender, EventArgs e)
        {   
            if (select_cusID == null)
            {
                MessageBox.Show("No Customer ID Selected");
            }
            else
            {
                // Delete customer record based on the selected customer ID 
                CommonFunctions.deleteFun("DELETE FROM customer WHERE c_id= '" + select_cusID + "'"); 

                tableLoad(); // Reloading the Data Grid View
            }
        }


        private void searchFun()
        {
            String sql = "SELECT customer.c_id AS 'Customer ID', customer.c_name AS 'Customer Name', customer.c_nic AS 'Customer NIC', customer.c_address AS 'Customer Address', customer.c_phoneNo AS 'Customer Phone No', city.city_name AS 'Customer District' FROM customer INNER JOIN city ON customer.city_id_fk = city.city_id WHERE customer.c_name LIKE '%" + searchBox.Text + "%'";

            CommonFunctions.DataTableLoadFun(sql, customerDataTable);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchFun();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            searchFun();
        }

        private void customerDataTable_DoubleClick(object sender, EventArgs e)
        {
            
        }
        
    }
}
