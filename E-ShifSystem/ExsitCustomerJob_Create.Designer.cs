namespace E_ShifSystem
{
    partial class ExsitCustomerJob_Create
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addJobOnlyBtn = new FontAwesome.Sharp.IconButton();
            this.lblRecentlyAddedJob = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pickupDateTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pickAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dropAddress = new System.Windows.Forms.TextBox();
            this.totalPayableBox = new System.Windows.Forms.TextBox();
            this.jobStatusBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.transportUnitBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cusBox = new System.Windows.Forms.ComboBox();
            this.continueWithLoadBtn = new System.Windows.Forms.Button();
            this.manageJobBtn = new System.Windows.Forms.Button();
            this.grpBoxSelectedTu = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblLorryName = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblContainerName = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpBoxSelectedTu.SuspendLayout();
            this.SuspendLayout();
            // 
            // addJobOnlyBtn
            // 
            this.addJobOnlyBtn.BackColor = System.Drawing.Color.Transparent;
            this.addJobOnlyBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.addJobOnlyBtn.FlatAppearance.BorderSize = 2;
            this.addJobOnlyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addJobOnlyBtn.Font = new System.Drawing.Font("Squada One", 15.75F);
            this.addJobOnlyBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.addJobOnlyBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addJobOnlyBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.addJobOnlyBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addJobOnlyBtn.IconSize = 30;
            this.addJobOnlyBtn.Location = new System.Drawing.Point(854, 278);
            this.addJobOnlyBtn.Name = "addJobOnlyBtn";
            this.addJobOnlyBtn.Size = new System.Drawing.Size(176, 50);
            this.addJobOnlyBtn.TabIndex = 29;
            this.addJobOnlyBtn.Text = "Only Add Job";
            this.addJobOnlyBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addJobOnlyBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addJobOnlyBtn.UseVisualStyleBackColor = false;
            this.addJobOnlyBtn.Click += new System.EventHandler(this.addJobOnlyBtn_Click);
            // 
            // lblRecentlyAddedJob
            // 
            this.lblRecentlyAddedJob.AutoSize = true;
            this.lblRecentlyAddedJob.Font = new System.Drawing.Font("Squada One", 47.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentlyAddedJob.Location = new System.Drawing.Point(141, 60);
            this.lblRecentlyAddedJob.Name = "lblRecentlyAddedJob";
            this.lblRecentlyAddedJob.Size = new System.Drawing.Size(87, 68);
            this.lblRecentlyAddedJob.TabIndex = 25;
            this.lblRecentlyAddedJob.Text = "00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Squada One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(54, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(258, 26);
            this.label12.TabIndex = 24;
            this.label12.Text = "Most Recently Added Job ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.lblRecentlyAddedJob);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Font = new System.Drawing.Font("Quicksand", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(854, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 136);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Note";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Pickup Date and Time: ";
            // 
            // pickupDateTime
            // 
            this.pickupDateTime.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.pickupDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickupDateTime.Location = new System.Drawing.Point(20, 186);
            this.pickupDateTime.Name = "pickupDateTime";
            this.pickupDateTime.Size = new System.Drawing.Size(360, 30);
            this.pickupDateTime.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total Payable: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Pickup Street";
            // 
            // pickAddress
            // 
            this.pickAddress.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.pickAddress.Location = new System.Drawing.Point(20, 260);
            this.pickAddress.Multiline = true;
            this.pickAddress.Name = "pickAddress";
            this.pickAddress.Size = new System.Drawing.Size(360, 78);
            this.pickAddress.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(414, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 22);
            this.label9.TabIndex = 15;
            this.label9.Text = "Drop Address: ";
            // 
            // dropAddress
            // 
            this.dropAddress.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.dropAddress.Location = new System.Drawing.Point(418, 260);
            this.dropAddress.Multiline = true;
            this.dropAddress.Name = "dropAddress";
            this.dropAddress.Size = new System.Drawing.Size(360, 78);
            this.dropAddress.TabIndex = 16;
            // 
            // totalPayableBox
            // 
            this.totalPayableBox.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.totalPayableBox.Location = new System.Drawing.Point(20, 379);
            this.totalPayableBox.Name = "totalPayableBox";
            this.totalPayableBox.Size = new System.Drawing.Size(360, 30);
            this.totalPayableBox.TabIndex = 12;
            // 
            // jobStatusBox
            // 
            this.jobStatusBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.jobStatusBox.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.jobStatusBox.FormattingEnabled = true;
            this.jobStatusBox.Items.AddRange(new object[] {
            "Batticaloa",
            "Colombo",
            "Kandy"});
            this.jobStatusBox.Location = new System.Drawing.Point(418, 186);
            this.jobStatusBox.Name = "jobStatusBox";
            this.jobStatusBox.Size = new System.Drawing.Size(360, 30);
            this.jobStatusBox.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(414, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 22);
            this.label10.TabIndex = 12;
            this.label10.Text = "Select the Job Status: ";
            // 
            // transportUnitBox
            // 
            this.transportUnitBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.transportUnitBox.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.transportUnitBox.FormattingEnabled = true;
            this.transportUnitBox.Items.AddRange(new object[] {
            "Batticaloa",
            "Colombo",
            "Kandy"});
            this.transportUnitBox.Location = new System.Drawing.Point(418, 379);
            this.transportUnitBox.Name = "transportUnitBox";
            this.transportUnitBox.Size = new System.Drawing.Size(360, 30);
            this.transportUnitBox.TabIndex = 18;
            this.transportUnitBox.SelectedIndexChanged += new System.EventHandler(this.transportUnitBox_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(414, 354);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(204, 22);
            this.label11.TabIndex = 17;
            this.label11.Text = "Select the Transport Unit: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cusBox);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.transportUnitBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.jobStatusBox);
            this.groupBox2.Controls.Add(this.totalPayableBox);
            this.groupBox2.Controls.Add(this.dropAddress);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.pickAddress);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pickupDateTime);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Quicksand", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(805, 483);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create Job";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Squada One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Select Customer: ";
            // 
            // cusBox
            // 
            this.cusBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cusBox.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.cusBox.FormattingEnabled = true;
            this.cusBox.Items.AddRange(new object[] {
            "Batticaloa",
            "Colombo",
            "Kandy"});
            this.cusBox.Location = new System.Drawing.Point(218, 83);
            this.cusBox.Name = "cusBox";
            this.cusBox.Size = new System.Drawing.Size(360, 30);
            this.cusBox.TabIndex = 20;
            // 
            // continueWithLoadBtn
            // 
            this.continueWithLoadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.continueWithLoadBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.continueWithLoadBtn.FlatAppearance.BorderSize = 2;
            this.continueWithLoadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continueWithLoadBtn.Font = new System.Drawing.Font("Squada One", 15.75F);
            this.continueWithLoadBtn.ForeColor = System.Drawing.Color.White;
            this.continueWithLoadBtn.Location = new System.Drawing.Point(854, 185);
            this.continueWithLoadBtn.Name = "continueWithLoadBtn";
            this.continueWithLoadBtn.Size = new System.Drawing.Size(358, 76);
            this.continueWithLoadBtn.TabIndex = 27;
            this.continueWithLoadBtn.Text = "Continue with Adding Loads";
            this.continueWithLoadBtn.UseVisualStyleBackColor = false;
            this.continueWithLoadBtn.Click += new System.EventHandler(this.continueWithLoadBtn_Click);
            // 
            // manageJobBtn
            // 
            this.manageJobBtn.BackColor = System.Drawing.Color.Transparent;
            this.manageJobBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.manageJobBtn.FlatAppearance.BorderSize = 2;
            this.manageJobBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageJobBtn.Font = new System.Drawing.Font("Squada One", 15.75F);
            this.manageJobBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.manageJobBtn.Location = new System.Drawing.Point(1036, 278);
            this.manageJobBtn.Name = "manageJobBtn";
            this.manageJobBtn.Size = new System.Drawing.Size(176, 50);
            this.manageJobBtn.TabIndex = 28;
            this.manageJobBtn.Text = "Open Manage Jobs";
            this.manageJobBtn.UseVisualStyleBackColor = false;
            this.manageJobBtn.Click += new System.EventHandler(this.manageJobBtn_Click);
            // 
            // grpBoxSelectedTu
            // 
            this.grpBoxSelectedTu.Controls.Add(this.lblStatus);
            this.grpBoxSelectedTu.Controls.Add(this.label19);
            this.grpBoxSelectedTu.Controls.Add(this.lblLorryName);
            this.grpBoxSelectedTu.Controls.Add(this.label17);
            this.grpBoxSelectedTu.Controls.Add(this.lblContainerName);
            this.grpBoxSelectedTu.Controls.Add(this.label14);
            this.grpBoxSelectedTu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpBoxSelectedTu.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxSelectedTu.Location = new System.Drawing.Point(854, 340);
            this.grpBoxSelectedTu.Name = "grpBoxSelectedTu";
            this.grpBoxSelectedTu.Size = new System.Drawing.Size(358, 273);
            this.grpBoxSelectedTu.TabIndex = 30;
            this.grpBoxSelectedTu.TabStop = false;
            this.grpBoxSelectedTu.Text = "Select Transport Unit Details";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.lblStatus.Location = new System.Drawing.Point(159, 235);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(116, 22);
            this.lblStatus.TabIndex = 29;
            this.lblStatus.Text = "Not Available";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Squada One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(85, 232);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 26);
            this.label19.TabIndex = 28;
            this.label19.Text = "Status: ";
            // 
            // lblLorryName
            // 
            this.lblLorryName.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLorryName.Location = new System.Drawing.Point(27, 55);
            this.lblLorryName.Name = "lblLorryName";
            this.lblLorryName.Size = new System.Drawing.Size(308, 69);
            this.lblLorryName.TabIndex = 27;
            this.lblLorryName.Text = "Buddy Lorry - Normal Purpose";
            this.lblLorryName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Squada One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(125, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(121, 26);
            this.label17.TabIndex = 26;
            this.label17.Text = "Lorry Name: ";
            // 
            // lblContainerName
            // 
            this.lblContainerName.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.lblContainerName.Location = new System.Drawing.Point(19, 154);
            this.lblContainerName.Name = "lblContainerName";
            this.lblContainerName.Size = new System.Drawing.Size(331, 66);
            this.lblContainerName.TabIndex = 25;
            this.lblContainerName.Text = "Dry box Container";
            this.lblContainerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Squada One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(103, 124);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(166, 26);
            this.label14.TabIndex = 24;
            this.label14.Text = " Container Name: ";
            // 
            // ExsitCustomerJob_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 653);
            this.Controls.Add(this.grpBoxSelectedTu);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.addJobOnlyBtn);
            this.Controls.Add(this.manageJobBtn);
            this.Controls.Add(this.continueWithLoadBtn);
            this.Controls.Add(this.groupBox2);
            this.Name = "ExsitCustomerJob_Create";
            this.Text = "Exsit Customer Job Create";
            this.Load += new System.EventHandler(this.ExsitCustomerJob_Create_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpBoxSelectedTu.ResumeLayout(false);
            this.grpBoxSelectedTu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton addJobOnlyBtn;
        private System.Windows.Forms.Label lblRecentlyAddedJob;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker pickupDateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pickAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox dropAddress;
        private System.Windows.Forms.TextBox totalPayableBox;
        private System.Windows.Forms.ComboBox jobStatusBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox transportUnitBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cusBox;
        private System.Windows.Forms.Button continueWithLoadBtn;
        private System.Windows.Forms.Button manageJobBtn;
        private System.Windows.Forms.GroupBox grpBoxSelectedTu;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblLorryName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblContainerName;
        private System.Windows.Forms.Label label14;
    }
}