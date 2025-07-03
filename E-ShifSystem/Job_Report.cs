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
    public partial class Job_Report : Form
    {
        public Job_Report()
        {
            InitializeComponent();
        }

        /*private void tableLoad()
        {
            String sql = "SELECT job.j_id AS 'Job ID', job.j_regDateTime AS 'Reg TimeStamp', job.j_pickLocation AS 'Pickup Location', job.j_dropLocation AS 'Drop Location', job.j_pickDateTime AS 'Drop Location', customer.c_name AS 'Cus Name', customer.c_phoneNo AS 'Cus Phone', jobStatus.jStatus AS 'Job Status', trackStatus.trackingProccess AS 'Tracking Status' FROM job INNER JOIN customer ON job.c_id_fk = customer.c_id  INNER JOIN jobStatus ON job.jobStatus_id_fk = jobStatus.jStatus_id INNER JOIN trackStatus ON job.tracking_id_fk = trackStatus.track_id";

            CommonFunctions.DataTableLoadFun(sql, jobDataTable);
        }*/

        private string reportSql = "SELECT job.j_id AS 'Job ID', job.j_regDateTime AS 'Reg TimeStamp', job.j_pickLocation AS 'Pickup Location', job.j_dropLocation AS 'Drop Location', job.j_pickDateTime AS 'Drop Location', customer.c_name AS 'Cus Name', customer.c_phoneNo AS 'Cus Phone', jobStatus.jStatus AS 'Job Status', trackStatus.trackingProccess AS 'Tracking Status' FROM job INNER JOIN customer ON job.c_id_fk = customer.c_id  INNER JOIN jobStatus ON job.jobStatus_id_fk = jobStatus.jStatus_id INNER JOIN trackStatus ON job.tracking_id_fk = trackStatus.track_id WHERE job.j_id != '0' ";

        private void Job_Report_Load(object sender, EventArgs e)
        {
            CommonFunctions.DataTableLoadFun(reportSql, jobDataTable);

            CommonFunctions.DataComboBox("SELECT * FROM jobStatus", jobStatusBox, "jStatus", "jStatus_id");

            CommonFunctions.DataComboBox("SELECT * FROM trackStatus", trackJobBox, "trackingProccess", "track_id");

            jobStatusBox.SelectedItem = null;

            trackJobBox.SelectedItem = null;

            cusNamBox.Text = null;
            
            lblReportGenDate.Text = DateTime.Now.ToString();

        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            reportSql = "SELECT job.j_id AS 'Job ID', job.j_regDateTime AS 'Reg TimeStamp', job.j_pickLocation AS 'Pickup Location', job.j_dropLocation AS 'Drop Location', job.j_pickDateTime AS 'Drop Location', customer.c_name AS 'Cus Name', customer.c_phoneNo AS 'Cus Phone', jobStatus.jStatus AS 'Job Status', trackStatus.trackingProccess AS 'Tracking Status' FROM job INNER JOIN customer ON job.c_id_fk = customer.c_id  INNER JOIN jobStatus ON job.jobStatus_id_fk = jobStatus.jStatus_id INNER JOIN trackStatus ON job.tracking_id_fk = trackStatus.track_id WHERE job.j_id != '0' ";

            if (checkBoxfilterByDate.Checked)
            {
                if (regDateStart.Value != null && regDateEnd.Value != null)
                {
                    reportSql += " AND job.j_regDateTime BETWEEN '" + regDateStart.Value.Date + "' AND '" + regDateEnd.Value.Date + "' ";
                }

                if (pickUpStart.Value != null && pickUpEnd.Value != null)
                {
                    reportSql += " AND job.j_pickDateTime BETWEEN '" + pickUpStart.Value.Date + "' AND '" + pickUpEnd.Value.Date + "' ";
                }
            }

            if (checkBoxfilterByAll.Checked)
            {
                if (jobStatusBox.SelectedValue != null)
                {
                    reportSql += " AND job.jobStatus_id_fk = '" + jobStatusBox.SelectedValue.ToString() + "' ";
                }

                if (trackJobBox.SelectedValue != null)
                {
                    reportSql += " AND job.tracking_id_fk = '" + trackJobBox.SelectedValue.ToString() + "' ";
                }

                if (cusNamBox.Text != "")
                {
                    reportSql += " AND customer.c_name LIKE '%" + cusNamBox.Text + "%' ";
                }
            }
            
            CommonFunctions.DataTableLoadFun(reportSql, jobDataTable);

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            jobStatusBox.SelectedItem = null;

            trackJobBox.SelectedItem = null;

            cusNamBox.Text = null;

            checkBoxfilterByDate.Checked = false;
            checkBoxfilterByAll.Checked = false;    
        }
    }
}
