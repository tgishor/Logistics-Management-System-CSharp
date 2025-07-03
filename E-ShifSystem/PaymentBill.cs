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
    public partial class PaymentBill : Form
    {

        private string selectedJobID;
        public PaymentBill(string _jobID)
        {
            InitializeComponent();
            selectedJobID = _jobID; 
        }



        private void calculateAmount()
        {
            DataTable loadJobGood = CommonFunctions.tableFun("SELECT * FROM load INNER JOIN job ON load.j_id_fk = job.j_id INNER JOIN good ON load.good_id_fk = good.good_id WHERE job.j_id = '" + selectedJobID + "'");

            int totalAmount = 0;

            string totaljobPayAmount = null;

            string LoadPrint = "----------------------------- \n Load Payment \n ----------------------------- \n ";

            foreach (DataRow row in loadJobGood.Rows)
            {
                string quantity = row["quantity"].ToString();
                string goodAmount = row["good_initailAmount"].ToString();

                LoadPrint += row["good_name"]+ " - Rs. " + goodAmount + " X " + quantity + "\n";

                int totalLoadAmount = Convert.ToInt32(quantity) * Convert.ToInt32(goodAmount);

                totalAmount = totalLoadAmount + totalAmount;

                totaljobPayAmount = row["j_payable"].ToString();
            }

            int finalPayAmount = Convert.ToInt32(totaljobPayAmount) + totalAmount;

            LoadPrint += "----------------------------- \n";
            LoadPrint += "=> Rs. "+ totalAmount;

            



            DataTable payTable = CommonFunctions.tableFun("SELECT * FROM payment WHERE j_id_fk = '" + selectedJobID + "'");


            int initiallyPaid = 0;

            foreach (DataRow row in payTable.Rows)
            {
                string AlreadyPaidAmount = row["p_amount"].ToString();

                initiallyPaid = Convert.ToInt32(AlreadyPaidAmount) + initiallyPaid;

            }

            int remainPayment = finalPayAmount - initiallyPaid;

            LoadPrint += "\n \n ----------------------------- \n Job Payment \n ----------------------------- \n ";
            LoadPrint += "=> Rs. "+ totaljobPayAmount;

            LoadPrint += "\n \n ----------------------------- \n Final Payment \n ----------------------------- \n ";
            LoadPrint += "=> Rs. " + finalPayAmount;


            loadCalculate.Text = LoadPrint;

        }

        private void PaymentBill_Load(object sender, EventArgs e)
        {

            lblJobID.Text = selectedJobID;

            DataTable jobDetails = CommonFunctions.tableFun("SELECT job.j_id AS 'Job ID', job.j_regDateTime AS 'Reg TimeStamp', job.j_pickLocation AS 'Pickup Location', job.j_dropLocation AS 'Drop Location', job.j_pickDateTime AS 'Drop Location', customer.c_name AS 'Cus Name', customer.c_phoneNo AS 'Cus Phone', jobStatus.jStatus AS 'Job Status', trackStatus.trackingProccess AS 'Tracking Status' FROM job INNER JOIN customer ON job.c_id_fk = customer.c_id  INNER JOIN jobStatus ON job.jobStatus_id_fk = jobStatus.jStatus_id INNER JOIN trackStatus ON job.tracking_id_fk = trackStatus.track_id WHERE job.j_id = '"+selectedJobID+"'");

            lblCustomerName.Text = jobDetails.Rows[0]["Cus Name"].ToString();

            lblCusPhoneNo.Text = jobDetails.Rows[0]["Cus Phone"].ToString();

            calculateAmount();

        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            new Payment_Create(Convert.ToInt32(selectedJobID));
        }
    }
}
