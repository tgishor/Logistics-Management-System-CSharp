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
    public partial class Customer_Dashboard : Form
    {
        public Customer_Dashboard()
        {
            InitializeComponent();
        }

        private string customerID;
        private void Customer_Dashboard_Load(object sender, EventArgs e)
        {
            lblCusName.Text = CommonFunctions.logedUserInfo.getName + " ("+ CommonFunctions.logedUserInfo.getUsername + ")";
            customerID = CommonFunctions.logedUserInfo.getID;


            DataTable customerDetails1 = CommonFunctions.tableFun("SELECT job.j_id AS 'Job ID', job.j_regDateTime AS 'Reg TimeStamp', job.j_pickLocation AS 'Pickup Location', job.j_dropLocation AS 'Drop Location', job.j_pickDateTime AS 'Pickup Date Time', customer.c_name AS 'Cus Name', customer.c_phoneNo AS 'Cus Phone', jobStatus.jStatus AS 'Job Status', trackStatus.trackingProccess AS 'Tracking Status' FROM job INNER JOIN customer ON job.c_id_fk = customer.c_id  INNER JOIN jobStatus ON job.jobStatus_id_fk = jobStatus.jStatus_id INNER JOIN trackStatus ON job.tracking_id_fk = trackStatus.track_id WHERE customer.c_id ='"+ customerID + "' ");

            int count1 = customerDetails1.Rows.Count;

            if (count1 > 0)
            {
                lblSelectJob.Show();
                jobComboBox.Show();
            }
            else
            {
                lblSelectJob.Hide();
                jobComboBox.Hide();


                lblJobStatus.Text = "Current Job Status: None";

                lblTrackStatus.Text = "Current Track Status: None";

                lblJobDate.Text = "Current Job Date: None";
            }



            CommonFunctions.DataComboBox("SELECT job.j_id AS 'Job ID', job.j_regDateTime AS 'Reg TimeStamp', job.j_pickLocation AS 'Pickup Location', job.j_dropLocation AS 'Drop Location', job.j_pickDateTime AS 'Pickup Date Time', customer.c_name AS 'Cus Name', customer.c_phoneNo AS 'Cus Phone', jobStatus.jStatus AS 'Job Status', trackStatus.trackingProccess AS 'Tracking Status' FROM job INNER JOIN customer ON job.c_id_fk = customer.c_id  INNER JOIN jobStatus ON job.jobStatus_id_fk = jobStatus.jStatus_id INNER JOIN trackStatus ON job.tracking_id_fk = trackStatus.track_id WHERE customer.c_id ='" + customerID + "'", jobComboBox, "Job ID", "Job ID");


            DataTable pendingJobCheck = CommonFunctions.tableFun("SELECT job.j_id AS 'Job ID', job.j_regDateTime AS 'Reg TimeStamp', job.j_pickLocation AS 'Pickup Location', job.j_dropLocation AS 'Drop Location', job.j_pickDateTime AS 'Pickup Date Time', customer.c_name AS 'Cus Name', customer.c_phoneNo AS 'Cus Phone', jobStatus.jStatus AS 'Job Status', trackStatus.trackingProccess AS 'Tracking Status' FROM job INNER JOIN customer ON job.c_id_fk = customer.c_id  INNER JOIN jobStatus ON job.jobStatus_id_fk = jobStatus.jStatus_id INNER JOIN trackStatus ON job.tracking_id_fk = trackStatus.track_id WHERE customer.c_id ='" + customerID + "' AND jobStatus.jStatus = 'Waiting For Approval' ");

            lblTotalPendingJobs.Text = pendingJobCheck.Rows.Count.ToString();

            


            DataTable jobAndCus = CommonFunctions.tableFun("SELECT * FROM job WHERE c_id_fk = '"+customerID+"' ");

            int totalRemainingPayable = 0;

            foreach (DataRow row in jobAndCus.Rows)
            {

                int singleTotalPay = CommonFunctions.calculateRemainingPayment(row["j_id"].ToString());

                totalRemainingPayable = singleTotalPay + totalRemainingPayable;
            }

            lblRemainingPayAmount.Text = totalRemainingPayable.ToString();

        }

        private void idJobLoadData()
        {
            DataTable customerDetails = CommonFunctions.tableFun("SELECT job.j_id AS 'Job ID', job.j_regDateTime AS 'Reg TimeStamp', job.j_pickLocation AS 'Pickup Location', job.j_dropLocation AS 'Drop Location', job.j_pickDateTime AS 'Pickup Date Time', customer.c_name AS 'Cus Name', customer.c_phoneNo AS 'Cus Phone', jobStatus.jStatus AS 'Job Status', trackStatus.trackingProccess AS 'Tracking Status' FROM job INNER JOIN customer ON job.c_id_fk = customer.c_id  INNER JOIN jobStatus ON job.jobStatus_id_fk = jobStatus.jStatus_id INNER JOIN trackStatus ON job.tracking_id_fk = trackStatus.track_id WHERE customer.c_id ='" + customerID + "' AND job.j_id = '"+jobComboBox.SelectedValue.ToString()+"' ");

            int count = customerDetails.Rows.Count;

            if (count > 0)
            {
                lblJobStatus.Text = "Current Job Status: " + customerDetails.Rows[0]["Job Status"].ToString();

                lblTrackStatus.Text = "Current Track Status: " + customerDetails.Rows[0]["Tracking Status"].ToString();

                lblJobDate.Text = "Current Job Date: " + customerDetails.Rows[0]["Pickup Date Time"].ToString();
            }
            else
            {
                lblJobStatus.Text = "Current Job Status: None";

                lblTrackStatus.Text = "Current Track Status: None";

                lblJobDate.Text = "Current Job Date: None";
            }

        }

        private void jobComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            idJobLoadData();
        }
    }
}
