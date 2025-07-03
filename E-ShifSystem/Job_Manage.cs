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
    public partial class Job_Manage : Form
    {
        public Job_Manage()
        {
            InitializeComponent();
        }

        private string select_jobID;

        private void tableLoad()
        {
            String sql = "SELECT job.j_id AS 'Job ID', job.j_regDateTime AS 'Reg TimeStamp', job.j_pickLocation AS 'Pickup Location', job.j_dropLocation AS 'Drop Location', job.j_pickDateTime AS 'Drop Location', customer.c_name AS 'Cus Name', customer.c_phoneNo AS 'Cus Phone', jobStatus.jStatus AS 'Job Status', trackStatus.trackingProccess AS 'Tracking Status' FROM job INNER JOIN customer ON job.c_id_fk = customer.c_id  INNER JOIN jobStatus ON job.jobStatus_id_fk = jobStatus.jStatus_id INNER JOIN trackStatus ON job.tracking_id_fk = trackStatus.track_id";

            CommonFunctions.DataTableLoadFun(sql, jobDataTable);
        }

        private void Job_Manage_Load(object sender, EventArgs e)
        {

            tableLoad();

            lblSelectedJobID.Text = "None";

        }

        private void jobDataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int index = e.RowIndex;
                select_jobID = jobDataTable.Rows[index].Cells["Job ID"].Value.ToString();

                lblSelectedJobID.Text = select_jobID;
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
                String sql = "SELECT job.j_id AS 'Job ID', job.j_regDateTime AS 'Reg TimeStamp', job.j_pickLocation AS 'Pickup Location', job.j_dropLocation AS 'Drop Location', job.j_pickDateTime AS 'Pickup DateTime', customer.c_name AS 'Cus Name', customer.c_phoneNo AS 'Cus Phone', jobStatus.jStatus AS 'Job Status', trackStatus.trackingProccess AS 'Tracking Status' FROM job INNER JOIN customer ON job.c_id_fk = customer.c_id  INNER JOIN jobStatus ON job.jobStatus_id_fk = jobStatus.jStatus_id INNER JOIN trackStatus ON job.tracking_id_fk = trackStatus.track_id  WHERE customer.c_id = '" + searchBox.Text + "'";

                CommonFunctions.DataTableLoadFun(sql, jobDataTable);
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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (select_jobID == null)
            {
                MessageBox.Show("No Job ID Selected");
            }
            else
            {
                MainPanel.OpenChildForm(new Job_Update(select_jobID));
            }
        }

        private void generateReportBtn_Click(object sender, EventArgs e)
        {
            MainPanel.OpenChildForm(new Job_Report());
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Job Delete Successfully");
        }
    }
}
