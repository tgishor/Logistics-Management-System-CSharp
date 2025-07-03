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
    public partial class Payment_Create : Form
    {
        public Payment_Create()
        {
            InitializeComponent();
        }

        private int selectedJobID = 0;

        private int selectedJobIDFromCons = 0;

        public Payment_Create(int job_id)
        {
            InitializeComponent();
            this.selectedJobIDFromCons = job_id;

        }

        List<ComboBox> comboBoxList;
        List<TextBox> textBoxList;

        private void tableLoad()
        {
            String sql = "SELECT p_id AS 'Payment ID', p_date AS 'Payment Date', p_amount AS 'Payment Amount', paymentType.pType AS 'Payment Type', customer.c_name AS 'Customer Name', customer.c_phoneNo AS 'Customer Phone' FROM payment INNER JOIN job ON payment.j_id_fk = job.j_id INNER JOIN customer ON job.c_id_fk = customer.c_id INNER JOIN paymentType ON payment.pType_id_fk = paymentType.pType_id";

            CommonFunctions.DataTableLoadFun(sql, payDataTable);
        }

        private void calculateAmount()
        {
            DataTable loadJobGood = CommonFunctions.tableFun("SELECT * FROM load INNER JOIN job ON load.j_id_fk = job.j_id INNER JOIN good ON load.good_id_fk = good.good_id WHERE job.j_id = '" + selectedJobID + "'");

            int totalAmount = 0;

            string totaljobPayAmount = null;

            foreach (DataRow row in loadJobGood.Rows)
            {
                string quantity = row["quantity"].ToString();
                string goodAmount = row["good_initailAmount"].ToString();

                int totalLoadAmount = Convert.ToInt32(quantity) * Convert.ToInt32(goodAmount);

                totalAmount = totalLoadAmount + totalAmount;

                totaljobPayAmount = row["j_payable"].ToString();
            }

            int finalPayAmount = Convert.ToInt32(totaljobPayAmount) + totalAmount;

            lblTotalPayAmount.Text = finalPayAmount.ToString();



            DataTable payTable = CommonFunctions.tableFun("SELECT * FROM payment WHERE j_id_fk = '" + selectedJobID + "'");


            int initiallyPaid = 0;

            foreach (DataRow row in payTable.Rows)
            {
                string AlreadyPaidAmount = row["p_amount"].ToString();

                initiallyPaid = Convert.ToInt32(AlreadyPaidAmount) + initiallyPaid;

            }

            int remainPayment = finalPayAmount - initiallyPaid;

            if(remainPayment <= 0)
            {
                lblRemainAmount.Text = "Amount Paid";
                payBtn.Enabled = false;
            }
            else
            {
                payBtn.Enabled = true;
                lblRemainAmount.Text = "Rs. "+remainPayment.ToString();
            }

            
        }

        private void Payment_Create_Load(object sender, EventArgs e)
        {
            CommonFunctions.DataComboBox("SELECT * FROM paymentType", payTypeBox, "pType", "pType_id");
            CommonFunctions.DataComboBox("SELECT * FROM job", jobBox, "j_id", "j_id");

            // Declaring List of TextBox and List of ComboBox
            textBoxList = new List<TextBox>(){
                finalPayBox
            };

            comboBoxList = new List<ComboBox>(){
                jobBox, payTypeBox
            };

            tableLoad();

            if (selectedJobIDFromCons > 0)
            {
                selectedJobID = selectedJobIDFromCons;
            }

            if (selectedJobIDFromCons > 0)
            {
                jobBox.Text = selectedJobID.ToString();
                jobBox.Enabled = false;
            }

            calculateAmount();

        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            // Validating If all the textboxes are available
            if (CommonFunctions.validate(textBoxList) && CommonFunctions.validate(comboBoxList) && CommonFunctions.checkComoboBoxData(comboBoxList))
            {
                CommonFunctions.insertFun("INSERT INTO payment (p_amount, p_date, pType_id_fk, j_id_fk) VALUES ('"+finalPayBox.Text+ "', '" + DateTime.Now.ToString() + "','"+payTypeBox.SelectedValue.ToString()+"', '"+ selectedJobID + "')");

                calculateAmount();

                tableLoad();

            }
            else
            {
                MessageBox.Show("Please fill all the required boxes");
            }
                
        }

        private void jobBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedJobID = Convert.ToInt32(jobBox.Text);
            calculateAmount();

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            CommonFunctions.resetAllTextBoxes(textBoxList);
            CommonFunctions.resetAllTextBoxes(comboBoxList);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

