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
    public partial class Payment_Manage : Form
    {
        public Payment_Manage()
        {
            InitializeComponent();
        }

        private string select_paytID;
        private string selected_jobID;
        private void tableLoad()
        {
            String sql = "SELECT p_id AS 'Payment ID', job.j_id AS 'Job ID' , p_date AS 'Payment Date', p_amount AS 'Payment Amount', paymentType.pType AS 'Payment Type', customer.c_name AS 'Customer Name', customer.c_phoneNo AS 'Customer Phone' FROM payment INNER JOIN job ON payment.j_id_fk = job.j_id INNER JOIN customer ON job.c_id_fk = customer.c_id INNER JOIN paymentType ON payment.pType_id_fk = paymentType.pType_id";

            CommonFunctions.DataTableLoadFun(sql, payDataTable);
        }


        private void Payment_Manage_Load(object sender, EventArgs e)
        {
            tableLoad();
        }

        private void payDataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                select_paytID = payDataTable.Rows[index].Cells["Payment ID"].Value.ToString();

                selected_jobID = payDataTable.Rows[index].Cells["Job ID"].Value.ToString();

                lblSelectedPayID.Text = select_paytID;

                lblJobID.Text = selected_jobID;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Opopss Error!!!! \nProbably you had selected the invalid data row \nError Description:" + ex.Message);
            }
        }

        private void searchFun()
        {
            if (searchBox.Text != "")
            {
                String sql = "SELECT p_id AS 'Payment ID', p_date AS 'Payment Date', p_amount AS 'Payment Amount', paymentType.pType AS 'Payment Type', customer.c_name AS 'Customer Name', customer.c_phoneNo AS 'Customer Phone' FROM payment INNER JOIN job ON payment.j_id_fk = job.j_id INNER JOIN customer ON job.c_id_fk = customer.c_id INNER JOIN paymentType ON payment.pType_id_fk = paymentType.pType_id WHERE payment.p_id = '" + searchBox.Text + "'";

                CommonFunctions.DataTableLoadFun(sql, payDataTable);
            }
            else
            {
                tableLoad();
            }

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            searchFun();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchFun();
        }

        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.allowOnlyNumberChar(sender,e);
        }

        private void deletBtn_Click(object sender, EventArgs e)
        {
            if (select_paytID == null)
            {
                MessageBox.Show("No Payment ID Selected");
            }
            else
            {
                CommonFunctions.deleteFun("DELETE FROM payment WHERE p_id= '" + select_paytID + "'");
                tableLoad();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (select_paytID == null)
            {
                MessageBox.Show("No Payment ID Selected");
            }
            else
            {
                this.Hide();
                new Payment_Update(select_paytID).Show();
            }
            
        }

        private void printBillBtn_Click(object sender, EventArgs e)
        {
            if (selected_jobID == null)
            {
                MessageBox.Show("No Job ID Selected");
            }
            else
            {
                new PaymentBill(selected_jobID).Show();
            }
        }
    }
}
