using System;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Widget Pending Job

            DataTable dtPendingJob = CommonFunctions.tableFun("SELECT job.j_id AS 'Job ID', job.j_regDateTime AS 'Reg TimeStamp', job.j_pickLocation AS 'Pickup Location', job.j_dropLocation AS 'Drop Location', job.j_pickDateTime AS 'Drop Location', customer.c_name AS 'Cus Name', customer.c_phoneNo AS 'Cus Phone', jobStatus.jStatus AS 'Job Status', trackStatus.trackingProccess AS 'Tracking Status' FROM job INNER JOIN customer ON job.c_id_fk = customer.c_id  INNER JOIN jobStatus ON job.jobStatus_id_fk = jobStatus.jStatus_id INNER JOIN trackStatus ON job.tracking_id_fk = trackStatus.track_id WHERE jobStatus.jStatus = 'Waiting For Approval'");

            int totalPendingJob = dtPendingJob.Rows.Count;

            lblPendingJob.Text = string.Format("{0:00}", totalPendingJob);


            // Widget Job on Service 

            DataTable dtJobOnService = CommonFunctions.tableFun("SELECT job.j_id AS 'Job ID', job.j_regDateTime AS 'Reg TimeStamp', job.j_pickLocation AS 'Pickup Location', job.j_dropLocation AS 'Drop Location', job.j_pickDateTime AS 'Drop Location', customer.c_name AS 'Cus Name', customer.c_phoneNo AS 'Cus Phone', jobStatus.jStatus AS 'Job Status', trackStatus.trackingProccess AS 'Tracking Status' FROM job INNER JOIN customer ON job.c_id_fk = customer.c_id INNER JOIN jobStatus ON job.jobStatus_id_fk = jobStatus.jStatus_id INNER JOIN trackStatus ON job.tracking_id_fk = trackStatus.track_id WHERE trackStatus.trackingProccess != 'Job in Waiting' AND trackStatus.trackingProccess != 'Job Completed' AND trackStatus.trackingProccess != 'Job Cancelled'");

            int totalJobOnService = dtJobOnService.Rows.Count;

            lblJobOnService.Text = string.Format("{0:00}", totalJobOnService); // Function used to add 01,02,03 likewise String Format


            // Widget Available Transport Unit

            DataTable dtAvaTransUnit = CommonFunctions.tableFun("SELECT * FROM transportUnit INNER JOIN tu_status ON transportUnit.tu_status_fk = tu_status.tu_status_id WHERE tu_status.tu_statusName = 'Available'");

            int totalTransUnit = dtAvaTransUnit.Rows.Count;

            lblAvailableTransUnit.Text = string.Format("{0:00}", totalTransUnit); // Function used to add 01,02,03 likewise String Format

            chartTotalRevenue.Show();
            revenueChartFill();
            orderChartFill();
        }

        private void revenueChartFill()
        {
            DataSet ds = new DataSet();
            CommonFunctions.con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT sum(p_amount) AS 'Amount' , CAST(p_date AS DATE) AS 'Date' FROM payment GROUP BY CAST(p_date AS DATE)", CommonFunctions.con);
            adapt.Fill(ds);
            chartTotalRevenue.DataSource = ds;

            // set the member of the chart data source used to data bind to the X-values of the series
            chartTotalRevenue.Series["Revenue"].XValueMember = "Date";

            //set the member columns of the chart data source used to data bind to the X-values of the series  
            chartTotalRevenue.Series["Revenue"].YValueMembers = "Amount";

            CommonFunctions.con.Close();
        }

        private void orderChartFill()
        {
            /*DataSet ds = new DataSet();
            CommonFunctions.con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT p_amount,j_id_fk FROM payment", CommonFunctions.con);
            adapt.Fill(ds);
            orderStatusChart.DataSource = ds;

            // set the member of the chart data source used to data bind to the X-values of the series
            orderStatusChart.Series["Orders"].XValueMember = "j_id_fk";

            //set the member columns of the chart data source used to data bind to the X-values of the series  
            orderStatusChart.Series["Orders"].YValueMembers = "p_amount";

            CommonFunctions.con.Close(); */

            // AddXY value in chart1 in series named as Salary
            orderStatusChart.Series["Orders"].Points.AddXY("Dilvered Orders", "10");
            orderStatusChart.Series["Orders"].Points.AddXY("Dilvery On Progress", "20");
            orderStatusChart.Series["Orders"].Points.AddXY("Undilvered Orders", "3");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnPendingJobs_Click(object sender, EventArgs e)
        {
            MainPanel.OpenChildForm(new Job_Manage());
        }

        private void btnJobOnService_Click(object sender, EventArgs e)
        {
            MainPanel.OpenChildForm(new Job_Manage());
        }

        private void btnTransUni_Click(object sender, EventArgs e)
        {
            MainPanel.OpenChildForm(new TransportUnit_Manage());
        }

        private void label9_Click(object sender, EventArgs e)
        {
            MainPanel.OpenChildForm(new NewCustomerJob_Create());
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            MainPanel.OpenChildForm(new NewCustomerJob_Create());
        }

        private void label12_Click(object sender, EventArgs e)
        {
            MainPanel.OpenChildForm(new Payment_Create());
        }

        private void label11_Click(object sender, EventArgs e)
        {
            MainPanel.OpenChildForm(new TransportUnit_Manage());
        }

        private void label13_Click(object sender, EventArgs e)
        {
            MainPanel.OpenChildForm(new Job_Manage());
        }
    }
}
