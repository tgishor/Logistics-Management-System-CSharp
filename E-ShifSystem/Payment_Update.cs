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
    public partial class Payment_Update : Form
    {
        private string payment_id = null;
        public Payment_Update(string _payID)
        {
            InitializeComponent();
            payment_id = _payID;    
        }

        List<ComboBox> comboBoxList;
        List<TextBox> textBoxList;

        private void Payment_Update_Load(object sender, EventArgs e)
        {
            lblSelectedPayId.Text = payment_id;

            CommonFunctions.DataComboBox("SELECT * FROM job", jobBox, "j_id", "j_id");
            CommonFunctions.DataComboBox("SELECT * FROM paymentType",payTypeBox,"pType", "pType_id");

            DataTable payTable = CommonFunctions.tableFun("SELECT * FROM payment WHERE p_id = '"+ payment_id + "' ");

            foreach (DataRow row in payTable.Rows)
            {
                jobBox.SelectedValue = row["j_id_fk"].ToString();
                payAmountBox.Text = row["p_amount"].ToString();
                payTypeBox.SelectedValue = row["pType_id_fk"].ToString();

            }

            // Declaring List of TextBox and List of ComboBox
            textBoxList = new List<TextBox>(){
                payAmountBox
            };

            comboBoxList = new List<ComboBox>(){
                jobBox, payTypeBox
            };

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (payment_id == null)
            {
                MessageBox.Show("No Payment ID Selected");
            }
            else
            {
                // Validating If all the textboxes are available
                if (CommonFunctions.validate(textBoxList) && CommonFunctions.validate(comboBoxList) && CommonFunctions.checkComoboBoxData(comboBoxList))
                {
                    CommonFunctions.updateFun("UPDATE payment SET p_amount = '"+payAmountBox.Text+"', pType_id_fk = '"+payTypeBox.SelectedValue.ToString()+"', j_id_fk = '"+jobBox.SelectedValue.ToString()+"' WHERE p_id = '"+ payment_id + "' ");

                }
                else
                {
                    MessageBox.Show("Please fill all the required boxes");
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Payment_Manage().Show();
        }
    }
}
