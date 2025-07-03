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
    public partial class Job_Update : Form
    {
        public Job_Update()
        {
            InitializeComponent();
        }

        private string job_id = null;
        public Job_Update(string _jobID)
        {
            InitializeComponent();
            job_id = _jobID;
        }

        List<ComboBox> comboBoxList;
        List<TextBox> textBoxList;

        private void Job_Update_Load(object sender, EventArgs e)
        {
            // Setting up the format for dateTimePicker "pickDateTime"
            pickDateTime.Format = DateTimePickerFormat.Custom;
            pickDateTime.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            pickDateTime.Value  = DateTime.Now;

            lblSelectedJobID.Text = job_id;

            CommonFunctions.DataComboBox("SELECT * FROM jobStatus", jobStatusBox, "jStatus", "jStatus_id");
            CommonFunctions.DataComboBox("SELECT * FROM transportUnit", transUnitBox, "tu_desc", "tu_id");
            CommonFunctions.DataComboBox("SELECT * FROM customer", cusNameBox, "c_name", "c_id");
            CommonFunctions.DataComboBox("SELECT * FROM trackStatus", trackStatusBox, "trackingProccess", "track_id");

            DataTable payTable = CommonFunctions.tableFun("SELECT * FROM job WHERE j_id = '" + job_id + "' ");

            foreach (DataRow row in payTable.Rows)
            {
                jobStatusBox.SelectedValue = row["jobStatus_id_fk"].ToString();
                transUnitBox.SelectedValue = row["tu_id_fk"].ToString();
                cusNameBox.SelectedValue = row["c_id_fk"].ToString();
                trackStatusBox.SelectedValue = row["tracking_id_fk"].ToString();
                totalPayable.Text = row["j_payable"].ToString();
                pickAddress.Text = row["j_pickLocation"].ToString();
                pickDateTime.Value = Convert.ToDateTime(row["j_pickDateTime"]);
                dropAddress.Text = row["j_dropLocation"].ToString();
            }

            //Define All ComboBox
            textBoxList = new List<TextBox>(){
               pickAddress,dropAddress,totalPayable
            };

            comboBoxList = new List<ComboBox>(){
                jobStatusBox,transUnitBox,cusNameBox,trackStatusBox
            };

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (job_id == null)
            {
                MessageBox.Show("No Payment ID Selected");
            }
            else
            {
                // Validating If all the textboxes are available
                if (CommonFunctions.validate(textBoxList) && CommonFunctions.validate(comboBoxList) && CommonFunctions.checkComoboBoxData(comboBoxList))
                {
                    CommonFunctions.updateFun("UPDATE job SET j_pickLocation= '" +pickAddress.Text +"' ,j_pickDateTime= '" +pickDateTime.Value+"' , c_id_fk= '" +cusNameBox.SelectedValue +"' , tu_id_fk= '" +transUnitBox.SelectedValue+"' , tracking_id_fk= '" +trackStatusBox.SelectedValue+"' , jobStatus_id_fk= '" +jobStatusBox.SelectedValue +"' ,j_dropLocation= '" +dropAddress.Text +"' , j_payable= '" +totalPayable.Text +"' WHERE j_id = '" + job_id + "' ");

                }
                else
                {
                    MessageBox.Show("Please fill all the required boxes");
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            MainPanel.OpenChildForm(new Job_Manage());
        }
    }
}
