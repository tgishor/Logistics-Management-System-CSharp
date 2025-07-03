using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_ShifSystem
{
    public partial class Customer_Report : Form
    {
        public Customer_Report()
        {
            InitializeComponent();
        }

        private void tableLoad()
        {
            String sql = "SELECT customer.c_id AS 'Customer ID', customer.c_name AS 'Customer Name', customer.c_nic AS 'Customer NIC', customer.c_address AS 'Customer Address', customer.c_phoneNo AS 'Customer Phone No', city.city_name AS 'Customer District' FROM customer INNER JOIN city ON customer.city_id_fk = city.city_id";

            CommonFunctions.DataTableLoadFun(sql, customerDataTable);


        }

        private void Customer_Report_Load(object sender, EventArgs e)
        {
            tableLoad();
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {

            /*DataTable dataTable;

            List<string[]> MyStringArrays = new List<string[]>();
            foreach (var row in datatable.rows)//or similar
            {
                MyStringArrays.Add(new string[] { row.Name, row.Address, row.Age.ToString() });
            }*/

        }


    }
}
