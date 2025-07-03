using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace E_ShifSystem
{
    public partial class MainPanel : Form
    {
        // Oject for the DeisgnFunction Class is been Created
        static DesignFunctions designObj = new DesignFunctions();
        public static Form MainPanelForm = null;
        
        public MainPanel()
        {
            InitializeComponent();
            designObj.leftBorderBtn = new Panel();
            designObj.leftBorderBtn.Size = new Size(7, 80);
            panelMenu.Controls.Add(designObj.leftBorderBtn);

            MainPanelForm = this;
        }

        private Customer_Manage mainForm = null;
        public MainPanel(Form callingForm)
        {
            mainForm = callingForm as Customer_Manage;
            InitializeComponent();
            designObj.leftBorderBtn = new Panel();
            designObj.leftBorderBtn.Size = new Size(7, 80);
            panelMenu.Controls.Add(designObj.leftBorderBtn);
        }

        public static void OpenChildForm(Form childForm)
        {
            //open only form

            if (designObj.currentChildForm != null)
            {
                designObj.currentChildForm.Close();
            }

            designObj.currentChildForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.AutoScroll = true;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblFormTitle.Text = childForm.Text;
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblAdminName.Text = CommonFunctions.logedUserInfo.getName + " (" + CommonFunctions.logedUserInfo.getUsername + ")";

            designObj.ActivateBtn(iconDashboard, DesignFunctions.RGBColors.color3);

            CustomerMenu.IsMainMenu = true;
            CustomerMenu.PrimaryColor = Color.Orange;

            LoadMenu.IsMainMenu = true;
            LoadMenu.PrimaryColor = Color.Orange;

            
            JobMenu.IsMainMenu = true;
            JobMenu.PrimaryColor = Color.Orange;

            PayMenu.IsMainMenu= true;   
            PayMenu.PrimaryColor = Color.Orange;

            GoodsMenu.IsMainMenu = true;
            GoodsMenu.PrimaryColor = Color.Orange;

            TransportUnitMenu.IsMainMenu = true;
            TransportUnitMenu.PrimaryColor = Color.Orange;

            StaffMenu.IsMainMenu = true;
            StaffMenu.PrimaryColor = Color.Orange;

            TopBarMenuAdmin.IsMainMenu = true;
            TopBarMenuAdmin.PrimaryColor = Color.Orange;    
        }

        // Defining Click Function for the Logo & Panel
        private void panelLogo_Click(object sender, EventArgs e)
        {
            designObj.ActivateBtn(iconDashboard, DesignFunctions.RGBColors.color3);
        }

        private void pictureLogo_Click(object sender, EventArgs e)
        {
            designObj.ActivateBtn(iconDashboard, DesignFunctions.RGBColors.color3);
        }

        // Seperate Click Functions Being Made
        private void iconDashboard_Click(object sender, EventArgs e)
        {
            designObj.ActivateBtn(sender, DesignFunctions.RGBColors.color3);

            OpenChildForm(new Dashboard());
        }

        private void iconCustomer_Click(object sender, EventArgs e)
        {
            // Function Called From DesignFuntion Class
            designObj.ActivateBtn(sender, DesignFunctions.RGBColors.color1);
            CustomerMenu.Show(iconCustomer, iconCustomer.Width, 0);
        }


        private void iconJob_Click(object sender, EventArgs e)
        {
            designObj.ActivateBtn(sender, DesignFunctions.RGBColors.color2);
            JobMenu.Show(iconJob, iconJob.Width, 0);
        }

        private void iconLoad_Click(object sender, EventArgs e)
        {
            designObj.ActivateBtn(sender, DesignFunctions.RGBColors.color4);
            LoadMenu.Show(iconLoad, iconLoad.Width, 0);
        }

        private void iconPayement_Click(object sender, EventArgs e)
        {
            designObj.ActivateBtn(sender, DesignFunctions.RGBColors.color5);
            PayMenu.Show(iconPayement, iconPayement.Width, 0);
        }

        private void iconGoods_Click(object sender, EventArgs e)
        {
            designObj.ActivateBtn(sender, DesignFunctions.RGBColors.color6);
            GoodsMenu.Show(iconGoods, iconGoods.Width, 0);

        }

        private void iconTransport_Click(object sender, EventArgs e)
        {
            designObj.ActivateBtn(sender, DesignFunctions.RGBColors.color7);
            TransportUnitMenu.Show(iconTransport, iconTransport.Width, 0);
        }

        private void iconEmployee_Click(object sender, EventArgs e)
        {
            designObj.ActivateBtn(sender, DesignFunctions.RGBColors.color8);
            StaffMenu.Show(iconEmployee, iconEmployee.Width, 0);
        }


        // Click Function for ContextMenu (Sub Menus in Context Menu)

        // -- Customer Menu --
        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new customer_create());
        }

        private void manageAllCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Customer_Manage());
        }

        // -- Load Menu --
        private void addNewLoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Load_Create());
        }

        private void manageLoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Load_Manage());
        }

        // -- Payement Menu --
        private void makeAPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Payment_Create());
        }

        private void manageAllPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Payment_Manage());
        }

        // -- Goods Menu --
        private void addNewItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File menu item clicked");
        }

        private void manageAllGoodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Goods_Manage());

        }

        // -- Transport Unit Menu --
        private void createNewUnitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TransportUnit_Create());
        }
        private void addNewLorryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File menu item clicked");
        }

        private void addNewDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File menu item clicked");
        }

        private void addNewAssistantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File menu item clicked");
        }

        private void addNewContainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File menu item clicked");
        }

        private void manageAllTransportUnitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TransportUnit_Manage());
        }


        // -- Job Menu --

        private void newCustomerJobToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NewCustomerJob_Create());
        }

        private void exsistingCustomerJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ExsitCustomerJob_Create());
        }

        private void manageAllJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Job_Manage());
        }

        private void checkJobStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File menu item clicked");
        }

        // -- Staff Menu --
        private void addNewStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageAllStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addStaffTypeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void manageStaffTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Driver_Manage());
        }

        private void manageAssisstantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Asstistant_Manage());
        }

        private void manageLorryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Lorry_Manage());
        }

        private void manageContainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Container_Manage());
        }

        

        private void manageAdminAccToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin_Manage());
        }

        private void lblAdminName_Click(object sender, EventArgs e)
        {
            TopBarMenuAdmin.Show(lblAdminName, 0, lblAdminName.Height);
        }
    }

}
